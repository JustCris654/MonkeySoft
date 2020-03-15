namespace MonkeySoft_2 {
    public class LuxuryResidence : Residence {
        private string _energyClass;
        private int    _terrainExtension;

        public LuxuryResidence( string code, string address, int meters, int spaces, string energyClass,
                                int    terrainExtension )
            : base( code, address, meters, spaces ) {
            _energyClass      = energyClass;
            _terrainExtension = terrainExtension;
        }

        public string EnerrgyClass {
            get => _energyClass;
            set => _energyClass = value;
        }

        public int TerrainExtension {
            get => _terrainExtension;
            set => _terrainExtension = value;
        }

        public override double PropertyTax( ) {
            return Meters * 2.5 + _terrainExtension * 1.25;
        }

        public override bool Equals( object? obj ) {
            return Equals( obj as LuxuryResidence );
        }

        public bool Equals( LuxuryResidence residence ) {
            return residence != null && Code             == residence.Code
                                     && Address          == residence.Address && Meters       == residence.Meters
                                     && Spaces           == residence.Spaces  && EnerrgyClass == residence.EnerrgyClass
                                     && TerrainExtension == residence.TerrainExtension;
        }

        public override string ToString( ) {
            return
                $"{base.ToString()}, {nameof(EnerrgyClass)}: {EnerrgyClass}, {nameof(TerrainExtension)}: {TerrainExtension}";
        }
    }
}