using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileBridgeAss.MenuItems.DTOs
{
    public class MenuItemDto
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public string Description { get; set;}

        public string Url { get; set; }

        public int DisplayOrder { get; set; }

        public int RoleId { get; set; }

        public bool IsActive { get; set; }
    }
}
