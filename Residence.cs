namespace MonkeySoft_2 {
    public abstract class Residence {
        protected string _code;
        protected string _address;
        protected int    _meters;
        protected int    _spaces;

        protected Residence( string code, string address, int meters, int spaces ) {
            _code    = code;
            _address = address;
            _meters  = meters;
            _spaces  = spaces;
        }

        public string Code => _code;

        public string Address => _address;

        public int Meters => _meters;

        public int Spaces => _spaces;

        public abstract double PropertyTax( );

        public override string ToString( ) {
            return $"{nameof(Code)}: {Code}, {nameof(Address)}: {Address}, {nameof(Meters)}: {Meters}, {nameof(Spaces)}: {Spaces}";
        }
    }
}