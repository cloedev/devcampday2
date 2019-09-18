using RecipesEFCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesEFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListAuthors();
            //CreateAuthor();
            //CreateRecipe(); 
            
            //UpdateRecipeTime(5, 180);
            //DeleteRecipe();
        }

        
        public static void CreateAuthor()
        {
            using (var db = new RecipeContext())
            {
                Console.WriteLine("Introduce nombre de autor:");
                string name = Console.ReadLine();

                var author = new Author() { Name = name };
                db.Authors.Add(author);
                db.SaveChanges();

                Console.WriteLine();
                Console.WriteLine("Autor creado!");
            }
        }

        public static void CreateRecipe()
        {
            using (var db = new RecipeContext())
            {
                Console.WriteLine("Introduce nombre de receta:");
                string name = Console.ReadLine();

                Console.WriteLine("Introduce descripción de receta:");
                string description = Console.ReadLine();

                Console.WriteLine("Introduce tiempo de elaboración:");
                int time = Convert.ToInt32(Console.ReadLine()); // comprobar que es un número entero

                Console.WriteLine("Introduce id del autor:");
                int authorId = Convert.ToInt32(Console.ReadLine()); // qué tal si comprobamos que existe

                try
                {
                    var recipe = new Recipe()
                    {
                        Name = name,
                        Description = description,
                        Time = time,
                        AuthorId = authorId
                    };
                                        
                    db.Recipes.Add(recipe);
                    db.SaveChanges();

                    Console.WriteLine();
                    Console.WriteLine("Receta creada!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    Console.WriteLine("Presiona cualquier tecla para salir.");
                    Console.ReadKey();
                }

            }
        }

        public static void ListAuthors()
        {
            using (var db = new RecipeContext())
            {
                Console.WriteLine("Lista de autores:");
                Console.WriteLine("-----------------");

                var authors = db.Authors.ToList();
                foreach (var a in authors)
                {
                    Console.WriteLine($"Id: {a.Id}, Name: {a.Name}");
                    bool hasRecipes = a.Recipes.Count > 0;
                    if (hasRecipes)
                    {
                        Console.WriteLine("\tSus recetas:");
                        foreach (var r in a.Recipes)
                        {
                            Console.WriteLine($"\tId: {r.Id}, Name: {r.Name}, Description: {r.Description}, Time: {r.Time}");
                        }
                    }
                }

                Console.WriteLine("Presiona cualquier tecla para salir.");
                Console.ReadKey();
            }
        }

        private static void UpdateRecipeTime(int recipeId, int newTime)
        {
            using (var db = new RecipeContext())
            {
                var recipe = db.Recipes.Where(r => r.Id == recipeId).FirstOrDefault();
                if (recipe != null)
                {
                    recipe.Time = newTime;
                    db.SaveChanges();
                    Console.WriteLine("Tiempo actualizado!");
                }
                else
                {
                    Console.WriteLine($"La receta con id {recipeId} no existe");
                }

                Console.WriteLine("Presiona cualquier tecla para salir.");
                Console.ReadKey();
            }
        }


    }
}
