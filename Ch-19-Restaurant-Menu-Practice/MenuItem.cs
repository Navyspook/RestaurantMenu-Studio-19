using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_19_Restaurant_Menu_Practice
{
    class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string NewOrNot { get; set; }
        public static DateTime TimeDate { get; set; }


        public static void PrintDateUpdated()
        {
            Console.WriteLine($"Menu Last Updated On: {TimeDate}");
        }

        public void PrintMenu()
        {

            Console.WriteLine($"{this.Name}     {this.NewOrNot}\n{this.Price}\n{this.Description}");
            Console.WriteLine("____________________________\n");

        }

        public void PrintItem()
        {
            Console.WriteLine($"{this.Name}     {this.NewOrNot}\n{this.Price}\n{this.Description}");
            Console.WriteLine("____________________________\n");
        }

        public MenuItem(string name, double price, string description, string category, string newOrNot)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.NewOrNot = newOrNot;
        }

        public MenuItem(string name, double price, string description, string category)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Category = category;
        }

        public override Boolean Equals(object toBeCompared)
        {

            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            MenuItem s = toBeCompared as MenuItem;
            return s.Name == this.Name;
        }

    }
}
