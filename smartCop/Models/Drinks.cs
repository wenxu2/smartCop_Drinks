using System;
using System.Collections.Generic;

/*
 * Description: Model class for drinks 
 * @author Wenwen Xu
 * @version 1.0
 Filename: drink.cs
*/

public class Drinks
{
    public string Type { get; set; }
    public bool IsCarbonated { get; set; }
    public string TypeDescription { get; set; }

    public override string ToString()
    {
        //If isCarbonated equal to true, print the word 'cardbonated' 
        //else print out 'not cardbonated'
        if (IsCarbonated)
        {
            return Type + ", " + "cardbonated," + " " + TypeDescription;
        }
        else
            return Type + ", " + "not cardbonated," + " " + TypeDescription;
    }
}




