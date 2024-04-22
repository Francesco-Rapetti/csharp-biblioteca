/* 
    Si vuole progettare un sistema per la gestione di una biblioteca.
    Gli utenti si possono registrare al sistema, fornendo:
    - cognome
    - nome
    - email
    - password
    - recapito telefonico
    Gli utenti registrati possono prendere in prestito dei documenti che sono di vario tipo (libri, DVD).
    I documenti sono caratterizzati da:
    - un codice identificativo di tipo stringa
    - titolo
    - anno
    - settore (storia, matematica, economia, …)
    - uno scaffale in cui è posizionato
    - un autore (Nome, Cognome)
    Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
    L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, prendere in prestito registrando il periodo (Dal/Al) del prestito e il documento.
    Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.
    Creiamo anche una classe Biblioteca che contiene la lista dei documenti, la lista degli utenti e la lista dei prestiti.
    Contiene inoltre i metodi per le ricerche e per l’aggiunta dei documenti, utenti e prestiti.
*/

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Utenti
            Console.WriteLine(Prettifier("Utenti"));
            User user1 = new User("Pippo", "Pluto", "pippo@pluto", "pippo123", "1234567890");
            User user2 = new User("Paperino", "Paperone", "paperino@paperone", "paperino123", "1234567890");
            User user3 = new User("Topolino", "Topolino", "topolino@topolino", "topolino123", "1234567890");
            Console.WriteLine(user1);
            Console.WriteLine(user2);
            Console.WriteLine(user3);
            Console.WriteLine();

            // Autori
            Author tolkien = new Author("J.R.R.", "Tolkien");
            Author wachowski = new Author("Lana and Lilly", "Wachowski");

            // Documenti
            Console.WriteLine(Prettifier("Documenti"));
            Book book1 = new Book("The Fellowship of the Ring", 1954, Category.FANTASY, tolkien, 432);
            Book book2 = new Book("The Two Towers", 1954, Category.FANTASY, tolkien, 352);
            Book book3 = new Book("The Return of the King", 1955, Category.FANTASY, tolkien, 1228);

            DVD dvd1 = new DVD("The Matrix", 1999, Category.FANTASY, wachowski, 120);
            DVD dvd2 = new DVD("The Matrix Reloaded", 2003, Category.FANTASY, wachowski, 120);
            DVD dvd3 = new DVD("The Matrix Revolutions", 2003, Category.FANTASY, wachowski, 120);

            Console.WriteLine(book1);
            Console.WriteLine(book2);
            Console.WriteLine(book3);
            Console.WriteLine(dvd1);
            Console.WriteLine(dvd2);
            Console.WriteLine(dvd3);

            // Biblioteca
            Library library = new Library(new List<Document>() { book1, book2, book3, dvd1, dvd2, dvd3 });

            // Aggiunta utenti
            library.AddUser(user1);
            library.AddUser(user2);
            library.AddUser(user3);

            // Aggiunta prestiti
            Console.WriteLine(Prettifier("Prestiti"));
            library.AddLoan(new Loan(user1, book1));
            library.AddLoan(new Loan(user2, book2));
            library.AddLoan(new Loan(user3, book3));

            // Aggiornamento prestiti
            Loan loan1 = new Loan(user1, dvd1);
            library.AddLoan(loan1);
            loan1.Return();
            library.Loans.ForEach(loan => Console.WriteLine(loan));

            // Ricerche
            Console.WriteLine(Prettifier("Ricerche"));
            try { Console.WriteLine(library.SearchDocumentByTitle("The Return of the King")); } catch (Exception) { Console.WriteLine("Document not found"); }
            try { Console.WriteLine(library.SearchUser("pippo@pluto")); } catch (Exception) { Console.WriteLine("User not found"); }
            Console.WriteLine();
            try { Console.WriteLine(library.SearchLoan("pippo@pluto", "The Return of the King")); } catch (Exception) { Console.WriteLine("Loan not found"); }
            Console.WriteLine();
            try { Console.WriteLine(library.SearchLoan("pippo@pluto", dvd1.Id)); } catch (Exception) { Console.WriteLine("Loan not found"); }
            
        }

        public static string Prettifier(string input) 
            => $"{String.Concat(Enumerable.Repeat("-", input.Length + 2))} \n {input.ToUpper()} \n{String.Concat(Enumerable.Repeat("-", input.Length + 2))}";
    }
}
