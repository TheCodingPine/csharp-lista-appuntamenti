using lista_appuntamenti;

/*
Per ogni appuntamento chiediamo le informazioni necessarie e inizializziamo un oggetto Appuntamento, stando attenti a gestire eventuali eccezioni,
ossia se uno sbaglia quell'appuntamento deve essere ri-richiesto. Inseriamo l’oggetto appuntamento correttamente inizializzato nella lista.
Alla fine stampate in maniera user-friendly (usando possibilmente l'override del metodo ToString(); della classe Object) la lista dei vostri appuntamenti futuri.*/


List<Appuntamento> listaAppuntamenti = new List<Appuntamento>(); //my lista vuota

Console.Write("Inserire il numero di appuntamenti: ");
int numeroDiAppuntamenti = Int32.Parse(Console.ReadLine()); //dovrei fare un try per null?

while (numeroDiAppuntamenti > 0) //suggerito dall'IDE
{
    Console.Write("Nome dell'appuntamento: ");
    string nome = Console.ReadLine();
    Console.Write("")
}
