//Tema1 PIU Andrei Ventuneac 3121A Calculatoare
//Realizare meniu
//Optiune de reexaminare
//Optiune de creste nota
//Optiuni afisare

using System;

namespace Teema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tema1 PIU Andrei Ventuneac 3121A Calculatoare\n");
            string intrebare_;
            string[] intrebare = new string[] { "Ce functie este utilizata pentru a afisa un text pe o line de consola?", "Ce functie este utilizata pentru a citi o linie de pe consola?", "O clasa poate avea membrii publici?" };
            string[] raspunss = new string[] { "Console.WriteLine()", "Console.ReadLine()", "DA" };
            //test primul elev + afisare
            Student elev = new Student("Andrei, Tudor, 10");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("LISTA ELEVI + NOTE + situatie: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(elev.ConversieLaSir());

            //sir de obiecte + functie random
            string[] nume = new string[] { "Popescu", "Maradona", "Georgescu", "Scutescu" };
            string[] prenume = new string[] { "Andrei", "Alexandru", "Mircea", "Stefan" };

            Student[] elevi = new Student[50];
            Random rnd = new Random();
            for (int i = 0; i <= 10; i++)
            {
                string nume_ = nume[rnd.Next(0, nume.Length)];
                string prenume_ = prenume[rnd.Next(0, prenume.Length)];
                double nota_ = rnd.Next(1, 10);
                elevi[i] = new Student(nume_, prenume_, nota_);
                elevi[i].setstatus(nota_);
                Console.WriteLine(elevi[i].ConversieLaSir());
            }
            //afisare elevi respinsi
            int nr = 0;
            Console.WriteLine("\nElevii respinsi:");
            for (int i = 0; i <= 10; i++)
            {
                if (elevi[i].afisareresp() != string.Empty)
                {
                    nr++;
                    Console.WriteLine(elevi[i].afisareresp());
                }
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nR: Reexaminare elevi");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("C: Crestere nota elevi admisi");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("A: Afisare lista elevi");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("F: Afisare lista elevi respinsi");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("O: Comparare doi elevi");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("X: Exit");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("ALEGERE OPTIUNE: ");
                string c = Console.ReadLine();
                switch (c)
                {
                    case "R":
                        Console.WriteLine("\nDoriti o reexaminare a elevilor? (DA/NU)\n");
                        string raspuns;
                        raspuns = Console.ReadLine();
                        int admis = 0;

                        if (raspuns == "DA")
                        {
                            for (int i = 0; i <= 10; i++)
                            {
                                if (elevi[i].getstatus().Equals("respins"))
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n\n---------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("|                                                                                                              |");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("|   " + string.Format(elevi[i].getnumepr() + " cu intrebarea:  "));
                                    intrebare_ = intrebare[rnd.Next(0, intrebare.Length)];
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(" " + intrebare_ + "\n");
                                    Console.WriteLine("|                                                                                                              |");
                                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                    Console.Write("\nRASPUNS : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string raspuns_ = Console.ReadLine();

                                    for (int j = 0; j <= 2; j++)
                                    {
                                        if (intrebare_.Equals(intrebare[j]))
                                        {
                                            if (raspuns_.Equals(raspunss[j]))
                                            {
                                                admis = 1;
                                            }
                                            else
                                            {
                                                admis = 0;
                                            }
                                        }
                                    }

                                    if (admis == 1)
                                    {
                                        Console.WriteLine("Felicitari sunteti admis cu nota 5!\n");
                                        elevi[i].setnota(5);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ati picat iar testul!");
                                    }

                                }
                            }
                        }

                        //reexaminare - raspunde la o intrebare pentru a trece sau ramai picat!
                        //reafisare elevi respinsi
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nElevii respinsi dupa reactualizare:");
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int i = 0; i <= 10; i++)
                        {
                            if (elevi[i].getstatus().Equals("respins") && elevi[i].afisareresp() != string.Empty)
                            {
                                Console.WriteLine(elevi[i].afisareresp());
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "C":
                        Console.WriteLine("\nDoriti marirea notelor elevilor admisi? (DA/NU)\n");
                        string raspuns1;
                        raspuns1 = Console.ReadLine();
                        int admis1 = 0;
                        if (raspuns1 == "DA")
                        {
                            for (int i = 0; i <= 10; i++)
                            {
                                if (elevi[i].getstatus().Equals("admis") && elevi[i].nota < 10)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\n\n---------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("|                                                                                                              |");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write("|   " + string.Format(elevi[i].getnumepr() + " cu intrebarea:  "));
                                    intrebare_ = intrebare[rnd.Next(0, intrebare.Length)];
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(" " + intrebare_ + "\n");
                                    Console.WriteLine("|                                                                                                              |");
                                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                    Console.Write("\nRASPUNS : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string raspuns_ = Console.ReadLine();

                                    for (int j = 0; j <= 2; j++)
                                    {
                                        if (intrebare_.Equals(intrebare[j]))
                                        {
                                            if (raspuns_.Equals(raspunss[j]))
                                            {
                                                admis1 = 1;
                                            }
                                            else
                                            {
                                                admis1 = 0;
                                            }
                                        }
                                    }

                                    if (admis1 == 1)
                                    {
                                        Console.WriteLine("Felicitari ti-ai marit nota cu un punct!\n");
                                        elevi[i].nota += 1;

                                    }
                                    else
                                    {
                                        Console.WriteLine("Raspuns gresit!");
                                    }

                                }
                            }
                        }


                        //reafisare elevi admisi
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nNotele elevilor admisi dupa reactualizare: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int i = 0; i <= 10; i++)
                        {
                            if (elevi[i].getstatus().Equals("admis") && elevi[i].afisareadmis() != string.Empty)
                            {
                                Console.WriteLine(elevi[i].afisareadmis());
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "A":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nAFISARE LISTA ELEVI");
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int i = 0; i <= 10; i++)
                        {
                            Console.WriteLine(elevi[i].ConversieLaSir());
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "F":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nElevii respinsi");
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int i = 0; i <= 10; i++)
                        {
                            if (elevi[i].getstatus().Equals("respins") && elevi[i].afisareresp() != string.Empty)
                            {
                                Console.WriteLine(elevi[i].afisareresp());
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "O":
                        Console.Write("\nCITIRE NUMAR SUDENT1: ");
                        int nrstud1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("CITIRE NUMAR SUDENT2: ");
                        int nrstud2 = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Ati ales studentii " + elevi[nrstud1].numecomplet + "cu nota " + elevi[nrstud1].nota + " si " + elevi[nrstud2].numecomplet + "cu nota " + elevi[nrstud2].nota);
                        Console.ForegroundColor = ConsoleColor.White;
                        int ok;
                        ok = elevi[nrstud1].compare(elevi[nrstud2]);

                        if (ok == Student.MARE)
                        {
                            Console.WriteLine("ELEVUL " + elevi[nrstud1].numecomplet + " > ELEVUL " + elevi[nrstud2].numecomplet);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Aveam asteptari mai mari pentru tine domnule " + elevi[nrstud2].numecomplet);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.WriteLine("ELEVUL " + elevi[nrstud1].numecomplet + " < ELEVUL " + elevi[nrstud2].numecomplet);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Aveam asteptari mai mari pentru tine domnule " + elevi[nrstud1].numecomplet);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "X":
                        Environment.Exit(0);
                        break;

                }


            }

        }
    }
}
