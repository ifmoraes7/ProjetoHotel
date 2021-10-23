using ProjetoHotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHotel.Dao
{
    public class HospedeDao
    {
        readonly SqlConnection conn = new SqlConnection("Data Source = DESKTOP-OJ1KOSL; Initial Catalog = PrjHotel; User id = sa; Password=@Moraes123;");

        public void SetHospede(HospedeModel hospede)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SP_HOSPEDE_SET", conn)
                {
                    CommandType = CommandType.StoredProcedure

                };
                cmd.Parameters.Add(new SqlParameter("@NOME", hospede.Nome));
                cmd.Parameters.Add(new SqlParameter("@CPF", hospede.CPF));
                cmd.Parameters.Add(new SqlParameter("@RG", hospede.RG));
                cmd.Parameters.Add(new SqlParameter("@Data_de_Nascimento", hospede.Data_de_Nascimento));
                cmd.Parameters.Add(new SqlParameter("@Genero", hospede.Genero));
                cmd.Parameters.Add(new SqlParameter("@Profissao", hospede.Profissao));
                cmd.Parameters.Add(new SqlParameter("@Estado_civil", hospede.Estado_civil));
                cmd.Parameters.Add(new SqlParameter("@Telefone", hospede.Telefone));
                cmd.Parameters.Add(new SqlParameter("@Email", hospede.Email));
                cmd.Parameters.Add(new SqlParameter("@CEP", hospede.CEP));
                cmd.Parameters.Add(new SqlParameter("@Endereco", hospede.Endereco));
                cmd.Parameters.Add(new SqlParameter("@Numero", hospede.Numero));
                cmd.Parameters.Add(new SqlParameter("@Cidade", hospede.Cidade));
                cmd.Parameters.Add(new SqlParameter("@Estado", hospede.Estado));
                

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

    
    }
}
