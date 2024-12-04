namespace InterfacePoo
{
    partial class FrmFechaNac
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtDay = new TextBox();
            TxtMonth = new TextBox();
            TxtYear = new TextBox();
            BtnCancelar = new Button();
            BtnAceptar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 17);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su fecha de nacimiento: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 1;
            label2.Text = "Dia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(104, 70);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 2;
            label3.Text = "Mes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(196, 70);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 17);
            label4.TabIndex = 3;
            label4.Text = "Ano:";
            // 
            // TxtDay
            // 
            TxtDay.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDay.Location = new Point(51, 67);
            TxtDay.Margin = new Padding(4, 3, 4, 3);
            TxtDay.Name = "TxtDay";
            TxtDay.Size = new Size(40, 25);
            TxtDay.TabIndex = 4;
            // 
            // TxtMonth
            // 
            TxtMonth.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtMonth.Location = new Point(146, 67);
            TxtMonth.Margin = new Padding(4, 3, 4, 3);
            TxtMonth.Name = "TxtMonth";
            TxtMonth.Size = new Size(40, 25);
            TxtMonth.TabIndex = 5;
            // 
            // TxtYear
            // 
            TxtYear.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TxtYear.Location = new Point(237, 67);
            TxtYear.Margin = new Padding(4, 3, 4, 3);
            TxtYear.Name = "TxtYear";
            TxtYear.Size = new Size(40, 25);
            TxtYear.TabIndex = 6;
            // 
            // BtnCancelar
            // 
            BtnCancelar.DialogResult = DialogResult.Cancel;
            BtnCancelar.Image = InterfaceNewPoo.Properties.Resources.Cancelar;
            BtnCancelar.Location = new Point(177, 119);
            BtnCancelar.Margin = new Padding(4, 3, 4, 3);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(115, 57);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "&Cancelar ";
            BtnCancelar.TextAlign = ContentAlignment.BottomCenter;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Image = InterfaceNewPoo.Properties.Resources.Aceptar2;
            BtnAceptar.Location = new Point(30, 117);
            BtnAceptar.Margin = new Padding(4, 3, 4, 3);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(119, 59);
            BtnAceptar.TabIndex = 7;
            BtnAceptar.Text = "&Aceptar";
            BtnAceptar.TextAlign = ContentAlignment.BottomCenter;
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmFechaNac
            // 
            AcceptButton = BtnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancelar;
            ClientSize = new Size(320, 192);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Controls.Add(TxtYear);
            Controls.Add(TxtMonth);
            Controls.Add(TxtDay);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFechaNac";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validacion de mayoria de edad !";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtDay;
        private TextBox TxtMonth;
        private TextBox TxtYear;
        private Button BtnAceptar;
        private Button BtnCancelar;
        private ErrorProvider errorProvider1;
    }
}

