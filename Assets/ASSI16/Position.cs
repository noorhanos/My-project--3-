using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 namespace Assignment18
{
public struct Position 
{
    public float X;
    public float Y;   
    public float Z;

     public Position(float X, float Y, float Z)
     {
        this.X = X;
        this.Y = Y;
        this.Z = Z;

     }
     public void PrintPosition(float X, float Y, float Z)
     {
        Debug.Log("Position: " + X + Y +Z);

     }



}
}