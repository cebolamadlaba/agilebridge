using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileBridgeAss.MenuItems.Data;
using AgileBridgeAss.MenuItems.DTOs;
using AgileBridgeAss.MenuItems.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AgileBridgeAss.Controllers
{
    [Route("api/MenuItem")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemManager _menuItemManager;

        public MenuItemController(IMenuItemManager menuItemManager)
        {
            _menuItemManager = menuItemManager;
        }

        [HttpGet]
        [Route("GetList")]
        public ActionResult<IEnumerable<MenuItemDto>> GetList(string roleType)
        {
            return _menuItemManager.GetAll(roleType);
        }

        [HttpGet("Get")]
        public ActionResult<MenuItemDto> Get(int id)
        {
            return _menuItemManager.Get(id);
        }

        [HttpPost]
        [Route("Post")]
        public void Post([FromBody] MenuItemDto item)
        {
            MenuItem menuItem = new MenuItem
            {
                Description = item.Description,
                DisplayOrder = item.DisplayOrder,
                RoleId = item.RoleId,
                ParentId = item.ParentId,
                Url = item.Url,
                IsActive = item.IsActive
            };
            _menuItemManager.Add(menuItem);
        }

        [HttpPut]
        [Route("Update")]
        public void Update(int id, [FromBody] MenuItemDto item)
        {
            _menuItemManager.Update(item);
        }

        [HttpDelete]
        [Route("Delete")]
        public void Delete(MenuItemDto item)
        {
            _menuItemManager.Delete(item);
        }
    }
}
