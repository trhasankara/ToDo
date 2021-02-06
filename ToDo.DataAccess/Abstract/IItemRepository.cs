using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ToDo.Entities;

namespace ToDo.DataAccess.Abstract
{
    public interface IItemRepository
    {
        List<Item> getList();
        Item getById(int id);
        Item Add(Item item);
        Item Update(Item item);
        void Delete(int id);
    }
}
