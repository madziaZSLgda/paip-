using System.Collections.Generic;
public enum Plec
{
    kobieta,
    mezczyzna
}
class Uczen
{

    public string imie;
    public string nazwisko;
    public Plec plec;
    public int inteligencja;
    public int sila;
    public string id;


    public Uczen(string imie, string nazwisko, Plec plec, int inteligencja, int sila)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.plec = plec;
        this.inteligencja = inteligencja;
        this.sila = sila;
        Random rnd = new Random();
        id = rnd.Next(1, 100).ToString();
    }

    public void Wyswietl()
    {
        Console.WriteLine("------------ Uczen " + this.imie + " " + this.nazwisko + " [id: "+ this.id + "] i jego supermoce: ------------");
        Console.WriteLine(" ----- Inteligencja: " + this.inteligencja);
        Console.WriteLine(" ----- Sila: " + this.sila);
        Console.WriteLine(" ----- Plec: " + this.plec);
    }
}

class Klasa
{
    // private Uczen[] klasa;
    public List<Uczen> klasa = new List<Uczen>();
    public Uczen[] tablica = new Uczen[30];
    public double srednia_inteligencja;
    public double srednia_sila;
    public double procent_m;
    public double procent_k;
    public int liczba_uczniow;
    public int liczba_k;
    public int liczba_m;
    public string id;
    private int l;
    public void AddUczen(Uczen uczen)
    {
        l++;
        klasa.Add(uczen);
        //Dodawanie oznaczenia klasy do id znajdujacych sie w niej uczniow
        uczen.id = this.id + l;

        Procent_k();
        Procent_m();
        SredniaInteligencja();
        SredniaSila();
        this.liczba_uczniow = klasa.Count;
    }

    public Klasa(string id)
    {
        this.id = id;
        this.l=0;
        this.liczba_k = 0;
        this.liczba_m = 0;
    }
    
    public void Wyswietl()
    {
        Console.WriteLine("===================================================== Klasa  " + this.id + " ============================================================= ");
        Console.WriteLine("liczba uczniow: "+this.liczba_uczniow +"  ||  mezczyzni:  "+ this.procent_m +"%  ||  kobiety:  " + this.procent_k + "%  ||  srednia inteligencja:  " + this.srednia_inteligencja + "  ||  srednia sila:  " + this.srednia_sila +" ");
        Console.WriteLine("============================================================================================================================= ");
        foreach (var uczen in klasa)
        {
            uczen.Wyswietl();
        }
        Console.WriteLine("");

    }

    public double Procent_m()
    {
        double n = 0;
        foreach (var uczen in klasa)
        {
            if (uczen.plec == Plec.mezczyzna) { 
                n++;
                liczba_m++;
            }
        }
        n = Math.Round((n / klasa.Count)*100, 2);
        this.procent_m=n;
        return n;
    }
    public double Procent_k()
    {
        double n = 0;
        foreach (var uczen in klasa)
        {
            if (uczen.plec == Plec.kobieta)
            {
                liczba_k++;
                n++;
            }
        }
        n = Math.Round((n / klasa.Count) * 100, 2);
        this.procent_k = n;
        return n;
    }
    public double SredniaInteligencja()
    {
        double srednia = 0;
        foreach (var uczen in klasa)
        {
            srednia += uczen.inteligencja;
        }
        srednia /= klasa.Count;
        srednia = Math.Round(srednia, 2);
        this.srednia_inteligencja = srednia;
        return srednia;
    }
    public double SredniaSila()
    {
        double srednia = 0;
        foreach (var uczen in klasa)
        {
            srednia += uczen.sila;
        }
        srednia /= klasa.Count;
        srednia = Math.Round(srednia, 2);
        this.srednia_sila = srednia;
        return srednia;
    }
}

class Szkola
{
    private List<Klasa> szkola = new List<Klasa>();
    public int ilosc_klas;
    public int liczba_uczniow;
    public string nazwa;
    public string id;
    public double srednia_inteligencja;
    public double srednia_sila;
    public double procent_m;
    public double procent_k;

    public void AddKlasa(Klasa dodawana)
    {
        //Dodawanie oznaczenia szkoly do id znajdujacych sie w niej uczniow
        foreach (var uczen in dodawana.klasa)
        {
            uczen.id = "zsl" + uczen.id;
        }
        
        szkola.Add(dodawana);
        Procent_k();
        Procent_m();
        SredniaInteligencja();
        SredniaSila();
        LiczbaUczniow();
        
        this.ilosc_klas=szkola.Count;

    }
    public Szkola(string nazwa, string id)
    {
        this.nazwa = id;
        this.nazwa = nazwa;
    }
    public void Wyswietl()
    {
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.WriteLine("=================================================       " + this.nazwa + "       ========================================================");
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.WriteLine("ilosc klas: " + this.ilosc_klas + "  ||  liczba uczniow: " + this.liczba_uczniow + "  ||  mezczyzni:  " + this.procent_m + "%  ||  kobiety:  " + this.procent_k + "%  ||  srednia inteligencja:  " + this.srednia_inteligencja + "  ||  srednia sila:  " + this.srednia_sila);
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.WriteLine("");
        foreach (var klasa in szkola)
        {
            klasa.Wyswietl();
        }
        
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

    }
    public double Procent_m()
    {
        double n = 0;
        foreach (var klasa in szkola)
        {
            n += klasa.procent_m;
        }
        n /= szkola.Count;
        n = Math.Round(n, 2);
        this.procent_m = n;
        return n;
    }
    public double Procent_k()
    {
        double n = 0;
        foreach (var klasa in szkola)
        {
            n += klasa.procent_k;
        }
        n /= szkola.Count;
        n = Math.Round(n, 2);
        this.procent_k = n;
        return n;
    }
    public double SredniaInteligencja()
    {
        double srednia = 0;
        foreach (var klasa in szkola)
        {
            srednia += klasa.srednia_inteligencja;
        }
        srednia /= szkola.Count;
        srednia = Math.Round(srednia, 2);
        this.srednia_inteligencja = srednia;
        return srednia;
    }
    public double SredniaSila()
    {
        double srednia = 0;
        foreach (var klasa in szkola)
        {
            srednia += klasa.srednia_sila;
        }
        srednia /= szkola.Count;
        srednia = Math.Round(srednia, 2);
        this.srednia_sila = srednia;
        return srednia;
    }
    public int LiczbaUczniow()
    {
        int n = 0;
        foreach(var klasa in szkola)
        {
            n += klasa.liczba_uczniow;
        }
        this.liczba_uczniow = n;
        return n;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
       
        string[] mimiona = { "Belzebub", "Ignacy", "Bozydar", "Korniszon", "Waclaw", "Jerzy", "Misiek", "Bronislaw"};
        string[] kimiona = { "Konstancja", "Izyda", "Genowefa", "Kunegunda", "Oksana", "Jagoda", "Kamila", "Julita" };
        string[] nazwiska = { "Wieczorek", "Kielbasa", "Ryszard", "Nowak", "Podloga", "Ozorek", "Sosna", "Bagienko", "Przystan", "Michalek", "Olej", "Kowal" };


        Uczen u1 = new Uczen(mimiona[rnd.Next(0,7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u2 = new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u3 = new Uczen(kimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.kobieta, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u4 = new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u5 = new Uczen(kimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.kobieta, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u6 = new Uczen(kimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.kobieta, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u7 = new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u8 = new Uczen(kimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.kobieta, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u9 = new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u10 = new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u11= new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u12= new Uczen(kimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.kobieta, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u13= new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u14= new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u15= new Uczen(kimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.kobieta, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u16= new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u17= new Uczen(kimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.kobieta, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u18= new Uczen(kimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.kobieta, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u19 = new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u20 = new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u21= new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u22 = new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u23= new Uczen(mimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.mezczyzna, rnd.Next(0, 99), rnd.Next(0, 99));
        Uczen u24= new Uczen(kimiona[rnd.Next(0, 7)], nazwiska[rnd.Next(0, 11)], Plec.kobieta, rnd.Next(0, 99), rnd.Next(0, 99));

        Klasa k1 = new Klasa("1a");
        Klasa k2 = new Klasa("1b");
        Klasa k3 = new Klasa("2a");
        Klasa k4 = new Klasa("3a");

        Szkola s1 = new Szkola("Zespol Szkol Lacznosci","zsl");

        k1.AddUczen(u1);
        k1.AddUczen(u2);
        k1.AddUczen(u3);
        k1.AddUczen(u4);
        k1.AddUczen(u5);
        k1.AddUczen(u6);

        k2.AddUczen(u7);
        k2.AddUczen(u8);
        k2.AddUczen(u9);
        k2.AddUczen(u10);
        k2.AddUczen(u11);
        k2.AddUczen(u12);

        k3.AddUczen(u13);
        k3.AddUczen(u14);
        k3.AddUczen(u15);
        k3.AddUczen(u16);
        k3.AddUczen(u17);
        k3.AddUczen(u18);

        k4.AddUczen(u19);
        k4.AddUczen(u20);
        k4.AddUczen(u21);
        k4.AddUczen(u22);
        k4.AddUczen(u23);
        k4.AddUczen(u24);

        s1.AddKlasa(k1);
        s1.AddKlasa(k2);
        s1.AddKlasa(k3);
        s1.AddKlasa(k4);

        s1.Wyswietl();


       
    }
}


