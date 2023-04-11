 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_1 : MonoBehaviour
{
    public int count = 0;

    private void Update()
    {
        if (count == 5)
        {
            Debug.Log("Activate Portal");
        }
    }



}