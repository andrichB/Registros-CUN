namespace Registros_CUN
{
    partial class Registro
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
            label1 = new Label();
            tbx_nombres = new TextBox();
            tbx_apellidos = new TextBox();
            label2 = new Label();
            label3 = new Label();
            listbx_tipo_documento = new ListBox();
            tbx_numero_documento = new TextBox();
            label4 = new Label();
            listBox1 = new ListBox();
            label5 = new Label();
            btn_agregar = new Button();
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
            pct_logo.TabIndex = 1;
            pct_logo.TabStop = false;
            // 
            // lbl_texto_1
            // 
            lbl_texto_1.AutoSize = true;
            lbl_texto_1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_texto_1.Location = new Point(33, 198);
            lbl_texto_1.Name = "lbl_texto_1";
            lbl_texto_1.Size = new Size(75, 21);
            lbl_texto_1.TabIndex = 2;
            lbl_texto_1.Text = "Nombres";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 27);
            label1.Name = "label1";
            label1.Size = new Size(121, 40);
            label1.TabIndex = 3;
            label1.Text = "Registro";
            // 
            // tbx_nombres
            // 
            tbx_nombres.Location = new Point(114, 196);
            tbx_nombres.Name = "tbx_nombres";
            tbx_nombres.Size = new Size(255, 23);
            tbx_nombres.TabIndex = 4;
            // 
            // tbx_apellidos
            // 
            tbx_apellidos.Location = new Point(114, 236);
            tbx_apellidos.Name = "tbx_apellidos";
            tbx_apellidos.Size = new Size(255, 23);
            tbx_apellidos.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 238);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 5;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(393, 198);
            label3.Name = "label3";
            label3.Size = new Size(144, 21);
            label3.TabIndex = 7;
            label3.Text = "Tipo de documento";
            // 
            // listbx_tipo_documento
            // 
            listbx_tipo_documento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbx_tipo_documento.FormattingEnabled = true;
            listbx_tipo_documento.ItemHeight = 21;
            listbx_tipo_documento.Items.AddRange(new object[] { "Cédula de ciudadanía", "Pasaporte", "Cédula de extrajero" });
            listbx_tipo_documento.Location = new Point(586, 198);
            listbx_tipo_documento.Name = "listbx_tipo_documento";
            listbx_tipo_documento.Size = new Size(187, 25);
            listbx_tipo_documento.TabIndex = 8;
            // 
            // tbx_numero_documento
            // 
            tbx_numero_documento.Location = new Point(586, 240);
            tbx_numero_documento.Name = "tbx_numero_documento";
            tbx_numero_documento.Size = new Size(187, 23);
            tbx_numero_documento.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(393, 240);
            label4.Name = "label4";
            label4.Size = new Size(172, 21);
            label4.TabIndex = 9;
            label4.Text = "Número de documento";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Items.AddRange(new object[] { "Estudiante", "Docente", "Funcionario", "Visitante" });
            listBox1.Location = new Point(81, 146);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(157, 25);
            listBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 146);
            label5.Name = "label5";
            label5.Size = new Size(33, 21);
            label5.TabIndex = 11;
            label5.Text = "Rol";
            // 
            // btn_agregar
            // 
            btn_agregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(318, 392);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(141, 46);
            btn_agregar.TabIndex = 13;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_agregar);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(tbx_numero_documento);
            Controls.Add(label4);
            Controls.Add(listbx_tipo_documento);
            Controls.Add(label3);
            Controls.Add(tbx_apellidos);
            Controls.Add(label2);
            Controls.Add(tbx_nombres);
            Controls.Add(label1);
            Controls.Add(lbl_texto_1);
            Controls.Add(pct_logo);
            Name = "Registro";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pct_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pct_logo;
        private Label lbl_texto_1;
        private Label label1;
        private TextBox tbx_nombres;
        private TextBox tbx_apellidos;
        private Label label2;
        private Label label3;
        private ListBox listbx_tipo_documento;
        private TextBox tbx_numero_documento;
        private Label label4;
        private ListBox listBox1;
        private Label label5;
        private Button btn_agregar;
    }
}