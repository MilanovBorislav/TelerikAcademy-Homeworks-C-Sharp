using KingsValey.Context;
using KingsValey.ExternalServices.PubNub;
using KingsValey.Models.GameModels;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KingsValey.Api.Controllers
{
    public class GameController : ApiController
    {
        private KingsValeyContext db = new KingsValeyContext();

        //                                                   "[{\"X\":0,\"Y\":0,\"IsKing\":false,\"color\":0},{\"X\":1,\"Y\":0,\"IsKing\":false,\"color\":0},{\"X\":2,\"Y\":0,\"IsKing\":false,\"color\":0},{\"X\":3,\"Y\":0,\"IsKing\":false,\"color\":0},{\"X\":4,\"Y\":0,\"IsKing\":false,\"color\":0}]"
        private const string FIGURES_START_POSITIONS = "[{\"X\":0,\"Y\":0,\"IsKing\":false,\"color\":0},{\"X\":1,\"Y\":0,\"IsKing\":false,\"color\":0},{\"X\":2,\"Y\":0,\"IsKing\":true,\"color\":0},{\"X\":3,\"Y\":0,\"IsKing\":false,\"color\":0},{\"X\":4,\"Y\":0,\"IsKing\":false,\"color\":0}," +
        "{\"X\":0,\"Y\":4,\"IsKing\":false,\"color\":1},{\"X\":1,\"Y\":4,\"IsKing\":false,\"color\":1},{\"X\":2,\"Y\":4,\"IsKing\":true,\"color\":1},{\"X\":3,\"Y\":4,\"IsKing\":false,\"color\":1},{\"X\":4,\"Y\":4,\"IsKing\":false,\"color\":1}]";

        // GET api/Game
        //public IEnumerable<GameStateModel> GetGameStateModels()
        //{
        //    return db.Games.AsEnumerable();
        //}

        // GET api/Game/5
        public GameStateModel GetGameStateModel(int id)
        {
            GameStateModel gamestatemodel = db.Games.FirstOrDefault(g => g.RedPlayer == id || g.WhitePlayer == id);

            if (gamestatemodel == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            if (gamestatemodel.RedPlayer == 0 || gamestatemodel.WhitePlayer == 0)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest));
            }

            return gamestatemodel;
        }

        // POST api/Game
        public HttpResponseMessage PostGameStateModel(int id, string sessionKey)
        {
            if (!db.Players.Any(p => p.PlayerId == id && p.SessionKey == sessionKey))
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized);
            }

            if (ModelState.IsValid)
            {
                GameStateModel game = db.Games.FirstOrDefault(g => g.RedPlayer == 0);

                if (game != null)
                {
                    if (game.WhitePlayer == id)
                    {
                        return Request.CreateResponse(HttpStatusCode.BadRequest);
                    }

                    game.RedPlayer = id;
                    db.SaveChanges();

                    PubNubPushNotifier.PushData("channel-" + game.WhitePlayer, new { startGame = true, playerInTurn = game.PlayerInMove, gameId = game.GameStateModelId });
                    PubNubPushNotifier.PushData("channel-" + game.RedPlayer, new { startGame = true, playerInTurn = game.PlayerInMove, gameId = game.GameStateModelId });

                    return Request.CreateResponse(HttpStatusCode.Created);
                }

                var newGame = new GameStateModel
                {
                    PlayerInMove = id,
                    WhitePlayer = id,
                    GameFigures = FIGURES_START_POSITIONS
                };

                db.Games.Add(newGame);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, newGame);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = newGame.GameStateModelId }));

                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Game/5
        //public HttpResponseMessage DeleteGameStateModel(int id)
        //{
        //    GameStateModel gamestatemodel = db.Games.Find(id);
        //    if (gamestatemodel == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound);
        //    }

        //    db.Games.Remove(gamestatemodel);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound);
        //    }

        //    return Request.CreateResponse(HttpStatusCode.OK, gamestatemodel);
        //}

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}