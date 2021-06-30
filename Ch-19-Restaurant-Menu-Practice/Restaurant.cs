using System;
using System.Collections.Generic;

namespace Ch_19_Restaurant_Menu_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> items = new List<MenuItem>();

            Menu myMenu = new Menu($"MENU");

            MenuItem item1 = new MenuItem("Chips and Guacamole", 10.00, "Homemade Guacamole with corn tortillas", "Appetizer", "NEW ITEM!!!");
            MenuItem item2 = new MenuItem("Buffalo Wings", 5.99, "Buffalo Wings with celery and ranch.", "Main Course");
            MenuItem item3 = new MenuItem("CheeseBurger", 9.99, "16oz Burger with Provolone, toppings of choice, and fries.", "Main Course");
            MenuItem item4 = new MenuItem("Cheese Cake", 5.99, "New York style cheesecake.", "Dessert", "");
            MenuItem item5 = new MenuItem("Bread Sticks", 3.00, "Bread sticks with butter and garlic.", "Appetizer", "NEW ITEM!!!");
            MenuItem item6 = new MenuItem("Buffalo Wings", 5.99, "Buffalo Wings with celery and ranch.", "Main Course");
            MenuItem item7 = new MenuItem("Chips and Dip ", 4.99, "Chips with mild salsa.", "Appetizer", "");
            MenuItem item8 = new MenuItem("Apple Pie", 4.99, "Mama's original apple pie ala mode.", "Dessert");
            MenuItem item9 = new MenuItem("Fresh Fruit", 4.99, "Assortment of fresh fruits.", "Dessert");


            myMenu.AddMenuItem(item1);
            myMenu.AddMenuItem(item2);
            myMenu.AddMenuItem(item3);
            myMenu.AddMenuItem(item4);
            myMenu.AddMenuItem(item5);
            myMenu.AddMenuItem(item6);
            myMenu.AddMenuItem(item7);
            myMenu.AddMenuItem(item8);
            myMenu.AddMenuItem(item9);


            myMenu.RemoveMenuItem(item6);

            myMenu.PrintSingleItem(item1);
            myMenu.PrintMenuItems();

            Console.WriteLine($"{item2.Name} is equal to {item6.Name}: {item2.Equals(item6)}");
            Console.WriteLine($"{item2.Name} is equal to {item7.Name}: {item2.Equals(item7)}");

        }

    }
}
