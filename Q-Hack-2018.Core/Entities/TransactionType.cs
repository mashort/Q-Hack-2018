using System;
using System.Collections.Generic;
using System.Text;

namespace Q_Hack_2018.Core.Entities
{
    public class TransactionType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Process { get; set; }

        public Nullable<int> HardCategoryID { get; set; }
    }
}
