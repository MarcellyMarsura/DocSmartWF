using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocSmart
{
    public static class MockDados
    {
        public static List<string> Cliente()
        {
            List<string> clientes = new List<string>
            {
                "Cliente A",
                "Cliente B",
                "Cliente C",
                "Cliente A",
                "Cliente B",
                "Cliente C",
                "Cliente A",
                "Cliente B",
                "Cliente C",
                "Cliente A",
                "Cliente B",
                "Cliente C",
            };

            return clientes;
        }

        public static List<string> Sistema()
        {
            List<string> sistemas = new List<string>
            {
                "Sistema A",
                "Sistema B",
                "Sistema C",
                "Sistema A",
                "Sistema B",
                "Sistema C",
                "Sistema A",
                "Sistema B",
                "Sistema C",
                "Sistema A",
                "Sistema B",
                "Sistema C",
            };

            return sistemas;
        }

        public static List<string> Modulo()
        {
            List<string> modulos = new List<string>
            {
                "Modulo 1",
                "Modulo 2",
                "Modulo 3",
                "Modulo 1",
                "Modulo 2",
                "Modulo 3",
                "Modulo 1",
                "Modulo 2",
                "Modulo 3",
                "Modulo 1",
                "Modulo 2",
                "Modulo 3",
                "Modulo 1",
                "Modulo 2",
                "Modulo 3",
            };

            return modulos;
        }

    }
}
