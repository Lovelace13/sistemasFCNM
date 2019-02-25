namespace sistemaFCNM.Vistas
{
    partial class RegistrarUsuario
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
            this.Nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioAyudante = new System.Windows.Forms.RadioButton();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.txtconfirmPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(72, 70);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(128, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(189, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(128, 142);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(189, 20);
            this.txtUser.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario Espol";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(128, 184);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(189, 20);
            this.txtPass.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // radioAyudante
            // 
            this.radioAyudante.AutoSize = true;
            this.radioAyudante.Location = new System.Drawing.Point(89, 298);
            this.radioAyudante.Name = "radioAyudante";
            this.radioAyudante.Size = new System.Drawing.Size(70, 17);
            this.radioAyudante.TabIndex = 8;
            this.radioAyudante.TabStop = true;
            this.radioAyudante.Text = "Ayudante";
            this.radioAyudante.UseVisualStyleBackColor = true;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Location = new System.Drawing.Point(233, 298);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(88, 17);
            this.radioAdmin.TabIndex = 9;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Administrador";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // txtconfirmPass
            // 
            this.txtconfirmPass.Location = new System.Drawing.Point(128, 227);
            this.txtconfirmPass.Name = "txtconfirmPass";
            this.txtconfirmPass.PasswordChar = '*';
            this.txtconfirmPass.Size = new System.Drawing.Size(189, 20);
            this.txtconfirmPass.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirm Password";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(178, 365);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 12;
            this.btnReg.Text = "Registrar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 522);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtconfirmPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioAdmin);
            this.Controls.Add(this.radioAyudante);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Nombre);
            this.Name = "RegistrarUsuario";
            this.Text = "RegistrarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioAyudante;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.TextBox txtconfirmPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReg;
    }
}