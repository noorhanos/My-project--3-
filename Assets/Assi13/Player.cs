using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
   public static int playerCount = 0;
   public string PlyerName;
   public int health;
   public int MaxHealth=100;
public void InitializePlayer(string Name, int Health)
   {
    PlyerName= Name;
    health = Health;
    playerCount++;
   }

   public void Heal (int amount)
   {
    health += 5;
    Debug.Log(health);

   }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            // Fully restore health
            health = MaxHealth;
        }
      
    }

          public static void ShowPlayerCount()
    {
        // Use Debug.Log to print the current player count in the Unity console
        Debug.Log("Total players:" + playerCount);
    }
    
}
