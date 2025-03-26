namespace GestoreAccount
{
    partial class FormGestionale
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
            dgvGestore = new DataGridView();
            btnModifica = new DataGridViewButtonColumn();
            listBoxTipi = new ListBox();
            panelWithThreeButton = new Panel();
            disconnettiti = new Button();
            btRemoveAccount = new Button();
            btAddAccount = new Button();
            panelWithResearch = new Panel();
            tbCercaAccount = new TextBox();
            label2 = new Label();
            nEmail = new Label();
            tbCercaNEmail = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGestore).BeginInit();
            panelWithThreeButton.SuspendLayout();
            panelWithResearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGestore
            // 
            dgvGestore.BackgroundColor = Color.CadetBlue;
            dgvGestore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestore.Columns.AddRange(new DataGridViewColumn[] { btnModifica });
            dgvGestore.GridColor = Color.CadetBlue;
            dgvGestore.Location = new Point(239, 172);
            dgvGestore.Margin = new Padding(4, 5, 4, 5);
            dgvGestore.Name = "dgvGestore";
            dgvGestore.ReadOnly = true;
            dgvGestore.RowHeadersWidth = 62;
            dgvGestore.RowTemplate.Height = 25;
            dgvGestore.Size = new Size(816, 352);
            dgvGestore.TabIndex = 0;
            dgvGestore.CellContentClick += dgvGestore_CellContentClick;
            dgvGestore.DataError += dgvGestore_DataError;
            // 
            // btnModifica
            // 
            btnModifica.HeaderText = "MODIFICA";
            btnModifica.MinimumWidth = 8;
            btnModifica.Name = "btnModifica";
            btnModifica.ReadOnly = true;
            btnModifica.Width = 125;
            // 
            // listBoxTipi
            // 
            listBoxTipi.BackColor = Color.CadetBlue;
            listBoxTipi.FormattingEnabled = true;
            listBoxTipi.ItemHeight = 25;
            listBoxTipi.Location = new Point(9, 172);
            listBoxTipi.Margin = new Padding(4, 5, 4, 5);
            listBoxTipi.Name = "listBoxTipi";
            listBoxTipi.Size = new Size(222, 354);
            listBoxTipi.TabIndex = 1;
            listBoxTipi.SelectedIndexChanged += listBoxTipi_SelectedIndexChanged;
            // 
            // panelWithThreeButton
            // 
            panelWithThreeButton.BackColor = Color.CadetBlue;
            panelWithThreeButton.Controls.Add(disconnettiti);
            panelWithThreeButton.Controls.Add(btRemoveAccount);
            panelWithThreeButton.Controls.Add(btAddAccount);
            panelWithThreeButton.Location = new Point(12, 12);
            panelWithThreeButton.Margin = new Padding(4, 5, 4, 5);
            panelWithThreeButton.Name = "panelWithThreeButton";
            panelWithThreeButton.Size = new Size(218, 148);
            panelWithThreeButton.TabIndex = 2;
            // 
            // disconnettiti
            // 
            disconnettiti.Location = new Point(6, 12);
            disconnettiti.Margin = new Padding(2);
            disconnettiti.Name = "disconnettiti";
            disconnettiti.Size = new Size(208, 32);
            disconnettiti.TabIndex = 2;
            disconnettiti.Text = "DISCONETTITI";
            disconnettiti.UseVisualStyleBackColor = true;
            disconnettiti.Click += disconnettiti_Click;
            // 
            // btRemoveAccount
            // 
            btRemoveAccount.Location = new Point(6, 102);
            btRemoveAccount.Margin = new Padding(4, 5, 4, 5);
            btRemoveAccount.Name = "btRemoveAccount";
            btRemoveAccount.Size = new Size(208, 38);
            btRemoveAccount.TabIndex = 1;
            btRemoveAccount.Text = "RIMUOVI ACCOUNT";
            btRemoveAccount.UseVisualStyleBackColor = true;
            btRemoveAccount.Click += btRemoveAccount_Click;
            // 
            // btAddAccount
            // 
            btAddAccount.Location = new Point(6, 52);
            btAddAccount.Margin = new Padding(4, 5, 4, 5);
            btAddAccount.Name = "btAddAccount";
            btAddAccount.Size = new Size(208, 38);
            btAddAccount.TabIndex = 0;
            btAddAccount.Text = "AGGIUNGI ACCOUNT";
            btAddAccount.UseVisualStyleBackColor = true;
            btAddAccount.Click += btAddAccount_Click;
            // 
            // panelWithResearch
            // 
            panelWithResearch.BackColor = Color.CadetBlue;
            panelWithResearch.Controls.Add(tbCercaAccount);
            panelWithResearch.Controls.Add(label2);
            panelWithResearch.Controls.Add(nEmail);
            panelWithResearch.Controls.Add(tbCercaNEmail);
            panelWithResearch.Controls.Add(label1);
            panelWithResearch.Location = new Point(239, 12);
            panelWithResearch.Margin = new Padding(2);
            panelWithResearch.Name = "panelWithResearch";
            panelWithResearch.Size = new Size(816, 148);
            panelWithResearch.TabIndex = 3;
            // 
            // tbCercaAccount
            // 
            tbCercaAccount.Location = new Point(388, 45);
            tbCercaAccount.Margin = new Padding(2);
            tbCercaAccount.Name = "tbCercaAccount";
            tbCercaAccount.Size = new Size(150, 31);
            tbCercaAccount.TabIndex = 4;
            tbCercaAccount.TextChanged += tbCercaAccount_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 48);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(351, 25);
            label2.TabIndex = 3;
            label2.Text = "Inserisci l'email di cui desideri fare la ricerca";
            // 
            // nEmail
            // 
            nEmail.AutoSize = true;
            nEmail.Location = new Point(791, 12);
            nEmail.Margin = new Padding(2, 0, 2, 0);
            nEmail.Name = "nEmail";
            nEmail.Size = new Size(22, 25);
            nEmail.TabIndex = 2;
            nEmail.Text = "n";
            nEmail.Visible = false;
            // 
            // tbCercaNEmail
            // 
            tbCercaNEmail.Location = new Point(636, 9);
            tbCercaNEmail.Margin = new Padding(2);
            tbCercaNEmail.Name = "tbCercaNEmail";
            tbCercaNEmail.Size = new Size(132, 31);
            tbCercaNEmail.TabIndex = 1;
            tbCercaNEmail.TextChanged += tbCercaNEmail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(607, 25);
            label1.TabIndex = 0;
            label1.Text = "Inserisci l'email per conoscere il numero delle tipologie che a cui è associata";
            // 
            // FormGestionale
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1068, 538);
            Controls.Add(panelWithResearch);
            Controls.Add(panelWithThreeButton);
            Controls.Add(listBoxTipi);
            Controls.Add(dgvGestore);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FormGestionale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionale";
            FormClosed += FormGestionale_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvGestore).EndInit();
            panelWithThreeButton.ResumeLayout(false);
            panelWithResearch.ResumeLayout(false);
            panelWithResearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGestore;
        private ListBox listBoxTipi;
        private Panel panelWithThreeButton;
        private Button btAddAccount;
        private Button btRemoveAccount;
        private Button disconnettiti;
        private Panel panelWithResearch;
        private Label label1;
        private TextBox tbCercaNEmail;
        private Label nEmail;
        private Label label2;
        private TextBox tbCercaAccount;
        private DataGridViewButtonColumn btnModifica;
    }
}