using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
   public string Name
    { 
      get{return Name; }
      set{Name= value;} 
    }

   public int Health 
   { 
    get {return Health;}
    set {Health= value;}
   }

   public Character(string name, int health)
   {

    Name=name;
    Health= health;

   }



}
