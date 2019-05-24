namespace LIGMA.Forms.TelaPrincipal
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblPresenca = new System.Windows.Forms.Label();
            this.lblEstagio = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbFotoAluno = new System.Windows.Forms.PictureBox();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblAulas = new System.Windows.Forms.Label();
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.lblMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblLIGMA = new System.Windows.Forms.Label();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            this.pnlInfoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.pnlFormBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfoAluno
            // 
            this.pnlInfoAluno.Controls.Add(this.btnEditar);
            this.pnlInfoAluno.Controls.Add(this.lblPeriodo);
            this.pnlInfoAluno.Controls.Add(this.lblPresenca);
            this.pnlInfoAluno.Controls.Add(this.lblEstagio);
            this.pnlInfoAluno.Controls.Add(this.lblCurso);
            this.pnlInfoAluno.Controls.Add(this.lblNome);
            this.pnlInfoAluno.Controls.Add(this.pcbFotoAluno);
            this.pnlInfoAluno.Location = new System.Drawing.Point(0, 61);
            this.pnlInfoAluno.Name = "pnlInfoAluno";
            this.pnlInfoAluno.Size = new System.Drawing.Size(179, 446);
            this.pnlInfoAluno.TabIndex = 1;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(136)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(50, 422);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 25);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar Perfil";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.ForeColor = System.Drawing.Color.Black;
            this.lblPeriodo.Location = new System.Drawing.Point(64, 378);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(49, 14);
            this.lblPeriodo.TabIndex = 5;
            this.lblPeriodo.Text = "Periodo";
            // 
            // lblPresenca
            // 
            this.lblPresenca.AutoSize = true;
            this.lblPresenca.ForeColor = System.Drawing.Color.Black;
            this.lblPresenca.Location = new System.Drawing.Point(34, 340);
            this.lblPresenca.Name = "lblPresenca";
            this.lblPresenca.Size = new System.Drawing.Size(126, 14);
            this.lblPresenca.TabIndex = 4;
            this.lblPresenca.Text = "Situação de Presença:";
            // 
            // lblEstagio
            // 
            this.lblEstagio.AutoSize = true;
            this.lblEstagio.ForeColor = System.Drawing.Color.Black;
            this.lblEstagio.Location = new System.Drawing.Point(64, 295);
            this.lblEstagio.Name = "lblEstagio";
            this.lblEstagio.Size = new System.Drawing.Size(47, 14);
            this.lblEstagio.TabIndex = 3;
            this.lblEstagio.Text = "Estágio";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.ForeColor = System.Drawing.Color.Black;
            this.lblCurso.Location = new System.Drawing.Point(68, 244);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 14);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(68, 209);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 14);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // pcbFotoAluno
            // 
            this.pcbFotoAluno.Location = new System.Drawing.Point(37, 61);
            this.pcbFotoAluno.Name = "pcbFotoAluno";
            this.pcbFotoAluno.Size = new System.Drawing.Size(100, 102);
            this.pcbFotoAluno.TabIndex = 0;
            this.pcbFotoAluno.TabStop = false;
            // 
            // dgvNotas
            // 
            this.dgvNotas.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(275, 61);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(444, 162);
            this.dgvNotas.TabIndex = 2;
            // 
            // dgvAulas
            // 
            this.dgvAulas.BackgroundColor = System.Drawing.Color.White;
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.Location = new System.Drawing.Point(275, 295);
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.Size = new System.Drawing.Size(444, 162);
            this.dgvAulas.TabIndex = 3;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.ForeColor = System.Drawing.Color.Black;
            this.lblNotas.Location = new System.Drawing.Point(473, 44);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(39, 14);
            this.lblNotas.TabIndex = 4;
            this.lblNotas.Text = "Notas";
            // 
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.ForeColor = System.Drawing.Color.Black;
            this.lblAulas.Location = new System.Drawing.Point(473, 278);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(38, 14);
            this.lblAulas.TabIndex = 5;
            this.lblAulas.Text = "Aulas";
            // 
            // pnlFormBorder
            // 
            this.pnlFormBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(147)))));
            this.pnlFormBorder.Controls.Add(this.lblMaximizar);
            this.pnlFormBorder.Controls.Add(this.btnMinimizar);
            this.pnlFormBorder.Controls.Add(this.btnFechar);
            this.pnlFormBorder.Controls.Add(this.lblLIGMA);
            this.pnlFormBorder.Controls.Add(this.pcbIcone);
            this.pnlFormBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBorder.Name = "pnlFormBorder";
            this.pnlFormBorder.Size = new System.Drawing.Size(800, 29);
            this.pnlFormBorder.TabIndex = 10;
            // 
            // lblMaximizar
            // 
            this.lblMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.lblMaximizar.BackgroundImage = global::LIGMA.Properties.Resources.MaximizarJanela;
            this.lblMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaximizar.Location = new System.Drawing.Point(740, 0);
            this.lblMaximizar.Margin = new System.Windows.Forms.Padding(5);
            this.lblMaximizar.Name = "lblMaximizar";
            this.lblMaximizar.Padding = new System.Windows.Forms.Padding(3);
            this.lblMaximizar.Size = new System.Drawing.Size(25, 26);
            this.lblMaximizar.TabIndex = 14;
            this.lblMaximizar.UseVisualStyleBackColor = false;
            this.lblMaximizar.Click += new System.EventHandler(this.lblMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::LIGMA.Properties.Resources.MinimizarJanela;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(708, 0);
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
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(772, 0);
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
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.pnlFormBorder);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.dgvAulas);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.pnlInfoAluno);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aluno";
            this.Text = "Aluno";
            this.pnlInfoAluno.ResumeLayout(false);
            this.pnlInfoAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlInfoAluno;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblPresenca;
        private System.Windows.Forms.Label lblEstagio;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbFotoAluno;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblAulas;
        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Label lblLIGMA;
        private System.Windows.Forms.PictureBox pcbIcone;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button lblMaximizar;
    }
}