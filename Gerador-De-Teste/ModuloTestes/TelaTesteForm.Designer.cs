namespace Gerador_De_Teste.ModuloTestes
{
    partial class TelaTesteForm
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
            label4 = new Label();
            numericQtdQuestoes = new NumericUpDown();
            cbmDisciplina = new ComboBox();
            cbmMateria = new ComboBox();
            txtTitulo = new TextBox();
            cbRecuperacao = new CheckBox();
            groupBox1 = new GroupBox();
            listQuestoes = new ListBox();
            btnSortearQuestoes = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericQtdQuestoes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 51);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 83);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 1;
            label2.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 126);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 2;
            label3.Text = "Matéria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(390, 83);
            label4.Name = "label4";
            label4.Size = new Size(135, 28);
            label4.TabIndex = 3;
            label4.Text = "Qtd.Questões:";
            // 
            // numericQtdQuestoes
            // 
            numericQtdQuestoes.Location = new Point(531, 89);
            numericQtdQuestoes.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericQtdQuestoes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQtdQuestoes.Name = "numericQtdQuestoes";
            numericQtdQuestoes.Size = new Size(55, 27);
            numericQtdQuestoes.TabIndex = 3;
            numericQtdQuestoes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericQtdQuestoes.ValueChanged += numericQtdQuestoes_ValueChanged;
            // 
            // cbmDisciplina
            // 
            cbmDisciplina.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmDisciplina.FormattingEnabled = true;
            cbmDisciplina.Location = new Point(113, 88);
            cbmDisciplina.Name = "cbmDisciplina";
            cbmDisciplina.Size = new Size(271, 28);
            cbmDisciplina.TabIndex = 2;
            cbmDisciplina.SelectedIndexChanged += cbmDisciplina_SelectedIndexChanged;
            // 
            // cbmMateria
            // 
            cbmMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbmMateria.Enabled = false;
            cbmMateria.FormattingEnabled = true;
            cbmMateria.Location = new Point(113, 130);
            cbmMateria.Name = "cbmMateria";
            cbmMateria.Size = new Size(271, 28);
            cbmMateria.TabIndex = 4;
            cbmMateria.SelectedIndexChanged += cbmMateria_SelectedIndexChanged_1;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(113, 55);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(473, 27);
            txtTitulo.TabIndex = 1;
            // 
            // cbRecuperacao
            // 
            cbRecuperacao.AutoSize = true;
            cbRecuperacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRecuperacao.Location = new Point(390, 126);
            cbRecuperacao.Name = "cbRecuperacao";
            cbRecuperacao.Size = new Size(227, 32);
            cbRecuperacao.TabIndex = 5;
            cbRecuperacao.Text = "Prova de Recuperação";
            cbRecuperacao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listQuestoes);
            groupBox1.Controls.Add(btnSortearQuestoes);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(599, 496);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // listQuestoes
            // 
            listQuestoes.Dock = DockStyle.Bottom;
            listQuestoes.FormattingEnabled = true;
            listQuestoes.ItemHeight = 28;
            listQuestoes.Location = new Point(3, 69);
            listQuestoes.Name = "listQuestoes";
            listQuestoes.Size = new Size(593, 424);
            listQuestoes.TabIndex = 1;
            // 
            // btnSortearQuestoes
            // 
            btnSortearQuestoes.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSortearQuestoes.Location = new Point(6, 27);
            btnSortearQuestoes.Name = "btnSortearQuestoes";
            btnSortearQuestoes.Size = new Size(157, 36);
            btnSortearQuestoes.TabIndex = 7;
            btnSortearQuestoes.Text = "Sortear Questões";
            btnSortearQuestoes.UseVisualStyleBackColor = true;
            btnSortearQuestoes.Click += btnSortearQuestoes_Click;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(340, 678);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(131, 40);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(477, 678);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(131, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 18);
            label5.Name = "label5";
            label5.Size = new Size(33, 28);
            label5.TabIndex = 12;
            label5.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(113, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(62, 27);
            txtId.TabIndex = 13;
            txtId.Text = "0";
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 733);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(cbRecuperacao);
            Controls.Add(txtTitulo);
            Controls.Add(cbmMateria);
            Controls.Add(cbmDisciplina);
            Controls.Add(numericQtdQuestoes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTesteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Teste";
            ((System.ComponentModel.ISupportInitialize)numericQtdQuestoes).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericQtdQuestoes;
        private ComboBox cbmDisciplina;
        private ComboBox cbmMateria;
        private TextBox txtTitulo;
        private CheckBox cbRecuperacao;
        private GroupBox groupBox1;
        private ListBox listQuestoes;
        private Button btnSortearQuestoes;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label5;
        private TextBox txtId;
    }
}