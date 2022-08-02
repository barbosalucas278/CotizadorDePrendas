
namespace ExamenQuarkCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckChupin = new System.Windows.Forms.CheckBox();
            this.CheckCuelloMao = new System.Windows.Forms.CheckBox();
            this.CheckMangaCorta = new System.Windows.Forms.CheckBox();
            this.RadioPantalon = new System.Windows.Forms.RadioButton();
            this.RadioCamisa = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadioCalidadPremium = new System.Windows.Forms.RadioButton();
            this.RadioCalidadStandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBoxCantidad = new System.Windows.Forms.TextBox();
            this.TextBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelNombreEmpresa = new System.Windows.Forms.Label();
            this.LabelDireccionEmpresa = new System.Windows.Forms.Label();
            this.LabelDatosVendedor = new System.Windows.Forms.Label();
            this.LabelLinkHistorial = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LabelStockDisponible = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ButtomCotizar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.LabelMonto = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckChupin);
            this.groupBox1.Controls.Add(this.CheckCuelloMao);
            this.groupBox1.Controls.Add(this.CheckMangaCorta);
            this.groupBox1.Controls.Add(this.RadioPantalon);
            this.groupBox1.Controls.Add(this.RadioCamisa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            // 
            // CheckChupin
            // 
            this.CheckChupin.AutoSize = true;
            this.CheckChupin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckChupin.Location = new System.Drawing.Point(182, 134);
            this.CheckChupin.Name = "CheckChupin";
            this.CheckChupin.Size = new System.Drawing.Size(71, 21);
            this.CheckChupin.TabIndex = 6;
            this.CheckChupin.Text = "Chupín";
            this.CheckChupin.UseVisualStyleBackColor = true;
            this.CheckChupin.CheckedChanged += new System.EventHandler(this.CheckChupin_CheckedChanged);
            // 
            // CheckCuelloMao
            // 
            this.CheckCuelloMao.AutoSize = true;
            this.CheckCuelloMao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCuelloMao.Location = new System.Drawing.Point(321, 47);
            this.CheckCuelloMao.Name = "CheckCuelloMao";
            this.CheckCuelloMao.Size = new System.Drawing.Size(97, 21);
            this.CheckCuelloMao.TabIndex = 5;
            this.CheckCuelloMao.Text = "Cuello Mao";
            this.CheckCuelloMao.UseVisualStyleBackColor = true;
            this.CheckCuelloMao.CheckedChanged += new System.EventHandler(this.CheckCuelloMao_CheckedChanged);
            // 
            // CheckMangaCorta
            // 
            this.CheckMangaCorta.AutoSize = true;
            this.CheckMangaCorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckMangaCorta.Location = new System.Drawing.Point(182, 47);
            this.CheckMangaCorta.Name = "CheckMangaCorta";
            this.CheckMangaCorta.Size = new System.Drawing.Size(108, 21);
            this.CheckMangaCorta.TabIndex = 4;
            this.CheckMangaCorta.Text = "Manga Corta";
            this.CheckMangaCorta.UseVisualStyleBackColor = true;
            this.CheckMangaCorta.CheckedChanged += new System.EventHandler(this.CheckMangaCorta_CheckedChanged);
            // 
            // RadioPantalon
            // 
            this.RadioPantalon.AutoSize = true;
            this.RadioPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioPantalon.Location = new System.Drawing.Point(34, 133);
            this.RadioPantalon.Name = "RadioPantalon";
            this.RadioPantalon.Size = new System.Drawing.Size(82, 21);
            this.RadioPantalon.TabIndex = 3;
            this.RadioPantalon.Text = "Pantalon";
            this.RadioPantalon.UseVisualStyleBackColor = true;
            this.RadioPantalon.CheckedChanged += new System.EventHandler(this.RadioPantalon_CheckedChanged);
            // 
            // RadioCamisa
            // 
            this.RadioCamisa.BackColor = System.Drawing.SystemColors.Control;
            this.RadioCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioCamisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RadioCamisa.Location = new System.Drawing.Point(34, 37);
            this.RadioCamisa.Name = "RadioCamisa";
            this.RadioCamisa.Size = new System.Drawing.Size(96, 35);
            this.RadioCamisa.TabIndex = 2;
            this.RadioCamisa.Text = "Camisa";
            this.RadioCamisa.UseVisualStyleBackColor = false;
            this.RadioCamisa.CheckedChanged += new System.EventHandler(this.RadioCamisa_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 2);
            this.label2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadioCalidadPremium);
            this.groupBox2.Controls.Add(this.RadioCalidadStandard);
            this.groupBox2.Location = new System.Drawing.Point(12, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 67);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de Prenda";
            // 
            // RadioCalidadPremium
            // 
            this.RadioCalidadPremium.AutoSize = true;
            this.RadioCalidadPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioCalidadPremium.Location = new System.Drawing.Point(109, 30);
            this.RadioCalidadPremium.Name = "RadioCalidadPremium";
            this.RadioCalidadPremium.Size = new System.Drawing.Size(81, 21);
            this.RadioCalidadPremium.TabIndex = 1;
            this.RadioCalidadPremium.Text = "Premium";
            this.RadioCalidadPremium.UseVisualStyleBackColor = true;
            // 
            // RadioCalidadStandard
            // 
            this.RadioCalidadStandard.AutoSize = true;
            this.RadioCalidadStandard.Checked = true;
            this.RadioCalidadStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioCalidadStandard.Location = new System.Drawing.Point(17, 30);
            this.RadioCalidadStandard.Name = "RadioCalidadStandard";
            this.RadioCalidadStandard.Size = new System.Drawing.Size(84, 21);
            this.RadioCalidadStandard.TabIndex = 0;
            this.RadioCalidadStandard.TabStop = true;
            this.RadioCalidadStandard.Text = "Standard";
            this.RadioCalidadStandard.UseVisualStyleBackColor = true;
            this.RadioCalidadStandard.CheckedChanged += new System.EventHandler(this.RadioCalidadStandard_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBoxCantidad);
            this.groupBox3.Controls.Add(this.TextBoxPrecioUnitario);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(259, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 67);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio unitario y cantidad";
            // 
            // TextBoxCantidad
            // 
            this.TextBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCantidad.Location = new System.Drawing.Point(148, 24);
            this.TextBoxCantidad.Multiline = true;
            this.TextBoxCantidad.Name = "TextBoxCantidad";
            this.TextBoxCantidad.Size = new System.Drawing.Size(56, 28);
            this.TextBoxCantidad.TabIndex = 3;
            // 
            // TextBoxPrecioUnitario
            // 
            this.TextBoxPrecioUnitario.Enabled = false;
            this.TextBoxPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPrecioUnitario.Location = new System.Drawing.Point(26, 24);
            this.TextBoxPrecioUnitario.Multiline = true;
            this.TextBoxPrecioUnitario.Name = "TextBoxPrecioUnitario";
            this.TextBoxPrecioUnitario.Size = new System.Drawing.Size(56, 28);
            this.TextBoxPrecioUnitario.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(87, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(7, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "$";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 2);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(19, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 2);
            this.label3.TabIndex = 5;
            // 
            // LabelNombreEmpresa
            // 
            this.LabelNombreEmpresa.AutoSize = true;
            this.LabelNombreEmpresa.BackColor = System.Drawing.SystemColors.Control;
            this.LabelNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreEmpresa.ForeColor = System.Drawing.Color.Purple;
            this.LabelNombreEmpresa.Location = new System.Drawing.Point(32, 9);
            this.LabelNombreEmpresa.Name = "LabelNombreEmpresa";
            this.LabelNombreEmpresa.Size = new System.Drawing.Size(133, 13);
            this.LabelNombreEmpresa.TabIndex = 6;
            this.LabelNombreEmpresa.Text = "Nombre de la empresa";
            // 
            // LabelDireccionEmpresa
            // 
            this.LabelDireccionEmpresa.AutoSize = true;
            this.LabelDireccionEmpresa.BackColor = System.Drawing.SystemColors.Control;
            this.LabelDireccionEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDireccionEmpresa.ForeColor = System.Drawing.Color.Purple;
            this.LabelDireccionEmpresa.Location = new System.Drawing.Point(279, 9);
            this.LabelDireccionEmpresa.Name = "LabelDireccionEmpresa";
            this.LabelDireccionEmpresa.Size = new System.Drawing.Size(144, 13);
            this.LabelDireccionEmpresa.TabIndex = 7;
            this.LabelDireccionEmpresa.Text = "Direccion de la empresa";
            // 
            // LabelDatosVendedor
            // 
            this.LabelDatosVendedor.AutoSize = true;
            this.LabelDatosVendedor.ForeColor = System.Drawing.Color.Indigo;
            this.LabelDatosVendedor.Location = new System.Drawing.Point(31, 43);
            this.LabelDatosVendedor.Name = "LabelDatosVendedor";
            this.LabelDatosVendedor.Size = new System.Drawing.Size(243, 13);
            this.LabelDatosVendedor.TabIndex = 8;
            this.LabelDatosVendedor.Text = "Nombre y apellido vendedor | Codigo de vendedor";
            // 
            // LabelLinkHistorial
            // 
            this.LabelLinkHistorial.AutoSize = true;
            this.LabelLinkHistorial.ForeColor = System.Drawing.Color.Indigo;
            this.LabelLinkHistorial.Location = new System.Drawing.Point(321, 42);
            this.LabelLinkHistorial.Name = "LabelLinkHistorial";
            this.LabelLinkHistorial.Size = new System.Drawing.Size(107, 13);
            this.LabelLinkHistorial.TabIndex = 9;
            this.LabelLinkHistorial.TabStop = true;
            this.LabelLinkHistorial.Text = "Historial Cotizaciones";
            this.LabelLinkHistorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelLinkHistorial_LinkClicked);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(456, 36);
            this.label7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Unidades de Stock disponibles:";
            // 
            // LabelStockDisponible
            // 
            this.LabelStockDisponible.AutoSize = true;
            this.LabelStockDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStockDisponible.Location = new System.Drawing.Point(244, 299);
            this.LabelStockDisponible.Name = "LabelStockDisponible";
            this.LabelStockDisponible.Size = new System.Drawing.Size(17, 17);
            this.LabelStockDisponible.TabIndex = 12;
            this.LabelStockDisponible.Text = "0";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(0, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(481, 2);
            this.label12.TabIndex = 13;
            // 
            // ButtomCotizar
            // 
            this.ButtomCotizar.BackColor = System.Drawing.Color.Violet;
            this.ButtomCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtomCotizar.Location = new System.Drawing.Point(12, 435);
            this.ButtomCotizar.Name = "ButtomCotizar";
            this.ButtomCotizar.Size = new System.Drawing.Size(209, 46);
            this.ButtomCotizar.TabIndex = 14;
            this.ButtomCotizar.Text = "Cotizar";
            this.ButtomCotizar.UseVisualStyleBackColor = false;
            this.ButtomCotizar.Click += new System.EventHandler(this.ButtomCotizar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(255, 446);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 29);
            this.label13.TabIndex = 15;
            this.label13.Text = "$";
            // 
            // LabelMonto
            // 
            this.LabelMonto.AutoSize = true;
            this.LabelMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMonto.Location = new System.Drawing.Point(303, 453);
            this.LabelMonto.Name = "LabelMonto";
            this.LabelMonto.Size = new System.Drawing.Size(0, 17);
            this.LabelMonto.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(282, 473);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 2);
            this.label15.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 493);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LabelMonto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ButtomCotizar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LabelStockDisponible);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LabelLinkHistorial);
            this.Controls.Add(this.LabelDatosVendedor);
            this.Controls.Add(this.LabelDireccionEmpresa);
            this.Controls.Add(this.LabelNombreEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizador Express";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelNombreEmpresa;
        private System.Windows.Forms.Label LabelDireccionEmpresa;
        private System.Windows.Forms.Label LabelDatosVendedor;
        private System.Windows.Forms.CheckBox CheckChupin;
        private System.Windows.Forms.CheckBox CheckCuelloMao;
        private System.Windows.Forms.CheckBox CheckMangaCorta;
        private System.Windows.Forms.RadioButton RadioPantalon;
        private System.Windows.Forms.RadioButton RadioCamisa;
        private System.Windows.Forms.RadioButton RadioCalidadPremium;
        private System.Windows.Forms.RadioButton RadioCalidadStandard;
        private System.Windows.Forms.TextBox TextBoxCantidad;
        private System.Windows.Forms.TextBox TextBoxPrecioUnitario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel LabelLinkHistorial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LabelStockDisponible;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ButtomCotizar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LabelMonto;
        private System.Windows.Forms.Label label15;
    }
}

