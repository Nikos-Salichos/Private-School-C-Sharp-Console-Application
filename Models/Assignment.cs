using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_pro
{
    class Assignment
    {
        private string _title;
        private string _description;
        private DateTime _subDateTime;
        private int _oralMark;
        private int _totalMark;


        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        public DateTime subDateTime
        {
            get { return _subDateTime; }
            set { _subDateTime = value; }
        }
        public int oralMark
        {
            get { return _oralMark; }
            set { _oralMark = value; }
        }
        public int totalMark
        {
            get { return _totalMark; }
            set { _totalMark = value; }
        }

        public Assignment(string title, string description, DateTime subDateTime, int oralMark, int totalMark) //constructor
        {
            this.title = title;
            this.description = description;
            this.subDateTime = subDateTime;
            this.oralMark = oralMark;
            this.totalMark = totalMark;
        }

    }
}
