namespace MonkeySoft_2 {
    public class PopularResidence : Residence {
        private int _salary;

        public PopularResidence( string code, string address, int meters, int spaces, int salary )
            : base( code, address, meters, spaces ) {
            _salary = salary;
        }


        public int Salary {
            get => _salary;
            set => _salary = value;
        }

        public override double PropertyTax( ) {
            return Meters * 2;
        }

        public override bool Equals( object obj ) {
            return Equals( obj as PopularResidence );
        }

        public bool Equals( PopularResidence residence ) {
            return residence != null && Code    == residence.Code
                                     && Address == residence.Address && Meters == residence.Meters
                                     && Spaces  == residence.Spaces  && Salary==residence.Salary;
        }


        public override string ToString( ) {
            return $"{base.ToString()}, {nameof(Salary)}: {Salary}";
        }
    }
}