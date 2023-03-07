using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnTouch : MonoBehaviour
{
    public Transform respawnPoint; // set the respawn point in the inspector
    public Collider triggerCollider; // set the trigger collider in the inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other == triggerCollider)
        {
            RespawnObject();
        }
    }

    private void RespawnObject()
    {
        transform.position = respawnPoint.position;
        transform.rotation = respawnPoint.rotation;
    }
}


