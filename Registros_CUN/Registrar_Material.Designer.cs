namespace Registros_CUN
{
    partial class Registrar_Material
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
            components = new System.ComponentModel.Container();
            cbx_tipo_material = new ComboBox();
            label5 = new Label();
            tbx_cual = new TextBox();
            lbl_cual = new Label();
            label3 = new Label();
            tbx_marca = new TextBox();
            label2 = new Label();
            tbx_serial = new TextBox();
            lbl_titulo = new Label();
            lbl_texto_1 = new Label();
            pct_logo = new PictureBox();
            btn_regresar = new Button();
            btn_agregar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            tbx_color = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pct_logo).BeginInit();
            SuspendLayout();
            // 
            // cbx_tipo_material
            // 
            cbx_tipo_material.FormattingEnabled = true;
            cbx_tipo_material.Location = new Point(161, 148);
            cbx_tipo_material.Name = "cbx_tipo_material";
            cbx_tipo_material.Size = new Size(208, 23);
            cbx_tipo_material.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 146);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 26;
            label5.Text = "Tipo de material";
            // 
            // tbx_cual
            // 
            tbx_cual.Location = new Point(450, 152);
            tbx_cual.Name = "tbx_cual";
            tbx_cual.Size = new Size(323, 23);
            tbx_cual.TabIndex = 25;
            // 
            // lbl_cual
            // 
            lbl_cual.AutoSize = true;
            lbl_cual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cual.Location = new Point(396, 150);
            lbl_cual.Name = "lbl_cual";
            lbl_cual.Size = new Size(48, 21);
            lbl_cual.TabIndex = 24;
            lbl_cual.Text = "Cuál?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(393, 198);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 23;
            label3.Text = "Color";
            // 
            // tbx_marca
            // 
            tbx_marca.Location = new Point(114, 236);
            tbx_marca.Name = "tbx_marca";
            tbx_marca.Size = new Size(255, 23);
            tbx_marca.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 238);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 21;
            label2.Text = "Marca";
            // 
            // tbx_serial
            // 
            tbx_serial.Location = new Point(114, 196);
            tbx_serial.Name = "tbx_serial";
            tbx_serial.Size = new Size(255, 23);
            tbx_serial.TabIndex = 20;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(161, 27);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(260, 40);
            lbl_titulo.TabIndex = 19;
            lbl_titulo.Text = "Registro materiales";
            // 
            // lbl_texto_1
            // 
            lbl_texto_1.AutoSize = true;
            lbl_texto_1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_texto_1.Location = new Point(33, 198);
            lbl_texto_1.Name = "lbl_texto_1";
            lbl_texto_1.Size = new Size(49, 21);
            lbl_texto_1.TabIndex = 18;
            lbl_texto_1.Text = "Serial";
            // 
            // pct_logo
            // 
            pct_logo.Image = Properties.Resources.CUN_svg;
            pct_logo.Location = new Point(12, 12);
            pct_logo.Name = "pct_logo";
            pct_logo.Size = new Size(131, 55);
            pct_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pct_logo.TabIndex = 17;
            pct_logo.TabStop = false;
            // 
            // btn_regresar
            // 
            btn_regresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_regresar.Location = new Point(233, 365);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(141, 46);
            btn_regresar.TabIndex = 30;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = true;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(396, 365);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(141, 46);
            btn_agregar.TabIndex = 29;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // tbx_color
            // 
            tbx_color.Location = new Point(450, 200);
            tbx_color.Name = "tbx_color";
            tbx_color.Size = new Size(323, 23);
            tbx_color.TabIndex = 31;
            // 
            // Registrar_Material
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbx_color);
            Controls.Add(btn_regresar);
            Controls.Add(btn_agregar);
            Controls.Add(cbx_tipo_material);
            Controls.Add(label5);
            Controls.Add(tbx_cual);
            Controls.Add(lbl_cual);
            Controls.Add(label3);
            Controls.Add(tbx_marca);
            Controls.Add(label2);
            Controls.Add(tbx_serial);
            Controls.Add(lbl_titulo);
            Controls.Add(lbl_texto_1);
            Controls.Add(pct_logo);
            Name = "Registrar_Material";
            Text = "Registrar_Material";
            Load += Registrar_Material_Load;
            ((System.ComponentModel.ISupportInitialize)pct_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbx_tipo_material;
        private Label label5;
        private TextBox tbx_cual;
        private Label lbl_cual;
        private Label label3;
        private TextBox tbx_marca;
        private Label label2;
        private TextBox tbx_serial;
        private Label lbl_titulo;
        private Label lbl_texto_1;
        private PictureBox pct_logo;
        private Button btn_regresar;
        private Button btn_agregar;
        private System.Windows.Forms.Timer timer1;
        private TextBox tbx_color;
    }
}