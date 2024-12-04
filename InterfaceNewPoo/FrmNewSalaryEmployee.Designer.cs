namespace InterfaceNewPoo
{
    partial class FrmNewSalaryEmployee
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
            BtnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtId = new TextBox();
            TxtNombres = new TextBox();
            TxtApellidos = new TextBox();
            TxtFNacDia = new TextBox();
            TxtFNacMes = new TextBox();
            TxtFNacYear = new TextBox();
            TxtFHirinYear = new TextBox();
            TxtFHirinMes = new TextBox();
            TxtFHirinDay = new TextBox();
            label6 = new Label();
            label7 = new Label();
            BtnSalir = new Button();
            TxtSalaryPorDay = new TextBox();
            TxtNDias = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(278, 109);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(116, 24);
            BtnCalcular.TabIndex = 11;
            BtnCalcular.Text = "&Calcular nomina";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 18);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 18);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 59);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 57);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 13;
            label5.Text = "Fecha de contratacion";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(40, 15);
            TxtId.Name = "TxtId";
            TxtId.PlaceholderText = "1270002";
            TxtId.Size = new Size(58, 23);
            TxtId.TabIndex = 0;
            // 
            // TxtNombres
            // 
            TxtNombres.Location = new Point(166, 15);
            TxtNombres.Name = "TxtNombres";
            TxtNombres.Size = new Size(178, 23);
            TxtNombres.TabIndex = 1;
            // 
            // TxtApellidos
            // 
            TxtApellidos.Location = new Point(412, 15);
            TxtApellidos.Name = "TxtApellidos";
            TxtApellidos.Size = new Size(253, 23);
            TxtApellidos.TabIndex = 2;
            // 
            // TxtFNacDia
            // 
            TxtFNacDia.Location = new Point(152, 56);
            TxtFNacDia.Name = "TxtFNacDia";
            TxtFNacDia.PlaceholderText = "Dia";
            TxtFNacDia.Size = new Size(29, 23);
            TxtFNacDia.TabIndex = 3;
            // 
            // TxtFNacMes
            // 
            TxtFNacMes.Location = new Point(187, 56);
            TxtFNacMes.Name = "TxtFNacMes";
            TxtFNacMes.PlaceholderText = "Mes";
            TxtFNacMes.Size = new Size(29, 23);
            TxtFNacMes.TabIndex = 4;
            // 
            // TxtFNacYear
            // 
            TxtFNacYear.Location = new Point(222, 56);
            TxtFNacYear.Name = "TxtFNacYear";
            TxtFNacYear.PlaceholderText = "An'o";
            TxtFNacYear.Size = new Size(57, 23);
            TxtFNacYear.TabIndex = 5;
            // 
            // TxtFHirinYear
            // 
            TxtFHirinYear.Location = new Point(500, 51);
            TxtFHirinYear.Name = "TxtFHirinYear";
            TxtFHirinYear.PlaceholderText = "An'o";
            TxtFHirinYear.Size = new Size(68, 23);
            TxtFHirinYear.TabIndex = 8;
            // 
            // TxtFHirinMes
            // 
            TxtFHirinMes.Location = new Point(465, 51);
            TxtFHirinMes.Name = "TxtFHirinMes";
            TxtFHirinMes.PlaceholderText = "Mes";
            TxtFHirinMes.Size = new Size(29, 23);
            TxtFHirinMes.TabIndex = 7;
            // 
            // TxtFHirinDay
            // 
            TxtFHirinDay.Location = new Point(433, 51);
            TxtFHirinDay.Name = "TxtFHirinDay";
            TxtFHirinDay.PlaceholderText = "Dia";
            TxtFHirinDay.Size = new Size(29, 23);
            TxtFHirinDay.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 114);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 18;
            label6.Text = "Salario Diario: $";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 150);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 19;
            label7.Text = "Dias Trabajados :";
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(549, 145);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(116, 24);
            BtnSalir.TabIndex = 12;
            BtnSalir.Text = "&Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // TxtSalaryPorDay
            // 
            TxtSalaryPorDay.Location = new Point(114, 111);
            TxtSalaryPorDay.Name = "TxtSalaryPorDay";
            TxtSalaryPorDay.PlaceholderText = "Mayor al salario minimo";
            TxtSalaryPorDay.Size = new Size(135, 23);
            TxtSalaryPorDay.TabIndex = 9;
            // 
            // TxtNDias
            // 
            TxtNDias.Location = new Point(121, 145);
            TxtNDias.Name = "TxtNDias";
            TxtNDias.PlaceholderText = "1";
            TxtNDias.Size = new Size(39, 23);
            TxtNDias.TabIndex = 10;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmNewSalaryEmployee
            // 
            AcceptButton = BtnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnSalir;
            ClientSize = new Size(673, 183);
            Controls.Add(TxtNDias);
            Controls.Add(TxtSalaryPorDay);
            Controls.Add(BtnSalir);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TxtFHirinMes);
            Controls.Add(TxtFHirinYear);
            Controls.Add(TxtFHirinDay);
            Controls.Add(TxtFNacYear);
            Controls.Add(TxtFNacMes);
            Controls.Add(TxtFNacDia);
            Controls.Add(TxtApellidos);
            Controls.Add(TxtNombres);
            Controls.Add(TxtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnCalcular);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNewSalaryEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Captura empleado por salario";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtId;
        private TextBox TxtNombres;
        private TextBox TxtApellidos;
        private TextBox TxtFNacDia;
        private TextBox TxtFNacMes;
        private TextBox TxtFNacYear;
        private TextBox TxtFHirinYear;
        private TextBox TxtFHirinMes;
        private TextBox TxtFHirinDay;
        private Label label6;
        private Label label7;
        private Button BtnSalir;
        private TextBox TxtSalaryPorDay;
        private TextBox TxtNDias;
        private ErrorProvider errorProvider1;
    }
}