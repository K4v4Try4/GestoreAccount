namespace GestoreAccount
{
    partial class FormAddAccount
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
            btAddAccount = new Button();
            gbAggiungi = new GroupBox();
            btValida = new Button();
            tbLunghezzaPsd = new NumericUpDown();
            btGeneraPsd = new Button();
            tbPassword = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            cbTipo = new ComboBox();
            tbTipo = new TextBox();
            label4 = new Label();
            tbComments = new RichTextBox();
            tbEmail = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btIndietro = new Button();
            gbAggiungi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbLunghezzaPsd).BeginInit();
            SuspendLayout();
            // 
            // btAddAccount
            // 
            btAddAccount.Location = new Point(352, 420);
            btAddAccount.Margin = new Padding(4, 5, 4, 5);
            btAddAccount.Name = "btAddAccount";
            btAddAccount.Size = new Size(109, 38);
            btAddAccount.TabIndex = 3;
            btAddAccount.Text = "AGGIUNGI";
            btAddAccount.UseVisualStyleBackColor = true;
            btAddAccount.Click += btAddAccount_Click;
            // 
            // gbAggiungi
            // 
            gbAggiungi.BackColor = Color.CadetBlue;
            gbAggiungi.Controls.Add(btValida);
            gbAggiungi.Controls.Add(tbLunghezzaPsd);
            gbAggiungi.Controls.Add(btGeneraPsd);
            gbAggiungi.Controls.Add(tbPassword);
            gbAggiungi.Controls.Add(label2);
            gbAggiungi.Controls.Add(label6);
            gbAggiungi.Controls.Add(label5);
            gbAggiungi.Controls.Add(cbTipo);
            gbAggiungi.Controls.Add(tbTipo);
            gbAggiungi.Controls.Add(label4);
            gbAggiungi.Controls.Add(tbComments);
            gbAggiungi.Controls.Add(tbEmail);
            gbAggiungi.Controls.Add(label3);
            gbAggiungi.Controls.Add(label1);
            gbAggiungi.Location = new Point(19, 20);
            gbAggiungi.Margin = new Padding(4, 5, 4, 5);
            gbAggiungi.Name = "gbAggiungi";
            gbAggiungi.Padding = new Padding(4, 5, 4, 5);
            gbAggiungi.Size = new Size(671, 392);
            gbAggiungi.TabIndex = 2;
            gbAggiungi.TabStop = false;
            gbAggiungi.Text = "Aggiungi Account";
            // 
            // btValida
            // 
            btValida.Location = new Point(531, 120);
            btValida.Margin = new Padding(2);
            btValida.Name = "btValida";
            btValida.Size = new Size(112, 34);
            btValida.TabIndex = 16;
            btValida.Text = "VALIDA";
            btValida.UseVisualStyleBackColor = true;
            btValida.Click += btValida_Click;
            // 
            // tbLunghezzaPsd
            // 
            tbLunghezzaPsd.Location = new Point(432, 178);
            tbLunghezzaPsd.Margin = new Padding(4, 5, 4, 5);
            tbLunghezzaPsd.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            tbLunghezzaPsd.Name = "tbLunghezzaPsd";
            tbLunghezzaPsd.Size = new Size(90, 31);
            tbLunghezzaPsd.TabIndex = 15;
            tbLunghezzaPsd.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // btGeneraPsd
            // 
            btGeneraPsd.Location = new Point(531, 176);
            btGeneraPsd.Margin = new Padding(4, 5, 4, 5);
            btGeneraPsd.Name = "btGeneraPsd";
            btGeneraPsd.Size = new Size(112, 32);
            btGeneraPsd.TabIndex = 14;
            btGeneraPsd.Text = "GENERA";
            btGeneraPsd.UseVisualStyleBackColor = true;
            btGeneraPsd.Click += btGeneraPsd_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(109, 178);
            tbPassword.Margin = new Padding(4, 5, 4, 5);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(316, 31);
            tbPassword.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 178);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 38);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 11;
            label6.Text = "Presenti";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 40);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 10;
            label5.Text = "Nuovo";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(259, 68);
            cbTipo.Margin = new Padding(4, 5, 4, 5);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(143, 33);
            cbTipo.TabIndex = 9;
            // 
            // tbTipo
            // 
            tbTipo.Location = new Point(109, 70);
            tbTipo.Margin = new Padding(4, 5, 4, 5);
            tbTipo.Name = "tbTipo";
            tbTipo.Size = new Size(143, 31);
            tbTipo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 72);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 25);
            label4.TabIndex = 7;
            label4.Text = "Tipo";
            // 
            // tbComments
            // 
            tbComments.Location = new Point(109, 232);
            tbComments.Margin = new Padding(4, 5, 4, 5);
            tbComments.Name = "tbComments";
            tbComments.Size = new Size(534, 136);
            tbComments.TabIndex = 4;
            tbComments.Text = "";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(109, 120);
            tbEmail.Margin = new Padding(4, 5, 4, 5);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(415, 31);
            tbEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 238);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Commenti";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // btIndietro
            // 
            btIndietro.Location = new Point(244, 420);
            btIndietro.Margin = new Padding(4, 2, 4, 2);
            btIndietro.Name = "btIndietro";
            btIndietro.Size = new Size(101, 38);
            btIndietro.TabIndex = 4;
            btIndietro.Text = "INDIETRO";
            btIndietro.UseVisualStyleBackColor = true;
            btIndietro.Click += btIndietro_Click;
            // 
            // FormAddAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(704, 462);
            Controls.Add(btIndietro);
            Controls.Add(btAddAccount);
            Controls.Add(gbAggiungi);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormAddAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aggiungi";
            FormClosed += FormAddAccount_FormClosed;
            gbAggiungi.ResumeLayout(false);
            gbAggiungi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbLunghezzaPsd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btAddAccount;
        private GroupBox gbAggiungi;
        private RichTextBox tbComments;
        private TextBox tbEmail;
        private Label label3;
        private Label label1;
        private Label label4;
        private TextBox tbTipo;
        private ComboBox cbTipo;
        private Label label5;
        private Label label6;
        private NumericUpDown tbLunghezzaPsd;
        private Button btGeneraPsd;
        private TextBox tbPassword;
        private Label label2;
        private Button btIndietro;
        private Button btValida;
    }
}