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
            this.textoEncabezado = new System.Windows.Forms.Label();
            this.Encabezado = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelEstaticoTipoHabitacion = new System.Windows.Forms.Label();
            this.labelEstaticoMonto = new System.Windows.Forms.Label();
            this.labelVariableMonto = new System.Windows.Forms.Label();
            this.columna1Calendario = new Lab4v2.columnaCalendario();
            this.columnaCalendario2 = new Lab4v2.columnaCalendario();
            this.columnaCalendario1 = new Lab4v2.columnaCalendario();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna2Calendario = new Lab4v2.columnaCalendario();
            ((System.ComponentModel.ISupportInitialize)(this.Encabezado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // Encabezado
            // 
            this.Encabezado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Encabezado.Image = global::Lab4v2.Properties.Resources.Encabezado;
            this.Encabezado.Location = new System.Drawing.Point(-18, -58);
            this.Encabezado.Name = "Encabezado";
            this.Encabezado.Size = new System.Drawing.Size(1233, 207);
            this.Encabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Encabezado.TabIndex = 10;
            this.Encabezado.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(1006, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reservas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todo",
            "Suite",
            "Doble",
            "Individuales"});
            this.comboBox1.Location = new System.Drawing.Point(1006, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 329);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // labelEstaticoTipoHabitacion
            // 
            this.labelEstaticoTipoHabitacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEstaticoTipoHabitacion.AutoSize = true;
            this.labelEstaticoTipoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstaticoTipoHabitacion.Location = new System.Drawing.Point(999, 213);
            this.labelEstaticoTipoHabitacion.Name = "labelEstaticoTipoHabitacion";
            this.labelEstaticoTipoHabitacion.Size = new System.Drawing.Size(154, 20);
            this.labelEstaticoTipoHabitacion.TabIndex = 20;
            this.labelEstaticoTipoHabitacion.Text = "Tipo de Habitación:";
            // 
            // labelEstaticoMonto
            // 
            this.labelEstaticoMonto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEstaticoMonto.AutoSize = true;
            this.labelEstaticoMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstaticoMonto.Location = new System.Drawing.Point(999, 299);
            this.labelEstaticoMonto.Name = "labelEstaticoMonto";
            this.labelEstaticoMonto.Size = new System.Drawing.Size(97, 20);
            this.labelEstaticoMonto.TabIndex = 21;
            this.labelEstaticoMonto.Text = "Monto total:";
            // 
            // labelVariableMonto
            // 
            this.labelVariableMonto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelVariableMonto.AutoSize = true;
            this.labelVariableMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVariableMonto.Location = new System.Drawing.Point(1102, 299);
            this.labelVariableMonto.Name = "labelVariableMonto";
            this.labelVariableMonto.Size = new System.Drawing.Size(18, 20);
            this.labelVariableMonto.TabIndex = 22;
            this.labelVariableMonto.Text = "0";
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
            // columna2Calendario
            // 
            this.columna2Calendario.HeaderText = "Fecha de salida";
            this.columna2Calendario.MinimumWidth = 6;
            this.columna2Calendario.Name = "columna2Calendario";
            this.columna2Calendario.Width = 125;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1197, 505);
            this.Controls.Add(this.labelVariableMonto);
            this.Controls.Add(this.labelEstaticoMonto);
            this.Controls.Add(this.labelEstaticoTipoHabitacion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textoEncabezado);
            this.Controls.Add(this.Encabezado);
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.Encabezado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private columnaCalendario columna1Calendario;
        private columnaCalendario columnaCalendario2;
        private columnaCalendario columnaCalendario1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label textoEncabezado;
        private columnaCalendario columna2Calendario;
        private System.Windows.Forms.PictureBox Encabezado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelEstaticoTipoHabitacion;
        private System.Windows.Forms.Label labelEstaticoMonto;
        private System.Windows.Forms.Label labelVariableMonto;
    }
}