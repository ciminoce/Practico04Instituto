namespace Ejercicio01.Windows
{
    partial class FrmCuadrado
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            TxtLado = new TextBox();
            BtnOK = new Button();
            BtnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            LstCuadrados = new ListBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 47);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado del Cuadrado:";
            // 
            // TxtLado
            // 
            TxtLado.Location = new Point(156, 44);
            TxtLado.Name = "TxtLado";
            TxtLado.Size = new Size(100, 23);
            TxtLado.TabIndex = 1;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(40, 86);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(75, 46);
            BtnOK.TabIndex = 2;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(181, 86);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 46);
            BtnCancelar.TabIndex = 2;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 152);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 3;
            label2.Text = "Cuadrados Ingresados";
            // 
            // LstCuadrados
            // 
            LstCuadrados.FormattingEnabled = true;
            LstCuadrados.ItemHeight = 15;
            LstCuadrados.Location = new Point(58, 184);
            LstCuadrados.Name = "LstCuadrados";
            LstCuadrados.Size = new Size(165, 94);
            LstCuadrados.TabIndex = 4;
            // 
            // FrmCuadrado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 365);
            Controls.Add(LstCuadrados);
            Controls.Add(label2);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOK);
            Controls.Add(TxtLado);
            Controls.Add(label1);
            Name = "FrmCuadrado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formularios de Cuadrados";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtLado;
        private Button BtnOK;
        private Button BtnCancelar;
        private ErrorProvider errorProvider1;
        private ListBox LstCuadrados;
        private Label label2;
    }
}
