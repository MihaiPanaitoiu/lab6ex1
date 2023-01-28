using System;

namespace lab6ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             • Ex 1
 Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
 metoda care va calcula volumul acestuia.
 Folositi o clasa care va modela un dulap.
  Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
  Cele trei campuri vor fi initializate cu ajutorul constructorului
  Scrieti pului pe baza celor trei campuri.
 Instantiati un dulap in functia Main, apelati meo metoda care va calcula volumul dulatoda de calcul a volumului si
 afisati rezultatul.
             */
            Dulap myDulap = new Dulap(5, 6, 10);
            Console.WriteLine(myDulap.getVolumn());
        }
    }
}
