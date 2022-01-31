
namespace GestInfo.CapaPresentacion
{
    partial class pInventarioEquipoCliente
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
            this.dateTime_alta = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_tipo_equipo = new System.Windows.Forms.ComboBox();
            this.txt_num_serie = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_nom_pag = new System.Windows.Forms.TextBox();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Modif = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_marca_equipo = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_modelo_equipo = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cmb_idInventario = new System.Windows.Forms.ComboBox();
            this.dateTime_baja = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTime_alta
            // 
            this.dateTime_alta.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_alta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_alta.Location = new System.Drawing.Point(669, 24);
            this.dateTime_alta.Name = "dateTime_alta";
            this.dateTime_alta.Size = new System.Drawing.Size(119, 24);
            this.dateTime_alta.TabIndex = 136;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(403, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 24);
            this.textBox1.TabIndex = 135;
            this.textBox1.Text = "Tipo Equipo :";
            // 
            // cmb_tipo_equipo
            // 
            this.cmb_tipo_equipo.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_equipo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmb_tipo_equipo.FormattingEnabled = true;
            this.cmb_tipo_equipo.Location = new System.Drawing.Point(403, 149);
            this.cmb_tipo_equipo.Name = "cmb_tipo_equipo";
            this.cmb_tipo_equipo.Size = new System.Drawing.Size(215, 27);
            this.cmb_tipo_equipo.TabIndex = 134;
            // 
            // txt_num_serie
            // 
            this.txt_num_serie.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_serie.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_num_serie.Location = new System.Drawing.Point(48, 149);
            this.txt_num_serie.Name = "txt_num_serie";
            this.txt_num_serie.Size = new System.Drawing.Size(215, 27);
            this.txt_num_serie.TabIndex = 133;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(48, 119);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 24);
            this.textBox2.TabIndex = 132;
            this.textBox2.Text = "Numero de Serie :";
            // 
            // txt_nom_pag
            // 
            this.txt_nom_pag.BackColor = System.Drawing.Color.White;
            this.txt_nom_pag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nom_pag.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold);
            this.txt_nom_pag.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_nom_pag.Location = new System.Drawing.Point(21, 17);
            this.txt_nom_pag.Multiline = true;
            this.txt_nom_pag.Name = "txt_nom_pag";
            this.txt_nom_pag.Size = new System.Drawing.Size(242, 31);
            this.txt_nom_pag.TabIndex = 131;
            this.txt_nom_pag.Text = "Inventario Equipo Cliente";
            // 
            // btn_Alta
            // 
            this.btn_Alta.BackColor = System.Drawing.Color.LightGray;
            this.btn_Alta.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Alta.Location = new System.Drawing.Point(403, 395);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(111, 39);
            this.btn_Alta.TabIndex = 130;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = false;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Modif
            // 
            this.btn_Modif.BackColor = System.Drawing.Color.LightGray;
            this.btn_Modif.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modif.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Modif.Location = new System.Drawing.Point(669, 395);
            this.btn_Modif.Name = "btn_Modif";
            this.btn_Modif.Size = new System.Drawing.Size(111, 39);
            this.btn_Modif.TabIndex = 129;
            this.btn_Modif.Text = "Modificar";
            this.btn_Modif.UseVisualStyleBackColor = false;
            this.btn_Modif.Click += new System.EventHandler(this.btn_Modif_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.BackColor = System.Drawing.Color.LightGray;
            this.btn_Baja.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baja.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Baja.Location = new System.Drawing.Point(536, 395);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(111, 39);
            this.btn_Baja.TabIndex = 128;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = false;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.LightGray;
            this.btn_Salir.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_Salir.Location = new System.Drawing.Point(270, 395);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(111, 39);
            this.btn_Salir.TabIndex = 127;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txt_marca_equipo
            // 
            this.txt_marca_equipo.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marca_equipo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_marca_equipo.Location = new System.Drawing.Point(48, 237);
            this.txt_marca_equipo.Name = "txt_marca_equipo";
            this.txt_marca_equipo.Size = new System.Drawing.Size(215, 27);
            this.txt_marca_equipo.TabIndex = 138;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBox4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.Location = new System.Drawing.Point(48, 206);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 24);
            this.textBox4.TabIndex = 137;
            this.textBox4.Text = "Marca Equipo :";
            // 
            // txt_modelo_equipo
            // 
            this.txt_modelo_equipo.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modelo_equipo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_modelo_equipo.Location = new System.Drawing.Point(48, 325);
            this.txt_modelo_equipo.Name = "txt_modelo_equipo";
            this.txt_modelo_equipo.Size = new System.Drawing.Size(215, 27);
            this.txt_modelo_equipo.TabIndex = 140;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBox5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.Location = new System.Drawing.Point(48, 295);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 24);
            this.textBox5.TabIndex = 139;
            this.textBox5.Text = "Modelo Equipo :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Location = new System.Drawing.Point(403, 206);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 24);
            this.textBox3.TabIndex = 142;
            this.textBox3.Text = "Cliente :";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cliente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(403, 236);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(215, 27);
            this.cmb_cliente.TabIndex = 141;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBox6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox6.Location = new System.Drawing.Point(48, 68);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(95, 24);
            this.textBox6.TabIndex = 145;
            this.textBox6.Text = "IdInventario :";
            // 
            // cmb_idInventario
            // 
            this.cmb_idInventario.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_idInventario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmb_idInventario.FormattingEnabled = true;
            this.cmb_idInventario.Location = new System.Drawing.Point(149, 65);
            this.cmb_idInventario.Name = "cmb_idInventario";
            this.cmb_idInventario.Size = new System.Drawing.Size(95, 27);
            this.cmb_idInventario.TabIndex = 144;
            this.cmb_idInventario.SelectedIndexChanged += new System.EventHandler(this.cmb_idInventario_SelectedIndexChanged);
            // 
            // dateTime_baja
            // 
            this.dateTime_baja.Enabled = false;
            this.dateTime_baja.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_baja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_baja.Location = new System.Drawing.Point(669, 68);
            this.dateTime_baja.Name = "dateTime_baja";
            this.dateTime_baja.Size = new System.Drawing.Size(119, 24);
            this.dateTime_baja.TabIndex = 143;
            // 
            // pInventarioEquipoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.cmb_idInventario);
            this.Controls.Add(this.dateTime_baja);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.txt_modelo_equipo);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txt_marca_equipo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dateTime_alta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmb_tipo_equipo);
            this.Controls.Add(this.txt_num_serie);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_nom_pag);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.btn_Modif);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Salir);
            this.Name = "pInventarioEquipoCliente";
            this.Load += new System.EventHandler(this.pInventarioEquipoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime_alta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmb_tipo_equipo;
        private System.Windows.Forms.TextBox txt_num_serie;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_nom_pag;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modif;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox txt_marca_equipo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txt_modelo_equipo;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox cmb_idInventario;
        private System.Windows.Forms.DateTimePicker dateTime_baja;
    }
}