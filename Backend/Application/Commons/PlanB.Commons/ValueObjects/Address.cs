using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Commons.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neighborhood, string city, string stateOrProvince, string country, string zipCode, string district)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            StateOrProvince = stateOrProvince;
            Country = country;
            ZipCode = zipCode;
            District = district;
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string StateOrProvince { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public string District { get; private set; }
    }
}
