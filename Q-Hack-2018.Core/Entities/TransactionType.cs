using System;
using System.Collections.Generic;
using System.Text;

namespace Q_Hack_2018.Core.Entities
{
    public class TransactionType
    {
        private int _id;
        private string _name;
        private Nullable<bool> _process;
        private Nullable<int> _hardCategoryID;

        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Name { get
            {
                return _name;
            }
        }

        public Nullable<bool> Process { get
            {
                return _process;
            }
        }

        public Nullable<int> HardCategoryID {
            get
            {
                return _hardCategoryID;
            }
        }

        public TransactionType(int Id, string Name, bool? Process, Nullable<int> HardCategoryID)
        {
            _id = Id;
            _name = Name;
            _process = Process;
            _hardCategoryID = HardCategoryID;
        }
    }
}
