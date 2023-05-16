using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArtDotNet;

public class lightManager : MonoBehaviour
{
    private ArtNetClient artClient;

    [SerializeField]
    private Light[] lights;
}
