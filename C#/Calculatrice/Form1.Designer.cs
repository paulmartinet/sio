namespace Calculatrice
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_1 = new System.Windows.Forms.TextBox();
            this.text_2 = new System.Windows.Forms.TextBox();
            this.texte3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_gomme = new System.Windows.Forms.Button();
            this.btn_addi = new System.Windows.Forms.Button();
            this.btn_soustra = new System.Windows.Forms.Button();
            this.btn_quite = new System.Windows.Forms.Button();
            this.btn_divis = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_1
            // 
            this.text_1.Location = new System.Drawing.Point(302, 107);
            this.text_1.Name = "text_1";
            this.text_1.Size = new System.Drawing.Size(111, 20);
            this.text_1.TabIndex = 6;
            this.text_1.TextChanged += new System.EventHandler(this.text_1_TextChanged);
            // 
            // text_2
            // 
            this.text_2.Location = new System.Drawing.Point(302, 206);
            this.text_2.Name = "text_2";
            this.text_2.Size = new System.Drawing.Size(111, 20);
            this.text_2.TabIndex = 7;
            this.text_2.TextChanged += new System.EventHandler(this.text_2_TextChanged);
            // 
            // texte3
            // 
            this.texte3.Location = new System.Drawing.Point(302, 304);
            this.texte3.Name = "texte3";
            this.texte3.Size = new System.Drawing.Size(111, 20);
            this.texte3.TabIndex = 8;
            this.texte3.TextChanged += new System.EventHandler(this.texte3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::Calculatrice.Properties.Resources.égal1;
            this.label1.Location = new System.Drawing.Point(278, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "   ";
            // 
            // btn_gomme
            // 
            this.btn_gomme.Image = global::Calculatrice.Properties.Resources.gomme;
            this.btn_gomme.Location = new System.Drawing.Point(496, 76);
            this.btn_gomme.Name = "btn_gomme";
            this.btn_gomme.Size = new System.Drawing.Size(104, 81);
            this.btn_gomme.TabIndex = 5;
            this.btn_gomme.UseVisualStyleBackColor = true;
            this.btn_gomme.Click += new System.EventHandler(this.btn_gomme_Click);
            // 
            // btn_addi
            // 
            this.btn_addi.Image = global::Calculatrice.Properties.Resources.addition1;
            this.btn_addi.Location = new System.Drawing.Point(499, 176);
            this.btn_addi.Name = "btn_addi";
            this.btn_addi.Size = new System.Drawing.Size(101, 80);
            this.btn_addi.TabIndex = 4;
            this.btn_addi.UseVisualStyleBackColor = true;
            this.btn_addi.Click += new System.EventHandler(this.btn_addi_Click);
            // 
            // btn_soustra
            // 
            this.btn_soustra.Image = global::Calculatrice.Properties.Resources.soustraction2;
            this.btn_soustra.Location = new System.Drawing.Point(499, 273);
            this.btn_soustra.Name = "btn_soustra";
            this.btn_soustra.Size = new System.Drawing.Size(101, 81);
            this.btn_soustra.TabIndex = 3;
            this.btn_soustra.UseVisualStyleBackColor = true;
            this.btn_soustra.Click += new System.EventHandler(this.btn_soustra_Click);
            // 
            // btn_quite
            // 
            this.btn_quite.Image = global::Calculatrice.Properties.Resources.Quitter;
            this.btn_quite.Location = new System.Drawing.Point(631, 273);
            this.btn_quite.Name = "btn_quite";
            this.btn_quite.Size = new System.Drawing.Size(101, 81);
            this.btn_quite.TabIndex = 2;
            this.btn_quite.UseVisualStyleBackColor = true;
            this.btn_quite.Click += new System.EventHandler(this.btn_quite_Click);
            // 
            // btn_divis
            // 
            this.btn_divis.Image = global::Calculatrice.Properties.Resources.division;
            this.btn_divis.Location = new System.Drawing.Point(631, 175);
            this.btn_divis.Name = "btn_divis";
            this.btn_divis.Size = new System.Drawing.Size(101, 81);
            this.btn_divis.TabIndex = 1;
            this.btn_divis.UseVisualStyleBackColor = true;
            this.btn_divis.Click += new System.EventHandler(this.btn_divis_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Image = global::Calculatrice.Properties.Resources.multi;
            this.btn_multi.Location = new System.Drawing.Point(628, 76);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(104, 81);
            this.btn_multi.TabIndex = 0;
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texte3);
            this.Controls.Add(this.text_2);
            this.Controls.Add(this.text_1);
            this.Controls.Add(this.btn_gomme);
            this.Controls.Add(this.btn_addi);
            this.Controls.Add(this.btn_soustra);
            this.Controls.Add(this.btn_quite);
            this.Controls.Add(this.btn_divis);
            this.Controls.Add(this.btn_multi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_divis;
        private System.Windows.Forms.Button btn_quite;
        private System.Windows.Forms.Button btn_addi;
        private System.Windows.Forms.Button btn_gomme;
        private System.Windows.Forms.TextBox text_1;
        private System.Windows.Forms.TextBox text_2;
        private System.Windows.Forms.TextBox texte3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_soustra;
    }
}

