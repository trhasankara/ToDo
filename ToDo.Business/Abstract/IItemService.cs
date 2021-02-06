using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Entities;

namespace ToDo.Business.Abstract
{
    public interface IItemService
    {
        List<Item> getList();
        Item getById(int id);
        Item Add(Item item);
        Item Update(Item item);
        void Delete(int id);
    }
}
