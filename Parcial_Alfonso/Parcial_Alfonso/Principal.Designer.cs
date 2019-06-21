namespace Parcial_Alfonso
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMagos = new System.Windows.Forms.DataGridView();
            this.dgvhechizos = new System.Windows.Forms.DataGridView();
            this.Magos = new System.Windows.Forms.Label();
            this.Hechizos = new System.Windows.Forms.Label();
            this.AgregarHechizoMago = new System.Windows.Forms.Button();
            this.txtbuscarmago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhechizos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMagos
            // 
            this.dgvMagos.AllowUserToAddRows = false;
            this.dgvMagos.AllowUserToDeleteRows = false;
            this.dgvMagos.AllowUserToResizeColumns = false;
            this.dgvMagos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMagos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMagos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMagos.ColumnHeadersHeight = 20;
            this.dgvMagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMagos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMagos.EnableHeadersVisualStyles = false;
            this.dgvMagos.GridColor = System.Drawing.Color.White;
            this.dgvMagos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvMagos.Location = new System.Drawing.Point(34, 69);
            this.dgvMagos.MultiSelect = false;
            this.dgvMagos.Name = "dgvMagos";
            this.dgvMagos.ReadOnly = true;
            this.dgvMagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMagos.RowHeadersVisible = false;
            this.dgvMagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvMagos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMagos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dgvMagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMagos.Size = new System.Drawing.Size(233, 281);
            this.dgvMagos.TabIndex = 8;
            this.dgvMagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMagos_CellClick);
            // 
            // dgvhechizos
            // 
            this.dgvhechizos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvhechizos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvhechizos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhechizos.Location = new System.Drawing.Point(393, 53);
            this.dgvhechizos.Name = "dgvhechizos";
            this.dgvhechizos.Size = new System.Drawing.Size(286, 283);
            this.dgvhechizos.TabIndex = 9;
            // 
            // Magos
            // 
            this.Magos.AutoSize = true;
            this.Magos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Magos.Location = new System.Drawing.Point(89, 27);
            this.Magos.Name = "Magos";
            this.Magos.Size = new System.Drawing.Size(77, 25);
            this.Magos.TabIndex = 10;
            this.Magos.Text = "Magos";
            // 
            // Hechizos
            // 
            this.Hechizos.AutoSize = true;
            this.Hechizos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hechizos.Location = new System.Drawing.Point(502, 31);
            this.Hechizos.Name = "Hechizos";
            this.Hechizos.Size = new System.Drawing.Size(101, 25);
            this.Hechizos.TabIndex = 11;
            this.Hechizos.Text = "Hechizos";
            // 
            // AgregarHechizoMago
            // 
            this.AgregarHechizoMago.Location = new System.Drawing.Point(273, 201);
            this.AgregarHechizoMago.Name = "AgregarHechizoMago";
            this.AgregarHechizoMago.Size = new System.Drawing.Size(75, 23);
            this.AgregarHechizoMago.TabIndex = 12;
            this.AgregarHechizoMago.Text = "Agregar Hechizo";
            this.AgregarHechizoMago.UseVisualStyleBackColor = true;
            this.AgregarHechizoMago.Click += new System.EventHandler(this.AgregarHechizoMago_Click);
            // 
            // txtbuscarmago
            // 
            this.txtbuscarmago.Location = new System.Drawing.Point(205, 31);
            this.txtbuscarmago.Name = "txtbuscarmago";
            this.txtbuscarmago.Size = new System.Drawing.Size(100, 20);
            this.txtbuscarmago.TabIndex = 13;
            this.txtbuscarmago.TextChanged += new System.EventHandler(this.txtbuscarmago_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Has click Sobre el Mago Para ver sus Hechizos";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbuscarmago);
            this.Controls.Add(this.AgregarHechizoMago);
            this.Controls.Add(this.Hechizos);
            this.Controls.Add(this.Magos);
            this.Controls.Add(this.dgvhechizos);
            this.Controls.Add(this.dgvMagos);
            this.Name = "Principal";
            this.Text = "Tema 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhechizos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMagos;
        private System.Windows.Forms.DataGridView dgvhechizos;
        private System.Windows.Forms.Label Magos;
        private System.Windows.Forms.Label Hechizos;
        private System.Windows.Forms.Button AgregarHechizoMago;
        private System.Windows.Forms.TextBox txtbuscarmago;
        private System.Windows.Forms.Label label1;
    }
}

