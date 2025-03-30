namespace Integradora.Inventario
{
    partial class EliminarProducto
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
            Eliminar = new Button();
            IndicacionLabel = new Label();
            Elementos = new ComboBox();
            Estatus = new Label();
            SuspendLayout();
            // 
            // Eliminar
            // 
            Eliminar.Font = new Font("Segoe UI", 16F);
            Eliminar.Location = new Point(12, 86);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(209, 52);
            Eliminar.TabIndex = 0;
            Eliminar.Text = "Eliminar Elemento";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // IndicacionLabel
            // 
            IndicacionLabel.AutoSize = true;
            IndicacionLabel.Font = new Font("Segoe UI", 16F);
            IndicacionLabel.Location = new Point(12, 9);
            IndicacionLabel.Name = "IndicacionLabel";
            IndicacionLabel.Size = new Size(71, 30);
            IndicacionLabel.TabIndex = 1;
            IndicacionLabel.Text = "label1";
            // 
            // Elementos
            // 
            Elementos.Font = new Font("Segoe UI", 16F);
            Elementos.FormattingEnabled = true;
            Elementos.Location = new Point(12, 42);
            Elementos.Name = "Elementos";
            Elementos.Size = new Size(209, 38);
            Elementos.TabIndex = 2;
            // 
            // Estatus
            // 
            Estatus.AutoSize = true;
            Estatus.Font = new Font("Segoe UI", 16F);
            Estatus.Location = new Point(227, 97);
            Estatus.Name = "Estatus";
            Estatus.Size = new Size(0, 30);
            Estatus.TabIndex = 3;
            // 
            // EliminarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 151);
            Controls.Add(Estatus);
            Controls.Add(Elementos);
            Controls.Add(IndicacionLabel);
            Controls.Add(Eliminar);
            Name = "EliminarProducto";
            Text = "EliminarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Eliminar;
        private Label IndicacionLabel;
        private ComboBox Elementos;
        private Label Estatus;
    }
}