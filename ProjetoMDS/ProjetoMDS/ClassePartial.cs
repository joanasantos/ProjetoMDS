using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMDS
{
    public partial class Consulta
    {
        public String Adicionar(Consulta novaConsulta)
        {
            String verf = "True";
            HospitalDBContainer hospitalDB = new HospitalDBContainer();
            try
            {
                hospitalDB.ConsultaSet.Add(novaConsulta);
                hospitalDB.SaveChanges();
                
            }
            catch (Exception exception)
            {
                verf = exception.Message;
            }

            return verf;
        }
    }
    
    public partial class Paciente
    {
        public override string ToString()
        {
            return this.nome;
        }
    }

    public partial class TipoDiagnostico
    {
        public List<TipoDiagnostico> ListarTodosDiagnosticos()
        {
            HospitalDBContainer hospitalDB = new HospitalDBContainer();
            List<TipoDiagnostico> listaDiagnosticos = hospitalDB.TipoDiagnosticoSet.ToList<TipoDiagnostico>();

            return listaDiagnosticos;
        }

        public override string ToString()
        {
            return this.diagnostico; 
        }
    }
    
    public partial class TipoMedicamento
    {
        public List<TipoMedicamento> ListarTodosMedicamentos()
        {
            HospitalDBContainer hospitalDB = new HospitalDBContainer();
            List<TipoMedicamento> listaMedicamentos = hospitalDB.TipoMedicamentoSet.ToList<TipoMedicamento>();

            return listaMedicamentos;
        }

        public override string ToString()
        {
            return this.medicamento;
        }
    }
    
    public partial class TipoSintoma
    {
        public List<TipoSintoma> ListarTodosSintomas()
        {
            HospitalDBContainer hospitalDB = new HospitalDBContainer();
            List<TipoSintoma> listaSintomas = hospitalDB.TipoSintomaSet.ToList<TipoSintoma>();

            return listaSintomas;
        }

        public override string ToString()
        {
            return this.sintoma;
        }
    }
}
