using AgileBridgeAss.MenuItems.Data;
using System;
using Xunit;

namespace AgileBridgeAss.Test
{
    public class MenuItemTest
    {
        [Fact]
        public void AddMenuItemTest()
        {
            MenuItem menuItem = new MenuItem
            {
                Description = "event",
                DisplayOrder = 1,
                RoleId = (int)MenuEnum.Participant,
                ParentId = 0,
                Url = "/event",
                IsActive = true
            };

            //TODO Add assert 

        }
    }
}
