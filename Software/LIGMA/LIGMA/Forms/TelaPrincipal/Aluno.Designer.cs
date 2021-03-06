﻿namespace LIGMA.Forms.TelaPrincipal
{
    partial class Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aluno));
            this.pnlInfoAluno = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPresenca = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbFotoAluno = new System.Windows.Forms.PictureBox();
            this.btnAulaExtra = new System.Windows.Forms.Button();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.lblAulas = new System.Windows.Forms.Label();
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblLIGMA = new System.Windows.Forms.Label();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.pnlInfoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.pnlFormBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfoAluno
            // 
            this.pnlInfoAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnlInfoAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoAluno.Controls.Add(this.btnLogout);
            this.pnlInfoAluno.Controls.Add(this.lblPresenca);
            this.pnlInfoAluno.Controls.Add(this.btnEditar);
            this.pnlInfoAluno.Controls.Add(this.lblNome);
            this.pnlInfoAluno.Controls.Add(this.pcbFotoAluno);
            this.pnlInfoAluno.ForeColor = System.Drawing.Color.RoyalBlue;
            this.pnlInfoAluno.Location = new System.Drawing.Point(0, 26);
            this.pnlInfoAluno.Name = "pnlInfoAluno";
            this.pnlInfoAluno.Size = new System.Drawing.Size(179, 481);
            this.pnlInfoAluno.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(-1, 419);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(179, 28);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // lblPresenca
            // 
            this.lblPresenca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPresenca.AutoSize = true;
            this.lblPresenca.BackColor = System.Drawing.Color.Transparent;
            this.lblPresenca.ForeColor = System.Drawing.Color.Black;
            this.lblPresenca.Location = new System.Drawing.Point(-1, 225);
            this.lblPresenca.MaximumSize = new System.Drawing.Size(179, 22);
            this.lblPresenca.MinimumSize = new System.Drawing.Size(179, 22);
            this.lblPresenca.Name = "lblPresenca";
            this.lblPresenca.Size = new System.Drawing.Size(179, 22);
            this.lblPresenca.TabIndex = 4;
            this.lblPresenca.Text = "Situação de Presença";
            this.lblPresenca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPresenca.Click += new System.EventHandler(this.lblPresenca_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditar.Location = new System.Drawing.Point(-1, 393);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(179, 22);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Mudar Senha";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseEnter += new System.EventHandler(this.btnEditar_MouseEnter);
            this.btnEditar.MouseLeave += new System.EventHandler(this.btnEditar_MouseLeave);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(-1, 180);
            this.lblNome.MaximumSize = new System.Drawing.Size(179, 22);
            this.lblNome.MinimumSize = new System.Drawing.Size(179, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(179, 22);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbFotoAluno
            // 
            this.pcbFotoAluno.Image = global::LIGMA.Properties.Resources.Usuario;
            this.pcbFotoAluno.Location = new System.Drawing.Point(33, 40);
            this.pcbFotoAluno.Name = "pcbFotoAluno";
            this.pcbFotoAluno.Size = new System.Drawing.Size(100, 102);
            this.pcbFotoAluno.TabIndex = 0;
            this.pcbFotoAluno.TabStop = false;
            // 
            // btnAulaExtra
            // 
            this.btnAulaExtra.BackColor = System.Drawing.Color.Transparent;
            this.btnAulaExtra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAulaExtra.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnAulaExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAulaExtra.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAulaExtra.Location = new System.Drawing.Point(575, 228);
            this.btnAulaExtra.Name = "btnAulaExtra";
            this.btnAulaExtra.Size = new System.Drawing.Size(91, 48);
            this.btnAulaExtra.TabIndex = 9;
            this.btnAulaExtra.Text = "Solicitar Aula Extra";
            this.btnAulaExtra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAulaExtra.UseVisualStyleBackColor = false;
            this.btnAulaExtra.Click += new System.EventHandler(this.btnAulaExtra_Click);
            this.btnAulaExtra.MouseEnter += new System.EventHandler(this.btnAulaExtra_MouseEnter);
            this.btnAulaExtra.MouseLeave += new System.EventHandler(this.btnAulaExtra_MouseLeave);
            // 
            // dgvAulas
            // 
            this.dgvAulas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.GridColor = System.Drawing.Color.White;
            this.dgvAulas.Location = new System.Drawing.Point(222, 67);
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.Size = new System.Drawing.Size(444, 162);
            this.dgvAulas.TabIndex = 3;
            // 
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.ForeColor = System.Drawing.Color.Black;
            this.lblAulas.Location = new System.Drawing.Point(421, 50);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(42, 18);
            this.lblAulas.TabIndex = 5;
            this.lblAulas.Text = "Aulas";
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
            this.pnlFormBorder.TabIndex = 10;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::LIGMA.Properties.Resources.MinimizarJanela;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMinimizar.Location = new System.Drawing.Point(654, 1);
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
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFechar.Location = new System.Drawing.Point(689, 1);
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
            this.lblLIGMA.Size = new System.Drawing.Size(63, 23);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(342, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "As notas ainda não foram lançadas!";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.ForeColor = System.Drawing.Color.Black;
            this.lblNotas.Location = new System.Drawing.Point(420, 279);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(44, 18);
            this.lblNotas.TabIndex = 13;
            this.lblNotas.Text = "Notas";
            this.lblNotas.Visible = false;
            // 
            // dgvNotas
            // 
            this.dgvNotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.GridColor = System.Drawing.Color.White;
            this.dgvNotas.Location = new System.Drawing.Point(222, 298);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(444, 162);
            this.dgvNotas.TabIndex = 12;
            this.dgvNotas.Visible = false;
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 507);
            this.Controls.Add(this.dgvAulas);
            this.Controls.Add(this.btnAulaExtra);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.pnlFormBorder);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.pnlInfoAluno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(714, 507);
            this.MinimumSize = new System.Drawing.Size(714, 507);
            this.Name = "Aluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.Aluno_Load);
            this.pnlInfoAluno.ResumeLayout(false);
            this.pnlInfoAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlInfoAluno;
        private System.Windows.Forms.Label lblPresenca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbFotoAluno;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.Label lblAulas;
        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Label lblLIGMA;
        private System.Windows.Forms.PictureBox pcbIcone;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAulaExtra;
    }
}