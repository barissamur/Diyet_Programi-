using DiyetisyenProje.PL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetisyenProje.PL
{
    public partial class SplashScreen : Form
    {
        int sayac = 1;
       
        public SplashScreen()
        {
            InitializeComponent();
            tmrEkran.Start();
        }

        private void tmrEkran_Tick(object sender, EventArgs e)
        {
            if (sayac-- < 0)
            {
                DialogResult= DialogResult.OK;
                tmrEkran.Stop();
                Close();
            }
        }
    }
}
