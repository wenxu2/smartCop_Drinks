using System;
using System.Collections.Generic;

/*
 * @author Wenwen Xu
 * @version 1.0
 Filename: Juice.cs
*/

class Juice : IDrink
{
    //add new item 
    public void ToString() {

        List<Drinks> _Juice = new List<Drinks>();
        _Juice.Add(new Drinks() { Type = "Orange Juice", IsCarbonated = false, TypeDescription = "made from oranges" });

        foreach(Drinks aJuice in _Juice)
        { 
            if(aJuice.IsCarbonated)
            {
                Console.WriteLine(aJuice.Type + ", " + "cardbonated," + " " + aJuice.TypeDescription);

            }else
            {
                Console.WriteLine(aJuice.Type + ", " + "not cardbonated," + " " + aJuice.TypeDescription);
            }
        }


    }

}

