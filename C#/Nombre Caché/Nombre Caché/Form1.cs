using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nombre_Caché
{
    public partial class frmNombreCache : Form
    {
        public frmNombreCache()
        {
            InitializeComponent();
        }

        private int nbEssai;
        private int valeurChercher;
        private int random;

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            txtValeur.Clear();
        }

        private void txtValeur_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int valeur = Convert.ToInt32(txtValeur.Text);
            nbEssai = nbEssai +1;
            grpReponse.Text = "Essai n°" + nbEssai;

            if (valeur == valeurChercher)
                {
                    lblMessage.Text = " Félicitation, la réponse était bien : " + valeurChercher;
                    txtValeur.Enabled = false;
                }
            else
            {
                if (valeur > valeurChercher)
                {
                    lblMessage.Text = valeur + " est trop grand";
                }

                else
                {
                    lblMessage.Text = valeur + " est trop petit";
                }
            }
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void frmNombreCache_Load(object sender, EventArgs e)
        {
            nbEssai = 0;
            txtValeur.Text = "";
            txtValeur.Focus();
            valeurChercher = 55;


        }
    }
}
