using Shared;
using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProizvodRepository:IProizvodRepository
    {
        public List<Proizvod> GetAllProducts()
        {
            List<Proizvod> listaProizvoda = new List<Proizvod>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM PROIZVODI";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Proizvod p = new Proizvod();
                    p.sifra_proizvoda = dataReader.GetInt32(0);
                    p.naziv = dataReader.GetString(1);
                    p.marka = dataReader.GetString(2);
                    p.cena = dataReader.GetDecimal(3);
                    p.garancija = dataReader.GetInt32(4);

                    listaProizvoda.Add(p);
                }

            }
            return listaProizvoda;
        }
        public int InsertProduct(Proizvod p)
        {

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO PROIZVODI " +
                    "VALUES('{0}','{1}',{2}, {3})", p.naziv, p.marka, p.cena, p.garancija);

                return command.ExecuteNonQuery();

            }

        }
        public int UpdateProduct(Proizvod p)
        {

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("UPDATE PROIZVODI SET naziv='{0}', marka='{1}', cena={2},garancija={3}" +
                    "WHERE sifra_proizvoda={4}", p.naziv, p.marka, p.cena, p.garancija, p.sifra_proizvoda);

                return command.ExecuteNonQuery();

            }

        }
        public int DeleteProduct(Proizvod p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                {
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = string.Format("DELETE FROM PROIZVODI WHERE sifra_proizvoda = {0}", p.sifra_proizvoda);

                    return command.ExecuteNonQuery();
                }
            }


        }
    }
}
