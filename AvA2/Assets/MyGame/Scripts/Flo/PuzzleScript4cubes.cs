using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript4cubes : MonoBehaviour
{
    public Puzzle_2 puzzle_2;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            puzzle_2.count++;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cube")
        {
            puzzle_2.count--;
        }
    }
}