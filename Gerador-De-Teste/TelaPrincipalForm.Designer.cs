namespace Gerador_De_Teste
{
    partial class TelaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            disciplinasToolStripMenuItem = new ToolStripMenuItem();
            matériasToolStripMenuItem = new ToolStripMenuItem();
            questõesToolStripMenuItem = new ToolStripMenuItem();
            testesToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            toolStrip2 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            lblTipoDeCadastro = new ToolStripLabel();
            lblTipoCadastro = new ToolStripLabel();
            pnlRegistros = new Panel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1321, 35);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { disciplinasToolStripMenuItem, matériasToolStripMenuItem, questõesToolStripMenuItem, testesToolStripMenuItem });
            toolStripDropDownButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(182, 32);
            toolStripDropDownButton1.Text = "Opções de Menus";
            // 
            // disciplinasToolStripMenuItem
            // 
            disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            disciplinasToolStripMenuItem.Size = new Size(224, 32);
            disciplinasToolStripMenuItem.Text = "Disciplinas";
            disciplinasToolStripMenuItem.Click += disciplinasToolStripMenuItem_Click;
            // 
            // matériasToolStripMenuItem
            // 
            matériasToolStripMenuItem.Name = "matériasToolStripMenuItem";
            matériasToolStripMenuItem.Size = new Size(224, 32);
            matériasToolStripMenuItem.Text = "Matérias";
            // 
            // questõesToolStripMenuItem
            // 
            questõesToolStripMenuItem.Name = "questõesToolStripMenuItem";
            questõesToolStripMenuItem.Size = new Size(224, 32);
            questõesToolStripMenuItem.Text = "Questões";
            // 
            // testesToolStripMenuItem
            // 
            testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            testesToolStripMenuItem.Size = new Size(224, 32);
            testesToolStripMenuItem.Text = "Testes";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 585);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1321, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(185, 20);
            statusLabelPrincipal.Text = "Visualizando 0 registro(s)...";
            // 
            // toolStrip2
            // 
            toolStrip2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip2.ImageScalingSize = new Size(30, 30);
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnExcluir, btnEditar, lblTipoDeCadastro, lblTipoCadastro });
            toolStrip2.Location = new Point(0, 35);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1321, 37);
            toolStrip2.TabIndex = 4;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(34, 34);
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(34, 34);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(34, 34);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // lblTipoDeCadastro
            // 
            lblTipoDeCadastro.Name = "lblTipoDeCadastro";
            lblTipoDeCadastro.Size = new Size(0, 34);
            lblTipoDeCadastro.Click += toolStripLabel1_Click;
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(0, 34);
            // 
            // pnlRegistros
            // 
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 72);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(1321, 513);
            pnlRegistros.TabIndex = 5;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 611);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip2);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            Text = "Gerenciador-De-Testes";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem disciplinasToolStripMenuItem;
        private ToolStripMenuItem matériasToolStripMenuItem;
        private ToolStripMenuItem questõesToolStripMenuItem;
        private ToolStripMenuItem testesToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip2;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnExcluir;
        private ToolStripButton btnEditar;
        private ToolStripLabel lblTipoDeCadastro;
        private ToolStripLabel lblTipoCadastro;
        private Panel pnlRegistros;
        private ToolStripStatusLabel statusLabelPrincipal;
    }
}
