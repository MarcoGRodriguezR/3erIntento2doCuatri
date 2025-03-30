namespace Integradora.Inventario
{
    partial class MenuInventario
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
            ElementoLabel = new Label();
            ElementoBox = new ComboBox();
            TextoPrincipal = new RichTextBox();
            Cerrar = new Button();
            ModUnidades = new Button();
            AgregarProducto = new Button();
            EliminarProducto = new Button();
            AgregarSeccion = new Button();
            EliminarSecciones = new Button();
            SuspendLayout();
            // 
            // SeccionLabel
            // 
            SeccionLabel.AutoSize = true;
            SeccionLabel.Font = new Font("Segoe UI", 12F);
            SeccionLabel.Location = new Point(12, 9);
            SeccionLabel.Name = "SeccionLabel";
            SeccionLabel.Size = new Size(63, 21);
            SeccionLabel.TabIndex = 0;
            SeccionLabel.Text = "Seccion";
            // 
            // SeccionBox
            // 
            SeccionBox.Font = new Font("Segoe UI", 12F);
            SeccionBox.FormattingEnabled = true;
            SeccionBox.Location = new Point(108, 6);
            SeccionBox.Name = "SeccionBox";
            SeccionBox.Size = new Size(309, 29);
            SeccionBox.TabIndex = 1;
            SeccionBox.SelectedIndexChanged += Secciones_SelectedIndexChanged;
            // 
            // ElementoLabel
            // 
            ElementoLabel.AutoSize = true;
            ElementoLabel.Font = new Font("Segoe UI", 12F);
            ElementoLabel.Location = new Point(12, 46);
            ElementoLabel.Name = "ElementoLabel";
            ElementoLabel.Size = new Size(75, 21);
            ElementoLabel.TabIndex = 2;
            ElementoLabel.Text = "Elemento";
            // 
            // ElementoBox
            // 
            ElementoBox.Font = new Font("Segoe UI", 12F);
            ElementoBox.FormattingEnabled = true;
            ElementoBox.Location = new Point(108, 43);
            ElementoBox.Name = "ElementoBox";
            ElementoBox.Size = new Size(309, 29);
            ElementoBox.TabIndex = 3;
            ElementoBox.SelectedIndexChanged += Elementos_SelectedIndexChanged;
            // 
            // TextoPrincipal
            // 
            TextoPrincipal.Enabled = false;
            TextoPrincipal.Font = new Font("Segoe UI", 12F);
            TextoPrincipal.Location = new Point(12, 78);
            TextoPrincipal.Name = "TextoPrincipal";
            TextoPrincipal.Size = new Size(486, 122);
            TextoPrincipal.TabIndex = 4;
            TextoPrincipal.Text = "";
            // 
            // Cerrar
            // 
            Cerrar.Location = new Point(423, 6);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(75, 23);
            Cerrar.TabIndex = 5;
            Cerrar.Text = "Cerrar";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // ModUnidades
            // 
            ModUnidades.Font = new Font("Segoe UI", 12F);
            ModUnidades.Location = new Point(658, 250);
            ModUnidades.Name = "ModUnidades";
            ModUnidades.Size = new Size(106, 54);
            ModUnidades.TabIndex = 6;
            ModUnidades.Text = "Modificar \r\nUnidades";
            ModUnidades.UseVisualStyleBackColor = true;
            ModUnidades.Click += ModUnidades_Click;
            // 
            // AgregarProducto
            // 
            AgregarProducto.Font = new Font("Segoe UI", 12F);
            AgregarProducto.Location = new Point(504, 78);
            AgregarProducto.Name = "AgregarProducto";
            AgregarProducto.Size = new Size(106, 54);
            AgregarProducto.TabIndex = 7;
            AgregarProducto.Text = "Agregar Producto";
            AgregarProducto.UseVisualStyleBackColor = true;
            AgregarProducto.Click += AgregarProducto_Click;
            // 
            // EliminarProducto
            // 
            EliminarProducto.Font = new Font("Segoe UI", 12F);
            EliminarProducto.Location = new Point(504, 138);
            EliminarProducto.Name = "EliminarProducto";
            EliminarProducto.Size = new Size(106, 54);
            EliminarProducto.TabIndex = 8;
            EliminarProducto.Text = "Eliminar Productos";
            EliminarProducto.UseVisualStyleBackColor = true;
            EliminarProducto.Click += EliminarProducto_Click;
            // 
            // AgregarSeccion
            // 
            AgregarSeccion.Font = new Font("Segoe UI", 12F);
            AgregarSeccion.Location = new Point(616, 78);
            AgregarSeccion.Name = "AgregarSeccion";
            AgregarSeccion.Size = new Size(106, 54);
            AgregarSeccion.TabIndex = 9;
            AgregarSeccion.Text = "Agregar Seccion";
            AgregarSeccion.UseVisualStyleBackColor = true;
            AgregarSeccion.Click += AgregarSeccion_Click;
            // 
            // EliminarSecciones
            // 
            EliminarSecciones.Font = new Font("Segoe UI", 12F);
            EliminarSecciones.Location = new Point(616, 138);
            EliminarSecciones.Name = "EliminarSecciones";
            EliminarSecciones.Size = new Size(106, 54);
            EliminarSecciones.TabIndex = 10;
            EliminarSecciones.Text = "Eliminar Secciones";
            EliminarSecciones.UseVisualStyleBackColor = true;
            EliminarSecciones.Click += EliminarSecciones_Click;
            // 
            // MenuInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EliminarSecciones);
            Controls.Add(AgregarSeccion);
            Controls.Add(EliminarProducto);
            Controls.Add(AgregarProducto);
            Controls.Add(ModUnidades);
            Controls.Add(Cerrar);
            Controls.Add(TextoPrincipal);
            Controls.Add(ElementoBox);
            Controls.Add(ElementoLabel);
            Controls.Add(SeccionBox);
            Controls.Add(SeccionLabel);
            Name = "MenuInventario";
            Text = "MenuInventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SeccionLabel;
        public ComboBox SeccionBox;
        private Label ElementoLabel;
        public ComboBox ElementoBox;
        private RichTextBox TextoPrincipal;
        private Button Cerrar;
        private Button ModUnidades;
        private Button AgregarProducto;
        private Button EliminarProducto;
        private Button AgregarSeccion;
        private Button EliminarSecciones;
    }
}