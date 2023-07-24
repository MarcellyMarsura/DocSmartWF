using DocSmart.Models.PlanoDeTestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocSmart.Models.DocumentacaoTestes
{
    public class DocumentacaoTesteModel
    {
        private static readonly DocumentacaoTesteModel instance = new DocumentacaoTesteModel();

        public string Cliente { get; set; }
        public string Titulo { get; set; }
        public List<DocumentacaoCenarioModel> Cenarios { get; set; }

        private DocumentacaoTesteModel()
        {
            Cenarios = new List<DocumentacaoCenarioModel>();
        }

        public static DocumentacaoTesteModel Instance { get => instance; }

        public static DocumentacaoTesteModel Clear { get => new DocumentacaoTesteModel(); }

    }
}
