using System;
using System.Collections.Generic;
using System.Text;

namespace Teema1
{
    class Student
    {
        public const int MINIM = 5;
        const int NM = 0;
        const int PR = 1;
        const int NT = 2;
        public const string GOOD = "admis";
        public const string BAD = "respins";
        public const int MARE = 1;
        public const int MIC = 0;


        public string nume { get; set; }
        public string prenume { get; set; }
        public double nota { get; set; }
        public string status { get; set; }
        public string numecomplet { get; set; }

        public Student()
        {
            nota = 0;
            nume = string.Empty;
            prenume = string.Empty;
            status = string.Empty;
            numecomplet = nume + ' ' + prenume;
        }

        public Student(string nume_, string prenume_, double nota_)
        {
            nota = nota_;
            nume = nume_;
            prenume = prenume_;
            numecomplet = nume + ' ' + prenume;
        }

        public string ConversieLaSir()
        {
            if (status==GOOD)
                return string.Format("Elevul {0} {1} are nota {2} si este admis", nume, prenume, nota);
            else
                return string.Format("Elevul {0} {1} are nota {2} si este respins", nume, prenume, nota);
        }

        public string Afisareresp()
        {
            if (status == BAD)
                return string.Format("{0} {1} : nota {2}", nume, prenume, nota);
            else
                return string.Empty;
        }

        public string Afisareadmis()
        {
            if (status == GOOD)
                return string.Format("{0} {1} : nota {2}", nume, prenume, nota);
            else
                return string.Empty;
        }

        public Student(string text)
        {
            int k = 0;
            string[] cuvinte = text.Split(", ");
            foreach (string cuv in cuvinte)
            {
                if (k == NM)
                    nume = cuv;
                if (k == PR)
                    prenume = cuv;
                if (k == NT)
                    nota = Convert.ToDouble(cuv);
                k++;
            }
            numecomplet = nume + ' ' + prenume;
        }
        
        public int Compare(Student el)
        {
            int ok = 0;
            if (this.nota > el.nota)
                ok = MARE;
            if (this.nota == el.nota)
                ok = String.Compare(this.nume, el.nume);
            if (this.nota < el.nota)
                ok = MIC;

            return ok;
        }
    }
}
