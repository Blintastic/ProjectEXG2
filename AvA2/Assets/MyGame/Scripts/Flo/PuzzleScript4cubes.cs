using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript4cubes : MonoBehaviour
{
    public Puzzle_1 puzzle_1;
    public static bool isSnapped = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            puzzle_1.count++;

            other.gameObject.transform.position = gameObject.transform.position;
            other.gameObject.transform.rotation = gameObject.transform.rotation;
            isSnapped = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cube")
        {
            puzzle_1.count--;

            isSnapped = false;
        }
    }
}
