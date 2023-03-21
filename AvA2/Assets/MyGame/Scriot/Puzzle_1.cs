using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_1 : MonoBehaviour
{
    public int count = 0;
    public static bool isSnapped = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            count ++;

            other.gameObject.transform.position = gameObject.transform.position;
            other.gameObject.transform.rotation = gameObject.transform.rotation;
            isSnapped = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cube")
        {
            count--;

            isSnapped = false;
        }
    }

    
}