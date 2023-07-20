using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocSmart.Models.PlanoDeTestes
{
    public class HeaderCenarioModel
    {
        public string Sistema { get; set; }
        public List<string> Modulos { get; set; }
        public string Descricao { get; set; }
        public string Resultado { get; set; }

        public HeaderCenarioModel()
        {
            Modulos = new List<string>();
        }
    }
}
