using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01_EDII.Models
{
    public class DataSingelton
    {
        private static DataSingelton _instance = null;
        public static DataSingelton Instance
        {
            get
            {
                if (_instance == null) _instance = new DataSingelton();
                return _instance;
            }
        }
        private static Comparador _Comparador = new Comparador();
        public ArbolMulticamino<Movie> Arbolb = new ArbolMulticamino<Movie>(5, _Comparador.CompararPorNombre);
    }
}
