using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
namespace Assignment18
{
public class Inventory 
{
   private static  List<string> items;
   public Inventory() 
   {
    items=new List<string>();
   }
     public void AddItem( string item) 
   {
    items.Add(item);
   }
       public List<string> GetItems()
    {
        return new List<string>(items);
    }


   public void ShowItems(Inventory List1)
   {
    foreach (string item in List1.GetItems())
    {
        Debug.Log(item);
    }
   }

    public static Inventory operator +(Inventory sami, Inventory aziza)
    {
        Inventory comboInventory = new Inventory();

        // Access items via the GetItems method
        foreach (var item in sami.GetItems())
        {
            comboInventory.AddItem(item);
        }

        foreach (var item in aziza.GetItems())
        {
            comboInventory.AddItem(item);
        }

        return comboInventory;
    }
}
}
