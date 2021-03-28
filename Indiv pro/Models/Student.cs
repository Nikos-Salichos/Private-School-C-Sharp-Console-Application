using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_pro
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private decimal _tuitionFees;

        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime dateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public decimal tuitionFees
        {
            get { return _tuitionFees; }
            set { _tuitionFees = value; }
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, decimal tuitionFees) //constructor
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.tuitionFees = tuitionFees;
        }
    }
}
