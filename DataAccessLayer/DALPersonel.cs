using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Diagnostics.Eventing.Reader;
namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntitiyPersonel> PersonelListesi()
        {
            List<EntitiyPersonel> deger = new List<EntitiyPersonel>();

            SqlCommand cmd = new SqlCommand("select * from TBL_PERSONEL", baglanti.bgl);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntitiyPersonel ent = new EntitiyPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Name = dr["AD"].ToString();
                ent.Surname = dr["SOYAD"].ToString();
                ent.City = dr["SEHIR"].ToString();
                ent.Mision = dr["GOREV"].ToString();
                ent.Wage = short.Parse(dr["MAAS"].ToString());
                deger.Add(ent);
            }
            dr.Close();
            return deger;
        }

        public static int PersonelEkle(EntitiyPersonel P)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_PERSONEL (AD, SOYAD, SEHIR, GOREV, MAAS) values (@p1,@p2,@p3,@p4,@p5)",baglanti.bgl);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1",P.Name);
            cmd.Parameters.AddWithValue("@p2", P.Surname);
            cmd.Parameters.AddWithValue("@p3", P.City);
            cmd.Parameters.AddWithValue("@p4", P.Mision);
            cmd.Parameters.AddWithValue("@p5", P.Wage);

            return cmd.ExecuteNonQuery();

        }

        public static bool PersonelSil(int p)
        {
            SqlCommand cmd = new SqlCommand("delete from TBL_Personel where ID=@p1", baglanti.bgl);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", p);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool PerspnelGuncelle(EntitiyPersonel ent)
        {
            SqlCommand cmd = new SqlCommand("Update TBL_PERSONEL set AD=@p1, SOYAD=@p2, SEHIR=@p3, GOREV=@p4, MAAS=@p5 where ID=@p6", baglanti.bgl);

            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", ent.Name);
            cmd.Parameters.AddWithValue("@p2", ent.Surname);
            cmd.Parameters.AddWithValue("@p3", ent.City);
            cmd.Parameters.AddWithValue("@p4", ent.Mision);
            cmd.Parameters.AddWithValue("@p5", ent.Wage);
            cmd.Parameters.AddWithValue("@p6", ent.Id);

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
