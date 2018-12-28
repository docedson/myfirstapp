namespace classwork
{
    // The following House is a class
    public class House
    {
        // The following strings are fields
        string _foundation;
        // string _roof;
        string _windows;
        // string _doors;

        // Standard long way of a Property
        public string Foundation {
            get {
                return _foundation;
            }
            set {
                this._foundation = value;
            }
        }

        public string Window {
            get {
                return _windows;
            }
            set {
                this._windows = value;
            }
        }

        // Shorthand way of a Property + field; Auto Property
        public string Roof { get; set; }

        public string PaintDoor { get; set; }

        // The following are methods
        public void OpenDoor()
        {

        }

        public void CloseDoor()
        {

        }
    }
}