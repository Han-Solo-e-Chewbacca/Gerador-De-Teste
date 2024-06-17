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
            btnGravar = new Button();
            btnCancelar = new Button();
            checkBoxAlternativaA = new CheckBox();
            checkBoxAlternativaB = new CheckBox();
            checkBoxAlternativaC = new CheckBox();
            checkBoxAlternativaD = new CheckBox();
            groupBox1 = new GroupBox();
            txtD = new TextBox();
            txtC = new TextBox();
            txtB = new TextBox();
            txtA = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            cbAlternativCorreta = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 25);
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
            txtEnunciado.TabIndex = 2;
            // 
            // txtResposta
            // 
            txtResposta.Location = new Point(126, 178);
            txtResposta.Multiline = true;
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(385, 48);
            txtResposta.TabIndex = 3;
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
            cbmMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmMateria.FormattingEnabled = true;
            cbmMateria.Location = new Point(475, 29);
            cbmMateria.Name = "cbmMateria";
            cbmMateria.Size = new Size(232, 28);
            cbmMateria.TabIndex = 1;
            cbmMateria.SelectedIndexChanged += cbmMateria_SelectedIndexChanged;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(431, 474);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(135, 60);
            btnGravar.TabIndex = 11;
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
            btnCancelar.Click += btnCancelar_Click;
            // 
            // checkBoxAlternativaA
            // 
            checkBoxAlternativaA.AutoSize = true;
            checkBoxAlternativaA.Enabled = false;
            checkBoxAlternativaA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxAlternativaA.Location = new Point(6, 26);
            checkBoxAlternativaA.Name = "checkBoxAlternativaA";
            checkBoxAlternativaA.Size = new Size(69, 32);
            checkBoxAlternativaA.TabIndex = 11;
            checkBoxAlternativaA.Text = "A->";
            checkBoxAlternativaA.UseVisualStyleBackColor = true;
            checkBoxAlternativaA.CheckedChanged += checkBoxAlternativaA_CheckedChanged;
            // 
            // checkBoxAlternativaB
            // 
            checkBoxAlternativaB.AutoSize = true;
            checkBoxAlternativaB.Enabled = false;
            checkBoxAlternativaB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxAlternativaB.Location = new Point(8, 64);
            checkBoxAlternativaB.Name = "checkBoxAlternativaB";
            checkBoxAlternativaB.Size = new Size(67, 32);
            checkBoxAlternativaB.TabIndex = 12;
            checkBoxAlternativaB.Text = "B->";
            checkBoxAlternativaB.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlternativaC
            // 
            checkBoxAlternativaC.AutoSize = true;
            checkBoxAlternativaC.Enabled = false;
            checkBoxAlternativaC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxAlternativaC.Location = new Point(6, 102);
            checkBoxAlternativaC.Name = "checkBoxAlternativaC";
            checkBoxAlternativaC.Size = new Size(68, 32);
            checkBoxAlternativaC.TabIndex = 13;
            checkBoxAlternativaC.Text = "C->";
            checkBoxAlternativaC.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlternativaD
            // 
            checkBoxAlternativaD.AutoSize = true;
            checkBoxAlternativaD.Enabled = false;
            checkBoxAlternativaD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxAlternativaD.Location = new Point(6, 140);
            checkBoxAlternativaD.Name = "checkBoxAlternativaD";
            checkBoxAlternativaD.Size = new Size(70, 32);
            checkBoxAlternativaD.TabIndex = 14;
            checkBoxAlternativaD.Text = "D->";
            checkBoxAlternativaD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtD);
            groupBox1.Controls.Add(txtC);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(checkBoxAlternativaD);
            groupBox1.Controls.Add(checkBoxAlternativaA);
            groupBox1.Controls.Add(checkBoxAlternativaC);
            groupBox1.Controls.Add(checkBoxAlternativaB);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(4, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(703, 204);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alternativas";
            // 
            // txtD
            // 
            txtD.Location = new Point(71, 138);
            txtD.Name = "txtD";
            txtD.Size = new Size(602, 34);
            txtD.TabIndex = 9;
            // 
            // txtC
            // 
            txtC.Location = new Point(71, 100);
            txtC.Name = "txtC";
            txtC.Size = new Size(602, 34);
            txtC.TabIndex = 8;
            // 
            // txtB
            // 
            txtB.Location = new Point(71, 62);
            txtB.Name = "txtB";
            txtB.Size = new Size(602, 34);
            txtB.TabIndex = 7;
            txtB.TextChanged += txtB_TextChanged;
            // 
            // txtA
            // 
            txtA.Location = new Point(71, 26);
            txtA.Name = "txtA";
            txtA.Size = new Size(602, 34);
            txtA.TabIndex = 6;
            txtA.TextChanged += txtA_TextChanged;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(126, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 16;
            txtId.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(87, 26);
            label4.Name = "label4";
            label4.Size = new Size(33, 28);
            label4.TabIndex = 17;
            label4.Text = "Id:";
            label4.Click += label4_Click;
            // 
            // cbAlternativCorreta
            // 
            cbAlternativCorreta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAlternativCorreta.FormattingEnabled = true;
            cbAlternativCorreta.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cbAlternativCorreta.Location = new Point(528, 189);
            cbAlternativCorreta.Name = "cbAlternativCorreta";
            cbAlternativCorreta.Size = new Size(53, 28);
            cbAlternativCorreta.TabIndex = 4;
            // 
            // TelaQuestaoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 560);
            Controls.Add(cbAlternativCorreta);
            Controls.Add(label4);
            Controls.Add(txtId);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(cbmMateria);
            Controls.Add(btnAdicionar);
            Controls.Add(txtResposta);
            Controls.Add(txtEnunciado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaQuestaoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Questões";
            Load += TelaQuestaoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btnGravar;
        private Button btnCancelar;
        private CheckBox checkBoxAlternativaA;
        private CheckBox checkBoxAlternativaB;
        private CheckBox checkBoxAlternativaC;
        private CheckBox checkBoxAlternativaD;
        private GroupBox groupBox1;
        private TextBox txtId;
        private Label label4;
        private TextBox txtD;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private ComboBox cbAlternativCorreta;
    }
}