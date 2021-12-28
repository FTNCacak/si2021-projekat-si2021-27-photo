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
    public class PorucivanjeRepository: IPorucivanjeRepository
    {
        public List<Porucivanje> GetAllOrders()
        {
            List<Porucivanje> listaPorucenihProizvoda = new List<Porucivanje>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT * FROM PORUCIVANJA";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Porucivanje p = new Porucivanje();
                    p.id_porucivanja = dataReader.GetInt32(0);
                    p.naziv_proizvoda = dataReader.GetString(1);
                    p.sifraP = dataReader.GetInt32(2);
                    

                    listaPorucenihProizvoda.Add(p);
                }

            }
            return listaPorucenihProizvoda;
        }

        public int InsertOrder(Porucivanje p)
        {

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = string.Format("INSERT INTO PORUCIVANJA " +
                    "VALUES('{0}',{1})",p.naziv_proizvoda,p.sifraP);

                return command.ExecuteNonQuery();

            }

        }
    }
}
