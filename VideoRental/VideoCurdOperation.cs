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
    public class VideoCurdOperation
    {
        SqlConnection database_con = new SqlConnection(ConfigurationManager.ConnectionStrings["VRSDatabase"].ConnectionString);

        public int deleteVideoById(int MovieId)
        {

            try
            {
                database_con.Open();
                using (SqlCommand cmd = new SqlCommand("delete from Movie where MovieId=@MovieId", database_con))
                {
                    cmd.Parameters.AddWithValue("@MovieId", MovieId);

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

        public int insertVideo(string Title, DateTime ReleaseDate, decimal Cost, string Genre, string Plot)
        {

            try
            {
                database_con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into Movie(Title,ReleaseDate,RentalCost,Genre,Plot,Available)values(@Title,@ReleaseDate,@RentalCost,@Genre,@Plot,@Available)", database_con))
                {
                    cmd.Parameters.AddWithValue("@Title", Title);
                    cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                    cmd.Parameters.AddWithValue("@RentalCost", Cost);
                    cmd.Parameters.AddWithValue("@Genre", Genre);
                    cmd.Parameters.AddWithValue("@Plot", Plot);
                    cmd.Parameters.AddWithValue("@Available", "Yes");
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
        public DataTable getAllVideoList()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from Movie", database_con))
                {

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
        public int updateVideoById(string Title, DateTime ReleaseDate, decimal Cost, string Genre, string Plot, int MovieId)
        {

            try
            {
                database_con.Open();
                using (SqlCommand cmd = new SqlCommand("update Movie set Title=@Title,ReleaseDate=@ReleaseDate,RentalCost=@RentalCost,Genre=@Genre,Plot=@Plot where MovieId=@MovieId", database_con))
                {
                    cmd.Parameters.AddWithValue("@MovieId", MovieId);
                    cmd.Parameters.AddWithValue("@Title", Title);
                    cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                    cmd.Parameters.AddWithValue("@RentalCost", Cost);
                    cmd.Parameters.AddWithValue("@Genre", Genre);
                    cmd.Parameters.AddWithValue("@Plot", Plot);


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
    }
}
