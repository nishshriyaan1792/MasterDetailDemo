using System;
using System.Collections.Generic;
using System.Text;

namespace Datarynx.Models
{
    public enum MenuItemType
    {
        ToDoList,
        About,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
