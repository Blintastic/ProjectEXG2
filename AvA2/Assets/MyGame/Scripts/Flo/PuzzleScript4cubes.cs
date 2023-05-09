using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript4cubes : MonoBehaviour
{
    public Puzzle_1 puzzle_1;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            puzzle_1.count++;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cube")
        {
            puzzle_1.count--;           
        }
    }
}
