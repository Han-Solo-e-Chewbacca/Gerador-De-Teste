namespace Gerador_De_Teste.ModuloTestes
{
    partial class TelaPDFForm
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
            txtNomeDoArquivo = new TextBox();
            label1 = new Label();
            btnGerar = new Button();
            btnCancelar = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // txtNomeDoArquivo
            // 
            txtNomeDoArquivo.Location = new Point(12, 57);
            txtNomeDoArquivo.Name = "txtNomeDoArquivo";
            txtNomeDoArquivo.Size = new Size(475, 27);
            txtNomeDoArquivo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(282, 28);
            label1.TabIndex = 1;
            label1.Text = "Digite o nome do arquivo PDF:";
            // 
            // btnGerar
            // 
            btnGerar.DialogResult = DialogResult.OK;
            btnGerar.Location = new Point(190, 124);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(138, 34);
            btnGerar.TabIndex = 2;
            btnGerar.Text = "Gerar Arquivo";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(334, 124);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(153, 34);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(188, 86);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(286, 32);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Deseja gerar com  respostas?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // TelaPDFForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 170);
            Controls.Add(checkBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGerar);
            Controls.Add(label1);
            Controls.Add(txtNomeDoArquivo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPDFForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gerador de PDF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeDoArquivo;
        private Label label1;
        private Button btnGerar;
        private Button btnCancelar;
        private CheckBox checkBox1;
    }
}