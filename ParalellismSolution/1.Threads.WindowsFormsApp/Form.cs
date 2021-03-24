using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _1.Threads.WindowsFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
        }

        private void btnSynchonously_Click(object sender, EventArgs e)
        {

            lst1.Items.Clear();
            lst2.Items.Clear();


            for (int i = 0; i < numericUpToDown.Value; i++)
            {
                if (i % 2 == 0)
                {
                    lst1.Items.Add(i);
                }
            }

            for (int i = 0; i < numericUpToDown.Value; i++)
            {
                if (i % 3 == 0)
                {
                    lst2.Items.Add(i);
                }
            }
        }

        private void btnAsynchronously_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
            lst2.Items.Clear();

            Thread t1 = new Thread(delegate ()
            {
                for (int i = 0; i < numericUpToDown.Value; i++)
                {
                    if (i % 2 == 0)
                    {
                        lst1.Items.Add(i);
                    }
                }
            });

            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < numericUpToDown.Value; i++)
                {
                    if (i % 3 == 0)
                    {
                        lst2.Items.Add(i);
                    }
                }
            });

            t1.Start();

            //t1.Join(); // t1 bitenden sonra t2 ishleyecek.

            //Thread.Sleep(150); // butun Threadler 150 millisaniyelik yuxu rejimi alir

            //t1.Suspend(); // t1 dayanir

            //t1.Resume(); // t1 dayandigi yerden davam edir

            t2.Start();

            //t2.Abort(); // t2 Thread'i legv olunur
        }
    }
}
