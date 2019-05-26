namespace LIGMA
{
    partial class Professor
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
            this.lblNotas = new System.Windows.Forms.Label();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblLIGMA = new System.Windows.Forms.Label();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            this.lblAulas = new System.Windows.Forms.Label();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.pnlInfoAluno = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbFotoAluno = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarAula = new System.Windows.Forms.Button();
            this.btnLancarNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.pnlFormBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            this.pnlInfoAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.ForeColor = System.Drawing.Color.Black;
            this.lblNotas.Location = new System.Drawing.Point(420, 281);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(35, 13);
            this.lblNotas.TabIndex = 20;
            this.lblNotas.Text = "Notas";
            // 
            // dgvNotas
            // 
            this.dgvNotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(222, 298);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(444, 162);
            this.dgvNotas.TabIndex = 19;
            // 
            // pnlFormBorder
            // 
            this.pnlFormBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormBorder.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlFormBorder.Controls.Add(this.btnMinimizar);
            this.pnlFormBorder.Controls.Add(this.btnFechar);
            this.pnlFormBorder.Controls.Add(this.lblLIGMA);
            this.pnlFormBorder.Controls.Add(this.pcbIcone);
            this.pnlFormBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBorder.Name = "pnlFormBorder";
            this.pnlFormBorder.Size = new System.Drawing.Size(714, 29);
            this.pnlFormBorder.TabIndex = 18;
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
            this.btnMinimizar.Location = new System.Drawing.Point(655, 3);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(3);
            this.btnMinimizar.Size = new System.Drawing.Size(26, 26);
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
            this.btnFechar.Location = new System.Drawing.Point(689, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 28);
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
            // lblAulas
            // 
            this.lblAulas.AutoSize = true;
            this.lblAulas.ForeColor = System.Drawing.Color.Black;
            this.lblAulas.Location = new System.Drawing.Point(421, 43);
            this.lblAulas.Name = "lblAulas";
            this.lblAulas.Size = new System.Drawing.Size(33, 13);
            this.lblAulas.TabIndex = 17;
            this.lblAulas.Text = "Aulas";
            // 
            // dgvAulas
            // 
            this.dgvAulas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.Location = new System.Drawing.Point(222, 60);
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.Size = new System.Drawing.Size(444, 162);
            this.dgvAulas.TabIndex = 16;
            // 
            // pnlInfoAluno
            // 
            this.pnlInfoAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pnlInfoAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoAluno.Controls.Add(this.btnLogout);
            this.pnlInfoAluno.Controls.Add(this.btnEditar);
            this.pnlInfoAluno.Controls.Add(this.lblCurso);
            this.pnlInfoAluno.Controls.Add(this.lblNome);
            this.pnlInfoAluno.Controls.Add(this.pcbFotoAluno);
            this.pnlInfoAluno.ForeColor = System.Drawing.Color.RoyalBlue;
            this.pnlInfoAluno.Location = new System.Drawing.Point(0, 26);
            this.pnlInfoAluno.Name = "pnlInfoAluno";
            this.pnlInfoAluno.Size = new System.Drawing.Size(163, 488);
            this.pnlInfoAluno.TabIndex = 15;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(-1, 404);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(163, 24);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEditar.Location = new System.Drawing.Point(-1, 381);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(163, 22);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Mudar Senha";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseEnter += new System.EventHandler(this.btnEditar_MouseEnter);
            this.btnEditar.MouseLeave += new System.EventHandler(this.btnEditar_MouseLeave);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblCurso.ForeColor = System.Drawing.Color.Black;
            this.lblCurso.Location = new System.Drawing.Point(62, 182);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(62, 147);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // pcbFotoAluno
            // 
            this.pcbFotoAluno.Location = new System.Drawing.Point(32, 33);
            this.pcbFotoAluno.Name = "pcbFotoAluno";
            this.pcbFotoAluno.Size = new System.Drawing.Size(100, 102);
            this.pcbFotoAluno.TabIndex = 0;
            this.pcbFotoAluno.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(342, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "As notas ainda não foram lançadas!";
            // 
            // btnRegistrarAula
            // 
            this.btnRegistrarAula.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarAula.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrarAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAula.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarAula.Location = new System.Drawing.Point(604, 221);
            this.btnRegistrarAula.Name = "btnRegistrarAula";
            this.btnRegistrarAula.Size = new System.Drawing.Size(62, 37);
            this.btnRegistrarAula.TabIndex = 9;
            this.btnRegistrarAula.Text = "Registrar Aula";
            this.btnRegistrarAula.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarAula.UseVisualStyleBackColor = false;
            this.btnRegistrarAula.Click += new System.EventHandler(this.btnRegistrarAula_Click);
            this.btnRegistrarAula.MouseEnter += new System.EventHandler(this.btnRegistrarAula_MouseEnter);
            this.btnRegistrarAula.MouseLeave += new System.EventHandler(this.btnRegistrarAula_MouseLeave);
            // 
            // btnLancarNota
            // 
            this.btnLancarNota.BackColor = System.Drawing.Color.Transparent;
            this.btnLancarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancarNota.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLancarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancarNota.ForeColor = System.Drawing.Color.Black;
            this.btnLancarNota.Location = new System.Drawing.Point(604, 459);
            this.btnLancarNota.Name = "btnLancarNota";
            this.btnLancarNota.Size = new System.Drawing.Size(62, 42);
            this.btnLancarNota.TabIndex = 10;
            this.btnLancarNota.Text = "Lançar Notas";
            this.btnLancarNota.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLancarNota.UseVisualStyleBackColor = false;
            this.btnLancarNota.Click += new System.EventHandler(this.btnLancarNota_Click);
            this.btnLancarNota.MouseEnter += new System.EventHandler(this.btnLancarNota_MouseEnter);
            this.btnLancarNota.MouseLeave += new System.EventHandler(this.btnLancarNota_MouseLeave);
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(713, 513);
            this.Controls.Add(this.btnLancarNota);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.btnRegistrarAula);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.pnlFormBorder);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.dgvAulas);
            this.Controls.Add(this.pnlInfoAluno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(713, 513);
            this.MinimumSize = new System.Drawing.Size(713, 513);
            this.Name = "Professor";
            this.Text = "Professor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            this.pnlInfoAluno.ResumeLayout(false);
            this.pnlInfoAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblLIGMA;
        private System.Windows.Forms.PictureBox pcbIcone;
        private System.Windows.Forms.Label lblAulas;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.Panel pnlInfoAluno;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbFotoAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarAula;
        private System.Windows.Forms.Button btnLancarNota;
    }
}