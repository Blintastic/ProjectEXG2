using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GravityWeaponController : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] float maxGrabDistance = 10f, throwForce = 20f, lerpSpeed = 10f;
    [SerializeField] Transform objectHolder;

    [SerializeField] GameObject electricArc;
    [SerializeField] GameObject electricArcTargetPos;

    [SerializeField] float scrollSpeed = 5;

    [SerializeField] private LayerMask grabbedRBLayerMask;
        
    bool arcNeeded = false;

    Rigidbody grabbedRB;

    Material hightlightColor;

    //Markus du HS

    private void Update()
    {
        CheckArc();

        //if (PuzzleScript4cubes.isSnapped == true)
        {
           // grabbedRB = null;
            //arcNeeded = false;
            //PuzzleScript4cubes.isSnapped = true;
        }

        if (grabbedRB)
        {
            grabbedRB.MovePosition(Vector3.Lerp(grabbedRB.position, objectHolder.transform.position, Time.deltaTime * lerpSpeed));

            Vector3 translateDirection = new Vector3(0, 0, Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);

            objectHolder.transform.Translate(translateDirection);

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                arcNeeded = false;

                grabbedRB.isKinematic = false;
                grabbedRB.AddForce(cam.transform.forward * throwForce, ForceMode.VelocityChange);
                grabbedRB = null;
            }

            if (Input.GetKey(KeyCode.Mouse1))
            {
                arcNeeded = false;

                grabbedRB.velocity = Vector3.zero;

                grabbedRB.gameObject.GetComponent<Renderer>().material.color = Color.blue;

                grabbedRB.useGravity = false;
                grabbedRB = null;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (grabbedRB)
            {
                arcNeeded = false;

                grabbedRB.isKinematic = false;
                grabbedRB.useGravity = true;

                grabbedRB.gameObject.GetComponent<Renderer>().material.color = Color.green;
                grabbedRB = null;
            }
            else
            {
                

                RaycastHit hit;
                Ray ray = cam.ViewportPointToRay(new Vector3(.5f, .5f));
                if (Physics.Raycast(ray, out hit, maxGrabDistance))
                {
                    Debug.Log(hit);
                    grabbedRB = hit.collider.gameObject.GetComponent<Rigidbody>();
                    if (grabbedRB)
                    {
                        arcNeeded = true;
                        grabbedRB.isKinematic = true;

                        grabbedRB.transform.eulerAngles = Vector3.zero;
                    }
                }
            }
        }
    }

    void CheckArc()
    {
        if (arcNeeded)
        {
            electricArc.SetActive(true);
            electricArcTargetPos.transform.position = grabbedRB.position;
        }
        else if (!arcNeeded)
        {
            electricArc.SetActive(false);
        }
    }
}
