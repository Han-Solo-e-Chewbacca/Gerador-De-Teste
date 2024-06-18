using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_De_Teste.ModuloTestes
{
    public partial class TelaPDFForm : Form
    {
        public TelaPDFForm()
        {
            InitializeComponent();
        }
        public string nomeArquivo;
        public bool ComRespostas;
        private void btnGerar_Click(object sender, EventArgs e)
        {
            nomeArquivo = txtNomeDoArquivo.Text;
            ComRespostas = checkBox1.Checked;
        }


    }
}
