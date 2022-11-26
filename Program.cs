using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modelisation_d_examen
{
    internal class Program
    {
       internal class evaluation
        {
            private int note;
            private String matiere;
            private String intitule;

        }
       internal class Candidat
        {
            private String nom;
            private String prenom;
            private String filiere;
            public string Name { get; set; }
            public String Prenom
            {
                get { return prenom; }
                set { prenom = value; }
            }

        }
       
       internal class date
        {
            private int date_debut;
            private int date_fin;
            public date(int date_debut, int date_fin)
            {
                this.date_debut = date_debut;
                this.date_fin = date_fin;
            }

        }
        internal class reponse
        {
            public reponse()
            {

            }
            private string rep;
            public reponse(string rep)
            {
                this.rep = rep;
            }
            public string Rep { get { return rep; } set { rep = value; } }


        }
        class Vraie:reponse
        {
            private int nbrgagne = 0;
         public void incrementernbr()
            {
                nbrgagne++;
            }
        }
        class Faux:reponse
        {
           
            private int nbrgagne;
            public int Nbrg { get { return nbrgagne; } set { nbrgagne = value; } }
            public void decrementernbr()
            {
                nbrgagne--;
            }
        }
        class Note
        {
            private string note;


        }
       internal class Question
        {
            public Question()
            {

            }
            private string question;
            private int nbrNotes;
            public String Q { get { return question; } set { question = value; } }
            public Question(string question)
            {
                this.question = question;

            }
        }
        class QCM : Question
        {

            public class proposition
            {

            }
            public class alternatives
            {

            }
        }
        class degre_certitude
        {
            public void peusur(string r,string q)
            {

            }
            public void moysur(string r,string q)
            {

            }
            public void toutsur(string r, string q)
            {

            }
        }


        class Question_ouvertes : Question
        {
            public void VraiP()
            {


            }
            public void Falsep()
            {

            }
        }




        static void Main(string[] args)
        {

        }
    }
}



