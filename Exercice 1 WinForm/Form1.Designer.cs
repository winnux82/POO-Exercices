namespace Exercice_1_WinForm
{
    partial class Form1
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
            this.txtbox_Nom = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbox_Prenom = new System.Windows.Forms.TextBox();
            this.txtbox_Age = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_Nom
            // 
            this.txtbox_Nom.Location = new System.Drawing.Point(37, 77);
            this.txtbox_Nom.Name = "txtbox_Nom";
            this.txtbox_Nom.PlaceholderText = "Entrer votre nom";
            this.txtbox_Nom.Size = new System.Drawing.Size(100, 23);
            this.txtbox_Nom.TabIndex = 2;
            this.txtbox_Nom.Tag = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Monsieur",
            "Madame",
            "Mademoiselle"});
            this.comboBox1.Location = new System.Drawing.Point(37, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // txtbox_Prenom
            // 
            this.txtbox_Prenom.Location = new System.Drawing.Point(37, 120);
            this.txtbox_Prenom.Name = "txtbox_Prenom";
            this.txtbox_Prenom.PlaceholderText = "Entrer votre prénom";
            this.txtbox_Prenom.Size = new System.Drawing.Size(100, 23);
            this.txtbox_Prenom.TabIndex = 6;
            this.txtbox_Prenom.Tag = "";
            // 
            // txtbox_Age
            // 
            this.txtbox_Age.Location = new System.Drawing.Point(37, 166);
            this.txtbox_Age.Name = "txtbox_Age";
            this.txtbox_Age.PlaceholderText = "Entrer votre age";
            this.txtbox_Age.Size = new System.Drawing.Size(100, 23);
            this.txtbox_Age.TabIndex = 7;
            this.txtbox_Age.Tag = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "DireBonjour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox_Age);
            this.Controls.Add(this.txtbox_Prenom);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtbox_Nom);
            this.Name = "Form1";
            this.Text = "DireBonjour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbox_Nom;
        private ComboBox comboBox1;
        private TextBox txtbox_Prenom;
        private TextBox txtbox_Age;
        private Button button1;
    }
}