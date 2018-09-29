namespace Q_Hack_2018.Core.Entities
{
    public class Category
    {
        private decimal _value;
        private string _name;
        private int _id;

        public string Name { get
            {
                return _name;
            }
        }

        /// <summary>
        /// Get the ID. This is needed for the backend processing (but not for web frontend).
        /// </summary>
        public int Id {
            get
            {
                return _id;
            }
        }

        public decimal Value {
            get
            {
                return _value;
            }
        }

        public Category(int Id, string Name)
        {
            _id = Id;
            _name = Name;
        }

        public void AddAmount(decimal amount)
        {
            _value += amount;
        }
    }
}
