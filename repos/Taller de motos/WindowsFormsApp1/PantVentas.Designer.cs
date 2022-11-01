namespace WindowsFormsApp1
{
    partial class PantVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnEsconder = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dGVVentas = new System.Windows.Forms.DataGridView();
            this.iDVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idComprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEsconder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnEsconder);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Location = new System.Drawing.Point(731, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 25;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Visible = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Location = new System.Drawing.Point(772, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEsconder
            // 
            this.btnEsconder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsconder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEsconder.BackgroundImage")));
            this.btnEsconder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEsconder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsconder.Location = new System.Drawing.Point(691, 3);
            this.btnEsconder.Name = "btnEsconder";
            this.btnEsconder.Size = new System.Drawing.Size(25, 25);
            this.btnEsconder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEsconder.TabIndex = 24;
            this.btnEsconder.TabStop = false;
            this.btnEsconder.Click += new System.EventHandler(this.btnEsconder_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Location = new System.Drawing.Point(731, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 23;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnNuevaVenta);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 80);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(219, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 34);
            this.panel3.TabIndex = 15;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.White;
            this.btnNuevaVenta.Location = new System.Drawing.Point(219, 25);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(141, 34);
            this.btnNuevaVenta.TabIndex = 14;
            this.btnNuevaVenta.Text = "Nueva venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(441, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 34);
            this.panel4.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(441, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modificar venta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataSource = typeof(Logica.Ventas);
            // 
            // dGVVentas
            // 
            this.dGVVentas.AllowUserToAddRows = false;
            this.dGVVentas.AllowUserToDeleteRows = false;
            this.dGVVentas.AllowUserToResizeColumns = false;
            this.dGVVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dGVVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVVentas.AutoGenerateColumns = false;
            this.dGVVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVVentas.BackgroundColor = System.Drawing.Color.Silver;
            this.dGVVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGVVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVVentas.ColumnHeadersHeight = 45;
            this.dGVVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVentaDataGridViewTextBoxColumn,
            this.idComprador,
            this.descripcionVentaDataGridViewTextBoxColumn,
            this.fechaVentaDataGridViewTextBoxColumn,
            this.importeVentaDataGridViewTextBoxColumn});
            this.dGVVentas.DataSource = this.ventasBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVVentas.DefaultCellStyle = dataGridViewCellStyle7;
            this.dGVVentas.EnableHeadersVisualStyles = false;
            this.dGVVentas.GridColor = System.Drawing.Color.AliceBlue;
            this.dGVVentas.Location = new System.Drawing.Point(12, 51);
            this.dGVVentas.MaximumSize = new System.Drawing.Size(750, 300);
            this.dGVVentas.MinimumSize = new System.Drawing.Size(750, 300);
            this.dGVVentas.Name = "dGVVentas";
            this.dGVVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVVentas.RowHeadersVisible = false;
            this.dGVVentas.RowHeadersWidth = 40;
            this.dGVVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVVentas.RowTemplate.Height = 40;
            this.dGVVentas.RowTemplate.ReadOnly = true;
            this.dGVVentas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVVentas.Size = new System.Drawing.Size(750, 300);
            this.dGVVentas.StandardTab = true;
            this.dGVVentas.TabIndex = 2;
            // 
            // iDVentaDataGridViewTextBoxColumn
            // 
            this.iDVentaDataGridViewTextBoxColumn.DataPropertyName = "ID_Venta";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.iDVentaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iDVentaDataGridViewTextBoxColumn.HeaderText = "ID_Venta";
            this.iDVentaDataGridViewTextBoxColumn.Name = "iDVentaDataGridViewTextBoxColumn";
            // 
            // idComprador
            // 
            this.idComprador.DataPropertyName = "idComprador";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.idComprador.DefaultCellStyle = dataGridViewCellStyle4;
            this.idComprador.HeaderText = "idComprador";
            this.idComprador.Name = "idComprador";
            // 
            // descripcionVentaDataGridViewTextBoxColumn
            // 
            this.descripcionVentaDataGridViewTextBoxColumn.DataPropertyName = "descripcionVenta";
            this.descripcionVentaDataGridViewTextBoxColumn.HeaderText = "descripcionVenta";
            this.descripcionVentaDataGridViewTextBoxColumn.Name = "descripcionVentaDataGridViewTextBoxColumn";
            // 
            // fechaVentaDataGridViewTextBoxColumn
            // 
            this.fechaVentaDataGridViewTextBoxColumn.DataPropertyName = "fechaVenta";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.fechaVentaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.fechaVentaDataGridViewTextBoxColumn.HeaderText = "fechaVenta";
            this.fechaVentaDataGridViewTextBoxColumn.Name = "fechaVentaDataGridViewTextBoxColumn";
            // 
            // importeVentaDataGridViewTextBoxColumn
            // 
            this.importeVentaDataGridViewTextBoxColumn.DataPropertyName = "importeVenta";
            dataGridViewCellStyle6.Format = "C0";
            dataGridViewCellStyle6.NullValue = null;
            this.importeVentaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.importeVentaDataGridViewTextBoxColumn.HeaderText = "importeVenta";
            this.importeVentaDataGridViewTextBoxColumn.Name = "importeVentaDataGridViewTextBoxColumn";
            // 
            // PantVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVVentas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantVentas";
            this.Load += new System.EventHandler(this.PantVentas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEsconder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnEsconder;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.DataGridView dGVVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeVentaDataGridViewTextBoxColumn;
    }
}