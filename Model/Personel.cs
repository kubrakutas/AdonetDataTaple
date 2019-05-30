using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDataTable.Model
{
    class Personel
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Unvan { get; set; }

        private string acikUnvan;

        public string AcikUnvan
        {
            get
            {
                switch (Unvan)
                {
                    case "Dr.":
                        acikUnvan = "Doktor";
                        break;
                    case "Prof.":
                        acikUnvan = "Profesör";
                        break;
                    case "Yrd. Doç.":
                        acikUnvan = "Yardımcı Doçent";
                        break;
                    case "Doç.":
                        acikUnvan = "Doçent";
                        break;
                    default:
                        break;
                }
                return acikUnvan;
            }
            set{acikUnvan = value;}
        }
    }
}
