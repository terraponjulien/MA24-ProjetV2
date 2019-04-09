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
            timer1.Start();
            //Rend le bouton Restart inclickable au lancement de l'application
            cmdRestart.Enabled = false;
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

        //Initialisationdes deux variables qui permettront d'afficher le bon message
        double secondes = 0;
        double minutes = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Va afficher le message mis a jour toutes les 10 secondes
            secondes = secondes + 10;
            if (secondes < 60)
            {
                lblTemps.Text = "Vous avez lancé le programme il y a " + secondes + " secondes";
            }
            else
            {
                //Opération permettant de passer en minutes
                minutes = secondes / 60;
                lblTemps.Text = "Vous avez lancé le programme il y a " + minutes + " minutes";
            }
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            //Mise à zero du chrono et du timer1
            time = TimeSpan.Zero;
            timerChrono.Stop();
            timer1.Stop();
            lblChrono.Text = time.Hours.ToString("d2") + ":" + time.Minutes.ToString("d2") + ":" + time.Seconds.ToString("d2") + ":" + time.Milliseconds.ToString("d2");
            lblTemps.Text = "";
            //Remise à zero des variables secondes et minutes
            secondes = 0;
            minutes = 0;
            //Rend le bouton Restart clickable après avoir clicker sur le bouton Reset
            cmdRestart.Enabled = true;
        }

        private void cmdRestart_Click(object sender, EventArgs e)
        {
            //Restart du chrono et du timer1
            start = DateTime.Now;
            timerChrono.Start();
            timer1.Start();
            //Remet le bouton restart inclickable
            cmdRestart.Enabled = false;
        }
    }
}
