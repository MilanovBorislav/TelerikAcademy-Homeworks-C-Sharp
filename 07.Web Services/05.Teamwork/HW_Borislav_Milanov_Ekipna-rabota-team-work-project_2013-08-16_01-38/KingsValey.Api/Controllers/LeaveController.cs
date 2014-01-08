using KingsValey.Context;
using KingsValey.ExternalServices.PubNub;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KingsValey.Api.Controllers
{
    public class LeaveController : ApiController
    {
        // GET api/leave/5
        public string Get(int id, int playerId, string sessionKey)
        {
            using (var db = new KingsValeyContext())
            {
                var game = db.Games.FirstOrDefault(g => g.GameStateModelId == id);

                if (game != null)
                {
                    if (game.WhitePlayer != playerId && game.RedPlayer != playerId)
                    {
                        throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.Unauthorized));
                    }

                    var player = db.Players.FirstOrDefault(p => p.PlayerId == playerId);
                    if (player != null)
                    {
                        if (player.SessionKey == sessionKey)
                        {
                            db.Games.Remove(game);
                            db.SaveChanges();

                            PubNubPushNotifier.PushData("channel-" + game.WhitePlayer, new { gameTerminated = true, terminator = player.Name });
                            PubNubPushNotifier.PushData("channel-" + game.RedPlayer, new { gameTerminated = true, terminator = player.Name });
                        }
                        else
                        {
                            throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.Unauthorized));
                        }
                    }
                    else
                    {
                        throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
                    }
                }
                else
                {
                    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
                }
            }

            throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest));
        }
    }
}