using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyConverter.model
{
    public class Person
    {
        private String name;
        private String surname;
        private String birthDate;

        public Person(String name, String surname, String birthDate)
        {
            this.name = name;
            this.surname = surname;
            //DateTime.Parse(birthDate, "dd-MM-yy", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}