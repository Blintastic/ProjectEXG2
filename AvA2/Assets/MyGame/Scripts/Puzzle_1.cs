 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_1 : MonoBehaviour
{
    public int count = 0;
    public GameObject portal;

    private void Update()
    {
        if (count == 5)
        {
            portal.SetActive(true);
            Debug.Log("Activate Portal");
        }
    }



}