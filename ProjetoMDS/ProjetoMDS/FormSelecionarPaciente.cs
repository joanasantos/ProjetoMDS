using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS
{
    public partial class FormSelecionarPaciente : Form
    {
        private Medico medico;
        private HospitalDBContainer hospitalDB;
        public FormSelecionarPaciente(Medico medico)
        {
            InitializeComponent();
            hospitalDB = new HospitalDBContainer();
            this.medico = medico;
            labelMedico.Text = medico.nome;
        }

        private void FormSelecionarPaciente_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            (from pacienteSet in hospitalDB.PacienteSet select pacienteSet).Load();

            listBox1.DataSource = hospitalDB.PacienteSet.Local.ToBindingList();

            if (listBox1.Items.Count != 0)
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente novoPaciente = new Paciente();

            novoPaciente.nome = "André Silva";
            hospitalDB.PacienteSet.Add(novoPaciente);
            hospitalDB.SaveChanges();

            Atualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                return;

            Paciente paciente = (Paciente)listBox1.SelectedItem;

            FormNovaConsulta formNovaConsulta = new FormNovaConsulta(medico, paciente);
            formNovaConsulta.ShowDialog();
        }
    }
}
