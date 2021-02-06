using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Business.Abstract;
using ToDo.DataAccess.Concrete;
using ToDo.Entities;

namespace ToDo.Business.Concrete
{
    public class ItemManager:IItemService
    {
        ItemRepository _itemRepository;
        public ItemManager()
        {
            _itemRepository = new ItemRepository();
        }
        public List<Item> getList()
        {
           return _itemRepository.getList();
        }

        public Item getById(int id)
        {
            return _itemRepository.getById(id);
        }

        public Item Add(Item item)
        {
            return _itemRepository.Add(item);
        }

        public Item Update(Item item)
        {
            return _itemRepository.Update(item);
        }

        public void Delete(int id)
        {
            _itemRepository.Delete(id);
        }
    }
}
