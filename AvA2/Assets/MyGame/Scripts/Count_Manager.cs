using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count_Manager : MonoBehaviour
{
    public int count;

    private void Update()
    {
        if (count == 5)
        {
            Debug.Log("PORTAL OPEN");
        }
    }
}
