using System;

namespace MonkeySoft_2 {
    class Program {
        static void Main( string[] args ) {
            // var res  = new PopularResidence( "001", "ciao clang", 324, 5, 1000 );
            // var res2 = new LuxuryResidence( "978AA", "Via dei Tigli,10 - Thiene", 200, 8, "A", 300 );
            // var res3 = new PopularResidence( "253BB", "Via G.Leopradi,28 – Marostica", 50, 3, 10000 );
            // var res4 = new LuxuryResidence( "978BB", "|Via Pascoli,20 - Thiene", 180, 6, "B", 300 );

            var territory = new MunicipalTerritory( "Thiene" );
            Console.WriteLine( territory.AddResidence
                                   ( "001", "ciao clang", 324, 5, 1000 ) );
            Console.WriteLine( territory.AddResidence
                                   ( "978AA", "Via dei Tigli,10 - Thiene", 200, 8, "A", 300 ) );
            Console.WriteLine( territory.AddResidence
                                   ( "253BB", "Via G.Leopradi,28 – Marostica", 50, 3, 10000 ) );
            Console.WriteLine( territory.AddResidence
                                   ( "978BB", "|Via Pascoli,20 - Thiene", 180, 6, "B", 300 ) );

            Console.WriteLine( territory.TotalTaxes() );
            Console.WriteLine( territory.ResidencesPerType() );

            territory.Save();


            Console.ReadKey();
        }
    }
}