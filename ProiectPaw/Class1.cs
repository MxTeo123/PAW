using System;
using System.Collections.Generic;
using static AsigurareAuto;

// Interfața IClonable
public interface IClonable
{
    object Clone();
}

// Interfața IComparable
public interface IComparable<T>
{
    int CompareTo(T other);
}
// Clasa pentru reprezentarea unui client
public abstract class Client
{
    public int ClientId { get; set; }
    public string Nume { get; set; }
    public string Prenume { get; set; }
    public string Adresa { get; set; }
    public string Parola { get; set; }
    public List<PolitaAsigurare> Polite { get; set; }

    public Client(int clientId, string nume, string prenume, string adresa, string parola)
    {
        ClientId = clientId;
        Nume = nume;
        Prenume = prenume;
        Adresa = adresa;
        Parola = parola;
        Polite = new List<PolitaAsigurare>();
    }

    public void AdaugaPolita(PolitaAsigurare polita)
    {
        Polite.Add(polita);
    }
    public abstract object Clone();

    public abstract int CompareTo(AsigurareBase other);
    public void nrAsig()
    {
        int nr = 0;
        foreach (PolitaAsigurare polita in Polite)
        {
            nr++;
        }
            Console.WriteLine(nr);
    }
}


// Clasa pentru reprezentarea unei asigurări
public abstract class AsigurareBase
{
    public int AsigurareId { get; set; }
    public string Tip { get; set; }
    public decimal SumaAsigurata { get; set; }
    protected AsigurareBase(int asigurareId, string tip, decimal sumaAsigurata)
    {
        AsigurareId = asigurareId;
        Tip = tip;
        SumaAsigurata = sumaAsigurata;
    }

    public abstract object Clone();

    public abstract int CompareTo(AsigurareBase other);
}

// Clasa pentru asigurările de viață
public class AsigurareViata : AsigurareBase
{
    public int Durata { get; private set; }

    public AsigurareViata(int asigurareId, string tip, decimal sumaAsigurata, int durata)
        : base(asigurareId, tip, sumaAsigurata)
    {
        Durata = durata;
    }

    public override object Clone()
    {
        return new AsigurareViata(AsigurareId, Tip, SumaAsigurata, Durata);
    }

    public override int CompareTo(AsigurareBase other)
    {
        if (other is AsigurareViata otherViata)
        {
            return Durata.CompareTo(otherViata.Durata);
        }

        throw new ArgumentException("Cannot compare different types of insurance.");
    }

    // Supraincarcare de operatori
    public static bool operator <(AsigurareViata a1, AsigurareViata a2)
    {
        return a1.CompareTo(a2) < 0;
    }

    public static bool operator >(AsigurareViata a1, AsigurareViata a2)
    {
        return a1.CompareTo(a2) > 0;
    }
}

// Clasa pentru asigurările auto
public class AsigurareAuto : AsigurareBase
{
    public string NrInmatriculare { get; private set; }

    public AsigurareAuto(int asigurareId, string tip, decimal sumaAsigurata, string nrInmatriculare)
        : base(asigurareId, tip, sumaAsigurata)
    {
        NrInmatriculare = nrInmatriculare;
    }

    public override object Clone()
    {
        return new AsigurareAuto(AsigurareId, Tip, SumaAsigurata, NrInmatriculare);
    }

    public override int CompareTo(AsigurareBase other)
    {
        if (other is AsigurareAuto otherAuto)
        {
            return NrInmatriculare.CompareTo(otherAuto.NrInmatriculare);
        }

        throw new ArgumentException("Cannot compare different types of insurance.");
    }
    // Clasa pentru reprezentarea unei polite de asigurare
    public class PolitaAsigurare
    {
        public int PolitaId { get; set; }
        public AsigurareBase Asigurare { get; set; }
        public DateTime DataIncheiere { get; set; }
        public DateTime DataExpirare { get; set; }

        public PolitaAsigurare(int politaId, AsigurareBase asigurare, DateTime dataIncheiere, DateTime dataExpirare)
        {

            PolitaId = politaId;
            Asigurare = asigurare;
            DataIncheiere = dataIncheiere;
            DataExpirare = dataExpirare;
        }
        public void dateAsig()
        {
            Console.WriteLine(PolitaId+" "+Asigurare);
        }
    }
    
}

