using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player Aziz = new Player();
        Player Ahmad = new Player();

        Aziz.InitializePlayer("Aziz", 95);
        Ahmad.InitializePlayer("Ahmad", 80);

        Aziz.Heal(40);       
        Aziz.Heal(true);
        Ahmad.Heal(50);
        Ahmad.Heal(false);

        Player.ShowPlayerCount();




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
