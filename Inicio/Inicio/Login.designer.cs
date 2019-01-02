namespace Inicio
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLoginVertical = new System.Windows.Forms.Panel();
            this.pictureLoginLogo = new System.Windows.Forms.PictureBox();
            this.textLoginContraseña = new System.Windows.Forms.TextBox();
            this.labelLoginTitulo = new System.Windows.Forms.Label();
            this.buttonLoginAcceder = new System.Windows.Forms.Button();
            this.ptbminimizar = new System.Windows.Forms.PictureBox();
            this.textLoginUsuario = new System.Windows.Forms.TextBox();
            this.ptbcerrar = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panelLoginVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoginVertical
            // 
            this.panelLoginVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelLoginVertical.Controls.Add(this.pictureLoginLogo);
            this.panelLoginVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoginVertical.Location = new System.Drawing.Point(0, 0);
            this.panelLoginVertical.Name = "panelLoginVertical";
            this.panelLoginVertical.Size = new System.Drawing.Size(193, 275);
            this.panelLoginVertical.TabIndex = 0;
            this.panelLoginVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLoginVertical_MouseDown);
            // 
            // pictureLoginLogo
            // 
            this.pictureLoginLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLoginLogo.Image")));
            this.pictureLoginLogo.Location = new System.Drawing.Point(-7, 41);
            this.pictureLoginLogo.Name = "pictureLoginLogo";
            this.pictureLoginLogo.Size = new System.Drawing.Size(200, 200);
            this.pictureLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLoginLogo.TabIndex = 9;
            this.pictureLoginLogo.TabStop = false;
            // 
            // textLoginContraseña
            // 
            this.textLoginContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textLoginContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLoginContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLoginContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.textLoginContraseña.Location = new System.Drawing.Point(230, 149);
            this.textLoginContraseña.Name = "textLoginContraseña";
            this.textLoginContraseña.Size = new System.Drawing.Size(424, 20);
            this.textLoginContraseña.TabIndex = 1;
            this.textLoginContraseña.Text = "CONTRASEÑA";
            this.textLoginContraseña.Enter += new System.EventHandler(this.textLoginContraseña_Enter);
            this.textLoginContraseña.Leave += new System.EventHandler(this.textLoginContraseña_Leave);
            // 
            // labelLoginTitulo
            // 
            this.labelLoginTitulo.AutoSize = true;
            this.labelLoginTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.labelLoginTitulo.Location = new System.Drawing.Point(421, 9);
            this.labelLoginTitulo.Name = "labelLoginTitulo";
            this.labelLoginTitulo.Size = new System.Drawing.Size(100, 33);
            this.labelLoginTitulo.TabIndex = 4;
            this.labelLoginTitulo.Text = "LOGIN";
            // 
            // buttonLoginAcceder
            // 
            this.buttonLoginAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonLoginAcceder.FlatAppearance.BorderSize = 0;
            this.buttonLoginAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonLoginAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLoginAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginAcceder.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLoginAcceder.Location = new System.Drawing.Point(301, 205);
            this.buttonLoginAcceder.Name = "buttonLoginAcceder";
            this.buttonLoginAcceder.Size = new System.Drawing.Size(350, 40);
            this.buttonLoginAcceder.TabIndex = 2;
            this.buttonLoginAcceder.Text = "ACCEDER";
            this.buttonLoginAcceder.UseVisualStyleBackColor = false;
            this.buttonLoginAcceder.Click += new System.EventHandler(this.buttonLoginAcceder_Click);
            // 
            // ptbminimizar
            // 
            this.ptbminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbminimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbminimizar.Image")));
            this.ptbminimizar.Location = new System.Drawing.Point(661, 0);
            this.ptbminimizar.Name = "ptbminimizar";
            this.ptbminimizar.Size = new System.Drawing.Size(21, 21);
            this.ptbminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbminimizar.TabIndex = 7;
            this.ptbminimizar.TabStop = false;
            this.ptbminimizar.Click += new System.EventHandler(this.ptbminimizar_Click);
            // 
            // textLoginUsuario
            // 
            this.textLoginUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textLoginUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLoginUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLoginUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.textLoginUsuario.Location = new System.Drawing.Point(230, 76);
            this.textLoginUsuario.Name = "textLoginUsuario";
            this.textLoginUsuario.Size = new System.Drawing.Size(424, 20);
            this.textLoginUsuario.TabIndex = 0;
            this.textLoginUsuario.Text = "USUARIO";
            this.textLoginUsuario.Enter += new System.EventHandler(this.textLoginUsuario_Enter);
            this.textLoginUsuario.Leave += new System.EventHandler(this.textLoginUsuario_Leave);
            // 
            // ptbcerrar
            // 
            this.ptbcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbcerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbcerrar.Image")));
            this.ptbcerrar.Location = new System.Drawing.Point(699, 0);
            this.ptbcerrar.Name = "ptbcerrar";
            this.ptbcerrar.Size = new System.Drawing.Size(21, 21);
            this.ptbcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbcerrar.TabIndex = 6;
            this.ptbcerrar.TabStop = false;
            this.ptbcerrar.Click += new System.EventHandler(this.ptbcerrar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(720, 275);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.SystemColors.InfoText;
            this.lineShape2.X1 = 232;
            this.lineShape2.X2 = 691;
            this.lineShape2.Y1 = 173;
            this.lineShape2.Y2 = 173;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.SystemColors.InfoText;
            this.lineShape1.X1 = 228;
            this.lineShape1.X2 = 689;
            this.lineShape1.Y1 = 99;
            this.lineShape1.Y2 = 99;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(720, 275);
            this.Controls.Add(this.ptbminimizar);
            this.Controls.Add(this.ptbcerrar);
            this.Controls.Add(this.buttonLoginAcceder);
            this.Controls.Add(this.labelLoginTitulo);
            this.Controls.Add(this.textLoginContraseña);
            this.Controls.Add(this.textLoginUsuario);
            this.Controls.Add(this.panelLoginVertical);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panelLoginVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLoginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginVertical;
        private System.Windows.Forms.TextBox textLoginContraseña;
        private System.Windows.Forms.Label labelLoginTitulo;
        private System.Windows.Forms.Button buttonLoginAcceder;
        private System.Windows.Forms.PictureBox ptbminimizar;
        private System.Windows.Forms.TextBox textLoginUsuario;
        private System.Windows.Forms.PictureBox ptbcerrar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.PictureBox pictureLoginLogo;
    }
}

