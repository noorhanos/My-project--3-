using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MultiTable : MonoBehaviour
{
    int Multiply(int x, int y)
    {
        return x * y;
    }

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log("5 x " + i + " = " + Multiply(5, i));
        }
    }
}
