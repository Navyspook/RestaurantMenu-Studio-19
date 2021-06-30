using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_19_Restaurant_Menu_Practice
{
    class Menu
    {
        public string MenuName { get; set; }

        public List<MenuItem> ListOfMenuItems = new List<MenuItem>();

        public Menu(string name)
        {
            this.MenuName = name;
        }

        public void AddMenuItem(MenuItem item)
        {
            ListOfMenuItems.Add(item);
        }

        public void RemoveMenuItem(MenuItem item)
        {
            ListOfMenuItems.Remove(item);
        }

        public void PrintMenuItems()
        {
            foreach(MenuItem item in this.ListOfMenuItems)
            {
                item.PrintMenu();
            }
            MenuItem.PrintDateUpdated();
        }

        public void PrintSingleItem(MenuItem specificItem)
        {
            int i = this.ListOfMenuItems.IndexOf(specificItem);
            ListOfMenuItems[i].PrintItem();
        }


    }
}
