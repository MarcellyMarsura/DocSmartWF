using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocSmart.Models.PlanoDeTestes
{
    public sealed class PlanoDeTestesModel
    {
        private static readonly PlanoDeTestesModel instance = new PlanoDeTestesModel();

        public HeaderPlanoTesteModel HeaderPlanoTeste { get; set; }

        public List<CenarioModel> Cenarios { get; set; }

        private PlanoDeTestesModel()
        {
            Cenarios = new List<CenarioModel>();
        }

        public static PlanoDeTestesModel Instance { get => instance; }
    }
}
