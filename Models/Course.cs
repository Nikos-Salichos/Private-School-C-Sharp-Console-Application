using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_pro
{
    class Course
    {
        private string _title;
        private string _stream;
        private string _type;
        private DateTime _startDate;
        private DateTime _endDate;

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string stream
        {
            get { return _stream; }
            set { _stream = value; }
        }
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public DateTime startDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        public DateTime endDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate) //constructor
        {
            this.title = title;
            this.stream = stream;
            this.type = type;
            this.startDate = startDate;
            this.endDate = endDate;
        }


    }
}
