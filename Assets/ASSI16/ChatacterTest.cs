using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
public class ChatacterTest : MonoBehaviour
{
    Soldier soldier;
    Officer officer;    

    void Start()
    {
        soldier = new Soldier();
        officer = new Officer("Officer Mahsoon", 130, new Position(5, 10, 5));
        Character[] characters = new Character[] { soldier, officer };

        for(int i=0; i<characters.Length; i++)
        {
            characters[i].DisplayInfo();
        }

         Debug.Log("Before attack:" + soldier.name + "'s Health:" + soldier.Health);

         officer.Attack(35, soldier);

        Debug.Log("After attack:" + soldier.name + "'s Health:" + soldier.Health);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}