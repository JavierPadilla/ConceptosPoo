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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDay = new System.Windows.Forms.TextBox();
            this.TxtMonth = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su fecha de nacimiento: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano:";
            // 
            // TxtDay
            // 
            this.TxtDay.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDay.Location = new System.Drawing.Point(44, 58);
            this.TxtDay.Name = "TxtDay";
            this.TxtDay.Size = new System.Drawing.Size(35, 25);
            this.TxtDay.TabIndex = 4;
            // 
            // TxtMonth
            // 
            this.TxtMonth.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonth.Location = new System.Drawing.Point(125, 58);
            this.TxtMonth.Name = "TxtMonth";
            this.TxtMonth.Size = new System.Drawing.Size(35, 25);
            this.TxtMonth.TabIndex = 5;
            // 
            // TxtYear
            // 
            this.TxtYear.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYear.Location = new System.Drawing.Point(203, 58);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(35, 25);
            this.TxtYear.TabIndex = 6;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Image = global::InterfacePoo.Properties.Resources.Aceptar2;
            this.BtnAceptar.Location = new System.Drawing.Point(24, 101);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(102, 51);
            this.BtnAceptar.TabIndex = 7;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Image = global::InterfacePoo.Properties.Resources.Cancelar;
            this.BtnCancelar.Location = new System.Drawing.Point(152, 103);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 49);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "&Cancelar ";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmFechaNac
            // 
            this.AcceptButton = this.BtnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(274, 166);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.TxtMonth);
            this.Controls.Add(this.TxtDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFechaNac";
            this.Text = "Validacion de mayoria de edad !";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.TextBox TxtMonth;
        private System.Windows.Forms.TextBox TxtDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

