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
        // move the object to the respawn point
        transform.position = respawnPoint.position;
        transform.rotation = respawnPoint.rotation;

        // reset any other necessary properties or variables
        // ...

        Debug.Log("Object respawned at " + respawnPoint.position);
    }
}


