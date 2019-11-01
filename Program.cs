using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorbereitung
{
    class Program
    {
        static void Main(string[] args)
        {
            int auswahl;
            Console.WriteLine("1 Zeichen ersetzen");
            Console.WriteLine("2 Vokale entfernen");
            Console.WriteLine("3 Quersumme berechnen");
            Console.WriteLine("4 Passwort überprüfen");
            auswahl = Convert.ToInt32(Console.ReadLine());

            if (auswahl==1)
            {
                string a,u="";
                char b, c;
                Console.WriteLine("Text eingeben");
                a = Convert.ToString(Console.ReadLine());
                Console.WriteLine(a);
                Console.WriteLine("Welches Zeichen möchten Sie ersetzen");
                b= Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Mit welchem Zeichen soll ersetzt werden");
                c = Convert.ToChar(Console.ReadLine());
                for(int i=0;i<a.Length;i++)
                {
                    if (a[i]==b)
                    {
                        u += c;
                    }
                    else
                    {
                        u += a[i];
                    }

                }
                Console.WriteLine(u);
          

            }
            else if(auswahl==2)
            {
                string t, u="";
                Console.WriteLine("Text eingeben");
                t = Convert.ToString(Console.ReadLine());
                 for(int z=0;z<t.Length;z++)
                {
                  if (t[z]=='a'||t[z]=='e'||t[z]=='o'||t[z]=='u')
                    {
                        u += "";
                    }
                    else
                    {
                        u += t[z];
                    }
                }
                Console.WriteLine(u);

            }
            else if (auswahl==3)
            {
         string a;
                int u=0;

                Console.WriteLine("Zahlen eingeben");
                a = Convert.ToString(Console.ReadLine());
                for (int i=0;i<a.Length;i++)
                {
                    u += (Convert.ToInt32(Convert.ToString(a[i])));
                }
                Console.WriteLine(u);


            }
            else if(auswahl==4)
            {
                string passwort;
                Console.WriteLine("Passwort eingeben");
            PW:
                passwort = Convert.ToString(Console.ReadLine());

                if (passwort.Length < 8)
                {
                    Console.WriteLine("Passwort ist zu kurz");
                    goto PW;
                }
                else if (!ContainsUpperCase(passwort))
                {
                    Console.WriteLine("Passwort enthält keine Großbuchstaben");
                    goto PW;
                }
                else if (!ContainsLowerCase(passwort))
                {
                    Console.WriteLine("Passwort enthält keine Keinbuchstaben");
                    goto PW;
                }
                else if (!ContainSimbol(passwort))
                {
                    Console.WriteLine("Passwort kann nicht Zeichen enthälten");
                    goto PW;
                }
                else if (!ContainsNumber(passwort))
                {
                    Console.WriteLine("Passwort enthält keine Zahl");
                    goto PW;
                }
               else
                {
                    Console.WriteLine("Das Passwort ist gut");
                }
                  
            }
                  
        }
        static bool ContainsUpperCase(string passwort)
        {
            bool a = false;
            for (int q=0;q<passwort.Length;q++)
            {
                if (Char.IsUpper(passwort[q])) a = true;
            }
            return a;
        }
        static bool ContainsLowerCase(string passwort)
        {
            bool w = false;
            for(int q=0;q<passwort.Length;q++)
            {
                if (Char.IsLower(passwort[q])) w = true;
            }
            return w;
        }
        static bool ContainSimbol(string passwort)
        {
            bool g = false;
            for(int q=0;q<passwort.Length;q++)
            {
                if (Char.IsLetter(passwort[q])) g = true;
            }
            return g;
        }
        static bool ContainsNumber(string passwort)
        {
            bool r = false;
            for(int w=0;w<passwort.Length;w++)
            {
                if (Char.IsDigit(passwort[w])) r = true;
            }
            return r;
        }

    }
}
