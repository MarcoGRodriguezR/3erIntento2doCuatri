namespace Integradora.Inventario
{
    partial class AgregarProducto
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
            SeccionLabel = new Label();
            SeccionBox = new ComboBox();
            Nombre = new TextBox();
            NombreLabel = new Label();
            Unidades = new TextBox();
            UnidadesLabel = new Label();
            Ventas = new TextBox();
            VentasLabel = new Label();
            Agregar = new Button();
            Estatus = new Label();
            SuspendLayout();
            // 
            // SeccionLabel
            // 
            SeccionLabel.AutoSize = true;
            SeccionLabel.Font = new Font("Segoe UI", 12F);
            SeccionLabel.Location = new Point(12, 9);
            SeccionLabel.Name = "SeccionLabel";
            SeccionLabel.Size = new Size(63, 21);
            SeccionLabel.TabIndex = 1;
            SeccionLabel.Text = "Seccion";
            // 
            // SeccionBox
            // 
            SeccionBox.Font = new Font("Segoe UI", 12F);
            SeccionBox.FormattingEnabled = true;
            SeccionBox.Location = new Point(12, 48);
            SeccionBox.Name = "SeccionBox";
            SeccionBox.Size = new Size(184, 29);
            SeccionBox.TabIndex = 2;
            SeccionBox.SelectedIndexChanged += SeccionBox_SelectedIndexChanged;
            // 
            // Nombre
            // 
            Nombre.Font = new Font("Segoe UI", 12F);
            Nombre.Location = new Point(202, 48);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(184, 29);
            Nombre.TabIndex = 3;
            Nombre.TextChanged += Nombre_TextChanged;
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Font = new Font("Segoe UI", 12F);
            NombreLabel.Location = new Point(202, 9);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(160, 21);
            NombreLabel.TabIndex = 4;
            NombreLabel.Text = "Nombre del Producto";
            // 
            // Unidades
            // 
            Unidades.Font = new Font("Segoe UI", 12F);
            Unidades.Location = new Point(392, 48);
            Unidades.Name = "Unidades";
            Unidades.Size = new Size(184, 29);
            Unidades.TabIndex = 5;
            Unidades.Text = "0";
            Unidades.TextChanged += Unidades_TextChanged;
            // 
            // UnidadesLabel
            // 
            UnidadesLabel.AutoSize = true;
            UnidadesLabel.Font = new Font("Segoe UI", 12F);
            UnidadesLabel.Location = new Point(392, 9);
            UnidadesLabel.Name = "UnidadesLabel";
            UnidadesLabel.Size = new Size(137, 21);
            UnidadesLabel.TabIndex = 6;
            UnidadesLabel.Text = "Unidades Actuales";
            // 
            // Ventas
            // 
            Ventas.Font = new Font("Segoe UI", 12F);
            Ventas.Location = new Point(582, 48);
            Ventas.Name = "Ventas";
            Ventas.Size = new Size(184, 29);
            Ventas.TabIndex = 7;
            Ventas.Text = "0";
            Ventas.TextChanged += Ventas_TextChanged;
            // 
            // VentasLabel
            // 
            VentasLabel.AutoSize = true;
            VentasLabel.Font = new Font("Segoe UI", 12F);
            VentasLabel.Location = new Point(582, 9);
            VentasLabel.Name = "VentasLabel";
            VentasLabel.Size = new Size(56, 21);
            VentasLabel.TabIndex = 8;
            VentasLabel.Text = "Ventas";
            // 
            // Agregar
            // 
            Agregar.Font = new Font("Segoe UI", 16F);
            Agregar.Location = new Point(12, 83);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(184, 71);
            Agregar.TabIndex = 9;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click_1;
            // 
            // Estatus
            // 
            Estatus.AutoSize = true;
            Estatus.Font = new Font("Segoe UI", 16F);
            Estatus.Location = new Point(202, 103);
            Estatus.Name = "Estatus";
            Estatus.Size = new Size(0, 30);
            Estatus.TabIndex = 10;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 163);
            Controls.Add(Estatus);
            Controls.Add(Agregar);
            Controls.Add(VentasLabel);
            Controls.Add(Ventas);
            Controls.Add(UnidadesLabel);
            Controls.Add(Unidades);
            Controls.Add(NombreLabel);
            Controls.Add(Nombre);
            Controls.Add(SeccionBox);
            Controls.Add(SeccionLabel);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label SeccionLabel;
        private ComboBox SeccionBox;
        private TextBox Nombre;
        private Label NombreLabel;
        private TextBox Unidades;
        private Label UnidadesLabel;
        private TextBox Ventas;
        private Label VentasLabel;
        private Button Agregar;
        private Label Estatus;
    }
}