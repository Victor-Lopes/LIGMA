namespace LIGMA.Forms.Cadastro
{
    partial class CadastroAula
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
            this.txtDataAula = new System.Windows.Forms.TextBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lblDataAula = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvListaPresenca = new System.Windows.Forms.DataGridView();
            this.lblListaPresenca = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.lblLIGMA = new System.Windows.Forms.Label();
            this.rchCurso = new System.Windows.Forms.RichTextBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPresenca)).BeginInit();
            this.pnlFormBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataAula
            // 
            this.txtDataAula.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtDataAula.Location = new System.Drawing.Point(20, 213);
            this.txtDataAula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataAula.Name = "txtDataAula";
            this.txtDataAula.Size = new System.Drawing.Size(171, 30);
            this.txtDataAula.TabIndex = 103;
            // 
            // txtBox
            // 
            this.txtBox.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtBox.Location = new System.Drawing.Point(20, 140);
            this.txtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(171, 30);
            this.txtBox.TabIndex = 102;
            // 
            // lblDataAula
            // 
            this.lblDataAula.AutoSize = true;
            this.lblDataAula.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblDataAula.Location = new System.Drawing.Point(15, 186);
            this.lblDataAula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataAula.Name = "lblDataAula";
            this.lblDataAula.Size = new System.Drawing.Size(112, 23);
            this.lblDataAula.TabIndex = 101;
            this.lblDataAula.Text = "Data da Aula:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblCurso.Location = new System.Drawing.Point(231, 113);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(60, 23);
            this.lblCurso.TabIndex = 100;
            this.lblCurso.Text = "Curso:";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblTurma.Location = new System.Drawing.Point(17, 113);
            this.lblTurma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(59, 23);
            this.lblTurma.TabIndex = 99;
            this.lblTurma.Text = "Turma";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitulo.Location = new System.Drawing.Point(195, 50);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 29);
            this.lblTitulo.TabIndex = 98;
            this.lblTitulo.Text = "Cadastro da Aula";
            // 
            // dgvListaPresenca
            // 
            this.dgvListaPresenca.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaPresenca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPresenca.Location = new System.Drawing.Point(20, 287);
            this.dgvListaPresenca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListaPresenca.Name = "dgvListaPresenca";
            this.dgvListaPresenca.Size = new System.Drawing.Size(565, 185);
            this.dgvListaPresenca.TabIndex = 115;
            // 
            // lblListaPresenca
            // 
            this.lblListaPresenca.AutoSize = true;
            this.lblListaPresenca.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblListaPresenca.Location = new System.Drawing.Point(15, 258);
            this.lblListaPresenca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaPresenca.Name = "lblListaPresenca";
            this.lblListaPresenca.Size = new System.Drawing.Size(147, 23);
            this.lblListaPresenca.TabIndex = 116;
            this.lblListaPresenca.Text = "Lista de Presença:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnCancelar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.Location = new System.Drawing.Point(336, 549);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 38);
            this.btnCancelar.TabIndex = 119;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Calibri", 11F);
            this.btnEnviar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEnviar.Location = new System.Drawing.Point(469, 549);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(112, 38);
            this.btnEnviar.TabIndex = 118;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
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
            this.pnlFormBorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFormBorder.Name = "pnlFormBorder";
            this.pnlFormBorder.Size = new System.Drawing.Size(604, 36);
            this.pnlFormBorder.TabIndex = 120;
            // 
            // lblLIGMA
            // 
            this.lblLIGMA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLIGMA.AutoSize = true;
            this.lblLIGMA.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblLIGMA.ForeColor = System.Drawing.Color.White;
            this.lblLIGMA.Location = new System.Drawing.Point(40, 6);
            this.lblLIGMA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLIGMA.Name = "lblLIGMA";
            this.lblLIGMA.Size = new System.Drawing.Size(65, 24);
            this.lblLIGMA.TabIndex = 11;
            this.lblLIGMA.Text = "LIGMA";
            // 
            // rchCurso
            // 
            this.rchCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchCurso.Font = new System.Drawing.Font("Calibri", 11F);
            this.rchCurso.Location = new System.Drawing.Point(236, 140);
            this.rchCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rchCurso.Name = "rchCurso";
            this.rchCurso.Size = new System.Drawing.Size(348, 105);
            this.rchCurso.TabIndex = 121;
            this.rchCurso.Text = "";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::LIGMA.Properties.Resources.MinimizarJanela;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMinimizar.Location = new System.Drawing.Point(523, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Size = new System.Drawing.Size(33, 32);
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
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFechar.Location = new System.Drawing.Point(568, 1);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 32);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
            this.pcbIcone.Location = new System.Drawing.Point(4, 5);
            this.pcbIcone.Margin = new System.Windows.Forms.Padding(4);
            this.pcbIcone.Name = "pcbIcone";
            this.pcbIcone.Size = new System.Drawing.Size(28, 27);
            this.pcbIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcone.TabIndex = 10;
            this.pcbIcone.TabStop = false;
            // 
            // CadastroAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(604, 599);
            this.Controls.Add(this.rchCurso);
            this.Controls.Add(this.pnlFormBorder);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblListaPresenca);
            this.Controls.Add(this.dgvListaPresenca);
            this.Controls.Add(this.txtDataAula);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblDataAula);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CadastroAula";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPresenca)).EndInit();
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDataAula;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lblDataAula;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvListaPresenca;
        private System.Windows.Forms.Label lblListaPresenca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblLIGMA;
        private System.Windows.Forms.PictureBox pcbIcone;
        private System.Windows.Forms.RichTextBox rchCurso;
    }
}