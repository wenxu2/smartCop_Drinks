using System;
using System.Collections.Generic;

/*
* Description: This class add drinks to the list and loop the list
* @author Wenwen Xu
* @version 1.0
Filename: Program.cs
*/

class MainClass
{
    public static void Main(string[] args)
    {
        //Initalize a list with Drinks
        List<Drinks> DrinkList = new List<Drinks>();

        //Add items to the list
        DrinkList.Add(new Drinks() { Type = "Orange Juice", IsCarbonated = false, TypeDescription="made from oranges" });
        DrinkList.Add(new Drinks() { Type = "Budweiser", IsCarbonated = true, TypeDescription = "5% alcohol" });
        DrinkList.Add(new Drinks() { Type = "Pepsi", IsCarbonated = true });

        //print out the items in the list
        foreach(Drinks aDrink in DrinkList)
        {
            Console.WriteLine(aDrink.ToString());
        }


    }
}

