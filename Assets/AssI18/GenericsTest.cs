using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
namespace Assignment18
{
public class GenericsTest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> Sentence = new GameContainer<string> ();
        Sentence.SetItem("Healing potion");
        Sentence.GetItem();
        GameUtils.DescribeItem(Sentence.GetItem());
        
    }

}
}