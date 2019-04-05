using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MA24Projet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Démarrage des deux timers au lancement de l'application
            timerChrono.Start();
        }

        //Initialisation de la variable start qui contient la date, l'heure, les secondes... de l'ordinateur au démarage du programme
        DateTime start = DateTime.Now;
        TimeSpan time;

        private void timerChrono_Tick(object sender, EventArgs e)
        {
            //Va faire faire cette opération et actualiser le chrono toutes les 1ms
            DateTime now = DateTime.Now;
            time = now - start;
            lblChrono.Text = time.Hours.ToString("d2") + ":" + time.Minutes.ToString("d2") + ":" + time.Seconds.ToString("d2") + ":" + time.Milliseconds.ToString("d2");
        }
    }
}
