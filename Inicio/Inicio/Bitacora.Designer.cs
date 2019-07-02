namespace Inicio
{
    partial class Bitacora
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBitacoraBitacora = new System.Windows.Forms.Label();
            this.panelBitacoraHorizontal = new System.Windows.Forms.Panel();
            this.panelBitacoraVertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.filtro_fecha = new System.Windows.Forms.DateTimePicker();
            this.labelFBitacora = new System.Windows.Forms.Label();
            this.labelHBitacora = new System.Windows.Forms.Label();
            this.textBitacoraBuscar = new System.Windows.Forms.TextBox();
            this.labelBitacoraBuscar = new System.Windows.Forms.Label();
            this.panelBitacoraVertical2 = new System.Windows.Forms.Panel();
            this.dataGridBHorario = new System.Windows.Forms.DataGridView();
            this.buttonBitacoraGuardar = new System.Windows.Forms.Button();
            this.buttonBitacoraEditar = new System.Windows.Forms.Button();
            this.timerBitacora = new System.Windows.Forms.Timer(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBitacoraVertical.SuspendLayout();
            this.panelBitacoraVertical2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(1396, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 713);
            this.panel1.TabIndex = 0;
            // 
            // labelBitacoraBitacora
            // 
            this.labelBitacoraBitacora.AutoSize = true;
            this.labelBitacoraBitacora.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitacoraBitacora.Location = new System.Drawing.Point(1135, 28);
            this.labelBitacoraBitacora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBitacoraBitacora.Name = "labelBitacoraBitacora";
            this.labelBitacoraBitacora.Size = new System.Drawing.Size(247, 64);
            this.labelBitacoraBitacora.TabIndex = 2;
            this.labelBitacoraBitacora.Text = "Bitacora";
            // 
            // panelBitacoraHorizontal
            // 
            this.panelBitacoraHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelBitacoraHorizontal.Location = new System.Drawing.Point(0, 44);
            this.panelBitacoraHorizontal.Margin = new System.Windows.Forms.Padding(4);
            this.panelBitacoraHorizontal.Name = "panelBitacoraHorizontal";
            this.panelBitacoraHorizontal.Size = new System.Drawing.Size(1431, 31);
            this.panelBitacoraHorizontal.TabIndex = 3;
            // 
            // panelBitacoraVertical
            // 
            this.panelBitacoraVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelBitacoraVertical.Controls.Add(this.label1);
            this.panelBitacoraVertical.Controls.Add(this.filtro_fecha);
            this.panelBitacoraVertical.Controls.Add(this.labelFBitacora);
            this.panelBitacoraVertical.Controls.Add(this.labelHBitacora);
            this.panelBitacoraVertical.Controls.Add(this.textBitacoraBuscar);
            this.panelBitacoraVertical.Controls.Add(this.labelBitacoraBuscar);
            this.panelBitacoraVertical.Location = new System.Drawing.Point(8, 82);
            this.panelBitacoraVertical.Margin = new System.Windows.Forms.Padding(4);
            this.panelBitacoraVertical.Name = "panelBitacoraVertical";
            this.panelBitacoraVertical.Size = new System.Drawing.Size(1380, 144);
            this.panelBitacoraVertical.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(793, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Día:";
            // 
            // filtro_fecha
            // 
            this.filtro_fecha.Location = new System.Drawing.Point(892, 30);
            this.filtro_fecha.Name = "filtro_fecha";
            this.filtro_fecha.Size = new System.Drawing.Size(264, 22);
            this.filtro_fecha.TabIndex = 35;
            this.filtro_fecha.ValueChanged += new System.EventHandler(this.filtro_fecha_ValueChanged);
            // 
            // labelFBitacora
            // 
            this.labelFBitacora.AutoSize = true;
            this.labelFBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFBitacora.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelFBitacora.Location = new System.Drawing.Point(227, 78);
            this.labelFBitacora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFBitacora.Name = "labelFBitacora";
            this.labelFBitacora.Size = new System.Drawing.Size(126, 46);
            this.labelFBitacora.TabIndex = 34;
            this.labelFBitacora.Text = "label1";
            // 
            // labelHBitacora
            // 
            this.labelHBitacora.AutoSize = true;
            this.labelHBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHBitacora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelHBitacora.Location = new System.Drawing.Point(320, 30);
            this.labelHBitacora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHBitacora.Name = "labelHBitacora";
            this.labelHBitacora.Size = new System.Drawing.Size(139, 52);
            this.labelHBitacora.TabIndex = 33;
            this.labelHBitacora.Text = "label1";
            // 
            // textBitacoraBuscar
            // 
            this.textBitacoraBuscar.Location = new System.Drawing.Point(892, 81);
            this.textBitacoraBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBitacoraBuscar.Name = "textBitacoraBuscar";
            this.textBitacoraBuscar.Size = new System.Drawing.Size(264, 22);
            this.textBitacoraBuscar.TabIndex = 31;
            this.textBitacoraBuscar.TextChanged += new System.EventHandler(this.textBitacoraBuscar_TextChanged);
            // 
            // labelBitacoraBuscar
            // 
            this.labelBitacoraBuscar.AutoSize = true;
            this.labelBitacoraBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.labelBitacoraBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitacoraBuscar.ForeColor = System.Drawing.Color.White;
            this.labelBitacoraBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelBitacoraBuscar.Location = new System.Drawing.Point(793, 79);
            this.labelBitacoraBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBitacoraBuscar.Name = "labelBitacoraBuscar";
            this.labelBitacoraBuscar.Size = new System.Drawing.Size(87, 23);
            this.labelBitacoraBuscar.TabIndex = 25;
            this.labelBitacoraBuscar.Text = "Buscar :";
            // 
            // panelBitacoraVertical2
            // 
            this.panelBitacoraVertical2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelBitacoraVertical2.Controls.Add(this.dataGridBHorario);
            this.panelBitacoraVertical2.Controls.Add(this.buttonBitacoraGuardar);
            this.panelBitacoraVertical2.Controls.Add(this.buttonBitacoraEditar);
            this.panelBitacoraVertical2.Location = new System.Drawing.Point(8, 222);
            this.panelBitacoraVertical2.Margin = new System.Windows.Forms.Padding(4);
            this.panelBitacoraVertical2.Name = "panelBitacoraVertical2";
            this.panelBitacoraVertical2.Size = new System.Drawing.Size(1380, 628);
            this.panelBitacoraVertical2.TabIndex = 6;
            // 
            // dataGridBHorario
            // 
            this.dataGridBHorario.AllowUserToAddRows = false;
            this.dataGridBHorario.AllowUserToDeleteRows = false;
            this.dataGridBHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            this.dataGridBHorario.Location = new System.Drawing.Point(15, 12);
            this.dataGridBHorario.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridBHorario.Name = "dataGridBHorario";
            this.dataGridBHorario.Size = new System.Drawing.Size(1351, 449);
            this.dataGridBHorario.TabIndex = 24;
            // 
            // buttonBitacoraGuardar
            // 
            this.buttonBitacoraGuardar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonBitacoraGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBitacoraGuardar.FlatAppearance.BorderSize = 0;
            this.buttonBitacoraGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.buttonBitacoraGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.buttonBitacoraGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBitacoraGuardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBitacoraGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonBitacoraGuardar.Location = new System.Drawing.Point(639, 469);
            this.buttonBitacoraGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBitacoraGuardar.Name = "buttonBitacoraGuardar";
            this.buttonBitacoraGuardar.Size = new System.Drawing.Size(149, 43);
            this.buttonBitacoraGuardar.TabIndex = 23;
            this.buttonBitacoraGuardar.Text = "Guardar";
            this.buttonBitacoraGuardar.UseVisualStyleBackColor = false;
            this.buttonBitacoraGuardar.Click += new System.EventHandler(this.buttonBitacoraGuardar_Click);
            // 
            // buttonBitacoraEditar
            // 
            this.buttonBitacoraEditar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonBitacoraEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBitacoraEditar.FlatAppearance.BorderSize = 0;
            this.buttonBitacoraEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.buttonBitacoraEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.buttonBitacoraEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBitacoraEditar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBitacoraEditar.ForeColor = System.Drawing.Color.White;
            this.buttonBitacoraEditar.Location = new System.Drawing.Point(451, 469);
            this.buttonBitacoraEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBitacoraEditar.Name = "buttonBitacoraEditar";
            this.buttonBitacoraEditar.Size = new System.Drawing.Size(128, 43);
            this.buttonBitacoraEditar.TabIndex = 22;
            this.buttonBitacoraEditar.Text = "Editar";
            this.buttonBitacoraEditar.UseVisualStyleBackColor = false;
            this.buttonBitacoraEditar.Visible = false;
            this.buttonBitacoraEditar.Click += new System.EventHandler(this.buttonBitacoraEditar_Click);
            // 
            // timerBitacora
            // 
            this.timerBitacora.Enabled = true;
            this.timerBitacora.Tick += new System.EventHandler(this.timerBitacora_Tick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 756);
            this.Controls.Add(this.panelBitacoraVertical2);
            this.Controls.Add(this.panelBitacoraVertical);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelBitacoraBitacora);
            this.Controls.Add(this.panelBitacoraHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bitacora";
            this.Opacity = 0.96D;
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            this.panelBitacoraVertical.ResumeLayout(false);
            this.panelBitacoraVertical.PerformLayout();
            this.panelBitacoraVertical2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBitacoraBitacora;
        private System.Windows.Forms.Panel panelBitacoraHorizontal;
        private System.Windows.Forms.Panel panelBitacoraVertical;
        private System.Windows.Forms.TextBox textBitacoraBuscar;
        private System.Windows.Forms.Label labelBitacoraBuscar;
        private System.Windows.Forms.Panel panelBitacoraVertical2;
        private System.Windows.Forms.Label labelHBitacora;
        private System.Windows.Forms.Label labelFBitacora;
        private System.Windows.Forms.Timer timerBitacora;
        private System.Windows.Forms.Button buttonBitacoraGuardar;
        private System.Windows.Forms.DataGridView dataGridBHorario;
        private System.Windows.Forms.Button buttonBitacoraEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker filtro_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}