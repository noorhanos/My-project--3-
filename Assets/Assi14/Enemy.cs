using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
  public Enemy(string name, int health) : base(name, health)
    {
    }

     public void Attack(Character target, int damage)
    {
        // Ensure Health does not go below 0
        target.Health = target.Health - damage;        
        Debug.Log(Name +"attacked"  +target.Name + "for"+ damage+ "damage" + target.Name+ "'s current Health:"+ target.Health);

}}
