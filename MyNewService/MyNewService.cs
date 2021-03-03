﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MyNewService
{
    public partial class MyNewService : ServiceBase
    {
        Timer timer = new Timer();
        DateTime configuredTime;
        public MyNewService()
        {
            InitializeComponent();
            configuredTime = DateTime.Now.AddSeconds(12);
        }

        protected override void OnStart(string[] args)
        {
            FileWrite("Service started at " + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 10000; //number in milliseconds  
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            FileWrite("Service stopped at " + DateTime.Now);
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            if (DateTime.Now > configuredTime)
            {
                FileWrite("Service is called again at " + DateTime.Now);
            }
        }
        public void FileWrite(string Message)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            string path = "D:\\Downloads\\Cognizant Practice\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = path + "\\ServiceLog_" + DateTime.Now.ToString().Replace('/', '-') + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }
    }
}
