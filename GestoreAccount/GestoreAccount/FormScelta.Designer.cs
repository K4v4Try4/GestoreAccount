namespace GestoreAccount
{
    partial class FormScelta
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            btNo = new Button();
            btSi = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CadetBlue;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btNo);
            groupBox1.Controls.Add(btSi);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Scegli";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 40);
            label1.Name = "label1";
            label1.Size = new Size(316, 20);
            label1.TabIndex = 2;
            label1.Text = "Sei proprio sicuro di vlore eliminare l'account?";
            // 
            // btNo
            // 
            btNo.Location = new Point(186, 105);
            btNo.Name = "btNo";
            btNo.Size = new Size(94, 29);
            btNo.TabIndex = 1;
            btNo.Text = "NO";
            btNo.UseVisualStyleBackColor = true;
            btNo.Click += btNo_Click;
            // 
            // btSi
            // 
            btSi.Location = new Point(40, 105);
            btSi.Name = "btSi";
            btSi.Size = new Size(94, 29);
            btSi.TabIndex = 0;
            btSi.Text = "SI";
            btSi.UseVisualStyleBackColor = true;
            btSi.Click += btSi_Click;
            // 
            // FormScelta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(343, 164);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormScelta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scelta";
            FormClosed += FormScelta_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btNo;
        private Button btSi;
    }
}