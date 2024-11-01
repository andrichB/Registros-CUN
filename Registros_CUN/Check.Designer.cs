namespace Registros_CUN
{
    partial class Check
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
            lbl_titulo = new Label();
            pct_logo = new PictureBox();
            lbl_nombres = new Label();
            lbl_apellidos = new Label();
            dataGridView1 = new DataGridView();
            lbl_numero_documento = new Label();
            lbl_tipo_documento = new Label();
            lbl_rol = new Label();
            btn_agregar = new Button();
            btn_regresar = new Button();
            btn_aplicar_cambios = new Button();
            ((System.ComponentModel.ISupportInitialize)pct_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(161, 27);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(308, 40);
            lbl_titulo.TabIndex = 5;
            lbl_titulo.Text = "Marcar ingreso / salida";
            // 
            // pct_logo
            // 
            pct_logo.Image = Properties.Resources.CUN_svg;
            pct_logo.Location = new Point(12, 12);
            pct_logo.Name = "pct_logo";
            pct_logo.Size = new Size(131, 55);
            pct_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pct_logo.TabIndex = 4;
            pct_logo.TabStop = false;
            // 
            // lbl_nombres
            // 
            lbl_nombres.AutoSize = true;
            lbl_nombres.Font = new Font("Segoe UI", 12F);
            lbl_nombres.Location = new Point(39, 118);
            lbl_nombres.Name = "lbl_nombres";
            lbl_nombres.Size = new Size(38, 21);
            lbl_nombres.TabIndex = 6;
            lbl_nombres.Text = "-- --";
            // 
            // lbl_apellidos
            // 
            lbl_apellidos.AutoSize = true;
            lbl_apellidos.Font = new Font("Segoe UI", 12F);
            lbl_apellidos.Location = new Point(39, 158);
            lbl_apellidos.Name = "lbl_apellidos";
            lbl_apellidos.Size = new Size(38, 21);
            lbl_apellidos.TabIndex = 7;
            lbl_apellidos.Text = "-- --";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(732, 210);
            dataGridView1.TabIndex = 8;
            // 
            // lbl_numero_documento
            // 
            lbl_numero_documento.AutoSize = true;
            lbl_numero_documento.Font = new Font("Segoe UI", 12F);
            lbl_numero_documento.Location = new Point(347, 158);
            lbl_numero_documento.Name = "lbl_numero_documento";
            lbl_numero_documento.Size = new Size(38, 21);
            lbl_numero_documento.TabIndex = 10;
            lbl_numero_documento.Text = "-- --";
            // 
            // lbl_tipo_documento
            // 
            lbl_tipo_documento.AutoSize = true;
            lbl_tipo_documento.Font = new Font("Segoe UI", 12F);
            lbl_tipo_documento.Location = new Point(347, 118);
            lbl_tipo_documento.Name = "lbl_tipo_documento";
            lbl_tipo_documento.Size = new Size(38, 21);
            lbl_tipo_documento.TabIndex = 9;
            lbl_tipo_documento.Text = "-- --";
            // 
            // lbl_rol
            // 
            lbl_rol.AutoSize = true;
            lbl_rol.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_rol.Location = new Point(39, 71);
            lbl_rol.Name = "lbl_rol";
            lbl_rol.Size = new Size(49, 25);
            lbl_rol.TabIndex = 12;
            lbl_rol.Text = "-- --";
            // 
            // btn_agregar
            // 
            btn_agregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(616, 93);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(155, 40);
            btn_agregar.TabIndex = 13;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_regresar
            // 
            btn_regresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_regresar.Location = new Point(616, 47);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(155, 40);
            btn_regresar.TabIndex = 14;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = true;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // btn_aplicar_cambios
            // 
            btn_aplicar_cambios.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_aplicar_cambios.Location = new Point(616, 139);
            btn_aplicar_cambios.Name = "btn_aplicar_cambios";
            btn_aplicar_cambios.Size = new Size(155, 40);
            btn_aplicar_cambios.TabIndex = 15;
            btn_aplicar_cambios.Text = "Aplicar cambios";
            btn_aplicar_cambios.UseVisualStyleBackColor = true;
            btn_aplicar_cambios.Click += btn_aplicar_cambios_Click;
            // 
            // Check
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_aplicar_cambios);
            Controls.Add(btn_regresar);
            Controls.Add(btn_agregar);
            Controls.Add(lbl_rol);
            Controls.Add(lbl_numero_documento);
            Controls.Add(lbl_tipo_documento);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_apellidos);
            Controls.Add(lbl_nombres);
            Controls.Add(lbl_titulo);
            Controls.Add(pct_logo);
            Name = "Check";
            Text = "Check";
            Load += Check_Load;
            ((System.ComponentModel.ISupportInitialize)pct_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private PictureBox pct_logo;
        private Label lbl_nombres;
        private Label lbl_apellidos;
        private DataGridView dataGridView1;
        private Label lbl_numero_documento;
        private Label lbl_tipo_documento;
        private Label lbl_rol;
        private Button btn_agregar;
        private Button btn_regresar;
        private Button btn_aplicar_cambios;
    }
}