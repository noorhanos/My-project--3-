using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player1 Player = new Player1("Ali", 90);
        Enemy enemy = new Enemy("sami", 93);


        Debug.Log(Player.Name + Player.Health);
        Debug.Log(enemy.Name + enemy.Health);

        Player.Heal(10);
        enemy.Attack(Player,40);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
