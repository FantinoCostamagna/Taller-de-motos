namespace WindowsFormsApp1
{
    partial class PantInformeRep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantInformeRep));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnEsconder = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAñadirinforme = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dGVInforme = new System.Windows.Forms.DataGridView();
            this.iDinformeReparacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleReparacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeReparacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informeReparacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEsconder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeReparacionesBindingSource)).BeginInit();
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
            this.panel2.Controls.Add(this.btnAñadirinforme);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.button3);
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
            this.panel3.Location = new System.Drawing.Point(107, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 34);
            this.panel3.TabIndex = 15;
            // 
            // btnAñadirinforme
            // 
            this.btnAñadirinforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirinforme.FlatAppearance.BorderSize = 0;
            this.btnAñadirinforme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAñadirinforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirinforme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirinforme.ForeColor = System.Drawing.Color.White;
            this.btnAñadirinforme.Location = new System.Drawing.Point(107, 23);
            this.btnAñadirinforme.Name = "btnAñadirinforme";
            this.btnAñadirinforme.Size = new System.Drawing.Size(141, 34);
            this.btnAñadirinforme.TabIndex = 14;
            this.btnAñadirinforme.Text = "Añadir informe";
            this.btnAñadirinforme.UseVisualStyleBackColor = true;
            this.btnAñadirinforme.Click += new System.EventHandler(this.btnAñadirinforme_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(553, 23);
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
            this.button3.Location = new System.Drawing.Point(553, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Eliminar informe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(329, 23);
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
            this.button2.Location = new System.Drawing.Point(329, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modificar informe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dGVInforme
            // 
            this.dGVInforme.AllowUserToAddRows = false;
            this.dGVInforme.AllowUserToDeleteRows = false;
            this.dGVInforme.AllowUserToResizeColumns = false;
            this.dGVInforme.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dGVInforme.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dGVInforme.AutoGenerateColumns = false;
            this.dGVInforme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVInforme.BackgroundColor = System.Drawing.Color.Silver;
            this.dGVInforme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVInforme.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGVInforme.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVInforme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dGVInforme.ColumnHeadersHeight = 45;
            this.dGVInforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDinformeReparacionDataGridViewTextBoxColumn,
            this.ID_Cliente,
            this.detalleReparacionDataGridViewTextBoxColumn,
            this.importeReparacionDataGridViewTextBoxColumn});
            this.dGVInforme.DataSource = this.informeReparacionesBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVInforme.DefaultCellStyle = dataGridViewCellStyle10;
            this.dGVInforme.EnableHeadersVisualStyles = false;
            this.dGVInforme.GridColor = System.Drawing.Color.AliceBlue;
            this.dGVInforme.Location = new System.Drawing.Point(22, 50);
            this.dGVInforme.MaximumSize = new System.Drawing.Size(750, 300);
            this.dGVInforme.MinimumSize = new System.Drawing.Size(750, 300);
            this.dGVInforme.Name = "dGVInforme";
            this.dGVInforme.ReadOnly = true;
            this.dGVInforme.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVInforme.RowHeadersVisible = false;
            this.dGVInforme.RowHeadersWidth = 40;
            this.dGVInforme.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVInforme.RowTemplate.Height = 40;
            this.dGVInforme.RowTemplate.ReadOnly = true;
            this.dGVInforme.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVInforme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVInforme.Size = new System.Drawing.Size(750, 300);
            this.dGVInforme.StandardTab = true;
            this.dGVInforme.TabIndex = 2;
            // 
            // iDinformeReparacionDataGridViewTextBoxColumn
            // 
            this.iDinformeReparacionDataGridViewTextBoxColumn.DataPropertyName = "ID_informeReparacion";
            this.iDinformeReparacionDataGridViewTextBoxColumn.HeaderText = "ID_informeReparacion";
            this.iDinformeReparacionDataGridViewTextBoxColumn.Name = "iDinformeReparacionDataGridViewTextBoxColumn";
            this.iDinformeReparacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.DataPropertyName = "ID_Cliente";
            dataGridViewCellStyle8.NullValue = null;
            this.ID_Cliente.DefaultCellStyle = dataGridViewCellStyle8;
            this.ID_Cliente.HeaderText = "ID_Cliente";
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.ReadOnly = true;
            // 
            // detalleReparacionDataGridViewTextBoxColumn
            // 
            this.detalleReparacionDataGridViewTextBoxColumn.DataPropertyName = "detalleReparacion";
            this.detalleReparacionDataGridViewTextBoxColumn.HeaderText = "detalleReparacion";
            this.detalleReparacionDataGridViewTextBoxColumn.Name = "detalleReparacionDataGridViewTextBoxColumn";
            this.detalleReparacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importeReparacionDataGridViewTextBoxColumn
            // 
            this.importeReparacionDataGridViewTextBoxColumn.DataPropertyName = "importeReparacion";
            dataGridViewCellStyle9.Format = "C0";
            dataGridViewCellStyle9.NullValue = null;
            this.importeReparacionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.importeReparacionDataGridViewTextBoxColumn.HeaderText = "importeReparacion";
            this.importeReparacionDataGridViewTextBoxColumn.Name = "importeReparacionDataGridViewTextBoxColumn";
            this.importeReparacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // informeReparacionesBindingSource
            // 
            this.informeReparacionesBindingSource.DataSource = typeof(Logica.informeReparaciones);
            // 
            // PantInformeRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVInforme);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantInformeRep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantInformeRep";
            this.Load += new System.EventHandler(this.PantInformeRep_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEsconder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVInforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informeReparacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnEsconder;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAñadirinforme;
        private System.Windows.Forms.DataGridView dGVInforme;
        private System.Windows.Forms.BindingSource informeReparacionesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDinformeReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeReparacionDataGridViewTextBoxColumn;
    }
}