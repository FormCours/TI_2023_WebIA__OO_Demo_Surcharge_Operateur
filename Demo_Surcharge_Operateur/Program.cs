

using Demo_Surcharge_Operateur.Models;


Ingredient ingre1 = new Ingredient();
ingre1.Nom = "Tomate";

Ingredient ingre2 = new Ingredient();
ingre2.Nom = "Tomate";


Salade salade = new Salade();
Console.WriteLine($"Nombre d'ingrédient : {salade.Ingredients.Count()}");

salade.AjouterIngredient(ingre1);
Console.WriteLine($"Nombre d'ingrédient : {salade.Ingredients.Count()}");

salade.AjouterIngredient(ingre1);
Console.WriteLine($"Nombre d'ingrédient : {salade.Ingredients.Count()}");

salade.AjouterIngredient(ingre2);
Console.WriteLine($"Nombre d'ingrédient : {salade.Ingredients.Count()}");

Ingredient ingre3 = new Ingredient();
ingre3.Nom = "Maïs";

Salade salade2 = salade + ingre3;


Ingredient ingre4 = new Ingredient();
ingre3.Nom = "Onion";

Salade salade3 = ingre4 + salade2;




Console.WriteLine("Fini");
