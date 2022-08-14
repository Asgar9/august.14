using System;
using System.Collections.Generic;
using System.Text;

namespace music.app.Models
{
    class Singer
    {
        private string _name;
        private string _surName;
        private int _age;
        public string Name { get=>_name; set { if (value.Length < 101) { value = _name; } } } 
        public string SurName { get=>_surName; set { if (value.Length < 101) { value = _surName; } } }
        public int Age { get=>_age; set { if (value < 170) { value =_age; } } }
    }
}
