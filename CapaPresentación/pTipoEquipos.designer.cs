
namespace GestInfo.CapaPresentacion
{
    partial class pTipoEquipos
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
            this.txt_nom_tip_equi = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_nom_pag = new System.Windows.Forms.TextBox();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Modif = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cmb_idtipoEquipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_nom_tip_equi
            // 
            this.txt_nom_tip_equi.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom_tip_equi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_nom_tip_equi.Location = new System.Drawing.Point(403, 183);
            this.txt_nom_tip_equi.Name = "txt_nom_tip_equi";
            this.txt_nom_tip_equi.Size = new System.Drawing.Size(215, 27);
            this.txt_nom_tip_equi.TabIndex = 133;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(403, 153);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 24);
            this.textBox2.TabIndex = 132;
            this.textBox2.Text = "Nombre tipo equipo:";
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
            this.txt_nom_pag.Size = new System.Drawing.Size(183, 31);
            this.txt_nom_pag.TabIndex = 131;
            this.txt_nom_pag.Text = "Tipo Equipos";
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
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.textBox6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox6.Location = new System.Drawing.Point(141, 153);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(95, 24);
            this.textBox6.TabIndex = 147;
            this.textBox6.Text = "IdTipoEquipo :";
            // 
            // cmb_idtipoEquipo
            // 
            this.cmb_idtipoEquipo.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_idtipoEquipo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmb_idtipoEquipo.FormattingEnabled = true;
            this.cmb_idtipoEquipo.Location = new System.Drawing.Point(141, 183);
            this.cmb_idtipoEquipo.Name = "cmb_idtipoEquipo";
            this.cmb_idtipoEquipo.Size = new System.Drawing.Size(159, 27);
            this.cmb_idtipoEquipo.TabIndex = 146;
            this.cmb_idtipoEquipo.SelectedIndexChanged += new System.EventHandler(this.cmb_idtipoEquipo_SelectedIndexChanged);
            // 
            // pTipoEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.cmb_idtipoEquipo);
            this.Controls.Add(this.txt_nom_tip_equi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_nom_pag);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.btn_Modif);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Salir);
            this.Name = "pTipoEquipos";
            this.Load += new System.EventHandler(this.pTipoEquipos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nom_tip_equi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_nom_pag;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modif;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox cmb_idtipoEquipo;
    }
}