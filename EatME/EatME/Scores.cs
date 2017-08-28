using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatME
{
    [Serializable()]
    public class Scores : IComparable<Scores>
    {
        public string _name { get; set; }
        public string _time { get; set; }

        public Scores(string name, string time)
        {
            _name = name;
            _time = time;
        }
        public Scores()
        {
        }
        public int CompareTo(Scores other)
        {
            return this._time.CompareTo(other._time);
        }
    }
}
