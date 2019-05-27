namespace LIGMA
{
    partial class Administração
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
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblLIGMA = new System.Windows.Forms.Label();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            this.pnlInfoAluno = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pcbFotoAdmin = new System.Windows.Forms.PictureBox();
            this.btnRegistrarAula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ckdAulasSolicitas = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlFormBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            this.pnlInfoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormBorder
            // 
            this.pnlFormBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormBorder.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlFormBorder.Controls.Add(this.btnMinimizar);
            this.pnlFormBorder.Controls.Add(this.btnFechar);
            this.pnlFormBorder.Controls.Add(this.lblLIGMA);
            this.pnlFormBorder.Controls.Add(this.pcbIcone);
            this.pnlFormBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBorder.Name = "pnlFormBorder";
            this.pnlFormBorder.Size = new System.Drawing.Size(714, 29);
            this.pnlFormBorder.TabIndex = 11;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::LIGMA.Properties.Resources.MinimizarJanela;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(652, 1);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(3);
            this.btnMinimizar.Size = new System.Drawing.Size(25, 26);
            this.btnMinimizar.TabIndex = 13;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::LIGMA.Properties.Resources.FecharJanela;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(686, 1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 26);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblLIGMA
            // 
            this.lblLIGMA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLIGMA.AutoSize = true;
            this.lblLIGMA.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLIGMA.ForeColor = System.Drawing.Color.White;
            this.lblLIGMA.Location = new System.Drawing.Point(30, 5);
            this.lblLIGMA.Name = "lblLIGMA";
            this.lblLIGMA.Size = new System.Drawing.Size(48, 18);
            this.lblLIGMA.TabIndex = 11;
            this.lblLIGMA.Text = "LIGMA";
            // 
            // pcbIcone
            // 
            this.pcbIcone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbIcone.BackColor = System.Drawing.Color.Transparent;
            this.pcbIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbIcone.ErrorImage = global::LIGMA.Properties.Resources.logo;
            this.pcbIcone.Image = global::LIGMA.Properties.Resources._12133tongue_109560;
            this.pcbIcone.InitialImage = global::LIGMA.Properties.Resources.logo;
            this.pcbIcone.Location = new System.Drawing.Point(3, 4);
            this.pcbIcone.Name = "pcbIcone";
            this.pcbIcone.Size = new System.Drawing.Size(21, 22);
            this.pcbIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcone.TabIndex = 10;
            this.pcbIcone.TabStop = false;
            // 
            // pnlInfoAluno
            // 
            this.pnlInfoAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnlInfoAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoAluno.Controls.Add(this.btnLogout);
            this.pnlInfoAluno.Controls.Add(this.btnEditar);
            this.pnlInfoAluno.Controls.Add(this.button3);
            this.pnlInfoAluno.Controls.Add(this.button2);
            this.pnlInfoAluno.Controls.Add(this.button1);
            this.pnlInfoAluno.Controls.Add(this.pcbFotoAdmin);
            this.pnlInfoAluno.Location = new System.Drawing.Point(0, 29);
            this.pnlInfoAluno.Name = "pnlInfoAluno";
            this.pnlInfoAluno.Size = new System.Drawing.Size(163, 486);
            this.pnlInfoAluno.TabIndex = 12;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(-1, 433);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(163, 24);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditar.Location = new System.Drawing.Point(-1, 407);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(163, 24);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Mudar Senha";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(-1, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "Funcionários";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(-1, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Alunos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcbFotoAdmin
            // 
            this.pcbFotoAdmin.Image = global::LIGMA.Properties.Resources.Usuario;
            this.pcbFotoAdmin.Location = new System.Drawing.Point(29, 31);
            this.pcbFotoAdmin.Name = "pcbFotoAdmin";
            this.pcbFotoAdmin.Size = new System.Drawing.Size(100, 102);
            this.pcbFotoAdmin.TabIndex = 0;
            this.pcbFotoAdmin.TabStop = false;
            // 
            // btnRegistrarAula
            // 
            this.btnRegistrarAula.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarAula.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrarAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAula.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnRegistrarAula.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarAula.Location = new System.Drawing.Point(569, 359);
            this.btnRegistrarAula.Name = "btnRegistrarAula";
            this.btnRegistrarAula.Size = new System.Drawing.Size(88, 28);
            this.btnRegistrarAula.TabIndex = 18;
            this.btnRegistrarAula.Text = "Marcar Data";
            this.btnRegistrarAula.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarAula.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(359, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Aulas Extras Solicitadas";
            // 
            // ckdAulasSolicitas
            // 
            this.ckdAulasSolicitas.BackColor = System.Drawing.SystemColors.Window;
            this.ckdAulasSolicitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ckdAulasSolicitas.Font = new System.Drawing.Font("Calibri", 9F);
            this.ckdAulasSolicitas.FormattingEnabled = true;
            this.ckdAulasSolicitas.Location = new System.Drawing.Point(213, 205);
            this.ckdAulasSolicitas.Margin = new System.Windows.Forms.Padding(4);
            this.ckdAulasSolicitas.Name = "ckdAulasSolicitas";
            this.ckdAulasSolicitas.Size = new System.Drawing.Size(444, 155);
            this.ckdAulasSolicitas.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-15, -15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 9F);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(-1, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 24);
            this.button3.TabIndex = 10;
            this.button3.Text = "Turmas";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Administração
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 513);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckdAulasSolicitas);
            this.Controls.Add(this.btnRegistrarAula);
            this.Controls.Add(this.pnlFormBorder);
            this.Controls.Add(this.pnlInfoAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administração";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração";
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            this.pnlInfoAluno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblLIGMA;
        private System.Windows.Forms.PictureBox pcbIcone;
        private System.Windows.Forms.Panel pnlInfoAluno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.PictureBox pcbFotoAdmin;
        private System.Windows.Forms.Button btnRegistrarAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.CheckedListBox ckdAulasSolicitas;
        private System.Windows.Forms.Button button3;
    }
}