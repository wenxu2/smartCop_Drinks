using System;
using System.Collections.Generic;

public class Drink
{
    public string Type { get; set; }
    public bool IsCarbonated { get; set; }
    public string TypeDescription { get; set; }

    public override string ToString() {

        if(IsCarbonated)
        {
            return Type + ", " + "cardbonated," + " " + TypeDescription;
        }
        else
            return Type + ", " + "not cardbonated," + " " + TypeDescription;
    }
}



class MainClass
{
    public static void Main(string[] args)
    {

        List<Drink> DrinkList = new List<Drink>();

        DrinkList.Add(new Drink() { Type = "Orange Juice", IsCarbonated = false, TypeDescription="made from oranges" });
        DrinkList.Add(new Drink() { Type = "Budweiser", IsCarbonated = true, TypeDescription = "5% alcohol" });
        DrinkList.Add(new Drink() { Type = "Pepsi", IsCarbonated = true });

        foreach(Drink aDrink in DrinkList)
        {
            Console.WriteLine(aDrink.ToString());
        }


    }
}

