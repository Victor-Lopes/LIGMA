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
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblPresenca = new System.Windows.Forms.Label();
            this.lblEstagio = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblAulas = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pcbFotoAluno = new System.Windows.Forms.PictureBox();
            this.pnlInfoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoAluno)).BeginInit();
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
            this.pnlInfoAluno.Location = new System.Drawing.Point(0, 0);
            this.pnlInfoAluno.Name = "pnlInfoAluno";
            this.pnlInfoAluno.Size = new System.Drawing.Size(179, 507);
            this.pnlInfoAluno.TabIndex = 1;
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
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::LIGMA.Properties.Resources.Close_Icon_Dark_icon_icons_com_69143;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Location = new System.Drawing.Point(761, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 33);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pcbFotoAluno
            // 
            this.pcbFotoAluno.Location = new System.Drawing.Point(37, 61);
            this.pcbFotoAluno.Name = "pcbFotoAluno";
            this.pcbFotoAluno.Size = new System.Drawing.Size(100, 102);
            this.pcbFotoAluno.TabIndex = 0;
            this.pcbFotoAluno.TabStop = false;
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.btnFechar);
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
            this.Load += new System.EventHandler(this.Aluno_Load);
            this.pnlInfoAluno.ResumeLayout(false);
            this.pnlInfoAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoAluno)).EndInit();
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
        private System.Windows.Forms.Button btnFechar;
    }
}