using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01_EDII.Models
{
    public class Comparador
    {
        public int CompararPorNombre(Movie Movie1, Movie Movie2)
        {
            return Movie1 == null || Movie2 == null ? 1 : Movie1.Title.CompareTo(Movie2.Title);
        }
    }
}
