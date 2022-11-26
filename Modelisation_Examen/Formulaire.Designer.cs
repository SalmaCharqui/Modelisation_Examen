namespace Modelisation_d_examen
{
    partial class Formulaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.creerUnExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemajoutQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnQCMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAjoutQuesOuvert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemajoutQuestOuvert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxQuestionOuvert = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItemajoutProposition = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxPropos = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItemAjoutAlternative = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxAlternative = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxIntitul = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxMatiere = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxNbrEtudiant = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxDateDebut = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxDateFin = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerUnExamenToolStripMenuItem,
            this.toolStripTextBoxIntitul,
            this.toolStripTextBoxMatiere,
            this.toolStripTextBoxNbrEtudiant,
            this.toolStripTextBoxDateDebut,
            this.toolStripTextBoxDateFin});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(833, 27);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // creerUnExamenToolStripMenuItem
            // 
            this.creerUnExamenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemajoutQuestions});
            this.creerUnExamenToolStripMenuItem.Name = "creerUnExamenToolStripMenuItem";
            this.creerUnExamenToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.creerUnExamenToolStripMenuItem.Text = "Creer un examen";
            this.creerUnExamenToolStripMenuItem.Click += new System.EventHandler(this.creerUnExamenToolStripMenuItem_Click);
            // 
            // toolStripMenuItemajoutQuestions
            // 
            this.toolStripMenuItemajoutQuestions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnQCMToolStripMenuItem,
            this.toolStripMenuItemAjoutQuesOuvert});
            this.toolStripMenuItemajoutQuestions.Name = "toolStripMenuItemajoutQuestions";
            this.toolStripMenuItemajoutQuestions.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItemajoutQuestions.Text = "ajouter des questions";
            this.toolStripMenuItemajoutQuestions.Click += new System.EventHandler(this.toolStripMenuItemajoutQuestions_Click);
            // 
            // ajouterUnQCMToolStripMenuItem
            // 
            this.ajouterUnQCMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemajoutProposition,
            this.toolStripMenuItemAjoutAlternative});
            this.ajouterUnQCMToolStripMenuItem.Name = "ajouterUnQCMToolStripMenuItem";
            this.ajouterUnQCMToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.ajouterUnQCMToolStripMenuItem.Text = "Ajouter un QCM";
            this.ajouterUnQCMToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnQCMToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItemAjoutQuesOuvert
            // 
            this.toolStripMenuItemAjoutQuesOuvert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemajoutQuestOuvert});
            this.toolStripMenuItemAjoutQuesOuvert.Name = "toolStripMenuItemAjoutQuesOuvert";
            this.toolStripMenuItemAjoutQuesOuvert.Size = new System.Drawing.Size(236, 22);
            this.toolStripMenuItemAjoutQuesOuvert.Text = "Ajouter des questions ouvertes";
            this.toolStripMenuItemAjoutQuesOuvert.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItemajoutQuestOuvert
            // 
            this.toolStripMenuItemajoutQuestOuvert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxQuestionOuvert});
            this.toolStripMenuItemajoutQuestOuvert.Name = "toolStripMenuItemajoutQuestOuvert";
            this.toolStripMenuItemajoutQuestOuvert.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemajoutQuestOuvert.Text = "ajouter un question";
            this.toolStripMenuItemajoutQuestOuvert.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripTextBoxQuestionOuvert
            // 
            this.toolStripTextBoxQuestionOuvert.AutoSize = false;
            this.toolStripTextBoxQuestionOuvert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxQuestionOuvert.Name = "toolStripTextBoxQuestionOuvert";
            this.toolStripTextBoxQuestionOuvert.Size = new System.Drawing.Size(140, 23);
            this.toolStripTextBoxQuestionOuvert.Text = "veuillez saisir la question";
            this.toolStripTextBoxQuestionOuvert.Click += new System.EventHandler(this.toolStripTextBoxQuestionOuvert_Click);
            // 
            // toolStripMenuItemajoutProposition
            // 
            this.toolStripMenuItemajoutProposition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxPropos});
            this.toolStripMenuItemajoutProposition.Name = "toolStripMenuItemajoutProposition";
            this.toolStripMenuItemajoutProposition.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItemajoutProposition.Text = "ajouter un proposition";
            this.toolStripMenuItemajoutProposition.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripTextBoxPropos
            // 
            this.toolStripTextBoxPropos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxPropos.Name = "toolStripTextBoxPropos";
            this.toolStripTextBoxPropos.Size = new System.Drawing.Size(160, 23);
            this.toolStripTextBoxPropos.Text = "Veuillez saisir la proposition";
            this.toolStripTextBoxPropos.Click += new System.EventHandler(this.toolStripTextBoxPropos_Click);
            // 
            // toolStripMenuItemAjoutAlternative
            // 
            this.toolStripMenuItemAjoutAlternative.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxAlternative});
            this.toolStripMenuItemAjoutAlternative.Name = "toolStripMenuItemAjoutAlternative";
            this.toolStripMenuItemAjoutAlternative.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItemAjoutAlternative.Text = "ajouter une alternative";
            // 
            // toolStripTextBoxAlternative
            // 
            this.toolStripTextBoxAlternative.AutoSize = false;
            this.toolStripTextBoxAlternative.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxAlternative.Name = "toolStripTextBoxAlternative";
            this.toolStripTextBoxAlternative.Size = new System.Drawing.Size(150, 23);
            this.toolStripTextBoxAlternative.Text = "Veuillez saisir l\'alternative";
            // 
            // toolStripTextBoxIntitul
            // 
            this.toolStripTextBoxIntitul.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxIntitul.Name = "toolStripTextBoxIntitul";
            this.toolStripTextBoxIntitul.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxIntitul.Text = "intitule";
            this.toolStripTextBoxIntitul.Click += new System.EventHandler(this.toolStripTextBoxIntitul_Click);
            // 
            // toolStripTextBoxMatiere
            // 
            this.toolStripTextBoxMatiere.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxMatiere.Name = "toolStripTextBoxMatiere";
            this.toolStripTextBoxMatiere.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxMatiere.Text = "matiere";
            // 
            // toolStripTextBoxNbrEtudiant
            // 
            this.toolStripTextBoxNbrEtudiant.AutoSize = false;
            this.toolStripTextBoxNbrEtudiant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxNbrEtudiant.Name = "toolStripTextBoxNbrEtudiant";
            this.toolStripTextBoxNbrEtudiant.Size = new System.Drawing.Size(140, 23);
            this.toolStripTextBoxNbrEtudiant.Text = "nombres d\'etudiants";
            // 
            // toolStripTextBoxDateDebut
            // 
            this.toolStripTextBoxDateDebut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxDateDebut.Name = "toolStripTextBoxDateDebut";
            this.toolStripTextBoxDateDebut.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxDateDebut.Text = "date debut";
            // 
            // toolStripTextBoxDateFin
            // 
            this.toolStripTextBoxDateFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxDateFin.Name = "toolStripTextBoxDateFin";
            this.toolStripTextBoxDateFin.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxDateFin.Text = "date fin";
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 366);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formulaire";
            this.Text = "Formulaire";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem creerUnExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemajoutQuestions;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnQCMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAjoutQuesOuvert;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemajoutQuestOuvert;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemajoutProposition;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxQuestionOuvert;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPropos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAjoutAlternative;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxAlternative;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxIntitul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxMatiere;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxNbrEtudiant;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxDateDebut;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxDateFin;
    }
}