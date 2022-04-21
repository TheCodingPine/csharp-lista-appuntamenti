using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*A tale scopo dovremmo creare una classe Appuntamento che si occupa di salvare e gestire (costruttore e metodi opportuni) eventuali appuntamenti.
La classe Appuntamento avrà:


>Tutti gli eventuali altri Getters e Setters*/

namespace lista_appuntamenti
{
    internal class Appuntamento
    {
        private string nome;
        private string luogo;
        public DateTime data;

        //costruttore che inizializza i campi e controlli che la data non sia antecedente + exception

        public Appuntamento(string nome, string luogo, DateTime data)
        {
            try
            {
                isDataValida(this.data);
            }
            catch (Exception ex) //consigliata dal compiler et https://docs.microsoft.com/it-it/dotnet/csharp/language-reference/keywords/try-catch
            {
                Console.WriteLine("Eccezione:" + ex.Message); //consigliato dal compiler!
            }

            this.nome = nome;
            this.luogo = luogo;
           // this.data = data; inutile quando avrò il metodo nel try

        }


        //metodo interno per controllare la validità della data

        internal void isDataValida(DateTime data)
        {
            if (data == null) //why "a value of datatime is never equal to null"?
            {
                throw new ArgumentNullException("data");
            } else if (data < DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("Data antecedente a quella odierna");
            } else
            {
                this.data = data;
            }
        }



        //metodo per cambiare Date "dove riceverà un nuovo oggetto di tipo DateTime" + exception se antecedente

        











    }
}
