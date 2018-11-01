using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Référence à l'espace de nom System.Threading.Tasks pour raccourcir 
//son appel. tasks.Classes
using tasks = System.Threading.Tasks;

namespace FirstRepositoryTests
{
    class Program
    {
        //Test github
        static void Main(string[] args)
        {
            using (Font font1 = new Font("Arial", 10.0f))
            {
                byte charset = font1.GdiCharSet;
            }
        }
    }

    public class TestSimple
    {
        public string NomTest { get; set; }
        public int VersionTest { get; set; }

        public TestSimple(string nom, int version)
        {
            NomTest = nom;
            VersionTest = version;

            Console.WriteLine("Création d'un nouveau test simple");
            Console.WriteLine("Nom du test: {0}", NomTest);
            Console.WriteLine("Version du test: {1}", VersionTest);
        }

    }

    //Classe avec une méthode Générique (prend le paramètre donné)
    public static class Afficheur
    {
        public static void Affiche<T>(T a)
        {
            Console.WriteLine("Afficheur d'objet :");
            Console.WriteLine("\tType : " + a.GetType());
            Console.WriteLine("\tReprésentation : " + a.ToString());
        }

        //Méthode générique à deux paramètres de types différents
        public static void DoubleType<T, U>(T nom, U age)
        {
            Console.WriteLine("Nom est de type {0} et Age est de type {1}", typeof(T), typeof(U));
        }
    }

    //Classe TestEquatable qui implémente une interface IEquatable
    public class TestEquatable : IEquatable<TestEquatable> 
    {
        public bool Equals(TestEquatable test)
        {
            Console.WriteLine("Je compare un objet oulala");
            return true;
        }
    }

    //Petite structure définissant les propriétés d'un rectangle
    public struct Rectangle 
    {
        public int _height, _width;   

        public Rectangle(int height, int width)
        {
            this._height = height;
            this._width = width;
        }
    }
}
