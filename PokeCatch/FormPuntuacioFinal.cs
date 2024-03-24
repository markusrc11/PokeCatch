using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace PokeCatch
{
    public partial class FormPuntuacioFinal : Form
    {
        Boolean comboBoxCambiat;

        public FormPuntuacioFinal()
        {
            InitializeComponent();
        }

        public FormPuntuacioFinal(int punts, string nivell, Boolean record)
        {
            InitializeComponent();

            comboBoxCambiat = false;

            lblPunts.Text = punts.ToString();
            lblNivell.Text = "Nivell ";
            comboNivell.Text = nivell;
            lPuntsMax.Text = File.ReadAllText(@"puntuacio" + nivell + ".txt");

            if (record)
                lblRecord.Text = "NOU RÈCORD!!";
        }

        private void comboNivell_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCambiat)
            {
                lblPuntuacio.Hide();
                lblPunts.Hide();
                lblRecord.Hide();
            }

            try
            {
                switch (comboNivell.Text)
                {
                    case "Fàcil":
                        this.BackColor = ColorTranslator.FromHtml("#D65169");
                        comboNivell.BackColor = ColorTranslator.FromHtml("#D65169");
                        break;

                    case "Intermig":
                        this.BackColor = ColorTranslator.FromHtml("#44AAD2");
                        comboNivell.BackColor = ColorTranslator.FromHtml("#FEDD43");
                        comboNivell.BackColor = ColorTranslator.FromHtml("#44AAD2");
                        break;

                    case "Difícil":
                        this.BackColor = ColorTranslator.FromHtml("#FEDD43");
                        comboNivell.BackColor = ColorTranslator.FromHtml("#FEDD43");
                        break;
                }

                lPuntsMax.Text = File.ReadAllText(@"puntuacio" + comboNivell.Text + ".txt");
            }
            catch (FileNotFoundException)
            {
                lPuntsMax.Text = "-";
            }

            comboBoxCambiat = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}