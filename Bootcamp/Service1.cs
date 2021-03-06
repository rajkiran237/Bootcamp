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

namespace Bootcamp
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Log("OnStart");
        }

        protected override void OnStop()
        {
            Log("OnStop");
        }

        private List<string> Log(string data)
        {
            List<string> lines = new List<string>();
            try
            {
                lines.AddRange(
                new[] {
                        data,
                        "In log test for automated build. In demo. From Satish",
                        DateTime.Now.ToString()
                });

                File.AppendAllLines("c:\\BootcampDemo.log.txt", lines);
            }
            catch (Exception ex)
            {
                lines.AddRange(
                    new[] {
                        "Exception:",
                        ex.Message,
                        ex.StackTrace
                    });
            }

            return lines;
        }
    }
}
