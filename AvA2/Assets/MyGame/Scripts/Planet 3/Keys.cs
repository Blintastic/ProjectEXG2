using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Keys")
        {
            Debug.Log("hit");
            Portal.keys++;
            Destroy(other.gameObject);
        }
    }
}
