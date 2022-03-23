using System;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringChecker stringChecker = new StringChecker();
            Console.Write(stringChecker.IsStringValid().ToString());
        }
    }
}

/* 
  Napisz program sprawdzający poprawność działania matematycznego,
  w którym usunięto wszystkie liczby i operatory a pozostawiono jedynie 
  nawiasy okrągłe, np. (()()) lub )()), przy czy pierwszy przykład jest zapisem prawidłowym a drugi nieprawidłowym:
    • Program powinien zwrócić flagę typu Bool, przy czym:
        ◦ wartość true oznacza zapis prawidłowy
        ◦ wartość false zapis nieprawdiłowy 
    • Program powinien przyjmować jeden argument typu String. Wartość tego parametru to dowolny ciąg znaków ‘(‘ oraz ‘)’.
    • Napisać test jednostkowy, który sprawdza działanie metody na reprezentatywnych przykładach, np. dla następujących wartości:
        ◦ (((()()))())
        ◦ (((()()))()))
        ◦ )((((()))()))
    • Proszę dodać kilka własnych wartości w w/w teście jednostkowym
*/