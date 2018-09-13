namespace sistemaFCNM
{
    partial class Scanner
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
            this.lblCpu = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.lblPantalla = new System.Windows.Forms.Label();
            this.txtTeclado = new System.Windows.Forms.TextBox();
            this.lblTeclado = new System.Windows.Forms.Label();
            this.txtMouse = new System.Windows.Forms.TextBox();
            this.lblMouse = new System.Windows.Forms.Label();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtScanner = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Location = new System.Drawing.Point(115, 122);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(79, 13);
            this.lblCpu.TabIndex = 0;
            this.lblCpu.Text = "Inventario CPU";
            this.lblCpu.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(212, 184);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(185, 32);
            this.txtCode.TabIndex = 3;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(142, 184);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(37, 13);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "CODE";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(212, 252);
            this.txtTag.Multiline = true;
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(185, 32);
            this.txtTag.TabIndex = 5;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(142, 252);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(29, 13);
            this.lblTag.TabIndex = 4;
            this.lblTag.Text = "TAG";
            // 
            // txtPantalla
            // 
            this.txtPantalla.Location = new System.Drawing.Point(212, 329);
            this.txtPantalla.Multiline = true;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(185, 32);
            this.txtPantalla.TabIndex = 7;
            // 
            // lblPantalla
            // 
            this.lblPantalla.AutoSize = true;
            this.lblPantalla.Location = new System.Drawing.Point(111, 332);
            this.lblPantalla.Name = "lblPantalla";
            this.lblPantalla.Size = new System.Drawing.Size(95, 13);
            this.lblPantalla.TabIndex = 6;
            this.lblPantalla.Text = "Inventario Pantalla";
            // 
            // txtTeclado
            // 
            this.txtTeclado.Location = new System.Drawing.Point(566, 119);
            this.txtTeclado.Multiline = true;
            this.txtTeclado.Name = "txtTeclado";
            this.txtTeclado.Size = new System.Drawing.Size(185, 32);
            this.txtTeclado.TabIndex = 9;
            // 
            // lblTeclado
            // 
            this.lblTeclado.AutoSize = true;
            this.lblTeclado.Location = new System.Drawing.Point(464, 122);
            this.lblTeclado.Name = "lblTeclado";
            this.lblTeclado.Size = new System.Drawing.Size(96, 13);
            this.lblTeclado.TabIndex = 8;
            this.lblTeclado.Text = "Inventario Teclado";
            // 
            // txtMouse
            // 
            this.txtMouse.Location = new System.Drawing.Point(566, 184);
            this.txtMouse.Multiline = true;
            this.txtMouse.Name = "txtMouse";
            this.txtMouse.Size = new System.Drawing.Size(185, 32);
            this.txtMouse.TabIndex = 11;
            // 
            // lblMouse
            // 
            this.lblMouse.AutoSize = true;
            this.lblMouse.Location = new System.Drawing.Point(466, 187);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(89, 13);
            this.lblMouse.TabIndex = 10;
            this.lblMouse.Text = "Inventario Mouse";
            // 
            // txtInventario
            // 
            this.txtInventario.Location = new System.Drawing.Point(212, 116);
            this.txtInventario.Multiline = true;
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(185, 32);
            this.txtInventario.TabIndex = 12;
            this.txtInventario.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtInventario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaFCNM.Properties.Resources.pantalla;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtScanner
            // 
            this.txtScanner.Location = new System.Drawing.Point(315, 23);
            this.txtScanner.Multiline = true;
            this.txtScanner.Name = "txtScanner";
            this.txtScanner.Size = new System.Drawing.Size(258, 52);
            this.txtScanner.TabIndex = 14;
            this.txtScanner.TextChanged += new System.EventHandler(this.txtScanner_TextChanged);
            this.txtScanner.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtScanner_KeyUp);
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(856, 472);
            this.Controls.Add(this.txtScanner);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.txtMouse);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.txtTeclado);
            this.Controls.Add(this.lblTeclado);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.lblPantalla);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblCpu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.Load += new System.EventHandler(this.Scanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Label lblPantalla;
        private System.Windows.Forms.TextBox txtTeclado;
        private System.Windows.Forms.Label lblTeclado;
        private System.Windows.Forms.TextBox txtMouse;
        private System.Windows.Forms.Label lblMouse;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtScanner;
    }
}