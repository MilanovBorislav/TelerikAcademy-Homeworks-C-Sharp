using KingsValey.Context;
using KingsValey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KingsValey.Api.Controllers
{
    public class PlayersController : ApiController
    {
        private KingsValeyContext db = new KingsValeyContext();

        // GET api/Players
        public IEnumerable<PlayerViewModel> GetPlayers(int id)
        {
            var game = db.Games.FirstOrDefault(g => g.GameStateModelId == id);

            if (game == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return db.Players.Where(p => p.PlayerId == game.WhitePlayer || p.PlayerId == game.RedPlayer).Select(p => new PlayerViewModel
                {
                    PlayerId = p.PlayerId,
                    Avatar = p.Avatar,
                    Losses = p.Losses,
                    Name = p.Name,
                    Victories = p.Victories
                });
        }

        // POST api/Players
        public HttpResponseMessage PostPlayer(PlayerRegisterModel player)
        {
            if (ModelState.IsValid)
            {
                if (db.Players.Any(p => p.Name == player.Name))
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Conflict, new ArgumentException("Duplicate users are not allowed!"));
                }

                Player newPlayer = new Player
                    {
                        Avatar = player.Avatar,
                        Name = player.Name,
                        Password = player.Password
                    };

                db.Players.Add(newPlayer);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, player);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = player.Name }));

                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Players/5
        //public HttpResponseMessage DeletePlayer(int id)
        //{
        //    Player player = db.Players.Find(id);
        //    if (player == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.NotFound);
        //    }

        //    db.Players.Remove(player);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
        //    }

        //    return Request.CreateResponse(HttpStatusCode.OK, player);
        //}

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}