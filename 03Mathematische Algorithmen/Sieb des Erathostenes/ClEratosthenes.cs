using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NS_Standardalgorithmen_Csharp;
using NSAnzeigen;

// bewusst als string ausgegeben, weil Umwandlung noch Schritte braucht, z.b entweder string.Split oder über zähler um länge des neuen arrays zu ermitteln um diese vor beschreibung zu instanziieren.
// der Sieb arbeitet so, dass auf die natürlichen Zahlen ab 2 jede Zahl "markiert" wird, wenn diese durch eine unmakierte Zahl geteilt wird. allso alles was durch 2 geteilt werden kann wird gestrichen, 
// dann durch 3 usw.
namespace Sieb_des_Eratosthenes
{
    internal class ClEratosthenes
    {
        private static string EratosthenesSieb(int[] original)
        {
            int[] kopie = new int[original.Length]; // kopie array, weil wir nicht-Primzahlen auf null setzen. Damit original array bestehen bleibt.
            for (int i = 0; i < original.Length; i++)
                kopie[i] = original[i];

            string array = "";
            for (int i = 1; i < kopie.Length; i++)
            {
                if (i == 1 || kopie[i] == 0) // zwei Fälle: wir setzen 1 auf null (keine Primzahl) und alle weiteren die schon auf null gesetzt wurden continuen.
                {
                    kopie[i] = 0;
                    continue;
                }

                for (int j = i + i; j < kopie.Length; j += i)   // jedes vielfache einer unmarkierten wird markiert, also auf 0 gesetzt
                {
                    kopie[j] = 0;
                }
                array += kopie[i] + " ";    // da wir alle markierten skippen .... kommen nur die Primzahlen raus, sprich jeweils die erste die keinen Teiler vor sich hatte.
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] array = (ZahlenreiheErstellenBis(120));

            ClAnzeigen.PrintIntArray(array);

            Console.WriteLine(EratosthenesSieb(array));

            ClAnzeigen.PrintIntArray(array);
        }
        private static int[] ZahlenreiheErstellenBis(int länge)
        {
            int[] zahlenReihe = new int[länge];

            for (int i = 0;i<länge;i++)
                { zahlenReihe[i] = i; }

            return zahlenReihe;
        }


    }
}
