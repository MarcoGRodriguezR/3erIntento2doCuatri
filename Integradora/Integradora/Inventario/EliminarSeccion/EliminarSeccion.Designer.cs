namespace Integradora.Inventario
{
    partial class EliminarSeccion
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
            IndicasaoLabel = new Label();
            SeccionBox = new ComboBox();
            EstatusLabel = new Label();
            SuspendLayout();
            // 
            // Eliminar
            // 
            Eliminar.Font = new Font("Segoe UI", 16F);
            Eliminar.Location = new Point(12, 86);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(132, 44);
            Eliminar.TabIndex = 0;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // IndicasaoLabel
            // 
            IndicasaoLabel.AutoSize = true;
            IndicasaoLabel.Font = new Font("Segoe UI", 16F);
            IndicasaoLabel.Location = new Point(12, 9);
            IndicasaoLabel.Name = "IndicasaoLabel";
            IndicasaoLabel.Size = new Size(308, 30);
            IndicasaoLabel.TabIndex = 1;
            IndicasaoLabel.Text = "Eliga una seccion para eliminar";
            // 
            // SeccionBox
            // 
            SeccionBox.Font = new Font("Segoe UI", 16F);
            SeccionBox.FormattingEnabled = true;
            SeccionBox.Location = new Point(12, 42);
            SeccionBox.Name = "SeccionBox";
            SeccionBox.Size = new Size(308, 38);
            SeccionBox.TabIndex = 2;
            // 
            // EstatusLabel
            // 
            EstatusLabel.AutoSize = true;
            EstatusLabel.Font = new Font("Segoe UI", 16F);
            EstatusLabel.Location = new Point(150, 93);
            EstatusLabel.Name = "EstatusLabel";
            EstatusLabel.Size = new Size(0, 30);
            EstatusLabel.TabIndex = 3;
            // 
            // EliminarSeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 135);
            Controls.Add(EstatusLabel);
            Controls.Add(SeccionBox);
            Controls.Add(IndicasaoLabel);
            Controls.Add(Eliminar);
            Name = "EliminarSeccion";
            Text = "EliminarSeccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Eliminar;
        private Label IndicasaoLabel;
        private ComboBox SeccionBox;
        private Label EstatusLabel;
    }
}