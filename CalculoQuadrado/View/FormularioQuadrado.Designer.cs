namespace CalculoQuadrado.View
{
    partial class FormularioQuadrado
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
            label1 = new Label();
            label2 = new Label();
            tbx_Valor = new TextBox();
            tbx_Resultado = new Label();
            btn_Calcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 WGL4 BT", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(506, 48);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Cáculo Quadrado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(95, 143);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 1;
            label2.Text = "Digite o valor :";
            // 
            // tbx_Valor
            // 
            tbx_Valor.Location = new Point(211, 145);
            tbx_Valor.Name = "tbx_Valor";
            tbx_Valor.Size = new Size(103, 23);
            tbx_Valor.TabIndex = 2;
            // 
            // tbx_Resultado
            // 
            tbx_Resultado.BackColor = SystemColors.MenuHighlight;
            tbx_Resultado.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_Resultado.Location = new Point(36, 233);
            tbx_Resultado.Name = "tbx_Resultado";
            tbx_Resultado.Size = new Size(451, 175);
            tbx_Resultado.TabIndex = 3;
            tbx_Resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location = new Point(36, 198);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(451, 23);
            btn_Calcular.TabIndex = 4;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // FormularioQuadrado
            // 
            AcceptButton = btn_Calcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(btn_Calcular);
            Controls.Add(tbx_Resultado);
            Controls.Add(tbx_Valor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormularioQuadrado";
            ShowIcon = false;
            Text = "FormularioQuadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbx_Valor;
        private Label tbx_Resultado;
        private Button btn_Calcular;
    }
}