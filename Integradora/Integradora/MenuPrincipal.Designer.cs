namespace Integradora
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cerrar = new Button();
            Inventario = new Button();
            SuspendLayout();
            // 
            // Cerrar
            // 
            Cerrar.Location = new Point(89, 83);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(75, 23);
            Cerrar.TabIndex = 0;
            Cerrar.Text = "Cerrar";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // Inventario
            // 
            Inventario.Location = new Point(12, 33);
            Inventario.Name = "Inventario";
            Inventario.Size = new Size(75, 23);
            Inventario.TabIndex = 1;
            Inventario.Text = "Inventario";
            Inventario.UseVisualStyleBackColor = true;
            Inventario.Click += Inventario_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 118);
            Controls.Add(Inventario);
            Controls.Add(Cerrar);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button Cerrar;
        private Button Inventario;
    }
}
