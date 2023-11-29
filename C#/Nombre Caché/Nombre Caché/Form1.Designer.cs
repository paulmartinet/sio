namespace Nombre_Caché
{
    partial class frmNombreCache
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNombreCache));
            this.grpValeur = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpReponse = new System.Windows.Forms.GroupBox();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grpValeur.SuspendLayout();
            this.grpReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpValeur
            // 
            this.grpValeur.Controls.Add(this.btnValider);
            this.grpValeur.Controls.Add(this.txtValeur);
            this.grpValeur.Location = new System.Drawing.Point(66, 63);
            this.grpValeur.Name = "grpValeur";
            this.grpValeur.Size = new System.Drawing.Size(202, 67);
            this.grpValeur.TabIndex = 0;
            this.grpValeur.TabStop = false;
            this.grpValeur.Text = "Essai (entre 1 et 100)";
            // 
            // grpReponse
            // 
            this.grpReponse.Controls.Add(this.lblMessage);
            this.grpReponse.Location = new System.Drawing.Point(66, 151);
            this.grpReponse.Name = "grpReponse";
            this.grpReponse.Size = new System.Drawing.Size(202, 65);
            this.grpReponse.TabIndex = 1;
            this.grpReponse.TabStop = false;
            this.grpReponse.Text = "Essai";
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(6, 31);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(125, 20);
            this.txtValeur.TabIndex = 2;
            this.txtValeur.TextChanged += new System.EventHandler(this.txtValeur_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(13, 31);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(142, 31);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(42, 20);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "OK";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRejouer
            // 
            this.btnRejouer.Image = ((System.Drawing.Image)(resources.GetObject("btnRejouer.Image")));
            this.btnRejouer.Location = new System.Drawing.Point(297, 73);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(67, 56);
            this.btnRejouer.TabIndex = 2;
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitter.Image")));
            this.btnQuitter.Location = new System.Drawing.Point(295, 159);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(69, 57);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmNombreCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 281);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.grpReponse);
            this.Controls.Add(this.grpValeur);
            this.Name = "frmNombreCache";
            this.Text = "Nombre Caché";
            this.Load += new System.EventHandler(this.frmNombreCache_Load);
            this.grpValeur.ResumeLayout(false);
            this.grpValeur.PerformLayout();
            this.grpReponse.ResumeLayout(false);
            this.grpReponse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpValeur;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpReponse;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Button btnQuitter;
    }
}

