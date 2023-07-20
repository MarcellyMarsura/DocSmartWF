using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocSmart.Models.PlanoDeTestes
{
    public class CenarioModel
    {
        public HeaderCenarioModel Header { get; set; }
        public List<PassoModel> Passos { get; set; }

        public CenarioModel()
        {
            Passos = new List<PassoModel>();
        }
    }
}
