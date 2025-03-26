namespace GestoreAccount
{
    partial class FormLogin
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
            lbUser = new Label();
            gbLogin = new GroupBox();
            panelPulsanti = new Panel();
            btRegistrati = new Button();
            btAccedi = new Button();
            panelCredenziali = new Panel();
            btMostra = new Button();
            tbPsd = new TextBox();
            lbPsd = new Label();
            tbUser = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            salvaToolStripMenuItem = new ToolStripMenuItem();
            salvaEEsciToolStripMenuItem = new ToolStripMenuItem();
            salvaConNomeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            caricaToolStripMenuItem = new ToolStripMenuItem();
            gbLogin.SuspendLayout();
            panelPulsanti.SuspendLayout();
            panelCredenziali.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.BackColor = Color.LightSeaGreen;
            lbUser.ForeColor = SystemColors.ControlText;
            lbUser.Location = new Point(19, 18);
            lbUser.Margin = new Padding(4, 0, 4, 0);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(47, 25);
            lbUser.TabIndex = 1;
            lbUser.Text = "User";
            // 
            // gbLogin
            // 
            gbLogin.BackColor = Color.CadetBlue;
            gbLogin.Controls.Add(panelPulsanti);
            gbLogin.Controls.Add(panelCredenziali);
            gbLogin.Location = new Point(14, 40);
            gbLogin.Margin = new Padding(4, 5, 4, 5);
            gbLogin.Name = "gbLogin";
            gbLogin.Padding = new Padding(4, 5, 4, 5);
            gbLogin.Size = new Size(506, 242);
            gbLogin.TabIndex = 2;
            gbLogin.TabStop = false;
            gbLogin.Text = "Login";
            // 
            // panelPulsanti
            // 
            panelPulsanti.BackColor = Color.LightSeaGreen;
            panelPulsanti.Controls.Add(btRegistrati);
            panelPulsanti.Controls.Add(btAccedi);
            panelPulsanti.Location = new Point(129, 182);
            panelPulsanti.Margin = new Padding(4, 5, 4, 5);
            panelPulsanti.Name = "panelPulsanti";
            panelPulsanti.Size = new Size(246, 50);
            panelPulsanti.TabIndex = 7;
            // 
            // btRegistrati
            // 
            btRegistrati.Location = new Point(120, 5);
            btRegistrati.Margin = new Padding(4, 5, 4, 5);
            btRegistrati.Name = "btRegistrati";
            btRegistrati.Size = new Size(119, 38);
            btRegistrati.TabIndex = 6;
            btRegistrati.Text = "REGISTRATI";
            btRegistrati.UseVisualStyleBackColor = true;
            btRegistrati.Click += btRegistrati_Click;
            // 
            // btAccedi
            // 
            btAccedi.Location = new Point(4, 5);
            btAccedi.Margin = new Padding(4, 5, 4, 5);
            btAccedi.Name = "btAccedi";
            btAccedi.Size = new Size(109, 38);
            btAccedi.TabIndex = 5;
            btAccedi.Text = "ACCEDI";
            btAccedi.UseVisualStyleBackColor = true;
            btAccedi.Click += btAccedi_Click;
            // 
            // panelCredenziali
            // 
            panelCredenziali.BackColor = Color.LightSeaGreen;
            panelCredenziali.Controls.Add(btMostra);
            panelCredenziali.Controls.Add(tbPsd);
            panelCredenziali.Controls.Add(lbUser);
            panelCredenziali.Controls.Add(lbPsd);
            panelCredenziali.Controls.Add(tbUser);
            panelCredenziali.Location = new Point(40, 38);
            panelCredenziali.Margin = new Padding(4, 5, 4, 5);
            panelCredenziali.Name = "panelCredenziali";
            panelCredenziali.Size = new Size(421, 122);
            panelCredenziali.TabIndex = 8;
            // 
            // btMostra
            // 
            btMostra.Location = new Point(288, 68);
            btMostra.Margin = new Padding(4, 5, 4, 5);
            btMostra.Name = "btMostra";
            btMostra.Size = new Size(109, 38);
            btMostra.TabIndex = 5;
            btMostra.Text = "MOSTRA";
            btMostra.UseVisualStyleBackColor = true;
            btMostra.Click += btMostra_Click;
            // 
            // tbPsd
            // 
            tbPsd.Location = new Point(136, 68);
            tbPsd.Margin = new Padding(4, 5, 4, 5);
            tbPsd.Name = "tbPsd";
            tbPsd.PasswordChar = '*';
            tbPsd.Size = new Size(143, 31);
            tbPsd.TabIndex = 4;
            tbPsd.KeyDown += tbPsd_KeyDown;
            // 
            // lbPsd
            // 
            lbPsd.AutoSize = true;
            lbPsd.Location = new Point(19, 72);
            lbPsd.Margin = new Padding(4, 0, 4, 0);
            lbPsd.Name = "lbPsd";
            lbPsd.Size = new Size(87, 25);
            lbPsd.TabIndex = 3;
            lbPsd.Text = "Password";
            // 
            // tbUser
            // 
            tbUser.Location = new Point(136, 12);
            tbUser.Margin = new Padding(4, 5, 4, 5);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(143, 31);
            tbUser.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.Size = new Size(540, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvaToolStripMenuItem, salvaEEsciToolStripMenuItem, salvaConNomeToolStripMenuItem, toolStripSeparator1, caricaToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // salvaToolStripMenuItem
            // 
            salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            salvaToolStripMenuItem.Size = new Size(255, 34);
            salvaToolStripMenuItem.Text = "Salva";
            salvaToolStripMenuItem.Click += salvaToolStripMenuItem_Click;
            // 
            // salvaEEsciToolStripMenuItem
            // 
            salvaEEsciToolStripMenuItem.Name = "salvaEEsciToolStripMenuItem";
            salvaEEsciToolStripMenuItem.Size = new Size(255, 34);
            salvaEEsciToolStripMenuItem.Text = "Salva e Esci";
            salvaEEsciToolStripMenuItem.Click += salvaEEsciToolStripMenuItem_Click;
            // 
            // salvaConNomeToolStripMenuItem
            // 
            salvaConNomeToolStripMenuItem.Name = "salvaConNomeToolStripMenuItem";
            salvaConNomeToolStripMenuItem.Size = new Size(255, 34);
            salvaConNomeToolStripMenuItem.Text = "Salva con Nome...";
            salvaConNomeToolStripMenuItem.Click += salvaConNomeToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(252, 6);
            // 
            // caricaToolStripMenuItem
            // 
            caricaToolStripMenuItem.Name = "caricaToolStripMenuItem";
            caricaToolStripMenuItem.Size = new Size(255, 34);
            caricaToolStripMenuItem.Text = "Carica";
            caricaToolStripMenuItem.Click += caricaToolStripMenuItem_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(540, 295);
            Controls.Add(menuStrip1);
            Controls.Add(gbLogin);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load;
            gbLogin.ResumeLayout(false);
            panelPulsanti.ResumeLayout(false);
            panelCredenziali.ResumeLayout(false);
            panelCredenziali.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Label lbUser;
        private GroupBox gbLogin;
        private TextBox tbUser;
        private Label lbPsd;
        private TextBox tbPsd;
        private Button btAccedi;
        private Button btRegistrati;
        private Panel panelPulsanti;
        private Panel panelCredenziali;
        private Button btMostra;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem salvaToolStripMenuItem;
        private ToolStripMenuItem salvaEEsciToolStripMenuItem;
        private ToolStripMenuItem salvaConNomeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem caricaToolStripMenuItem;
    }
}