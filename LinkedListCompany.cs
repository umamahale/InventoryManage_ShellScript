using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement1
{
    class LinkedListCompany
    {
        static public void Main()
        {

            // Creating a linkedlist
            // Using LinkedList class
            LinkedList<String> my_list = new LinkedList<String>();

            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast("tcs");
            my_list.AddLast("infosys");
            my_list.AddLast("techmaindra");
            my_list.AddLast("NTT");
            my_list.AddLast("cognizant");
            my_list.AddLast("Wipro");

            Console.WriteLine("Best IT Comapany:");

            // Accessing the elements of 
            // LinkedList Using foreach loop
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }
        }
    }
}
