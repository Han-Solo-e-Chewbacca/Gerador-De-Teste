namespace Gerador_De_Teste.ModuloQuestoes
{
    partial class TelaQuestaoForm
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
            label3 = new Label();
            txtEnunciado = new TextBox();
            txtResposta = new TextBox();
            btnAdicionar = new Button();
            cbmMateria = new ComboBox();
            groupBox1 = new GroupBox();
            checkedListBox1 = new CheckedListBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 0;
            label1.Text = "Matéria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 76);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 1;
            label2.Text = "Enunciado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 178);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 2;
            label3.Text = "Resposta:";
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(126, 76);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(581, 96);
            txtEnunciado.TabIndex = 3;
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(126, 178);
            txtResposta.Multiline = true;
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(465, 48);
            txtResposta.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(597, 178);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(110, 48);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button1_Click;
            // 
            // cbmMateria
            // 
            cbmMateria.FormattingEnabled = true;
            cbmMateria.Location = new Point(126, 34);
            cbmMateria.Name = "cbmMateria";
            cbmMateria.Size = new Size(232, 28);
            cbmMateria.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(26, 249);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(681, 194);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alternativas:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.Control;
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "(A)->", "(B)->", "(C)->", "(D)->" });
            checkedListBox1.Location = new Point(3, 30);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(675, 161);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(431, 474);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(135, 60);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.OK;
            btnCancelar.Location = new Point(572, 474);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 60);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 560);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(cbmMateria);
            Controls.Add(btnAdicionar);
            Controls.Add(txtResposta);
            Controls.Add(txtEnunciado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaQuestaoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Questões";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEnunciado;
        private TextBox txtResposta;
        private Button btnAdicionar;
        private ComboBox cbmMateria;
        private GroupBox groupBox1;
        private CheckedListBox checkedListBox1;
        private Button btnGravar;
        private Button btnCancelar;
    }
}