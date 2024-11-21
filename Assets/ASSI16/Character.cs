using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
public class Character
{
    public string name;
    private int health;
    protected Position position;

    public int Health
    {
        get
        {
            return health;
        }

        set  
        {
            if (value < 0)
                health = 0;
            else if (value > 100)
                health = 100;
            else
                health = value;
        }
    }

 
    public Character (string name, int Health, Position position)
    {
        this.name = name;
        this.Health = Health;
        this.position = position;
    }

    public Character() : this("No name", 100, new Position(0, 0, 0))
    {
    }

    public virtual void DisplayInfo()
    {
        Debug.Log("Player is: "+ name + "its health: "+ health );
        position.PrintPosition;
    }

     public void Attack(int damage, Character target)
        {
            if (target != null)
            {
                target.Health -= damage;  
                Debug.Log(name + "attacks" + target.name + "for" + "damage" + damage);
                Debug.Log(target.name + "'s remaining health:"+  target.Health);
            }
            else
            {
                Debug.LogWarning("Target is null, cannot attack.");
            }
        }

     public void Attack(int damage, Character target, string AttackType)
     {
        if (target != null)
            {
                target.Health -= damage;  
                Debug.Log(name + "attacks" + target.name + "for" + "damage" + damage + target.name + "'s remaining health:"+  target.Health + "Attack Type is :"+ AttackType);
            }
            else
            {
                Debug.LogWarning("Target is null, cannot attack.");
            }

     }



}
}