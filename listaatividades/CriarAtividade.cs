using listaatividades.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaatividades
{
    public partial class CriarAtividade : Form
    {
        public CriarAtividade()
        {
            InitializeComponent();
        }



        private void buttondescartar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {


            Atividade atividade = new Atividade()
            {
                Titulo = textBoxTitulo.Text
            };

            if (!atividade.Criar())
            {
                labelErro.Text = "Não foi possivel criar a atividade";
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void CriarAtividade_Load(object sender, EventArgs e)
        {
            labelErro.Text = 
        }
    }
}
