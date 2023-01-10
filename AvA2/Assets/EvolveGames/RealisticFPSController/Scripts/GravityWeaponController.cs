using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityWeaponController : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] float maxGrabDistance = 10f, throwForce = 20f, lerpSpeed = 10f;
    [SerializeField] Transform objectHolder;

    [SerializeField] float scrollSpeed = 5;

    Rigidbody grabbedRB;

    Material hightlightColor;

    //Markus du HS

    private void Update()
    {
        if (grabbedRB)
        {
            grabbedRB.MovePosition(Vector3.Lerp(grabbedRB.position, objectHolder.transform.position, Time.deltaTime * lerpSpeed));

            Vector3 translateDirection = new Vector3(0,0, Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);

            objectHolder.transform.Translate(translateDirection);

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                grabbedRB.isKinematic = false;
                grabbedRB.AddForce(cam.transform.forward * throwForce, ForceMode.VelocityChange);
                grabbedRB = null;
            }

            if (Input.GetKey(KeyCode.Mouse1))
            {
                grabbedRB.velocity = Vector3.zero;

                grabbedRB.gameObject.GetComponent<Renderer>().material.color = Color.blue;

                grabbedRB.useGravity = false;
                grabbedRB = null;
            }
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            if (grabbedRB)
            {
                grabbedRB.isKinematic = false;
                grabbedRB.useGravity = true;

                grabbedRB.gameObject.GetComponent<Renderer>().material.color = Color.green;
                grabbedRB = null;  
            }
            else
            {
                RaycastHit hit;
                Ray ray = cam.ViewportPointToRay(new Vector3(.5f, .5f));
                if(Physics.Raycast(ray, out hit, maxGrabDistance))
                {
                    grabbedRB = hit.collider.gameObject.GetComponent<Rigidbody>();
                    if (grabbedRB)
                    {
                        grabbedRB.isKinematic = true;
                    }
                }
            }
        }
    }
}
