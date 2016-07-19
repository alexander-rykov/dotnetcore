namespace Monitor
{
    // TODO: Use SpinLock to protect this structure.
    public class AnotherClass
    {
        private int _value;

        public int Counter
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public void Increase()
        {
            _value++;
        }

        public void Decrease()
        {
            _value--;
        }
    }
}
