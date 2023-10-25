using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Surcharge_Operateur.Models
{
    public class Ingredient
    {
        private string _nom;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public static bool operator ==(Ingredient first, Ingredient second)
        {
            if (first is null && second is null)
                return true;

            if (first is null || second is null)
                return false;

            return first.Nom.ToLower() == second.Nom.ToLower();
        }

        public static bool operator !=(Ingredient first, Ingredient second)
        {
            return !(first == second);
        }
    }
}
