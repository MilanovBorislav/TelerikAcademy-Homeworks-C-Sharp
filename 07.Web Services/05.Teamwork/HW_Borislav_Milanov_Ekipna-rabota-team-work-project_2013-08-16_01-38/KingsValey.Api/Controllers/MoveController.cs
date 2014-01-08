using KingsValey.Context;
using KingsValey.ExternalServices.PubNub;
using KingsValey.Models.GameModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KingsValey.Api.Controllers
{
    public class MoveController : ApiController
    {
        private KingsValeyContext db = new KingsValeyContext();

        // GET api/move
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/move/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/move
        public HttpResponseMessage Post([FromBody]MoveRequest data)
        {
            /// TODO authorize user check

            GameStateModel game = db.Games.FirstOrDefault(g => g.WhitePlayer == data.PlayerId || g.RedPlayer == data.PlayerId);
            //GameStateModel game = db.Games.FirstOrDefault();

            if (game.RedPlayer == 0)
            {
                return Request.CreateResponse(HttpStatusCode.Conflict);
            }

            if (data.PlayerId != game.PlayerInMove)
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized);
            }

            if (db.Players.Find(game.WhitePlayer).SessionKey == data.SessionKey || db.Players.Find(game.RedPlayer).SessionKey == data.SessionKey)
            //true)
            {
                string gameFigures = game.GameFigures;

                List<GameFigure> gameFiguresArr = JsonConvert.DeserializeObject<List<GameFigure>>(gameFigures);

                var gameMove = new GameMove(gameFiguresArr);

                if (!gameMove.IsGameEnded())
                {
                    ICollection<Position> availablePositions = gameMove.GetAvailableDestinations(data.LocationX, data.LocationY);

                    if (availablePositions.Any(p => p.X == data.DestinationX && p.Y == data.DestinationY))
                    {
                        GameFigure movedFigure = gameFiguresArr.FirstOrDefault(f => f.X == data.LocationX && f.Y == data.LocationY);

                        movedFigure.X = data.DestinationX;
                        movedFigure.Y = data.DestinationY;

                        game.GameFigures = JsonConvert.SerializeObject(gameFiguresArr);
                        db.SaveChanges();

                        if (game.WhitePlayer == data.PlayerId)
                        {
                            game.PlayerInMove = game.RedPlayer;
                        }
                        else
                        {
                            game.PlayerInMove = game.WhitePlayer;
                        }

                        db.SaveChanges();
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.BadRequest);
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, data);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = data }));

                /// PUSH info to other user

                data.SessionKey = null;
                PubNubPushNotifier.PushData("channel-" + game.WhitePlayer, new { moveFigure = true, moveRequest = data });
                PubNubPushNotifier.PushData("channel-" + game.RedPlayer, new { moveFigure = true, moveRequest = data });

                if (gameMove.IsGameEnded())
                {
                    PubNubPushNotifier.PushData("channel-" + game.WhitePlayer, new { gameEnded = true, winner = gameMove.WinnerColor() });
                    PubNubPushNotifier.PushData("channel-" + game.RedPlayer, new { gameEnded = true, winner = gameMove.WinnerColor() });

                    var winner = db.Players.Find(data.PlayerId);
                    winner.Victories++;

                    var looserId = game.WhitePlayer == data.PlayerId ? game.RedPlayer : game.WhitePlayer;

                    var looser = db.Players.Find(looserId);
                    looser.Losses++;

                    db.Games.Remove(game);
                    db.SaveChanges();
                }

                return response;
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        // PUT api/move/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/move/5
        public void Delete(int id)
        {
        }
    }
}