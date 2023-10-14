using System;

namespace Conditions__Tasks__Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C. Task no 1");
            //Napisz program, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
            //Dane testowe: a: 5, b: 5. Rezultat w terminalu: 5 i 5 są równe.
            //Czy w praktyce stosuje się instrukcję if bez else? 
            int a = 5;
            int b = 5;
            if (a == b)
            {
                Console.WriteLine($"{a} i {b} są równe");
            }
            else
            {
                Console.WriteLine($"{a} i {b} nie są równe");
            }
            
            Console.WriteLine("C. Task no 2");
            //Napisz program, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
            //Dane testowe: 15
            //Rezultat: 15 jest liczbą nieparzystą.
            int number1 = 15;
            if (number1 % 2 == 0)
            {
                Console.WriteLine($"{number1} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine($"{number1} jest liczbą nieparzystą");
            }
            
            Console.WriteLine("C. Task no 3");
            //Napisz program, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
            //Dane testowe: 14. Rezultat w terminalu: 14 jest liczbą dodatnią.
            int no14 = 14;
            string effect;
            effect = (no14 > 0) ? $"{no14} jest liczbą dodatnią" : $"{no14} jest liczbą ujemną";
            Console.WriteLine(effect);

            Console.WriteLine("C. Task no 4");
            //Napisz program, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
            //Dane: 2016. Rezultat w terminalu: 2016 jest rokiem przestepnym.
            int yearno = 2016;
            if (yearno % 4 == 0)
            {
                Console.WriteLine($"{yearno} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"{yearno} nie jest rokiem przestępnym");
            }

            Console.WriteLine("C. Task no 5");
            //Napisz program, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się
            //o stanowisko posła, premiera, senatora, prezydenta.
            //Dane testowe: 21. Rezultat: Możesz zostać posłem.
            int age1 = 21;
            if (age1 >= 21)
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            else
            {
                Console.WriteLine("Błąd. Wprowadź poprawne dane");
            }
            int age2 = 30;
            if (age2 >= 30)
            {
                Console.WriteLine("Możesz zostać senatorem");
            }
            else
            {
                Console.WriteLine("Błąd. Wprowadź poprawne dane");
            }
            int age3 = 35;
            if (age3 >= 35)
            {
                Console.WriteLine("Możesz zostać prezydentem");
            }
            else
            {
                Console.WriteLine("Błąd. Wprowadź poprawne dane");
            }

            Console.WriteLine("C. Task no 6");
            //Napisz program, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
            //Dane testowe: 140. Rezultat: Jesteś krasnoludem.
            Console.WriteLine("Podaj swój wzrost");
            string userInput = Console.ReadLine();
            if (double.TryParse(userInput, out double userHeight))
            {
                if (userHeight <= 140)
                {
                    Console.WriteLine("Jesteś krasnoludem");
                }
                else
                {
                    Console.WriteLine("Nie jesteś krasnoludem");
                }
            }

            Console.WriteLine("C. Task no 7");
            //Napisz program, który pobierze 3 liczby od użytkownika i sprawdzi która jest największa.
            //Dane: 25, 63, 79. Rezultat: 79 jest największa z podanych.
            int no1 = 25;
            int no2 = 63;
            int no3 = 79;
            if (no1 < no2 & no2 < no3)
            {
                Console.WriteLine($"{no3} jest największą z podanych liczb");
            }
            else
            {
                Console.WriteLine($"{no3} nie jest największą z podanych liczb");
            }

            Console.WriteLine("C. Task no 8");
            //Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. kryteriow:
            //wynik z matury z matematyki powyżej: 70
            //wynik z fizyki powyżej: 55
            //wynik z chemii: powyżej 45
            //łączny wynik z 3 przedmiotów powyżej 180 albo wynik z matematyki i jednego przedmiotu powyżej: 150
            //Dane testowe: matma: 80, fizyka: 71, chemia 0
            //Rezultat: kandydat dopuszczony do rekrutacji
            int resultMath = 80;
            int resultPhysics = 71;
            int resultChemistry = 0;
            if ((resultMath + resultPhysics + resultChemistry > 180) || (resultMath + resultPhysics > 150) || (resultMath + resultChemistry > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }

            Console.WriteLine("C. Task no 9");
            //Napisz program, który odczyta temperaturę i zwróci nazwę jak w poniższych kryteriach.
            //temp < 0 cholernie piździ, temp 0 - 10 zimno, temp 10-20 chłodno,
            //temp 20-30 w sam raz, temp 30-40 zaczyna być słabo, bo gorąco
            //temp >=40 a weź wyprowadzam się na Alaskę
            //Dane testowe: 41 Rezultat: jadę na Alaskę
            int temperature = 41;
            if (temperature < 0)
            {
                Console.WriteLine("Cholernie piździ");
            }
            else if ((temperature > 0) && (temperature <= 10))
            {
                Console.WriteLine("Zimno");
            }
            else if ((temperature > 10) && (temperature < 20))
            {
                Console.WriteLine("Chłodno");
            }
            else if ((temperature > 20) && (temperature < 30))
            {
                Console.WriteLine("W sam raz");
            }
            else if ((temperature > 30) && (temperature < 40))
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco");
            }
            else if (temperature >= 40)
            {
                Console.WriteLine("A weź, przeprowadzam się na Alaskę");
            }
            else
            {
                Console.WriteLine("Błędna temperatura");
            }

            Console.WriteLine("C. Task no 10");
            //Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trojkąt.
            //Dane: 40, 55, 65. Rezultat: Można zbudować trójkąt.
            int first = 40;
            int second = 55;
            int third = 65;
            if ((first + second > third) & (first + third > second) & (second + third > first))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }

            Console.WriteLine("C. Task no 11");
            //Napisz program, który zmieni ocenę ucznia na jej opis wg danych:
            //6 celujący, 5 bardzo dobry, 4 dobry, 3 dostateczny, 2 dopuszczający, 1 niedostateczny
            // Dane: 3 Rezultat: dostateczny
            int rating1 = 6;
            int rating2 = 5;
            int rating3 = 4;
            int rating4 = 3;
            int rating5 = 2;
            int rating6 = 1;

            switch (rating4)
            {
                case 1:
                    Console.WriteLine("dostateczny");
                    break;
                default:
                    Console.WriteLine("Błędne dane");
                    break;
            }

            Console.WriteLine("C. Task no 12");
            //Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę.
            //Dane: 4 Rezultat: czwartek
            //Problem z linią 228???
            string dzień1 = "poniedziałek";
            string dzień2 = "wtorek";
            string dzień3 = "środa";
            string dzień4 = "czwartek";
            string dzień5 = "piątek";
            string dzień6 = "sobota";
            string dzień7 = "niedziela";

            switch (dzień4)
            {
                case "czwartek":
                    Console.WriteLine("czwartek");
                    break;
                default: Console.WriteLine("Błędne dane");
                    break;
            }

            Console.WriteLine("C. Task no 13");
            //Napisz program, który będzie posiadał menu wg wzoru poniżej i będzie prostym kalkulatorem
            //Podaj pierwszą liczbę ....
            //Podaj drugą liczbę...
            //Podaj numer operacji do wykonania
            //1. Dodawania 2. Odejmowanie 3. Mnożenie 4. Dzielenie
            //Twój wynik to:
            Console.WriteLine("Podaj pierwszą liczbę");
            string firstInput = Console.ReadLine();
            int firstNo;
            if (int.TryParse(firstInput, out firstNo))
            {
                Console.WriteLine($"Pierwsza liczba to: {firstNo}");
            }
            else
            {
                Console.WriteLine("Błąd. Wprowadź pierwszą liczbę");
            }
            Console.WriteLine("Podaj drugą liczbę");
            string secondInput = Console.ReadLine();
            int secondNo;
            if (int.TryParse(secondInput, out secondNo))
            {
                Console.WriteLine($"Druga liczba to: {secondNo}");
            }
            else
            {
                Console.WriteLine("Błąd. Wprowadż drugą liczbę");
            }
            Console.WriteLine("Podaj numer operacji do wykonania");
            Console.WriteLine("Operacja nr 1: dodawanie");
            Console.WriteLine("Operacja nr 2: odejmowanie");
            Console.WriteLine("Operacja nr 3: mnożenie");
            Console.WriteLine("Operacja nr 4: dzielenie");
            string operationNo = Console.ReadLine();
            int operation;
            if (int.TryParse(operationNo, out operation))
            {
                Console.WriteLine($"Nr operacji do wykonania to: {operation}");
            }
            else
            {
                Console.WriteLine("Błąd. Wprowadż nr operacji do wykonaina");
            }
            int result;
            switch (operation)
            {
                case 1:
                    result = firstNo + secondNo;
                    Console.WriteLine($"Twój wynik to: {result}");
                    break;
                case 2:
                    result = firstNo - secondNo;
                    Console.WriteLine($"Twój wynik to: {result}");
                    break;
                case 3:
                    result = firstNo * secondNo;
                    Console.WriteLine($"Twój wynik to: {result}");
                    break;
                case 4:
                    if (secondNo != 0)
                    {
                        result = firstNo / secondNo;
                        Console.WriteLine($"Twój wynik to: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Nie można dzielić przez 0");
                        return;
                    }
                    break;
            }
        }
    }
}