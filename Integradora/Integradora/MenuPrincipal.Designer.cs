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
            SuspendLayout();
            // 
            // Cerrar
            // 
            Cerrar.Location = new Point(102, 111);
            Cerrar.Margin = new Padding(3, 4, 3, 4);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(86, 31);
            Cerrar.TabIndex = 0;
            Cerrar.Text = "Cerrar";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 155);
            Controls.Add(Cerrar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button Cerrar;
    }
}
