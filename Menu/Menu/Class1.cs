using System;
using System.Collections;
namespace Menu
{
    public class MenuForm   
    {
        ArrayList menu;

        public MenuForm()
        {
            menu = new ArrayList();
        }
        public void addMenuItem(string mn)
        {
            menu.Add(mn);
        }
        public int GetChoice(int min, int max)
        {
            int choice = 0;
            while (true)
            {
                try
                {
                    foreach (string mn in menu)
                    {
                        Console.WriteLine(mn.ToString());
                    }
                    choice = int.Parse(Console.ReadLine());
                    return choice;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please input a number between " + min + " and " + max);
                }
            }
        }
    }
}
