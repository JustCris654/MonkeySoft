using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MonkeySoft_2 {
    public struct ResPerType {
        public int popular;
        public int luxury;

        public ResPerType( int popular, int luxury ) {
            this.popular = popular;
            this.luxury  = luxury;
        }

        public override string ToString( ) {
            return "Abitazioni popolari:  " + popular + "\n" +
                   "Abitazioni di lusso:  " + luxury;
        }
    }

    public class MunicipalTerritory {
        private string          _name;
        private List<Residence> _residences;

        public string Name => _name;

        public MunicipalTerritory( string name ) {
            _name       = name;
            _residences = new List<Residence>();
        }

        public bool AddResidence( string code, string address, int meters, int spaces, int salary ) {
            var newResidence = new PopularResidence( code, address, meters, spaces, salary );
            if ( _residences.Any( x => x.Address == address ) ) return false;
            _residences.Add( newResidence );
            return true;
        }

        public bool AddResidence( string code, string address, int meters, int spaces, string energyClass,
                                  int    terrainExtension ) {
            var newResidence = new LuxuryResidence( code, address, meters, spaces, energyClass, terrainExtension );
            if ( _residences.Any( x => x.Address == address ) ) return false;
            _residences.Add( newResidence );
            return true;
        }

        public double TotalTaxes( ) {
            return _residences.Sum( x => x.PropertyTax() );
        }

        public ResPerType ResidencesPerType( ) {
            return new ResPerType( _residences.Count( x => ( x is PopularResidence ) ),
                                   _residences.Count( x => ( x is LuxuryResidence ) ) );
        }

        public override string ToString( ) {
            string tmp = "Nome comune: " + Name + "\n";
            _residences.ForEach( x => tmp += x.ToString() +"\n" );
            return tmp;
        }

        public void Save( ) {
            StreamWriter write =
                new StreamWriter( "./../../../output.txt"/*, append: true */);
            write.WriteLine( this.ToString() );
            write.Close();
        }
    }
}