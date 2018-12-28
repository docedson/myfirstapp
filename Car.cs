namespace classwork
{
    // The following House is a class
    public class Car
    {
        // The following strings are fields
        string _tires;
        string _windows;
        string _doors;
        // string _gasoline;
        // string _model;

        // Standard long way of Property
        public string Tire {
            get {
                return _tires;
            }
            set {
                this._tires = value;
            }
        }

        public string Window {
            get {
                return _windows;
            }
            set{
                this._windows = value;
            }
        
        }

        public string Door {
            get {
                return _doors;
            }
            set {
                this._doors = value;
            }
        }

        // Shorthand way of a Property + field
        public string Gas { get; set; }

        public string YearMake { get; set; }

        // The following are methods
        public void Drive()
        {

        }

        public void Park()
        {

        }

        public void Drift()
        {

        }
        
    }
}