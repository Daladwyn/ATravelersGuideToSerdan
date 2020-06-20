using System.Collections.Generic;
using ATravelersGuideToSerdan.Models;
using ATravelersGuideToSerdan.Services;
using Microsoft.AspNetCore.Mvc;

namespace ATravelersGuideToSerdan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalentController : ControllerBase
    {
        private SqlSerdan _Db;

        public TalentController(SqlSerdan Db)
        {
            _Db = Db;
        }

        // GET: api/Talent
        [HttpGet("attribute")]
        public List<Talent> GetTalentList(string attribute)
        {
            var talentListToSend = _Db.GetTalentsBasedOnAttributeName(attribute);
            return talentListToSend;
        }

        // GET: api/Talent/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Talent
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Talent/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
