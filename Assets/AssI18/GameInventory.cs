using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
public class GameInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Inventory potion= new Inventory();
        potion.AddItem("Healing Potion");
        potion.AddItem("Strength Potion");
        
        Inventory elixirInv = new Inventory();
        elixirInv.AddItem("Elixir");
        elixirInv.AddItem("Dark Elixir"); 
        
        Inventory combinedInventory = potion + elixirInv;

        // Show items in the combined inventory
        Debug.Log("Combined Inventory:");
        combinedInventory.ShowItems(combinedInventory);
    }

  
}
}