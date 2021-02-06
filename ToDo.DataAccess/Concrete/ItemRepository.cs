using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ToDo.DataAccess.Abstract;
using ToDo.Entities;

namespace ToDo.DataAccess.Concrete
{
    public class ItemRepository:IItemRepository
    {
        public List<Item> getList()
        {
            using var toDoDbContext = new ToDoDbContext();
            return toDoDbContext.Items.ToList();
        }

        public Item getById(int id)
        {
            using var todoDbContext = new ToDoDbContext();
            return todoDbContext.Items.Find(id);
        }

        public Item Add(Item item)
        {
            using var todoDbContext = new ToDoDbContext();
            todoDbContext.Items.Add(item);
            todoDbContext.SaveChanges();
            return item;
        }

        public Item Update(Item item)
        {
            using var todoDbContext = new ToDoDbContext();
            todoDbContext.Items.Update(item);
            todoDbContext.SaveChanges();
            return item;
        }

        public void Delete(int id)
        {
            using var todoDbContext = new ToDoDbContext();
            todoDbContext.Items.Remove(getById(id));
            todoDbContext.SaveChanges();
        }
    }
}
