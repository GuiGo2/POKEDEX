using System;
using System.Collections.Generic;


namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();

            RegistroPokemon bulbasaur = new RegistroPokemon("Bulbasaur", 1);
            RegistroPokemon ivysaur = new RegistroPokemon("Ivysaur", 2);
            
            pokedex.pokemon.Add(bulbasaur);
            pokedex.pokemon.Add(ivysaur);

            pokedex.pokemon.Add(new RegistroPokemon("Venasaur", 3));
            pokedex.pokemon.Add(new RegistroPokemon("Charmander", 4));
            pokedex.pokemon.Add(new RegistroPokemon("Charmeleon", 5));
            pokedex.pokemon.Add(new RegistroPokemon("Charizard", 6));
            pokedex.pokemon.Add(new RegistroPokemon("Squirtle", 7));
            pokedex.pokemon.Add(new RegistroPokemon("Wartortle", 8));
            pokedex.pokemon.Add(new RegistroPokemon("Blastoise", 9));
            pokedex.pokemon.Add(new RegistroPokemon("Caterpie", 10));
            
            //pokedex.ConsultarPorId(3);
            RegistroPokemon resultadoBusquedaPorId = pokedex.ConsultarPorId(7);
            Console.WriteLine("Resultado de la busqueda: " + resultadoBusquedaPorId.nombre);
            Console.WriteLine("-----------");
            pokedex.ConsultarYMostrarPorId(3);

            //Console.WriteLine("-----------");
            //RegistroPokemon resultadoBusquedaPorNombre = pokedex.consultarPokemonPorNombre("charizard");
            //Console.WriteLine("Resultado de la busqueda: " + resultadoBusquedaPorNombre);
            
           


            //int a = 4;
            //int b = 6;
            //pokedex.Sumar(a, b);
            //Console.WriteLine("a = " + a);
            //Console.WriteLine("b = " + b);
            //Console.WriteLine("suma = " + pokedex.Sumar(a, b));
            //int suma = pokedex.Sumar(a, b);
            //Console.WriteLine("suma = " + suma);

            //float division = pokedex.Divir(a, b);
            //Console.WriteLine("division = " + division);

            //int suma2 = pokedex.Sumar(a, suma);
            //Console.WriteLine("suma2 = " + suma2);

            //int suma3 = pokedex.Sumar(suma, suma2);
            //Console.WriteLine("suma3 = " + suma3);
        }    
    }
}