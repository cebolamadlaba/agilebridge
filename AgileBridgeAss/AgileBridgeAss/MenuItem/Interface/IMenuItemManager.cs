using AgileBridgeAss.MenuItems.Data;
using AgileBridgeAss.MenuItems.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileBridgeAss.MenuItems.Interface
{
    public interface IMenuItemManager
    {
        List<MenuItemDto> GetAll(String roleType);
        MenuItemDto Get(long id);
        void Add(MenuItem menuItem);
        void Update(MenuItemDto menuItem);
        void Delete(MenuItemDto menuItem);
    }
}
