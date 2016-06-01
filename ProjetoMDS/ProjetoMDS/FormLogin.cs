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
    public partial class FormLogin : Form
    {
        private Medico medico;
        private HospitalDBContainer hospitalDB;
        public FormLogin()
        {
            InitializeComponent();
            hospitalDB = new HospitalDBContainer();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void Atualizar()
        {
            medico = (from medicoSet in hospitalDB.MedicoSet
                             where medicoSet.Id == 1
                             select medicoSet).FirstOrDefault();

            if (medico != null)
            {
                button2.Enabled = false;
                textBox1.Text = medico.nome;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Medico novoMedico = new Medico();
            novoMedico.nome = "António Silva";

            hospitalDB.MedicoSet.Add(novoMedico);
            hospitalDB.SaveChanges();

            Atualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;

            FormSelecionarPaciente formSelecionarPaciente = new FormSelecionarPaciente(medico);
            formSelecionarPaciente.ShowDialog();
        }
    }
}
