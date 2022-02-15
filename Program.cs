using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljeđivanjeVjezba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NebeskoTijelo tijelo = new NebeskoTijelo();
            Planet planet = new Planet(1000, 2000);
            Satelit satelit = new Satelit(100, 200);

            Console.WriteLine(tijelo.ispis());
            Console.WriteLine(planet.ispis());
            Console.WriteLine(satelit.ispis());

            Console.ReadKey();
        }
    }

    class NebeskoTijelo
    {
        double BrzinaOkoOsi, BrzinaOkoSunca;

        public double BrzinaOkoOsi1 { get => BrzinaOkoOsi; set => BrzinaOkoOsi = value; }
        public double BrzinaOkoSunca1 { get => BrzinaOkoSunca; set => BrzinaOkoSunca = value; }

        public virtual string ispis()
        {
            return "Nebesko Tijelo ima brzinu oko osi: " + BrzinaOkoOsi1 + " i brzinu oko sunca: " + BrzinaOkoSunca1 + ".";
        }
    }

    class Planet : NebeskoTijelo
    {
       public Planet(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi1 = brzinaOkoOsi;
            BrzinaOkoSunca1 = brzinaOkoSunca;
        }

        public override string ispis()
        {
            return "Planet ima brzinu oko osi: " + BrzinaOkoOsi1 + " i brzinu oko sunca: " + BrzinaOkoSunca1 + ".";
        }
    }

    class Satelit : NebeskoTijelo
    {
        public Satelit(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi1 = brzinaOkoOsi;
            BrzinaOkoSunca1 = brzinaOkoSunca;
        }

        public override string ispis()
        {
            return "Satelit ima brzinu oko osi: " + BrzinaOkoOsi1 + " i brzinu oko sunca: " + BrzinaOkoSunca1 + ".";
        }
    }
}
