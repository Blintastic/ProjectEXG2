using System.Collections;
using System;
using System.Net.Sockets;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using ArtDotNet.Packets;

namespace ArtDotNet
{

    public class lightManager : MonoBehaviour
    {
        private ArtNetClient artClient;
        public IPAddress Address { get; set; }

        [SerializeField]
        private Light[] lights;





    }

}




