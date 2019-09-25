using AgileBridgeAss.MenuItems.Data;
using AgileBridgeAss.MenuItems.DTOs;
using AgileBridgeAss.MenuItems.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileBridgeAss.MenuItems.Manager
{
    public class MenuItemManager : IMenuItemManager
    {
        readonly AgileBridgeContext _agileBridgeContext; 

        public MenuItemManager(AgileBridgeContext context)
        {
            _agileBridgeContext = context;        
        }

        public List<MenuItemDto> GetAll(string roleType)
        {
            var results =new List<MenuItem>();

            switch (roleType)
            {
                case "Coordinator":
                    results = _agileBridgeContext.MenuItem.Where(x => x.RoleId == (int)MenuEnum.Coordinator && x.IsActive)
                                            .ToList();
                    break;
                case "Participant":
                    results = _agileBridgeContext.MenuItem.Where(x => x.RoleId == (int)MenuEnum.Participant && x.IsActive)
                                            .ToList();
                    break;
            }

            if (results == null)
                return null;

            return MapMenuItems(results);      
        }

        public MenuItemDto Get(long id)
        {
            var item = _agileBridgeContext.MenuItem
                               .FirstOrDefault(e => e.Id == id && e.IsActive);
            if (item == null)
                return null;

            return MapMenuItem(item);
        }

        public void Add(MenuItem menuItem)
        {         
            _agileBridgeContext.MenuItem.Add(menuItem);
            _agileBridgeContext.SaveChanges();
        }

        public void Update(MenuItemDto menuItem)
        {
            MenuItem item = _agileBridgeContext.MenuItem
                                               .FirstOrDefault(x=>x.Id== menuItem.Id);

            item.Description = menuItem.Description;
            item.DisplayOrder = menuItem.DisplayOrder;
            item.IsActive = menuItem.IsActive;
            item.ParentId = menuItem.ParentId;
            item.Url = menuItem.Url;
            item.RoleId = menuItem.RoleId;

            _agileBridgeContext.SaveChanges();
        }

        public void Delete(MenuItemDto menuItem)
        {
            MenuItem item = _agileBridgeContext.MenuItem
                                              .FirstOrDefault(x => x.Id == menuItem.Id);

            if (item != null) {
                _agileBridgeContext.MenuItem.Remove(item);
                _agileBridgeContext.SaveChanges();
            }
        }

        public MenuItemDto MapMenuItem(MenuItem menuItem)
        {
            return new MenuItemDto {
                 Id=menuItem.Id,
                 Description = menuItem.Description,
                 DisplayOrder = menuItem.DisplayOrder,
                 IsActive = menuItem.IsActive,
                 ParentId = menuItem.ParentId,
                 Url = menuItem.Url,
                 RoleId = menuItem.RoleId
            };
        }

        private List<MenuItemDto> MapMenuItems(List<MenuItem> menuItems)
        {
            var itemList = new List<MenuItemDto>();

            menuItems.ForEach(x=>
            {
                itemList.Add(MapMenuItem(x));
            });

            return itemList;
        }
    }
}
