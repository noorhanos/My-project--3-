using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
     {
         // Number generator
       int counter = 0;  
         while (counter<21)
         {
             int Number = Random.Range(1,21);
             Debug.Log(Number);
             counter++;
             if (Number==5) continue;
             else if (Number==15) break;

            
            

            
         }
        }

        { // Funny Sentence generator

        string[] funny = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        int counter1=0;
        string Sentence = " ";
        while (counter1< funny.Length)
        {
            int RandomWord= Random.Range(0,funny.Length);
            Sentence += funny[RandomWord];
           
            counter1++;
            if (counter1 <funny.Length) 
            {
                Sentence += " "; // Add a space 
            }

        }
           Debug.Log(Sentence);






        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
