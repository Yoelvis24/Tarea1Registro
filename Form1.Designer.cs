
namespace DibujarFormularioTarea1
{
    partial class Registro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aliasLabel = new System.Windows.Forms.Label();
            this.nombresLabel = new System.Windows.Forms.Label();
            this.claveLabel = new System.Windows.Forms.Label();
            this.confClaveLabel = new System.Windows.Forms.Label();
            this.nivelLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.costoLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.aliasTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.costoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.nivelComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.confClaveTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(37, 41);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 15);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // aliasLabel
            // 
            this.aliasLabel.AutoSize = true;
            this.aliasLabel.Location = new System.Drawing.Point(37, 81);
            this.aliasLabel.Name = "aliasLabel";
            this.aliasLabel.Size = new System.Drawing.Size(32, 15);
            this.aliasLabel.TabIndex = 2;
            this.aliasLabel.Text = "Alias";
            // 
            // nombresLabel
            // 
            this.nombresLabel.AutoSize = true;
            this.nombresLabel.Location = new System.Drawing.Point(37, 122);
            this.nombresLabel.Name = "nombresLabel";
            this.nombresLabel.Size = new System.Drawing.Size(56, 15);
            this.nombresLabel.TabIndex = 3;
            this.nombresLabel.Text = "Nombres";
            // 
            // claveLabel
            // 
            this.claveLabel.AutoSize = true;
            this.claveLabel.Location = new System.Drawing.Point(37, 162);
            this.claveLabel.Name = "claveLabel";
            this.claveLabel.Size = new System.Drawing.Size(36, 15);
            this.claveLabel.TabIndex = 4;
            this.claveLabel.Text = "Clave";
            // 
            // confClaveLabel
            // 
            this.confClaveLabel.AutoSize = true;
            this.confClaveLabel.Location = new System.Drawing.Point(247, 162);
            this.confClaveLabel.Name = "confClaveLabel";
            this.confClaveLabel.Size = new System.Drawing.Size(93, 15);
            this.confClaveLabel.TabIndex = 5;
            this.confClaveLabel.Text = "Confirmar Clave";
            // 
            // nivelLabel
            // 
            this.nivelLabel.AutoSize = true;
            this.nivelLabel.Location = new System.Drawing.Point(499, 81);
            this.nivelLabel.Name = "nivelLabel";
            this.nivelLabel.Size = new System.Drawing.Size(34, 15);
            this.nivelLabel.TabIndex = 6;
            this.nivelLabel.Text = "Nivel";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(400, 122);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "Email";
            // 
            // costoLabel
            // 
            this.costoLabel.AutoSize = true;
            this.costoLabel.Location = new System.Drawing.Point(479, 162);
            this.costoLabel.Name = "costoLabel";
            this.costoLabel.Size = new System.Drawing.Size(76, 15);
            this.costoLabel.TabIndex = 8;
            this.costoLabel.Text = "Costo x Hora";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(101, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 23);
            this.idTextBox.TabIndex = 9;
            // 
            // aliasTextBox
            // 
            this.aliasTextBox.Location = new System.Drawing.Point(101, 78);
            this.aliasTextBox.Name = "aliasTextBox";
            this.aliasTextBox.Size = new System.Drawing.Size(168, 23);
            this.aliasTextBox.TabIndex = 10;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(101, 119);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(293, 23);
            this.nombresTextBox.TabIndex = 11;
            // 
            // costoTextBox
            // 
            this.costoTextBox.Location = new System.Drawing.Point(561, 159);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(113, 23);
            this.costoTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(442, 119);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(232, 23);
            this.emailTextBox.TabIndex = 15;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.AutoSize = true;
            this.activoCheckBox.Location = new System.Drawing.Point(614, 40);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.activoCheckBox.TabIndex = 17;
            this.activoCheckBox.Text = "Activo";
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // nivelComboBox
            // 
            this.nivelComboBox.FormattingEnabled = true;
            this.nivelComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Profesor",
            "Estudiante"});
            this.nivelComboBox.Location = new System.Drawing.Point(539, 78);
            this.nivelComboBox.Name = "nivelComboBox";
            this.nivelComboBox.Size = new System.Drawing.Size(135, 23);
            this.nivelComboBox.TabIndex = 18;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(207, 33);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(33, 31);
            this.BuscarButton.TabIndex = 21;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(193, 214);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(103, 59);
            this.NuevoButton.TabIndex = 22;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(333, 214);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(103, 59);
            this.GuardarButton.TabIndex = 23;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(469, 214);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(103, 59);
            this.EliminarButton.TabIndex = 24;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // confClaveTextBox
            // 
            this.confClaveTextBox.Location = new System.Drawing.Point(346, 159);
            this.confClaveTextBox.Name = "confClaveTextBox";
            this.confClaveTextBox.PasswordChar = '*';
            this.confClaveTextBox.Size = new System.Drawing.Size(127, 23);
            this.confClaveTextBox.TabIndex = 25;
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(101, 159);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(140, 23);
            this.claveTextBox.TabIndex = 26;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 312);
            this.Controls.Add(this.claveTextBox);
            this.Controls.Add(this.confClaveTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.nivelComboBox);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(this.aliasTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.costoLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nivelLabel);
            this.Controls.Add(this.confClaveLabel);
            this.Controls.Add(this.claveLabel);
            this.Controls.Add(this.nombresLabel);
            this.Controls.Add(this.aliasLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registros de Usuarios";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aliasLabel;
        private System.Windows.Forms.Label nombresLabel;
        private System.Windows.Forms.Label claveLabel;
        private System.Windows.Forms.Label confClaveLabel;
        private System.Windows.Forms.Label nivelLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label costoLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox aliasTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox costoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.ComboBox nivelComboBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.TextBox confClaveTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
    }
}

