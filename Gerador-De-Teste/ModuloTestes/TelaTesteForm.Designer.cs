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
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 32);
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
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(531, 89);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(55, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(113, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(271, 28);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(113, 130);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(271, 28);
            comboBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(473, 27);
            textBox1.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(390, 126);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(227, 32);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Prova de Recuperação";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(562, 496);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Questões Selecionadas";
            // 
            // TelaTesteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 717);
            Controls.Add(groupBox1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaTesteForm";
            Text = "TelaTesteForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
    }
}