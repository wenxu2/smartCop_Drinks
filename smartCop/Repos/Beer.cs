using System;
using System.Collections.Generic;

/*
 * @author Wenwen Xu
 * @version 1.0
 Filename: Beer.cs
*/

public class Beer : IDrink
{
    //add new item
    public void ToString()
    {

        List<Drinks> _Beer = new List<Drinks>();
        _Beer.Add(new Drinks() { Type = "Budweiser", IsCarbonated = true, TypeDescription = "5% alcohol" });

        foreach (Drinks aBeer in _Beer)
        {
            if (aBeer.IsCarbonated)
            {
                Console.WriteLine(aBeer.Type + ", " + "cardbonated," + " " + aBeer.TypeDescription);

            }
            else
            {
                Console.WriteLine(aBeer.Type + ", " + "not cardbonated," + " " + aBeer.TypeDescription);
            }
        }


    }

}




