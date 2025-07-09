using BancaSharp.programma;
using System;
using System.Collections.Generic;

public class Banca
{
    public string Nome { get; set; }
    public List<Cliente> Clienti { get; set; } = new List<Cliente>();
    public Dictionary<string, List<int>> Prestiti { get; set; } = new Dictionary<string, List<int>>();

    public void AggiungiCliente(Cliente cliente)
    {
        Clienti.Add(cliente);
    }

    public void AggiungiPrestito(string codiceFiscale, int ammontare)
    {
        if (!Prestiti.ContainsKey(codiceFiscale))
        {
            Prestiti[codiceFiscale] = new List<int>();
        }
        Prestiti[codiceFiscale].Add(ammontare);
    }

    public int AmmontareTotalePrestiti(string codiceFiscale)
    {
        if (Prestiti.ContainsKey(codiceFiscale))
        {
            return Prestiti[codiceFiscale].Sum();
        }
        return 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var banca = new Banca { Nome = "BancaSharp" };

        banca.AggiungiCliente(new Cliente
        {
            Nome = "Mario",
            Cognome = "Rossi",
            CodiceFiscaleIntestatario = "RSSMRA80A01H501U",
            Ammontare = 5000,
            DataInizio = new DateTime(2025, 1, 10),
            DataFine = new DateTime(2027, 1, 10),
            DataRichiesta = new DateTime(2025, 1, 5),
            Stipendio = 2500
        });
        banca.AggiungiCliente(new Cliente
        {
            Nome = "Anna",
            Cognome = "Bianchi",
            CodiceFiscaleIntestatario = "BNCNNA85C41H501Z",
            Ammontare = 7000,
            DataInizio = new DateTime(2025, 2, 15),
            DataFine = new DateTime(2028, 2, 15),
            DataRichiesta = new DateTime(2025, 2, 10),
            Stipendio = 3000
        });
        banca.AggiungiCliente(new Cliente
        {
            Nome = "Luca",
            Cognome = "Verdi",
            CodiceFiscaleIntestatario = "VRDLCA90D12H501Y",
            Ammontare = 3000,
            DataInizio = new DateTime(2025, 3, 1),
            DataFine = new DateTime(2026, 3, 1),
            DataRichiesta = new DateTime(2025, 2, 25),
            Stipendio = 2500
        });
        banca.AggiungiCliente(new Cliente
        {
            Nome = "Giulia",
            Cognome = "Neri",
            CodiceFiscaleIntestatario = "NRIGLU95E22H501X",
            Ammontare = 8000,
            DataInizio = new DateTime(2025, 4, 20),
            DataFine = new DateTime(2029, 4, 20),
            DataRichiesta = new DateTime(2025, 4, 15),
            Stipendio = 3500
        });
        banca.AggiungiCliente(new Cliente
        {
            Nome = "Paolo",
            Cognome = "Gialli",
            CodiceFiscaleIntestatario = "GLIPAO70F15H501W",
            Ammontare = 4500,
            DataInizio = new DateTime(2025, 5, 5),
            DataFine = new DateTime(2027, 5, 5),
            DataRichiesta = new DateTime(2025, 5, 1),
            Stipendio = 2000
        });
        banca.AggiungiCliente(new Cliente
        {
            Nome = "Sara",
            Cognome = "Blu",
            CodiceFiscaleIntestatario = "BLUSRA88G30H501V",
            Ammontare = 6000,
            DataInizio = new DateTime(2025, 6, 10),
            DataFine = new DateTime(2028, 6, 10),
            DataRichiesta = new DateTime(2025, 6, 5),
            Stipendio = 3000
        });
        banca.AggiungiCliente(new Cliente
        {
            Nome = "Marco",
            Cognome = "Rosa",
            CodiceFiscaleIntestatario = "RSAMRC92H10H501U",
            Ammontare = 3500,
            DataInizio = new DateTime(2025, 7, 15),
            DataFine = new DateTime(2026, 7, 15),
            DataRichiesta = new DateTime(2025, 7, 10),
            Stipendio = 2500
        });
        banca.AggiungiCliente(new Cliente
        {
            Nome = "Elisa",
            Cognome = "Viola",
            CodiceFiscaleIntestatario = "VLELSA87I25H501T",
            Ammontare = 9000,
            DataInizio = new DateTime(2025, 8, 20),
            DataFine = new DateTime(2030, 8, 20),
            DataRichiesta = new DateTime(2025, 8, 15),
            Stipendio = 4000
        });
        banca.AggiungiCliente(new Cliente
        {
            Nome = "Davide",
            Cognome = "Marrone",
            CodiceFiscaleIntestatario = "MRRDVD80L05H501S",
            Ammontare = 4000,
            DataInizio = new DateTime(2025, 9, 25),
            DataFine = new DateTime(2027, 9, 25),
            DataRichiesta = new DateTime(2025, 9, 20),
            Stipendio = 3000
        });
        banca.AggiungiCliente(new Cliente
        {
            Nome = "Federica",
            Cognome = "Grigio",
            CodiceFiscaleIntestatario = "GRIFED85M20H501R",
            Ammontare = 5500,
            DataInizio = new DateTime(2025, 10, 30),
            DataFine = new DateTime(2028, 10, 30),
            DataRichiesta = new DateTime(2025, 10, 25),
            Stipendio = 2500
        });

        Console.WriteLine("Clienti caricati: " + banca.Clienti.Count);
        foreach (var cliente in banca.Clienti)
        {
            Console.WriteLine($"Nome: {cliente.Nome}, Cognome: {cliente.Cognome}, Codice Fiscale: {cliente.CodiceFiscaleIntestatario}, Ammontare: {cliente.Ammontare}, Data inizio: {cliente.DataInizio}, Data fine: {cliente.DataFine}, Stipendio: {cliente.Stipendio}");
        }



        Console.ReadLine();
        Console.WriteLine("Inserire codice fiscale");
        string codiceFiscale = Console.ReadLine();
        var clienteTrovato = banca.Clienti.Find(c => c.CodiceFiscaleIntestatario == codiceFiscale);
        if (clienteTrovato != null)
        {
            Console.WriteLine($"Cliente trovato: {clienteTrovato.Nome} {clienteTrovato.Cognome}, Ammontare totale prestiti: {banca.AmmontareTotalePrestiti(clienteTrovato.CodiceFiscaleIntestatario)}");

        }
        else
        {
            Console.WriteLine("Cliente non trovato.");
        }
    }

    }
