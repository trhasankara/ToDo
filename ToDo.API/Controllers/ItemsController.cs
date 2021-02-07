using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ToDo.Business.Abstract;
using ToDo.Business.Concrete;
using ToDo.Entities;

namespace ToDo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public List<Item> Get()
        {
            return _itemService.getList();
        }

        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _itemService.getById(id);
        }

        [HttpPost]
        public Item Post([FromBody]Item item)
        {
            return _itemService.Add(item);
        }

        [HttpPut]
        public Item Put([FromBody] Item item)
        {
            return _itemService.Update(item);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _itemService.Delete(id);
        }
    }
}
