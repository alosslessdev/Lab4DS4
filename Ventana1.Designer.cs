﻿using System.Windows.Forms;

namespace Lab4v2
{
    partial class Ventana1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new Lab4v2.columnaCalendario();
            this.Column4 = new Lab4v2.columnaCalendario();
            this.labelEstaticoDias = new System.Windows.Forms.Label();
            this.labelFechaVariable = new System.Windows.Forms.Label();
            this.labelInfoEstatico = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCalendario1 = new Lab4v2.columnaCalendario();
            this.columnaCalendario2 = new Lab4v2.columnaCalendario();
            this.columna1Calendario = new Lab4v2.columnaCalendario();
            this.columna2Calendario = new Lab4v2.columnaCalendario();
            this.Encabezado = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Encabezado)).BeginInit();
            this.SuspendLayout();
            // 
            // textoEncabezado
            // 
            this.textoEncabezado.AutoSize = true;
            this.textoEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.textoEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEncabezado.Location = new System.Drawing.Point(12, 9);
            this.textoEncabezado.Name = "textoEncabezado";
            this.textoEncabezado.Size = new System.Drawing.Size(201, 38);
            this.textoEncabezado.TabIndex = 0;
            this.textoEncabezado.Text = "Hotel Otaku";
            this.textoEncabezado.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.dataGridView1.Location = new System.Drawing.Point(19, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 380);
            this.dataGridView1.TabIndex = 3;
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
            "Individual",
            "Doble",
            "Suite"});
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
            // labelEstaticoDias
            // 
            this.labelEstaticoDias.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEstaticoDias.AutoSize = true;
            this.labelEstaticoDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstaticoDias.Location = new System.Drawing.Point(825, 282);
            this.labelEstaticoDias.Name = "labelEstaticoDias";
            this.labelEstaticoDias.Size = new System.Drawing.Size(57, 25);
            this.labelEstaticoDias.TabIndex = 4;
            this.labelEstaticoDias.Text = "Dias:";
            // 
            // labelFechaVariable
            // 
            this.labelFechaVariable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFechaVariable.AutoSize = true;
            this.labelFechaVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaVariable.Location = new System.Drawing.Point(892, 282);
            this.labelFechaVariable.Name = "labelFechaVariable";
            this.labelFechaVariable.Size = new System.Drawing.Size(23, 25);
            this.labelFechaVariable.TabIndex = 6;
            this.labelFechaVariable.Text = "?";
            // 
            // labelInfoEstatico
            // 
            this.labelInfoEstatico.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelInfoEstatico.AutoSize = true;
            this.labelInfoEstatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoEstatico.Location = new System.Drawing.Point(825, 239);
            this.labelInfoEstatico.Name = "labelInfoEstatico";
            this.labelInfoEstatico.Size = new System.Drawing.Size(128, 25);
            this.labelInfoEstatico.TabIndex = 8;
            this.labelInfoEstatico.Text = "En fila actual:";
            this.labelInfoEstatico.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // columnaCalendario1
            // 
            this.columnaCalendario1.HeaderText = "Fecha de entrada";
            this.columnaCalendario1.MinimumWidth = 6;
            this.columnaCalendario1.Name = "columnaCalendario1";
            this.columnaCalendario1.Width = 125;
            // 
            // columnaCalendario2
            // 
            this.columnaCalendario2.HeaderText = "Fecha de salida";
            this.columnaCalendario2.MinimumWidth = 6;
            this.columnaCalendario2.Name = "columnaCalendario2";
            this.columnaCalendario2.Width = 125;
            // 
            // columna1Calendario
            // 
            this.columna1Calendario.HeaderText = "Fecha de entrada";
            this.columna1Calendario.MinimumWidth = 6;
            this.columna1Calendario.Name = "columna1Calendario";
            this.columna1Calendario.Width = 125;
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
            this.Encabezado.Location = new System.Drawing.Point(0, -2);
            this.Encabezado.Name = "Encabezado";
            this.Encabezado.Size = new System.Drawing.Size(1039, 152);
            this.Encabezado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Encabezado.TabIndex = 1;
            this.Encabezado.TabStop = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReportes.Location = new System.Drawing.Point(830, 338);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(123, 36);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1039, 602);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.labelInfoEstatico);
            this.Controls.Add(this.labelFechaVariable);
            this.Controls.Add(this.labelEstaticoDias);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textoEncabezado);
            this.Controls.Add(this.Encabezado);
            this.Name = "Ventana1";
            this.Text = "lbHotel";
            this.Load += new System.EventHandler(this.Ventana1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Encabezado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoEncabezado;
        private System.Windows.Forms.PictureBox Encabezado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private columnaCalendario columna1Calendario;
        private columnaCalendario columna2Calendario;
        private System.Windows.Forms.Label labelEstaticoDias;
        private System.Windows.Forms.Label labelFechaVariable;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewComboBoxColumn Column2;
        private columnaCalendario Column3;
        private columnaCalendario Column4;
        private Label labelInfoEstatico;
        private columnaCalendario columnaCalendario1;
        private columnaCalendario columnaCalendario2;
        private Button btnReportes;
    }
}

