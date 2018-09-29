namespace Q_Hack_2018.Core.Entities
{
    public class Category
    {
        private decimal _value;

        public string Name { get; }

        /// <summary>
        /// Get the ID. This is needed for the backend processing (but not for web frontend).
        /// </summary>
        public int Id { get; }

        public decimal Value {
            get
            {
                return _value;
            }
        }

        public void AddAmount(decimal amount)
        {
            _value += amount;
        }
    }
}
