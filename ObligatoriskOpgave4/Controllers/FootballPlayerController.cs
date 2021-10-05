using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatoriskOpgave1;
using ObligatoriskOpgave4.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ObligatoriskOpgave4.Controllers
{
    [Route("FootballPlayers")]
    [ApiController]
    public class FootballPlayerController : ControllerBase
    {
        private static readonly FootballPlayersManager Manager = new FootballPlayersManager();
        // GET: api/<FootballPlayerController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return Manager.GetAll();
        }

        // GET api/<FootballPlayerController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return Manager.GetById(id);
        }

        // POST api/<FootballPlayerController>
        [HttpPost]
        public void Post([FromBody] FootballPlayer value)
        {
            Manager.Add(value);
        }

        // PUT api/<FootballPlayerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FootballPlayer value)
        {
            Manager.Update(id, value);
        }

        // DELETE api/<FootballPlayerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Manager.Delete(id);
        }
    }
}
