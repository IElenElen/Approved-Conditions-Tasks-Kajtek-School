using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Conditions__Tasks__Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditions Tasks");

            Console.WriteLine("C. Task no 1");
            //Napisz program, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
            //Dane testowe: a: 5, b: 5. Rezultat w terminalu: 5 i 5 są równe.
            
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

            //Drugie podjeście do zad nr 3
            //dla zera zrobić, bo jest neutralne
            Console.WriteLine("Podaj liczbę: ");
            string noUserInput = Console.ReadLine();
            int noFromUser;
            int.TryParse(noUserInput, out noFromUser);
            if (noFromUser == 0)
            {
                Console.WriteLine("Zero jest liczbą naturalną");
            }
            else if (noFromUser < 0)
            {
                Console.WriteLine($"{noFromUser} jest liczbą ujemną");
            }
            else if (noFromUser > 0)
            {
                Console.WriteLine($"{noFromUser} jest liczbą dodatnią");
            }
            else 
            {
                Console.WriteLine("Błąd. Wprowadź liczbę");
            }

            //Pierwsze podjeście
            int no14 = 14;
            string effect;
            effect = (no14 > 0) ? $"{no14} jest liczbą dodatnią" : $"{no14} jest liczbą ujemną";
            Console.WriteLine(effect);

            Console.WriteLine("C. Task no 4");
            //Napisz program, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
            //Dane: 2016. Rezultat w terminalu: 2016 jest rokiem przestepnym.
            //więcej warunków dla roku przestepnego poszukać i to rozwinąć....

            //Drugie podjeście do zad nr 4
            Console.WriteLine("Podaj rok: ");
            string yearInput = Console.ReadLine();
            int year;
            if (int.TryParse(yearInput, out year))
            {
                Console.WriteLine("Podany rok to: ");
            }
            else
            {
                Console.WriteLine("Błąd. Wprowadź rok: ");
            }

            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"{year} nie jest rokiem przestępnym");
            }

            //Pierwsze podjeście
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
            //ustawić taki wiek, aby od razu sprawdzić wszystko - czyli jeden wiek ustawić

            //Drugie podejście do zad nr 5
            Console.WriteLine("Podaj swój wiek");
            string ageInput = Console.ReadLine();
            int age;
            if (int.TryParse(ageInput, out age))
            {
                Console.WriteLine("Konwersja wieku udała się");
            }
            else
            {
                Console.WriteLine("Błąd. Wprowadź poprawny wiek");
            }
            Console.WriteLine();

            if (age >= 35)
            {
                Console.WriteLine("Możesz zostać kim chcesz, masz wybór: posłem, premierem, senatorem a nawet prezydentem");
            }
            else
            {
                Console.WriteLine("Błąd. Wprowadź poprawne dane");
            }

            //Pierwsze podejście
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
            //więcej możliwości dopisać

            //Drugie podjeście do zad nr 6 - rozbudowanie opcji
            //& - oba warunki do sprawdzenia
            Console.WriteLine("Podaj swój wzrost");
            string userInput = Console.ReadLine();
            if (double.TryParse(userInput, out double userHeight))
            {
                if (userHeight <= 0)
                {
                    Console.WriteLine("Jesteś mikroskopijną bakterią");
                }
                else if (userHeight > 0 & userHeight <= 100)
                    {
                    Console.WriteLine("Jesteś bajkowym gumisiem");
                }
                else if (userHeight > 100 & userHeight <= 140)
                    {
                    Console.WriteLine("Jesteś mega niski");
                }
                else if (userHeight > 140 & userHeight <= 150)
                {
                    Console.WriteLine("Ujdzie, mogło być jednak lepiej");
                }
                else if (userHeight > 150 & userHeight <= 165)
                    {
                    Console.WriteLine("Mieścisz się w wzrościanej normie");
                }
                else if (userHeight > 165 & userHeight <= 170)
                {
                    Console.WriteLine("Takiego wzrostu to tylko pozazdrościć");
                }
                else if (userHeight > 170 & userHeight <= 190)
                {
                    Console.WriteLine("Możesz zostać koszykarzem");
                }
                else if (userHeight > 190)
                {
                    Console.WriteLine("No Tobie to trumnę na specjalne zamówineie bedą robić");
                }
                else
                {
                    Console.WriteLine("Nie piernicz głupot tylko wprowadź poprawny wzrost");
                }
            }

            Console.WriteLine("C. Task no 7");
            //Napisz program, który pobierze 3 liczby od użytkownika i sprawdzi która jest największa.
            //Dane: 25, 63, 79. Rezultat: 79 jest największa z podanych.
            //która liczba jest największa a nie tylko, że no3 np. największta to 79

            //Drugie podjeście do zad nr 7
            //skracam sprawdzanie prawdziwości - &&
            Console.WriteLine("Podaj pierwszą liczbę: ");
            string no1Input = Console.ReadLine();
            Console.WriteLine("Podaj drugą liczbę: ");
            string no2Input = Console.ReadLine();
            Console.WriteLine("Podaj trzecią liczbę: ");
            string no3Input = Console.ReadLine();
            int no1out;
            int no2out;
            int no3out;
            if (((int.TryParse(no1Input, out no1out)) && (int.TryParse(no2Input, out no2out)) && (int.TryParse(no3Input, out no3out))))
            {
                Console.WriteLine("Konwersja udana");

                if ((no1out < no2out) && (no2out < no3out))
                {
                    Console.WriteLine($"Najwieksza liczba to: {no3out}");
                }
                else if (no1out < no2out)
                {
                    Console.WriteLine($"Największa liczba to: {no2out}");
                }
                else
                {
                    Console.WriteLine($"Największa liczba to: {no1out}");
                }
            }
            else
            {
                Console.WriteLine("Bląd. Wprowadź poprawne liczby");
            }
         
            //Pierwsze podejście
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

            //do poprawy:
            //te 4 pierwsze warunki muszą być spełnione równocześnie, kandydat musi mieć 180 punktów
            //i te minimalne wyniki każdej matury też
            //albo po prostu matma i jakiś przedmiot w sumie ponad 150

            //Drugie podejście do zad nr 8
            //& wszystkie  warunki do sprawdzenia
            int resultNewMath = 80;
            int resultNewPhysics = 71;
            int resultNewChemistry = 0;
                if (((resultNewMath > 70 & resultNewPhysics > 55 & resultNewChemistry > 45) & (resultNewMath + resultNewPhysics + resultNewChemistry > 180)) || ((resultNewMath > 70 & resultNewPhysics > 55 & resultNewChemistry > 45) & (resultNewMath + resultNewPhysics > 150)) || ((resultNewMath > 70 & resultNewPhysics > 55 & resultNewChemistry > 45) & (resultNewMath + resultNewChemistry > 150)))
                {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");

                }
                else
                {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
                }

            //Pierwsze podejście
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
            //&& dobrze zastosowane
            //Napisz program, który odczyta temperaturę i zwróci nazwę jak w poniższych kryteriach.
            //temp < 0 cholernie piździ, temp 0 - 10 zimno, temp 10-20 chłodno,
            //temp 20-30 w sam raz, temp 30-40 zaczyna być słabo, bo gorąco
            //temp >=40 a weź wyprowadzam się na Alaskę
            //Dane testowe: 41 Rezultat: jadę na Alaskę

            //tylko w przejściu przez 10 masz dobrze, bo najpierw masz <= a potem >, czyli cały zakres jest pokryty
            //ale we wszystkich pozostałych granicach z obu stron sprawdzasz większy lub mniejszy, a nigdy równy
            //więc 0, 20, 30 to u Ciebie błędne temperatury
            //bo 40 jeszcze dobrze sprawdzasz, bo jest większe lub równe
            //błędnie zrozumiałam zakresy 
            //tu &, bo każdy warunek chcę sprawdzić

            //Drugie podejście do zad nr 9
            int temperatureInput = 41;
            if (temperatureInput < 0)
            {
                Console.WriteLine("Cholernie piździ");
            }
            else if ((temperatureInput > 0) & (temperatureInput <= 10))
            {
                Console.WriteLine("Zimno");
            }
            else if ((temperatureInput > 10) & (temperatureInput <= 20))
            {
                Console.WriteLine("Chłodno");
            }
            else if ((temperatureInput > 20) & (temperatureInput <= 30))
            {
                Console.WriteLine("W sam raz");
            }
            else if ((temperatureInput > 30) & (temperatureInput <= 40))
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco");
            }
            else if (temperatureInput >= 40)
            {
                Console.WriteLine("A weź, przeprowadzam się na Alaskę");
            }
            else
            {
                Console.WriteLine("Błędna temperatura");
            }

            //Pierwsze podejście zad nr 9
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
            //tu skracam czyli &&, bo prawdziwość każdego etapu ważna
            int first = 40;
            int second = 55;
            int third = 65;
            if ((first + second > third) && (first + third > second) && (second + third > first))
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

            //w 11 zadaniu chyba coś zaczęłaś i nie dokończyłas, bo masz tylko jeden case i to jeszcze ze złym opisem tekstowym
            //tak samo w zadaniu 12
            //czy może nie rozumiesz jak działa switch i potrzebujesz, żeby Ci to lepiej wytłumaczyć ?

            //Drugie podejście do zad nr 11
            int rating = 3;
            switch (rating)
            {
                case 1:
                    Console.WriteLine("niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("dostateczny");
                    break;
                case 4:
                    Console.WriteLine("dobry");
                    break;
                case 5:
                    Console.WriteLine("bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("celujący");
                    break;
                default:
                    Console.WriteLine("Błędne dane. Wprowadź poprawną ocenę");
                    break;
            }

            //Pierwsze podejście:
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
            //Tu też sugeruję się, że mam konkretny przypadek - tzn. wprowadzono już nr i oczekiwany jest opis
            //Tu też kolejne podejście

            //Drugie podejście zad nr 12
            //&& oba warunki, efektywność 
            Console.WriteLine("Podaj nr dnia: ");
            string dayNoInput = Console.ReadLine();
            int dayNo;
            if (int.TryParse(dayNoInput, out dayNo) && (dayNo >= 1 && dayNo <= 7))
            {
                 switch (dayNo)
                {
                    case 1:
                        Console.WriteLine("poniedziałek");
                        break;
                    case 2:
                        Console.WriteLine("wtorek");
                        break;
                    case 3:
                        Console.WriteLine("środa");
                        break;
                    case 4:
                        Console.WriteLine("czwartek");
                        break;
                    case 5:
                        Console.WriteLine("piątek");
                        break;
                    case 6:
                        Console.WriteLine("sobota");
                        break;
                    case 7:
                        Console.WriteLine("niedziela");
                        break;
                    default:
                        Console.WriteLine("Błąd. Wprowadż poprawny nr tygodnia");
                        break;
                }
            }

            //Pierwsze podejście
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