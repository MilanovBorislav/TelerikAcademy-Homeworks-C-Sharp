using KingsValey.Context;
using KingsValey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;

namespace KingsValey.Api.Controllers
{
    public class LoginController : ApiController
    {
        private KingsValeyContext db = new KingsValeyContext();

        // GET api/login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/login
        public object Post([FromBody]PlayerLoginModel value)
        {
            Player player = db.Players.FirstOrDefault(p => p.Name.ToLower() == value.Name.ToLower() && p.Password == value.Password);
            if (player != null)
            {
                string sessionKey = EncryptToSha1(value.Name + value.Password + DateTime.Now.ToShortTimeString());
                player.SessionKey = sessionKey;
                db.SaveChanges();

                return new { sessionKey = sessionKey, playerId = player.PlayerId };
            }

            throw new InvalidOperationException("Wrong username and password!");
        }

        private string EncryptToSha1(string text)
        {
            var sha = new SHA1CryptoServiceProvider();

            byte[] byteArr = Encoding.UTF8.GetBytes(text);

            byte[] result = sha.ComputeHash(byteArr);

            StringBuilder sb = new StringBuilder();

            foreach (var by in result)
            {
                sb.Append(by.ToString("x2"));
            }

            return sb.ToString();
        }

        // PUT api/login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/login/5
        public void Delete(int id)
        {
        }
    }
}