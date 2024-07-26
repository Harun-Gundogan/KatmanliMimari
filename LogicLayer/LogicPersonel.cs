using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Data.SqlClient;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntitiyPersonel> PersonelList() 
        {
            return DALPersonel.PersonelListesi();
        }

        public static int LPersonelEkle(EntitiyPersonel p)
        {
            if (p.Name != "" && p.Surname != "" && p.Wage > 17000 && p.Name.Length >= 2)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool LPersonelSil(int p)
        {
            if (p >= 1)
            {
                return DALPersonel.PersonelSil(p);
            }
            else
            {
                return false;
            }
        }

        public static bool LPersonelGuncelle(EntitiyPersonel p)
        {
            if(p.Name.Length>=2 && p.Wage >= 17000)
            {
                return DALPersonel.PerspnelGuncelle(p);
            }
            else
            {
                return false;
            }
        }
       
    }
}
