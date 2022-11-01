namespace WindowsFormsApp1
{
    partial class PantStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnEsconder = new System.Windows.Forms.PictureBox();
            this.dGVArticulos = new System.Windows.Forms.DataGridView();
            this.iDArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAñadircliente = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEsconder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnEsconder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Location = new System.Drawing.Point(851, 4);
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
            this.btnCerrar.Location = new System.Drawing.Point(892, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Location = new System.Drawing.Point(851, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 23;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click_1);
            // 
            // btnEsconder
            // 
            this.btnEsconder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsconder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEsconder.BackgroundImage")));
            this.btnEsconder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEsconder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsconder.Location = new System.Drawing.Point(811, 4);
            this.btnEsconder.Name = "btnEsconder";
            this.btnEsconder.Size = new System.Drawing.Size(25, 25);
            this.btnEsconder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEsconder.TabIndex = 24;
            this.btnEsconder.TabStop = false;
            this.btnEsconder.Click += new System.EventHandler(this.btnEsconder_Click);
            // 
            // dGVArticulos
            // 
            this.dGVArticulos.AllowUserToAddRows = false;
            this.dGVArticulos.AllowUserToDeleteRows = false;
            this.dGVArticulos.AllowUserToResizeColumns = false;
            this.dGVArticulos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dGVArticulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVArticulos.AutoGenerateColumns = false;
            this.dGVArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVArticulos.BackgroundColor = System.Drawing.Color.Silver;
            this.dGVArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGVArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVArticulos.ColumnHeadersHeight = 45;
            this.dGVArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDArticuloDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.descripcionArticuloDataGridViewTextBoxColumn});
            this.dGVArticulos.DataSource = this.stockBindingSource;
            this.dGVArticulos.EnableHeadersVisualStyles = false;
            this.dGVArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dGVArticulos.Location = new System.Drawing.Point(22, 58);
            this.dGVArticulos.MaximumSize = new System.Drawing.Size(875, 338);
            this.dGVArticulos.MinimumSize = new System.Drawing.Size(875, 338);
            this.dGVArticulos.Name = "dGVArticulos";
            this.dGVArticulos.ReadOnly = true;
            this.dGVArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVArticulos.RowHeadersVisible = false;
            this.dGVArticulos.RowHeadersWidth = 40;
            this.dGVArticulos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dGVArticulos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGVArticulos.RowTemplate.Height = 40;
            this.dGVArticulos.RowTemplate.ReadOnly = true;
            this.dGVArticulos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVArticulos.Size = new System.Drawing.Size(875, 338);
            this.dGVArticulos.StandardTab = true;
            this.dGVArticulos.TabIndex = 1;
            this.dGVArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVArticulos_CellContentClick);
            // 
            // iDArticuloDataGridViewTextBoxColumn
            // 
            this.iDArticuloDataGridViewTextBoxColumn.DataPropertyName = "ID_Articulo";
            this.iDArticuloDataGridViewTextBoxColumn.HeaderText = "ID_Articulo";
            this.iDArticuloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDArticuloDataGridViewTextBoxColumn.Name = "iDArticuloDataGridViewTextBoxColumn";
            this.iDArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionArticuloDataGridViewTextBoxColumn
            // 
            this.descripcionArticuloDataGridViewTextBoxColumn.DataPropertyName = "descripcionArticulo";
            this.descripcionArticuloDataGridViewTextBoxColumn.HeaderText = "descripcionArticulo";
            this.descripcionArticuloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionArticuloDataGridViewTextBoxColumn.Name = "descripcionArticuloDataGridViewTextBoxColumn";
            this.descripcionArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(Logica.Stock);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnAñadircliente);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 80);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(101, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 34);
            this.panel3.TabIndex = 13;
            // 
            // btnAñadircliente
            // 
            this.btnAñadircliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadircliente.FlatAppearance.BorderSize = 0;
            this.btnAñadircliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAñadircliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadircliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadircliente.ForeColor = System.Drawing.Color.White;
            this.btnAñadircliente.Location = new System.Drawing.Point(101, 23);
            this.btnAñadircliente.Name = "btnAñadircliente";
            this.btnAñadircliente.Size = new System.Drawing.Size(141, 34);
            this.btnAñadircliente.TabIndex = 12;
            this.btnAñadircliente.Text = "Añadir articulo";
            this.btnAñadircliente.UseVisualStyleBackColor = true;
            this.btnAñadircliente.Click += new System.EventHandler(this.btnAñadircliente_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(558, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 34);
            this.panel5.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(558, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Eliminar articulo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(334, 23);
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
            this.button2.Location = new System.Drawing.Point(334, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modificar articulo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PantStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(920, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dGVArticulos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantStock";
            this.Load += new System.EventHandler(this.PantStock_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEsconder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVArticulos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAñadircliente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnEsconder;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionArticuloDataGridViewTextBoxColumn;
    }
}