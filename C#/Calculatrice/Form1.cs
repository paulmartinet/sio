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

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isText1Filled = false;
        private bool isText2Filled = false;
        private string selectedOperation = "";

        private void UpdateOperationButtons()
        {
            if (!isText1Filled || !isText2Filled || string.IsNullOrEmpty(selectedOperation))
            {
                DisableAllButtons();
            }
            else
            {
                EnableAllButtons();
            }
        }

        private void DisableAllButtons()
        {
            btn_addi.Enabled = true;
            btn_soustra.Enabled = true;
            btn_divis.Enabled = true;
            btn_multi.Enabled = true;
            // ... Désactivez les autres boutons d'opération de la même manière
        }

        private void EnableAllButtons()
        {
            btn_addi.Enabled = false;
            btn_soustra.Enabled = false;
            btn_divis.Enabled = false;
            btn_multi.Enabled = false;
            // ... Activez les autres boutons d'opération de la même manière
        }

        private void ClearAllFields()
        {
            text_1.Text = string.Empty;
            text_2.Text = string.Empty;
            texte3.Text = string.Empty;
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            isText1Filled = false;
            isText2Filled = false;
            label2.Visible = false;
            UpdateOperationButtons();
        }

        private void text1_TextChangedHandler()
        {
            if (int.TryParse(text_1.Text, out _))
            {
                isText1Filled = true;
            }
            else
            {
                isText1Filled = false;
            }

            UpdateOperationButtons();
            if (!int.TryParse(text_1.Text, out _))
            {
                ShowErrorMessage("Veuillez saisir un nombre valide dans le champ Text 1.");
            }
        }

        private void text2_TextChangedHandler()
        {
            if (int.TryParse(text_2.Text, out _))
            {
                isText2Filled = true;
            }
            else
            {
                isText2Filled = false;
            }

            label2.Visible = isText1Filled && isText2Filled;
            label2.Text = selectedOperation == "+" ? "+" : selectedOperation; // Change en fonction de l'opération

            UpdateOperationButtons();
            if (!int.TryParse(text_2.Text, out _))
            {
                ShowErrorMessage("Veuillez saisir un nombre valide dans le champ Text 2.");
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_addi_Click(object sender, EventArgs e)
        {
            selectedOperation = "+";
            UpdateOperationButtons();
            PerformCalculation(selectedOperation);
        }

        private void btn_soustra_Click(object sender, EventArgs e)
        {
            selectedOperation = "-";
            UpdateOperationButtons();
            PerformCalculation(selectedOperation);
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            selectedOperation = "X";
            UpdateOperationButtons();
            PerformCalculation(selectedOperation);
        }

        private void btn_divis_Click(object sender, EventArgs e)
        {
            selectedOperation = "/";
            UpdateOperationButtons();
            PerformCalculation(selectedOperation);
        }

        private void PerformCalculation(string operation)
        {
            int res = 0;
            try
            {
                switch (operation)
                {
                    case "+":
                        res = Convert.ToInt32(text_1.Text) + Convert.ToInt32(text_2.Text);
                        break;
                    case "-":
                        res = Convert.ToInt32(text_1.Text) - Convert.ToInt32(text_2.Text);
                        break;
                    case "X":
                        res = Convert.ToInt32(text_1.Text) * Convert.ToInt32(text_2.Text);
                        break;
                    case "/":
                        res = Convert.ToInt32(text_1.Text) / Convert.ToInt32(text_2.Text);
                        break;
                    default:
                        break;
                }
                texte3.Text = res.ToString();
                label1.Text = res.ToString();
                label2.Text = operation;
            }
            catch (Exception)
            {
                label1.Text = "Erreur";
            }
        }

        private void btn_quite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_gomme_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void text_1_TextChanged(object sender, EventArgs e)
        {
            text1_TextChangedHandler();
        }

        private void text_2_TextChanged(object sender, EventArgs e)
        {
            text2_TextChangedHandler();
        }

        private void texte3_TextChanged(object sender, EventArgs e)
        {
            UpdateOperationButtons();
            if (!int.TryParse(texte3.Text, out _))
            {
                ShowErrorMessage("Veuillez saisir un nombre valide dans le champ Text 3.");
            }
        }

    }
}
