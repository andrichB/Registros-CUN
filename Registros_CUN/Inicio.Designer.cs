namespace Registros_CUN
{
    partial class Inicio
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
            pct_logo = new PictureBox();
            lbl_texto_1 = new Label();
            cbx_dni = new ComboBox();
            lbl_text_2 = new Label();
            btn_registrarse = new Button();
            ((System.ComponentModel.ISupportInitialize)pct_logo).BeginInit();
            SuspendLayout();
            // 
            // pct_logo
            // 
            pct_logo.Image = Properties.Resources.CUN_svg;
            pct_logo.Location = new Point(12, 12);
            pct_logo.Name = "pct_logo";
            pct_logo.Size = new Size(131, 55);
            pct_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pct_logo.TabIndex = 0;
            pct_logo.TabStop = false;
            // 
            // lbl_texto_1
            // 
            lbl_texto_1.AutoSize = true;
            lbl_texto_1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_texto_1.Location = new Point(140, 198);
            lbl_texto_1.Name = "lbl_texto_1";
            lbl_texto_1.Size = new Size(244, 21);
            lbl_texto_1.TabIndex = 1;
            lbl_texto_1.Text = "Ingrese su número de documento";
            // 
            // cbx_dni
            // 
            cbx_dni.FormattingEnabled = true;
            cbx_dni.Location = new Point(436, 196);
            cbx_dni.Name = "cbx_dni";
            cbx_dni.Size = new Size(270, 23);
            cbx_dni.TabIndex = 2;
            // 
            // lbl_text_2
            // 
            lbl_text_2.AutoSize = true;
            lbl_text_2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_text_2.Location = new Point(203, 414);
            lbl_text_2.Name = "lbl_text_2";
            lbl_text_2.Size = new Size(212, 21);
            lbl_text_2.TabIndex = 3;
            lbl_text_2.Text = "No, te encuentras? Registrate";
            // 
            // btn_registrarse
            // 
            btn_registrarse.Location = new Point(436, 410);
            btn_registrarse.Name = "btn_registrarse";
            btn_registrarse.Size = new Size(101, 33);
            btn_registrarse.TabIndex = 4;
            btn_registrarse.Text = "Registrate";
            btn_registrarse.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_registrarse);
            Controls.Add(lbl_text_2);
            Controls.Add(cbx_dni);
            Controls.Add(lbl_texto_1);
            Controls.Add(pct_logo);
            Name = "Inicio";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pct_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pct_logo;
        private Label lbl_texto_1;
        private ComboBox cbx_dni;
        private Label lbl_text_2;
        private Button btn_registrarse;
    }
}