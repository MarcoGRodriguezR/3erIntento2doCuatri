namespace Integradora.Inventario
{
    partial class AgregarSeccion
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
            IndicasaoLabel = new Label();
            Crear = new Button();
            Nombre = new TextBox();
            Estatus = new Label();
            SuspendLayout();
            // 
            // IndicasaoLabel
            // 
            IndicasaoLabel.AutoSize = true;
            IndicasaoLabel.Font = new Font("Segoe UI", 16F);
            IndicasaoLabel.Location = new Point(12, 9);
            IndicasaoLabel.Name = "IndicasaoLabel";
            IndicasaoLabel.Size = new Size(452, 30);
            IndicasaoLabel.TabIndex = 0;
            IndicasaoLabel.Text = "Escriba el nombre de la nueva seccion a crear";
            // 
            // Crear
            // 
            Crear.Font = new Font("Segoe UI", 16F);
            Crear.Location = new Point(12, 42);
            Crear.Name = "Crear";
            Crear.Size = new Size(98, 52);
            Crear.TabIndex = 1;
            Crear.Text = "Crear";
            Crear.UseVisualStyleBackColor = true;
            Crear.Click += Crear_Click;
            // 
            // Nombre
            // 
            Nombre.Font = new Font("Segoe UI", 16F);
            Nombre.Location = new Point(116, 50);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(348, 36);
            Nombre.TabIndex = 2;
            // 
            // Estatus
            // 
            Estatus.AutoSize = true;
            Estatus.Font = new Font("Segoe UI", 16F);
            Estatus.Location = new Point(12, 97);
            Estatus.Name = "Estatus";
            Estatus.Size = new Size(0, 30);
            Estatus.TabIndex = 3;
            // 
            // AgregarSeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 101);
            Controls.Add(Estatus);
            Controls.Add(Nombre);
            Controls.Add(Crear);
            Controls.Add(IndicasaoLabel);
            Name = "AgregarSeccion";
            Text = "AgregarSeccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IndicasaoLabel;
        private Button Crear;
        private TextBox Nombre;
        private Label Estatus;
    }
}