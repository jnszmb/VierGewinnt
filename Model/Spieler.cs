using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Spieler
    {
        int id;
        String name;
        int punktzahl;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Punktzahl
        {
            get
            {
                return punktzahl;
            }

            set
            {
                punktzahl = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}", this.Name);
        }
    }
}
