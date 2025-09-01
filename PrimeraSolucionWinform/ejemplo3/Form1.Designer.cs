namespace ejemplo3
{
    partial class Form1
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lvwElementos = new System.Windows.Forms.ListView();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.rbtwizard = new System.Windows.Forms.RadioButton();
            this.rbtmuggle = new System.Windows.Forms.RadioButton();
            this.rbtSkibs = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.labelColorFavorito = new System.Windows.Forms.Label();
            this.numNumeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.labelNumeroFavorito = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(66, 48);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(142, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(142, 93);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(131, 17);
            this.ckbChocolate.TabIndex = 2;
            this.ckbChocolate.Text = "te gusta el chocolate?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(143, 67);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(244, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // lvwElementos
            // 
            this.lvwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwElementos.HideSelection = false;
            this.lvwElementos.Location = new System.Drawing.Point(161, 221);
            this.lvwElementos.Name = "lvwElementos";
            this.lvwElementos.Size = new System.Drawing.Size(165, 97);
            this.lvwElementos.TabIndex = 7;
            this.lvwElementos.UseCompatibleStateImageBehavior = false;
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(17, 74);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.labelFechaNacimiento.TabIndex = 5;
            this.labelFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(177, 31);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "PerfilPersona";
            // 
            // rbtwizard
            // 
            this.rbtwizard.AutoSize = true;
            this.rbtwizard.Checked = true;
            this.rbtwizard.Location = new System.Drawing.Point(14, 25);
            this.rbtwizard.Name = "rbtwizard";
            this.rbtwizard.Size = new System.Drawing.Size(55, 17);
            this.rbtwizard.TabIndex = 1;
            this.rbtwizard.TabStop = true;
            this.rbtwizard.Text = "wizard";
            this.rbtwizard.UseVisualStyleBackColor = true;
            // 
            // rbtmuggle
            // 
            this.rbtmuggle.AutoSize = true;
            this.rbtmuggle.Location = new System.Drawing.Point(121, 25);
            this.rbtmuggle.Name = "rbtmuggle";
            this.rbtmuggle.Size = new System.Drawing.Size(59, 17);
            this.rbtmuggle.TabIndex = 1;
            this.rbtmuggle.Text = "muggle";
            this.rbtmuggle.UseVisualStyleBackColor = true;
            // 
            // rbtSkibs
            // 
            this.rbtSkibs.AutoSize = true;
            this.rbtSkibs.Location = new System.Drawing.Point(237, 25);
            this.rbtSkibs.Name = "rbtSkibs";
            this.rbtSkibs.Size = new System.Drawing.Size(51, 17);
            this.rbtSkibs.TabIndex = 2;
            this.rbtSkibs.Text = "Skibs";
            this.rbtSkibs.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxTipo.Controls.Add(this.rbtwizard);
            this.gbxTipo.Controls.Add(this.rbtSkibs);
            this.gbxTipo.Controls.Add(this.rbtmuggle);
            this.gbxTipo.Location = new System.Drawing.Point(77, 173);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(338, 42);
            this.gbxTipo.TabIndex = 5;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(142, 116);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(245, 21);
            this.cboColorFavorito.TabIndex = 3;
            // 
            // labelColorFavorito
            // 
            this.labelColorFavorito.AutoSize = true;
            this.labelColorFavorito.Location = new System.Drawing.Point(52, 116);
            this.labelColorFavorito.Name = "labelColorFavorito";
            this.labelColorFavorito.Size = new System.Drawing.Size(72, 13);
            this.labelColorFavorito.TabIndex = 12;
            this.labelColorFavorito.Text = "Color Favorito";
            // 
            // numNumeroFavorito
            // 
            this.numNumeroFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumeroFavorito.Location = new System.Drawing.Point(142, 147);
            this.numNumeroFavorito.Name = "numNumeroFavorito";
            this.numNumeroFavorito.Size = new System.Drawing.Size(245, 20);
            this.numNumeroFavorito.TabIndex = 4;
            // 
            // labelNumeroFavorito
            // 
            this.labelNumeroFavorito.AutoSize = true;
            this.labelNumeroFavorito.Location = new System.Drawing.Point(25, 149);
            this.labelNumeroFavorito.Name = "labelNumeroFavorito";
            this.labelNumeroFavorito.Size = new System.Drawing.Size(85, 13);
            this.labelNumeroFavorito.TabIndex = 14;
            this.labelNumeroFavorito.Text = "Numero Favorito";
            this.labelNumeroFavorito.Click += new System.EventHandler(this.labelNumeroFavorito_Click);
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVerPerfil.FlatAppearance.BorderSize = 3;
            this.btnVerPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.Location = new System.Drawing.Point(71, 221);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 50);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(69, 313);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 342);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.labelNumeroFavorito);
            this.Controls.Add(this.numNumeroFavorito);
            this.Controls.Add(this.labelColorFavorito);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelFechaNacimiento);
            this.Controls.Add(this.lvwElementos);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelNombre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(811, 534);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(695, 381);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ListView lvwElementos;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.RadioButton rbtwizard;
        private System.Windows.Forms.RadioButton rbtmuggle;
        private System.Windows.Forms.RadioButton rbtSkibs;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.Label labelColorFavorito;
        private System.Windows.Forms.NumericUpDown numNumeroFavorito;
        private System.Windows.Forms.Label labelNumeroFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
        private System.Windows.Forms.Button btnAgregar;
    }
}

