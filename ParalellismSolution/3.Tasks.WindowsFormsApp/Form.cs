using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Tasks.WindowsFormsApp
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
            // Qeyd: Yeni texnologiya Paralellism Methodlarinda "delegate"
            // moterizesiz yazilmalidir

            lst1.Items.Clear();
            lst2.Items.Clear();

            var t1 = Task.Run(delegate
             {
                 for (int i = 0; i < numericUpToDown.Value; i++)
                 {
                     if (i % 2 == 0)
                     {
                         lst1.Items.Add(i);
                     }
                 }
             });

            var t2 = Task.Run(delegate
           {
               for (int i = 0; i < numericUpToDown.Value; i++)
               {
                   if (i % 3 == 0)
                   {
                       lst2.Items.Add(i);
                   }
               }
           });

            // Task.WhenAll(t1, t2);

            // Task.WhenAny(t1, t2);
        }
    }
}
