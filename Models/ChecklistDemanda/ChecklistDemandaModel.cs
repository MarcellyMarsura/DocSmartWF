using DocSmart.Models.PlanoDeTestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocSmart.Models.ChecklistDemanda
{
    public class ChecklistDemandaModel
    {
        private static readonly ChecklistDemandaModel instance = new ChecklistDemandaModel();
        public List<string> Formalizacao { get; set; }
        public List<string> Planejamento { get; set; }
        public List<string> Desenho { get; set; }
        public List<string> Construcao { get; set; }
        public List<string> Testes { get; set; }
        public List<string> Suporte { get; set; }

        private ChecklistDemandaModel()
        {
            Formalizacao = new List<string>();
            Planejamento = new List<string>();
            Desenho = new List<string>();
            Construcao = new List<string>();
            Testes = new List<string>();
            Suporte = new List<string>();

        }

        public static ChecklistDemandaModel Instance { get => instance; }

        public static ChecklistDemandaModel Clear { get => new ChecklistDemandaModel(); }
  
    }
}
