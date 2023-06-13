using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalScript1 : MonoBehaviour
{

    public int LevelIndex;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GameController")
        {
            Debug.Log("funktioniert");
            SceneManager.LoadScene(3);


        }
        
    }
}