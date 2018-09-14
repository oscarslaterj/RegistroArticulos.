namespace RegistroArticulos.UI.Consultas
{
    partial class RegistroArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroArticulo));
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Descripcion = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.ExistenciatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CantidadCotizadanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaVencimientodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadCotizadanumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(50, 33);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.IDnumericUpDown.TabIndex = 1;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(15, 74);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 2;
            this.Descripcion.Text = "Descripción";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(93, 71);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(250, 20);
            this.DescripciontextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(93, 101);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(100, 20);
            this.PreciotextBox.TabIndex = 5;
            this.PreciotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreciotextBox_KeyPress);
            // 
            // ExistenciatextBox
            // 
            this.ExistenciatextBox.Location = new System.Drawing.Point(93, 135);
            this.ExistenciatextBox.Name = "ExistenciatextBox";
            this.ExistenciatextBox.Size = new System.Drawing.Size(100, 20);
            this.ExistenciatextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad Cotizada";
            // 
            // CantidadCotizadanumericUpDown
            // 
            this.CantidadCotizadanumericUpDown.Location = new System.Drawing.Point(143, 173);
            this.CantidadCotizadanumericUpDown.Name = "CantidadCotizadanumericUpDown";
            this.CantidadCotizadanumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.CantidadCotizadanumericUpDown.TabIndex = 9;
            // 
            // FechaVencimientodateTimePicker
            // 
            this.FechaVencimientodateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaVencimientodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaVencimientodateTimePicker.Location = new System.Drawing.Point(143, 215);
            this.FechaVencimientodateTimePicker.Name = "FechaVencimientodateTimePicker";
            this.FechaVencimientodateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.FechaVencimientodateTimePicker.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de vencimiento";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.Location = new System.Drawing.Point(121, 26);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(91, 31);
            this.Buscarbutton.TabIndex = 12;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.SystemColors.Window;
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.Location = new System.Drawing.Point(12, 255);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(96, 34);
            this.Nuevobutton.TabIndex = 13;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.Location = new System.Drawing.Point(121, 255);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(101, 34);
            this.Guardarbutton.TabIndex = 14;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.Location = new System.Drawing.Point(238, 255);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(94, 34);
            this.Eliminarbutton.TabIndex = 15;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RegistroArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 292);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechaVencimientodateTimePicker);
            this.Controls.Add(this.CantidadCotizadanumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExistenciatextBox);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "RegistroArticulo";
            this.Text = "Registro de Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadCotizadanumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox ExistenciatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CantidadCotizadanumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaVencimientodateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}