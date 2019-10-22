using APITest.DataDTO;
using APITest.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ITheService theService;
        
        public ValuesController(ITheService theService)
        {
            this.theService = theService;
        }

        // GET api/values
        [HttpGet]
        public List<MyDataDTO> GetMyDatas()
        {
            return this.theService.GetMyDatas();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] MyDataDTO newData) // Accept a MyData object from body of POST
        {
            // Use the service to add data
            this.theService.Create(newData); 
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
