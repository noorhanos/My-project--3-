using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
public class GameUtils 
{
    public static void DescribeItem <T> (T Something) 
    {
        Debug.Log("This item is: " + Something);
    }
}
}