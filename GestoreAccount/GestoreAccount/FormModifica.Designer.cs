namespace GestoreAccount
{
    partial class FormModifica
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
            gbModifica = new GroupBox();
            btValida = new Button();
            tbLunghezzaPsd = new NumericUpDown();
            btGeneraPsd = new Button();
            tbPassword = new TextBox();
            tbComments = new RichTextBox();
            tbEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btSaveAccount = new Button();
            btIndietro = new Button();
            gbModifica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbLunghezzaPsd).BeginInit();
            SuspendLayout();
            // 
            // gbModifica
            // 
            gbModifica.BackColor = Color.CadetBlue;
            gbModifica.Controls.Add(btValida);
            gbModifica.Controls.Add(tbLunghezzaPsd);
            gbModifica.Controls.Add(btGeneraPsd);
            gbModifica.Controls.Add(tbPassword);
            gbModifica.Controls.Add(tbComments);
            gbModifica.Controls.Add(tbEmail);
            gbModifica.Controls.Add(label3);
            gbModifica.Controls.Add(label2);
            gbModifica.Controls.Add(label1);
            gbModifica.Location = new Point(18, 20);
            gbModifica.Margin = new Padding(4, 5, 4, 5);
            gbModifica.Name = "gbModifica";
            gbModifica.Padding = new Padding(4, 5, 4, 5);
            gbModifica.Size = new Size(658, 322);
            gbModifica.TabIndex = 0;
            gbModifica.TabStop = false;
            gbModifica.Text = "Modifica Account";
            // 
            // btValida
            // 
            btValida.Location = new Point(531, 52);
            btValida.Margin = new Padding(2);
            btValida.Name = "btValida";
            btValida.Size = new Size(101, 38);
            btValida.TabIndex = 17;
            btValida.Text = "VALIDA";
            btValida.UseVisualStyleBackColor = true;
            btValida.Click += btValida_Click;
            // 
            // tbLunghezzaPsd
            // 
            tbLunghezzaPsd.Location = new Point(436, 112);
            tbLunghezzaPsd.Margin = new Padding(4, 5, 4, 5);
            tbLunghezzaPsd.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            tbLunghezzaPsd.Name = "tbLunghezzaPsd";
            tbLunghezzaPsd.Size = new Size(90, 31);
            tbLunghezzaPsd.TabIndex = 7;
            tbLunghezzaPsd.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // btGeneraPsd
            // 
            btGeneraPsd.Location = new Point(531, 112);
            btGeneraPsd.Margin = new Padding(4, 5, 4, 5);
            btGeneraPsd.Name = "btGeneraPsd";
            btGeneraPsd.Size = new Size(101, 38);
            btGeneraPsd.TabIndex = 6;
            btGeneraPsd.Text = "GENERA";
            btGeneraPsd.UseVisualStyleBackColor = true;
            btGeneraPsd.Click += btGeneraPsd_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(102, 110);
            tbPassword.Margin = new Padding(4, 5, 4, 5);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(325, 31);
            tbPassword.TabIndex = 5;
            // 
            // tbComments
            // 
            tbComments.Location = new Point(102, 162);
            tbComments.Margin = new Padding(4, 5, 4, 5);
            tbComments.Name = "tbComments";
            tbComments.Size = new Size(530, 136);
            tbComments.TabIndex = 4;
            tbComments.Text = "";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(102, 52);
            tbEmail.Margin = new Padding(4, 5, 4, 5);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(423, 31);
            tbEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 162);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Commenti";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // btSaveAccount
            // 
            btSaveAccount.Location = new Point(366, 348);
            btSaveAccount.Margin = new Padding(4, 5, 4, 5);
            btSaveAccount.Name = "btSaveAccount";
            btSaveAccount.Size = new Size(81, 38);
            btSaveAccount.TabIndex = 1;
            btSaveAccount.Text = "SALVA";
            btSaveAccount.UseVisualStyleBackColor = true;
            btSaveAccount.Click += btSaveAccount_Click;
            // 
            // btIndietro
            // 
            btIndietro.Location = new Point(241, 350);
            btIndietro.Margin = new Padding(4, 2, 4, 2);
            btIndietro.Name = "btIndietro";
            btIndietro.Size = new Size(118, 38);
            btIndietro.TabIndex = 2;
            btIndietro.Text = "INDIETRO";
            btIndietro.UseVisualStyleBackColor = true;
            btIndietro.Click += btIndietro_Click;
            // 
            // FormModifica
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(690, 402);
            Controls.Add(btIndietro);
            Controls.Add(btSaveAccount);
            Controls.Add(gbModifica);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormModifica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modifica";
            FormClosed += FormModifica_FormClosed;
            gbModifica.ResumeLayout(false);
            gbModifica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbLunghezzaPsd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbModifica;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbEmail;
        private RichTextBox tbComments;
        private TextBox tbPassword;
        private Button btSaveAccount;
        private Button btGeneraPsd;
        private NumericUpDown tbLunghezzaPsd;
        private Button btIndietro;
        private Button btValida;
    }
}