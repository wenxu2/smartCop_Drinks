using System;
using System.Collections.Generic;

public class Soda : IDrink
{
    public void ToString()
    {

        List<Drinks> _Soda = new List<Drinks>();
        _Soda.Add(new Drinks() { Type = "Pepsi", IsCarbonated = true }); 

        foreach (Drinks aSoda in _Soda)
        {
            if (aSoda.IsCarbonated)
            {
                Console.WriteLine(aSoda.Type + ", " + "cardbonated," + " " + aSoda.TypeDescription);

            }
            else
            {
                Console.WriteLine(aSoda.Type + ", " + "not cardbonated," + " " + aSoda.TypeDescription);
            }
        }


    }
}

