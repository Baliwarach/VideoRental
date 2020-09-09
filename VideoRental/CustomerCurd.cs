using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental
{
    
   public class CustomerCurd
    {
        SqlConnection database_con = new SqlConnection(ConfigurationManager.ConnectionStrings["VRSDatabase"].ConnectionString);
        public int deleteCustomerById(int CustId)
        {

            try
            {
                database_con.Open();
                using (SqlCommand cmd = new SqlCommand("delete from Customer where CustId=@CustId", database_con))
                {
                    cmd.Parameters.AddWithValue("@CustId", CustId);

                    cmd.ExecuteNonQuery();

                }
                database_con.Close();
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }
        public int addNewCustomer(string FirstName, string Lastname, string Address, string MobileNo)
        {

            try
            {
                database_con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into Customer(FirstName,LastName,Address,Phone)values(@FirstName,@LastName,@Address,@Phone)", database_con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", Lastname);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Phone", MobileNo);

                    cmd.ExecuteNonQuery();

                }
                database_con.Close();
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }
        public int updateCustomerById(string FirstName, string Lastname, string Address, string MobileNo, int CustId)
        {

            try
            {
                database_con.Open();
                using (SqlCommand cmd = new SqlCommand("update Customer set FirstName=@FirstName,LastName=@LastName,Address=@Address,Phone=@Phone  where CustId=@CustId", database_con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@LastName", Lastname);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@Phone", MobileNo);
                    cmd.Parameters.AddWithValue("@CustId", CustId);

                    cmd.ExecuteNonQuery();

                }
                database_con.Close();
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }
        public DataTable getAllCustomerList()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("spGetAllCustomer", database_con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {


                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch
            {
                return dt;
            }
        }
    }
}
