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
    public partial class ListaDeAtividades : Form
    {
        private Atividade? atividadeEmAndamento;

        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {
           labelErro.Text = string.Empty;

            CarregarAtividadeEmAndamento();
            CarregarListaDeAtividades();    
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (atividadeEmAndamento == null || atividadeEmAndamento.Id <= 0)
            {
                labelErro.Text = "Não há atividade em andamento.";
                return;
            }

            if (!atividadeEmAndamento.AtualizarSituacao())
            {
                labelErro.Text = "Não foi possivel finalizar a atividade.";
                return;
            }

            labelErro.Text = string.Empty;
           
            CarregarAtividadeEmAndamento();
           

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtividades.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Seleciona uma atividade";
            }

            var linhaSelecionada = dataGridViewAtividades.SelectedRows[0];

            Atividade atividade = new()
            {
                Id = (int)linhaSelecionada.Cells[0].Value,
                Titulo = (string)linhaSelecionada.Cells[1].Value,
                Situacao = (Situacao)linhaSelecionada.Cells[2].Value
            };

            atividade.AtualizarSituacao();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            var resultado = new CriarAtividade().ShowDialog();

            if (resultado != DialogResult.OK)
            {
                labelErro.Text = "A criação da atividade não foi concluída.";
                return;
            }
            labelErro.Text = "Atividade criada com sucesso.";
            CarregarListaDeAtividades();
        }

        private void CarregarListaDeAtividades()
        {
            Atividade atividade = new();

            var atividadePendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = atividadePendentes; 
        }

        private void CarregarAtividadeEmAndamento()
        {
            Atividade atividade = new();

            atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            string textoAtividade = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            textBoxAtividadeEmAndamento.Text = atividadeEmAndamento.Id > 0 ? textoAtividade : string.Empty;
        }
    }
}
