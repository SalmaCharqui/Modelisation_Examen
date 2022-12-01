namespace formulaire
{
    partial class FormPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblIntitule = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxintitule = new System.Windows.Forms.TextBox();
            this.textBoxdatedeb = new System.Windows.Forms.TextBox();
            this.textBoxdatefin = new System.Windows.Forms.TextBox();
            this.textBoxnbrEtudiant = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Location = new System.Drawing.Point(206, 38);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(182, 23);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "creer un examen";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIntitule
            // 
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.Location = new System.Drawing.Point(117, 81);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(44, 15);
            this.lblIntitule.TabIndex = 1;
            this.lblIntitule.Text = "intitule";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.Location = new System.Drawing.Point(117, 133);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(100, 23);
            this.lblDateDebut.TabIndex = 2;
            this.lblDateDebut.Text = "date debut";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(117, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "date fin";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(117, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "nombre d\'etudiants";
            // 
            // textBoxintitule
            // 
            this.textBoxintitule.Location = new System.Drawing.Point(263, 81);
            this.textBoxintitule.Name = "textBoxintitule";
            this.textBoxintitule.Size = new System.Drawing.Size(100, 23);
            this.textBoxintitule.TabIndex = 5;
            // 
            // textBoxdatedeb
            // 
            this.textBoxdatedeb.Location = new System.Drawing.Point(263, 133);
            this.textBoxdatedeb.Name = "textBoxdatedeb";
            this.textBoxdatedeb.Size = new System.Drawing.Size(100, 23);
            this.textBoxdatedeb.TabIndex = 6;
            // 
            // textBoxdatefin
            // 
            this.textBoxdatefin.Location = new System.Drawing.Point(263, 175);
            this.textBoxdatefin.Name = "textBoxdatefin";
            this.textBoxdatefin.Size = new System.Drawing.Size(100, 23);
            this.textBoxdatefin.TabIndex = 7;
            // 
            // textBoxnbrEtudiant
            // 
            this.textBoxnbrEtudiant.Location = new System.Drawing.Point(263, 217);
            this.textBoxnbrEtudiant.Name = "textBoxnbrEtudiant";
            this.textBoxnbrEtudiant.Size = new System.Drawing.Size(100, 23);
            this.textBoxnbrEtudiant.TabIndex = 8;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(117, 284);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(313, 284);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 347);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.textBoxnbrEtudiant);
            this.Controls.Add(this.textBoxdatefin);
            this.Controls.Add(this.textBoxdatedeb);
            this.Controls.Add(this.textBoxintitule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.lblIntitule);
            this.Controls.Add(this.lblTitre);
            this.Name = "FormPrincipale";
            this.Text = "FormPrincipale";
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitre;
        private Label lblIntitule;
        private Label lblDateDebut;
        private Label label1;
        private Label label2;
        private TextBox textBoxintitule;
        private TextBox textBoxdatedeb;
        private TextBox textBoxdatefin;
        private TextBox textBoxnbrEtudiant;
        private Button btnAjouter;
        private Button btnAnnuler;
    }
}