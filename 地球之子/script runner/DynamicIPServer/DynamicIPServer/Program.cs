﻿using System;
using System.Collections.Generic;
using System.ServiceProcess;
using System.Text;

namespace DynamicIPServer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new DynamicIPServer() 
            };
            ServiceBase.Run(ServicesToRun);


            //DynamicIPServer king = new DynamicIPServer();
            //king.connect();
            //king.loadsave();
            //king.portlisten();
        }
    }
}
