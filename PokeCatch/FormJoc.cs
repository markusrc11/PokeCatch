using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;



namespace PokeCatch
{
    public partial class FormJoc : Form
    {
        int comptadorTemps;
        int coordX;
        int coordY;
        int puntuacio;
        string nivell;
        Random r = new Random();
       
        //iniciem el reproductor
        WindowsMediaPlayer song;        
        WindowsMediaPlayer countdown;
        WindowsMediaPlayer caught1;
        WindowsMediaPlayer caught2;


        public FormJoc()
        {
            InitializeComponent();

            DoubleBuffered = true;

            infoBTN = new ToolTip();

            infoBTN.AutoPopDelay = 5000;
            infoBTN.InitialDelay = 1000;
            infoBTN.ReshowDelay = 500;
            infoBTN.ShowAlways = true;

            infoBTN.SetToolTip(this.btnPlayMenu, "Play");
            infoBTN.SetToolTip(this.pbPlay, "Play");
        }        

        private void comptTemps_Tick(object sender, EventArgs e)
        {
            comptadorTemps--;
            lblTime.Text = comptadorTemps.ToString();

            if (comptadorTemps == 0)
            {
                countdown.URL = "Juego Pokemon\\beep0.wav";
                btnStopMenu.PerformClick();

                //crida a mètode propi
                GuardarDificultat();
            }

            else if (comptadorTemps < 6)
            {
                countdown.URL = "Juego Pokemon\\beep-5.wav";
                lblTime.ForeColor = Color.Red;
            }

            else if (comptadorTemps < 11)
            {
                countdown.URL = "Juego Pokemon\\beep-10.wav";
                lblTime.ForeColor = Color.DarkOrange;
            }
        }

        private void GuardarDificultat()
        {
            string fitxer = @"puntuacio" + nivell + ".txt";
            string linia = "";
            Boolean record = false;

            if (File.Exists(fitxer))
            {
                linia = File.ReadAllText(fitxer);

                if (puntuacio > int.Parse(linia))
                {
                    File.WriteAllText(fitxer, puntuacio.ToString());
                    record = true;
                }
            }
            else
            {
                File.WriteAllText(fitxer, puntuacio.ToString());

            }

            FormPuntuacioFinal f2 = new FormPuntuacioFinal(puntuacio, nivell, record);
            f2.ShowDialog();
        }

        private void comptImatge1_Tick(object sender, EventArgs e)
        {
            do
            {
                coordX = r.Next(5, 900);
                coordY = r.Next(25, 445);

                pbPokemon1.Hide();
                pbPokemon1.Location = new Point(coordX, coordY);
            } while (pbPokemon1.Bounds.IntersectsWith(pbPokemon2.Bounds));
            
            pbPokemon1.Show();
        }

        private void comptImatge2_Tick(object sender, EventArgs e)
        {
            do
            {
                coordX = r.Next(5, 900);
                coordY = r.Next(25, 445);

                pbPokemon2.Hide();
                pbPokemon2.Location = new Point(coordX, coordY);
            } while (pbPokemon2.Bounds.IntersectsWith(pbPokemon1.Bounds));
            pbPokemon2.Show();
        }

        private void pbPpokemon1_Click(object sender, EventArgs e)
        {
            caught1.URL = ("Juego Pokemon\\pokemon_caught.wav");
            caught1.controls.play();
            pbPokemon1.Hide();
            puntuacio += 1;
            lblPunts.Text = puntuacio.ToString();
        }

        private void pbPokemon2_Click(object sender, EventArgs e)
        {
            caught2.URL = ("Juego Pokemon\\pokemon_caught.wav");
            caught2.controls.play();
            pbPokemon2.Hide();
            puntuacio += 1;
            lblPunts.Text = puntuacio.ToString();
        }

        private void pausarJoc_Click(object sender, EventArgs e)
        {
            if (comptTemps.Enabled == true)
            {
                comptTemps.Enabled = false;
                comptImatge1.Stop();
                comptImatge2.Stop();

                pbPokemon1.Hide();
                pbPokemon2.Hide();

                btnPlayPauseMenu.BackgroundImage = Properties.Resources.play;
                btnPlayPauseMenu.Show();

                pausarMenuItem.Text = "Reanudar";

                infoBTN.SetToolTip(this.btnPlayPauseMenu, "Play");

                song.controls.pause();
            }
            else
            {
                comptTemps.Enabled = true;
                comptImatge1.Start();
                comptImatge2.Start();

                pbPokemon1.Show();
                pbPokemon2.Show();

                btnPlayPauseMenu.BackgroundImage = Properties.Resources.pause;
                btnPlayPauseMenu.Show();

                pausarMenuItem.Text = "Pausar";

                infoBTN.SetToolTip(this.btnPlayPauseMenu, "Pause");

                song.controls.play();
            }
        }

        private void pararJoc_Click(object sender, EventArgs e)
        {
            song.controls.stop();

            comptTemps.Enabled = false;
            comptImatge1.Enabled = false;
            comptImatge2.Enabled = false;

            pbPokemon1.Hide();
            pbPokemon2.Hide();
            pbPokeball.Hide();
            lblPunts.Hide();
            lblTime.Hide();

            btnPlayMenu.Show();
            btnPlayPauseMenu.Hide();
            btnStopMenu.Hide();
            btnRestartMenu.Hide();
            pbPlay.Show();

            novaMenuItem.Visible = true;
            pausarMenuItem.Visible = false;
            reiniciarMenuItem.Visible = false;
            pararMenuItem.Visible = false;
            dificultatMenuItem.Visible = true;
            ajudaMenuItem.Visible = true;


            this.BackgroundImage = Properties.Resources.Pokemon_Intro;
        }

        private void reiniciarJoc_Click(object sender, EventArgs e)
        {
            comptImatge1.Enabled = false;
            comptImatge2.Enabled = false;
            comptTemps.Enabled = false;

            song.controls.stop();
            caught1.controls.stop();
            caught2.controls.stop();
            countdown.controls.stop();

            pbPokemon1.Hide();
            pbPokemon2.Hide();

            pausarMenuItem.Text = "Pausar";

            MessageBox.Show("El joc es reiniciarà en 2 segons","Informació",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Thread.Sleep(2000);

            puntuacio = 0;
            comptadorTemps = 60;
            lblPunts.Text = puntuacio.ToString();
            lblTime.ForeColor = Color.Green;
            lblTime.Text = comptadorTemps.ToString();

            comptImatge1.Enabled = true;
            comptImatge2.Enabled = true;
            comptTemps.Enabled = true;

            song.controls.play();

            pbPokemon1.Show();
            pbPokemon2.Show();
        }

        private void facilMenuItem_Click(object sender, EventArgs e)
        {
            if (facilMenuItem.Checked)
            {
                intermigMenuItem.Checked = false;
                dificilMenuItem.Checked = false;
            }
        }

        private void intermigMenuItem_Click(object sender, EventArgs e)
        {
            if (intermigMenuItem.Checked)
            {
                facilMenuItem.Checked = false;
                dificilMenuItem.Checked = false;
            }

        }

        private void dificilMenuItem_Click(object sender, EventArgs e)
        {
            if (dificilMenuItem.Checked)
            {
                facilMenuItem.Checked = false;
                intermigMenuItem.Checked = false;
            }
        }

        private void novaPartida_Click(object sender, EventArgs e)
        {
            if (facilMenuItem.Checked || intermigMenuItem.Checked || dificilMenuItem.Checked)
            {
                novaMenuItem.Visible = false;
                pausarMenuItem.Visible = true;
                reiniciarMenuItem.Visible = true;
                pararMenuItem.Visible = true;
                dificultatMenuItem.Visible = false;
                ajudaMenuItem.Visible = false;

                pbPlay.Hide();

                btnPlayPauseMenu.BackgroundImage = Properties.Resources.pause;
                btnRestartMenu.Show();
                btnPlayPauseMenu.Show();
                btnPlayMenu.Hide();
                btnStopMenu.Show();
                
                puntuacio = 0;
                comptadorTemps = 60;
                lblPunts.Text = puntuacio.ToString();
                lblPunts.Visible = true;
                lblTime.Visible = true;

                this.BackgroundImage = Properties.Resources.Pokemon_Wallpaper;

                lblTime.ForeColor = Color.Green;
                lblTime.Text = comptadorTemps.ToString();


                comptTemps.Enabled = true;
               
                song = new WindowsMediaPlayer();
                countdown = new WindowsMediaPlayer();
                caught1 = new WindowsMediaPlayer();
                caught2 = new WindowsMediaPlayer();
                song.URL = "Juego Pokemon\\pokemon_base.wav";
                song.settings.volume = 30;

                if (facilMenuItem.Checked)
                {
                    facilMenuItem.Checked = true;

                    pbPokemon1.BackgroundImage = Properties.Resources.Bulbasaur;
                    pbPokemon2.BackgroundImage = Properties.Resources.Squirtle;
                    pbPokeball.BackgroundImage = Properties.Resources.pokeball;

                    nivell = "Fàcil";

                    comptImatge1.Interval = 1700;
                    comptImatge2.Interval = 1400;
                }

                else if (intermigMenuItem.Checked)
                {
                    intermigMenuItem.Checked = true;

                    pbPokemon1.BackgroundImage = Properties.Resources.Pikachu;
                    pbPokemon2.BackgroundImage = Properties.Resources.Charmander;
                    pbPokeball.BackgroundImage = Properties.Resources.superball;

                    nivell = "Intermig";

                    comptImatge1.Interval = 1300;
                    comptImatge2.Interval = 1100;
                }

                else if (dificilMenuItem.Checked)
                {
                    dificilMenuItem.Checked = true;

                    pbPokemon1.BackgroundImage = Properties.Resources.Mew;
                    pbPokemon2.BackgroundImage = Properties.Resources.Mewtwo;
                    pbPokeball.BackgroundImage = Properties.Resources.ultraball;

                    nivell = "Difícil";

                    comptImatge1.Interval = 1000;
                    comptImatge2.Interval = 800;
                }
                pbPokeball.Show();
                comptImatge1.Enabled = true;
                comptImatge2.Enabled = true;

                infoBTN.SetToolTip(this.btnPlayPauseMenu, "Pause");
                infoBTN.SetToolTip(this.btnStopMenu, "Stop");
                infoBTN.SetToolTip(this.btnRestartMenu, "Restart");
            }
            else
                MessageBox.Show("Escull un nivell de dificultat");
        }

        private void quiSomMenuItem_Click(object sender, EventArgs e)
        {
            FormQuiSom f3 = new FormQuiSom();
            f3.ShowDialog();
        }
    }
}