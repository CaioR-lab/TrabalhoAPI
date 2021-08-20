using ClassLibrary1.Models;
using ClassLibrary1.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<M,R> : ControllerBase where M : Base where R : BaseRepository<M>
    {
        R repository = Activator.CreateInstance<R>();

        [HttpGet]
        public List<M> Get()
        {
            return repository.Read();
        }

        [HttpGet("{id}")]
        public M Get(int id)
        {
            return repository.Read(id);
        }

        [HttpPost]
        public void Post([FromBody] M model)
        {
            repository.Create(model);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] M model)
        {
            repository.Update(id, model);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
