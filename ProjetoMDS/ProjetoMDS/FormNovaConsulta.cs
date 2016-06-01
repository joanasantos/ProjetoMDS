using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS
{
    public partial class FormNovaConsulta : Form
    {
        private Medico medico;
        private Paciente paciente;
        private HospitalDBContainer hospitalDB;
        public FormNovaConsulta(Medico medico, Paciente paciente)
        {
            InitializeComponent();
            hospitalDB = new HospitalDBContainer();
            this.medico = medico;
            this.paciente = paciente;

            labelNomeMedico.Text = medico.nome;
            textBoxIDPaciente.Text = paciente.Id.ToString();
            textBoxNomePaciente.Text = paciente.nome;

            TipoSintoma tipoSintoma = new TipoSintoma();
            TipoMedicamento tipoMedicamento = new TipoMedicamento();
            TipoDiagnostico tipoDiagnostico = new TipoDiagnostico();

            comboBoxSintomas.DataSource = tipoSintoma.ListarTodosSintomas();
            comboBoxDiagnosticos.DataSource = tipoDiagnostico.ListarTodosDiagnosticos();
            comboBoxMedicamentos.DataSource = tipoMedicamento.ListarTodosMedicamentos();
        }

        private void buttonAdicionarSintoma_Click(object sender, EventArgs e)
        {
            if (comboBoxSintomas.SelectedIndex == -1)
                return;

            TipoSintoma tipoSintoma = (TipoSintoma)comboBoxSintomas.SelectedItem;
            listBoxSintomasPaciente.Items.Add(tipoSintoma);
        }

        private void buttonAdicionarDiagnosticos_Click(object sender, EventArgs e)
        {
            if (comboBoxDiagnosticos.SelectedIndex == -1)
                return;

            TipoDiagnostico tipoDiagnostico = (TipoDiagnostico)comboBoxDiagnosticos.SelectedItem;
            listBoxDiagnosticosPaciente.Items.Add(tipoDiagnostico);
        }

        private void buttonAdicionarMedicamento_Click(object sender, EventArgs e)
        {
            if (comboBoxMedicamentos.SelectedIndex == -1)
                return;

            TipoMedicamento tipoMedicamento = (TipoMedicamento)comboBoxMedicamentos.SelectedItem;
            listBoxMedicamentosPaciente.Items.Add(tipoMedicamento);
        }

        private void buttonRemoverSintoma_Click(object sender, EventArgs e)
        {
            if (listBoxSintomasPaciente.SelectedIndex == -1)
                return;

            TipoSintoma tipoSintoma = (TipoSintoma)listBoxSintomasPaciente.SelectedItem;
            listBoxSintomasPaciente.Items.Remove(tipoSintoma);
        }

        private void buttonRemoverDiagnosticos_Click(object sender, EventArgs e)
        {
            if (listBoxDiagnosticosPaciente.SelectedIndex == -1)
                return;

            TipoDiagnostico tipoDiagnostico = (TipoDiagnostico)listBoxDiagnosticosPaciente.SelectedItem;
            listBoxDiagnosticosPaciente.Items.Remove(tipoDiagnostico);
        }

        private void buttonRemoverMedicamento_Click(object sender, EventArgs e)
        {
            if (listBoxMedicamentosPaciente.SelectedIndex == -1)
                return;

            TipoMedicamento tipoMedicamento = (TipoMedicamento)listBoxMedicamentosPaciente.SelectedItem;
            listBoxMedicamentosPaciente.Items.Remove(tipoMedicamento);
        }

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            if(textBoxTitulo.Text.Length == 0)
            {
                MessageBox.Show("É necessário inserir um titulo.");
                return;
            }

            if(listBoxSintomasPaciente.Items.Count == 0 || listBoxDiagnosticosPaciente.Items.Count == 0)
            {
                MessageBox.Show("É necessário ter pelo menos um sintoma e um diagnóstico.");
                return;
            }

            Consulta novaConsulta = new Consulta();
            novaConsulta.titulo = textBoxTitulo.Text;
            novaConsulta.data = dateTimePicker1.Value;
            novaConsulta.PacienteId = paciente.Id;
            novaConsulta.MedicoId = medico.Id;
            foreach (TipoSintoma item in listBoxSintomasPaciente.Items)
            {
                Sintoma novoSintoma = new Sintoma();
                novoSintoma.TipoSintomaId = item.Id;
                novoSintoma.observacao = textBoxObservacoesSintomas.Text;
                novaConsulta.Sintomas.Add(novoSintoma);
            }

            foreach (TipoDiagnostico item in listBoxDiagnosticosPaciente.Items)
            {
                Diagnostico novoDiagnostico = new Diagnostico();
                novoDiagnostico.TipoDiagnosticoId = item.Id;
                novoDiagnostico.observacao = textBoxObservacoesDiagnosticos.Text;
                novaConsulta.Diagnosticos.Add(novoDiagnostico);
            }

            if(listBoxMedicamentosPaciente.Items.Count != 0)
            {
                foreach (TipoSintoma item in listBoxSintomasPaciente.Items)
                {
                    Sintoma novoSintoma = new Sintoma();
                    novoSintoma.TipoSintomaId = item.Id;
                    novoSintoma.observacao = textBoxObservacoesSintomas.Text;
                    novaConsulta.Sintomas.Add(novoSintoma);
                }
            }
            
            Consulta consulta = new Consulta();
            String verf = consulta.Adicionar(novaConsulta);
            if (verf == "True")
            {
                MessageBox.Show("Consulta adiciona com sucesso.");
                textBoxTitulo.Enabled = false;
                buttonAdicionarDiagnosticos.Enabled = false;
                buttonAdicionarSintoma.Enabled = false;
                buttonAdicionarMedicamento.Enabled = false;
                buttonRemoverDiagnosticos.Enabled = false;
                buttonRemoverMedicamento.Enabled = false;
                buttonRemoverSintoma.Enabled = false;
                buttonRegistar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Erro ao inserir consulta! \nErro: " + verf);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
