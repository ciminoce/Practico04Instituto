namespace Ejercicio03.Windows
{
    partial class FrmRectangulos
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
            TxtAnchura = new TextBox();
            label2 = new Label();
            TxtLongitud = new TextBox();
            BtnOk = new Button();
            BtnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            LstRectangulos = new ListBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 48);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Anchura:";
            // 
            // TxtAnchura
            // 
            TxtAnchura.Location = new Point(105, 45);
            TxtAnchura.Name = "TxtAnchura";
            TxtAnchura.Size = new Size(100, 23);
            TxtAnchura.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 86);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Longitud:";
            // 
            // TxtLongitud
            // 
            TxtLongitud.Location = new Point(105, 83);
            TxtLongitud.Name = "TxtLongitud";
            TxtLongitud.Size = new Size(100, 23);
            TxtLongitud.TabIndex = 1;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(47, 126);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 44);
            BtnOk.TabIndex = 2;
            BtnOk.Text = "OK";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(200, 126);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 44);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LstRectangulos
            // 
            LstRectangulos.FormattingEnabled = true;
            LstRectangulos.ItemHeight = 15;
            LstRectangulos.Location = new Point(53, 203);
            LstRectangulos.Name = "LstRectangulos";
            LstRectangulos.Size = new Size(222, 139);
            LstRectangulos.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 185);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Listado";
            // 
            // FrmRectangulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 450);
            Controls.Add(label3);
            Controls.Add(LstRectangulos);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOk);
            Controls.Add(TxtLongitud);
            Controls.Add(label2);
            Controls.Add(TxtAnchura);
            Controls.Add(label1);
            Name = "FrmRectangulos";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtAnchura;
        private Label label2;
        private TextBox TxtLongitud;
        private Button BtnOk;
        private Button BtnCancelar;
        private ErrorProvider errorProvider1;
        private Label label3;
        private ListBox LstRectangulos;
    }
}
