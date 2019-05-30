using AdoNetDataTable.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDataTable
{
    class PersonelHelper
    {
        public List<Personel> GetListAll()
        {
            string sql = "select * from Personel";
            var data = SqlQueries.SQLSorguCalistirUsing(sql);
            return ConvertToList(data);
        }

        public List<Personel> GetListByName(string name)
        {
            string sql = $"select * from Personel where Isim like '%" + name + "%'";
            var data = SqlQueries.SQLSorguCalistir(sql);
            return ConvertToList(data);
        }

        public List<Personel> GetListMarka()
        {
            string sql = "select Marka from ";
            var data = SqlQueries.SQLSorguCalistirUsing(sql);
            return ConvertToList(data);
        }

        public bool UpdatePersonel(int id,string isim,string soyisim)
        {
            string sql = $"update Personel set Isim='{isim}', Soyisim='{soyisim}' where ID={id}";
            var result = SqlQueries.NonSorguCalistir(sql);
            return result > 0 ? true : false;
        }

        public bool DeletePersonel(int id)
        {
            string sql = $"delete from Personel where ID={id}";
            var result = SqlQueries.NonSorguCalistir(sql);
            return result > 0 ? true : false;
        }

        public bool AddPersonel(int id, string isim, string soyisim,string unvan)
        {
            string sql = $"insert into Personel(ID,Isim,Soyisim,Unvan) values({id},'{isim}','{soyisim}','{unvan}')";
            var result = SqlQueries.NonSorguCalistir(sql);
            return result > 0 ? true : false;
        }
        

        public List<Personel> ConvertToList(DataTable data)
        {
            List<Personel> personelList = new List<Personel>();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                Personel personel = new Personel();
                personel.ID = Convert.ToInt32(data.Rows[i]["ID"]);
                personel.Isim = data.Rows[i]["Isim"].ToString();
                personel.Soyisim = data.Rows[i]["Soyisim"].ToString();
                personel.Unvan = data.Rows[i]["Unvan"].ToString();
                personelList.Add(personel);
            }
            return personelList;
        }
    }
}
