using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Surcharge_Operateur.Models
{
    public class Salade
    {
        private readonly List<Ingredient> _ingredients = new List<Ingredient>();

        public IEnumerable<Ingredient> Ingredients
        {
            get { return _ingredients.AsReadOnly(); }
        }

        public void AjouterIngredient(Ingredient ingredient)
        {
            bool notAlreadyAdded = true;
            for (int i = 0; notAlreadyAdded && i < _ingredients.Count; i++)
            {
                if (_ingredients[i] == ingredient)
                {
                    notAlreadyAdded = false;
                }
            }

            if (notAlreadyAdded)
            {
                _ingredients.Add(ingredient);
            }
        }


        public static Salade operator +(Salade gauche, Ingredient droite)
        {
            Salade resultat = new Salade();

            resultat._ingredients.AddRange(gauche.Ingredients);

            resultat.AjouterIngredient(droite);

            return resultat;
        }

        public static Salade operator +(Ingredient gauche, Salade droite)
        {
            return droite + gauche;
        }

        public static Salade operator -(Salade gauche, Ingredient droite)
        {
            Salade resultat = new Salade();

            resultat._ingredients.AddRange(gauche.Ingredients);
            resultat._ingredients.RemoveAll(i => i == droite);

            return resultat;
        }
    }
}
