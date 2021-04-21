using System;
using System.Collections.Generic;

namespace Pokedex
{
     class Pokedex
     {
         //public List<RegistroPokemon> pokemon = new List<RegistroPokemon>();
        public List<RegistroPokemon> pokemon;
        public Pokedex()
        {
            pokemon = new List<RegistroPokemon>();
            //pokemon.Add(new RegistroPokemon("Bulbasur", 1));
            //pokemon.Add(new RegistroPokemon("Ivysaur", 2));
            //pokemon.Add(new RegistroPokemon("Venasaur", 3));
            //pokemon.Add(new RegistroPokemon("Charmander", 4));
            //pokemon.Add(new RegistroPokemon("Charmeleon", 5));
            //pokemon.Add(new RegistroPokemon("Charizard", 6));
            //pokemon.Add(new RegistroPokemon("Squirtle", 7));
            //pokemon.Add(new RegistroPokemon("Wartortle", 8));
            //pokemon.Add(new RegistroPokemon("Blastoise", 9));
            //pokemon.Add(new RegistroPokemon("Caterpie", 10));
        }
        public RegistroPokemon ConsultarPorId(int id)
        {
             //return ;
             for (int i = 0; i < pokemon.Count; i++)
             {
                 Console.WriteLine("Buscando un pokemon ...");
                 if (pokemon[i].id == id)
                 {
                     //resultado encontrado!
                     return pokemon[i];
                 }
             }

             //no se encontro un resultado
             return null;

             // Reto 2
             //return new RegistroPokemon("MISSIGNO.", 0);
         }

        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public float Divir(float a, float b)
        {
            return a / b;
        }

        //public void consultarYMostrarPorId()
        //{
        //    Console.WriteLine("Pokemon encontrado:" + "");
        //}
        public void ConsultarYMostrarPorId(int id)
        {
            bool resultadoEncontrado = false;
            for (int i = 0; i < pokemon.Count; i++)
            {
                Console.WriteLine("Buscando un pokemon ...");
                if (pokemon[i].id == id)
                {
                // Resultado encontrado!
                //return pokemon[i];
                Console.WriteLine("Resultado encontrado: " + pokemon[i].nombre);
                resultadoEncontrado = true;
                //iterrumpe o finazila el ciclo
                break;
                }
            }
            
            // No se encontro un resultado
            //return null;
            if (!resultadoEncontrado)
            {
                Console.WriteLine("No se encontro un resultado");
            }
            
            
        }

        
     






        public void consultarPokemonPorNombre(string nombre)
        {
            bool resultadoEncontrado = false;
            for (int i = 0; i < pokemon.Count; i++)
             {
                Console.WriteLine("Buscando Id ...");
                if (pokemon[i].nombre == nombre)
                {
                // Resultado encontrado!
                //return pokemon[i];
                Console.WriteLine("Resultado encontrado: " + pokemon[i].id);
                resultadoEncontrado = true;
                //iterrumpe o finazila el ciclo
                break;
                }
            }
            
            // No se encontro un resultado
            //return null;
            if (!resultadoEncontrado)
            {
                Console.WriteLine("No se encontro un resultado");
            }

        //public __ consultarPokemonPorTodos()
        //{
        //    
        }
     }
}