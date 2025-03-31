namespace Integradora.Inventario
{
    partial class ModificarUnidades
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
            MasUno = new Button();
            UnidadesLabel = new Label();
            MenosUno = new Button();
            AgregarUnidadesLabel = new Label();
            AgregarUnidades = new Button();
            AgregarUnidadesText = new TextBox();
            QuitarUnidadesLabel = new Label();
            QuitarUnidades = new Button();
            QuitarUnidadesText = new TextBox();
            SuspendLayout();
            // 
            // MasUno
            // 
            MasUno.Font = new Font("Segoe UI", 12F);
            MasUno.Location = new Point(12, 42);
            MasUno.Name = "MasUno";
            MasUno.Size = new Size(88, 32);
            MasUno.TabIndex = 0;
            MasUno.Text = "+1";
            MasUno.UseVisualStyleBackColor = true;
            MasUno.Click += MasUno_Click;
            // 
            // UnidadesLabel
            // 
            UnidadesLabel.AutoSize = true;
            UnidadesLabel.Font = new Font("Segoe UI", 16F);
            UnidadesLabel.Location = new Point(12, 9);
            UnidadesLabel.Name = "UnidadesLabel";
            UnidadesLabel.Size = new Size(200, 30);
            UnidadesLabel.TabIndex = 1;
            UnidadesLabel.Text = "Unidades Actuales: ";
            // 
            // MenosUno
            // 
            MenosUno.Font = new Font("Segoe UI", 12F);
            MenosUno.Location = new Point(106, 42);
            MenosUno.Name = "MenosUno";
            MenosUno.Size = new Size(88, 32);
            MenosUno.TabIndex = 2;
            MenosUno.Text = "-1";
            MenosUno.UseVisualStyleBackColor = true;
            MenosUno.Click += MenosUno_Click;
            // 
            // AgregarUnidadesLabel
            // 
            AgregarUnidadesLabel.AutoSize = true;
            AgregarUnidadesLabel.Font = new Font("Segoe UI", 12F);
            AgregarUnidadesLabel.Location = new Point(12, 77);
            AgregarUnidadesLabel.Name = "AgregarUnidadesLabel";
            AgregarUnidadesLabel.Size = new Size(235, 21);
            AgregarUnidadesLabel.TabIndex = 3;
            AgregarUnidadesLabel.Text = "Escriba las unidades por agregar";
            // 
            // AgregarUnidades
            // 
            AgregarUnidades.Font = new Font("Segoe UI", 12F);
            AgregarUnidades.Location = new Point(12, 101);
            AgregarUnidades.Name = "AgregarUnidades";
            AgregarUnidades.Size = new Size(88, 54);
            AgregarUnidades.TabIndex = 4;
            AgregarUnidades.Text = "Agregar Unidades";
            AgregarUnidades.UseVisualStyleBackColor = true;
            AgregarUnidades.Click += AgregarUnidades_Click;
            // 
            // AgregarUnidadesText
            // 
            AgregarUnidadesText.Font = new Font("Segoe UI", 12F);
            AgregarUnidadesText.Location = new Point(106, 115);
            AgregarUnidadesText.Name = "AgregarUnidadesText";
            AgregarUnidadesText.Size = new Size(141, 29);
            AgregarUnidadesText.TabIndex = 5;
            AgregarUnidadesText.TextChanged += AgregarUnidadesText_TextChanged;
            // 
            // QuitarUnidadesLabel
            // 
            QuitarUnidadesLabel.AutoSize = true;
            QuitarUnidadesLabel.Font = new Font("Segoe UI", 12F);
            QuitarUnidadesLabel.Location = new Point(12, 158);
            QuitarUnidadesLabel.Name = "QuitarUnidadesLabel";
            QuitarUnidadesLabel.Size = new Size(222, 21);
            QuitarUnidadesLabel.TabIndex = 6;
            QuitarUnidadesLabel.Text = "Escriba las unidades por quitar";
            // 
            // QuitarUnidades
            // 
            QuitarUnidades.Font = new Font("Segoe UI", 12F);
            QuitarUnidades.Location = new Point(12, 182);
            QuitarUnidades.Name = "QuitarUnidades";
            QuitarUnidades.Size = new Size(88, 54);
            QuitarUnidades.TabIndex = 7;
            QuitarUnidades.Text = "Quitar Unidades";
            QuitarUnidades.UseVisualStyleBackColor = true;
            QuitarUnidades.Click += QuitarUnidades_Click;
            // 
            // QuitarUnidadesText
            // 
            QuitarUnidadesText.Font = new Font("Segoe UI", 12F);
            QuitarUnidadesText.Location = new Point(106, 196);
            QuitarUnidadesText.Name = "QuitarUnidadesText";
            QuitarUnidadesText.Size = new Size(141, 29);
            QuitarUnidadesText.TabIndex = 8;
            QuitarUnidadesText.TextChanged += QuitarUnidadesText_TextChanged;
            // 
            // ModificarUnidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 240);
            Controls.Add(QuitarUnidadesText);
            Controls.Add(QuitarUnidades);
            Controls.Add(QuitarUnidadesLabel);
            Controls.Add(AgregarUnidadesText);
            Controls.Add(AgregarUnidades);
            Controls.Add(AgregarUnidadesLabel);
            Controls.Add(MenosUno);
            Controls.Add(UnidadesLabel);
            Controls.Add(MasUno);
            Name = "ModificarUnidades";
            Text = "ModificarUnidades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MasUno;
        private Label UnidadesLabel;
        private Button MenosUno;
        private Label AgregarUnidadesLabel;
        private Button AgregarUnidades;
        private TextBox AgregarUnidadesText;
        private Label QuitarUnidadesLabel;
        private Button QuitarUnidades;
        private TextBox QuitarUnidadesText;
    }
}