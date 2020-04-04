using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Telemachus
{
    public class TelemachusBehaviour : MonoBehaviour
    {
        IWebHost server;
        
        public void Awake()
        {
            server = new WebHostBuilder().Build();
            server.Start();
        }

        public void OnDestroy()
        {
            server.StopAsync();
        }

        public void Update()
        {

        }
    }
}
