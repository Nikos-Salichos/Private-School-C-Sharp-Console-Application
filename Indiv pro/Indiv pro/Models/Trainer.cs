using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_pro
{
    class Trainer
    {
        private string _firstName;
        private string _lastName;
        private string _subject;

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
        public string subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        public Trainer(string firstName, string lastName, string subject) //constructor
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subject = subject;
        }

    }
}
