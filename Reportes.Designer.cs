namespace Lab4v2
{
    partial class Reportes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new Lab4v2.columnaCalendario();
            this.Column4 = new Lab4v2.columnaCalendario();
            this.columna1Calendario = new Lab4v2.columnaCalendario();
            this.columnaCalendario2 = new Lab4v2.columnaCalendario();
            this.columnaCalendario1 = new Lab4v2.columnaCalendario();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textoEncabezado = new System.Windows.Forms.Label();
            this.columna2Calendario = new Lab4v2.columnaCalendario();
            this.Encabezado = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Encabezado)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 329);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo de cuarto";
            this.Column2.Items.AddRange(new object[] {
            "Individual: $50",
            "Doble: $75",
            "Suite: $120"});
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha de entrada";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha de salida";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // columna1Calendario
            // 
            this.columna1Calendario.HeaderText = "Fecha de entrada";
            this.columna1Calendario.MinimumWidth = 6;
            this.columna1Calendario.Name = "columna1Calendario";
            this.columna1Calendario.Width = 125;
            // 
            // columnaCalendario2
            // 
            this.columnaCalendario2.HeaderText = "Fecha de salida";
            this.columnaCalendario2.MinimumWidth = 6;
            this.columnaCalendario2.Name = "columnaCalendario2";
            this.columnaCalendario2.Width = 125;
            // 
            // columnaCalendario1
            // 
            this.columnaCalendario1.HeaderText = "Fecha de entrada";
            this.columnaCalendario1.MinimumWidth = 6;
            this.columnaCalendario1.Name = "columnaCalendario1";
            this.columnaCalendario1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // textoEncabezado
            // 
            this.textoEncabezado.AutoSize = true;
            this.textoEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.textoEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEncabezado.Location = new System.Drawing.Point(-6, -47);
            this.textoEncabezado.Name = "textoEncabezado";
            this.textoEncabezado.Size = new System.Drawing.Size(201, 38);
            this.textoEncabezado.TabIndex = 9;
            this.textoEncabezado.Text = "Hotel Otaku";
            this.textoEncabezado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // columna2Calendario
            // 
            this.columna2Calendario.HeaderText = "Fecha de salida";
            this.columna2Calendario.MinimumWidth = 6;
            this.columna2Calendario.Name = "columna2Calendario";
            this.columna2Calendario.Width = 125;
            // 
            // Encabezado
            // 
            this.Encabezado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Encabezado.Image = global::Lab4v2.Properties.Resources.Encabezado;
            this.Encabezado.Location = new System.Drawing.Point(-18, -58);
            this.Encabezado.Name = "Encabezado";
            this.Encabezado.Size = new System.Drawing.Size(863, 207);
            this.Encabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Encabezado.TabIndex = 10;
            this.Encabezado.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reservas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todo",
            "Suite",
            "Doble",
            "Individuales"});
            this.comboBox1.Location = new System.Drawing.Point(636, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 505);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textoEncabezado);
            this.Controls.Add(this.Encabezado);
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Encabezado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private columnaCalendario Column3;
        private columnaCalendario Column4;
        private columnaCalendario columna1Calendario;
        private columnaCalendario columnaCalendario2;
        private columnaCalendario columnaCalendario1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label textoEncabezado;
        private columnaCalendario columna2Calendario;
        private System.Windows.Forms.PictureBox Encabezado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}