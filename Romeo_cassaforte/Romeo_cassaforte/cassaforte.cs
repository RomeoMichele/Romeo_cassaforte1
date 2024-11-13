using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romeo_cassaforte
{
    internal class cassaforte
    {
        public bool blocco ;
        public int contatore = 0;
        public bool aperto ;
        private int nmatricola;
        private string produttore;
        private string modello;
        public long cod_sblocco;
        public decimal cod_utente;
        /*private DateTime Data;*/


        public cassaforte(int Nmatricola, string Produttore, string Modello, long Cod_sblocco /*DateTime data*/ )
        {
            this.nmatricola = Nmatricola;
            this.produttore = Produttore;
            this.modello = Modello;
            this.cod_sblocco = Cod_sblocco;
            /*Data = data;*/
        }

        public void imposta(decimal Cod_utente)
        {
   
            this.cod_utente = Cod_utente;
        }

        public void apri(decimal Cod_insert /*DateTime data_insert*/) 
        {
            if(blocco == false )
            {
                if (Cod_insert == this.cod_utente /*&& data_insert == this.Data*/)
                { 
                    this.aperto = true; 
                }
                else
                { 
                    this.contatore++;
                }
            }


        }
        
        public void chiudi()
        {
            aperto = false;
        }

        public void sblocca(decimal Cod_insert)
        {
            if(Cod_insert==this.cod_sblocco ) 
            {
                blocco = false;

            }
        }
    }


  

}
