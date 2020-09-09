using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental
{
   public class SqldbContext
    {
        SqlConnection database_con = new SqlConnection(ConfigurationManager.ConnectionStrings["VRSDatabase"].ConnectionString);

        public DataTable GetAllRentedVideoView()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from ViewRentedMovies", database_con))
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
        public int insertVideoOnRental(int MovieId, int CustId, DateTime RentedDate)
        {

            try
            {
                database_con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into RentedMovies(MovieId,CustId,DateRented)values(@MovieId,@CustId,@DateRented)", database_con))
                {
                    cmd.Parameters.AddWithValue("@MovieId", MovieId);
                    cmd.Parameters.AddWithValue("@CustId", CustId);
                    cmd.Parameters.AddWithValue("@DateRented", RentedDate);

                    cmd.ExecuteNonQuery();

                }
                database_con.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable WhoMostBorrowList()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select CustId,FirstName,LastName,Address,Phone,Count(*) as 'Total Borrows' from ViewRentedMovies group by CustId,FirstName,LastName,Address,Phone order by 'Total Borrows' desc", database_con))
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
        
        
        
       
        
      
        
       
       
        public bool checkReturnVideo(int MovieId)
        {

            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from Movie where Available='No' and MovieId=" + MovieId + "", database_con))
                {
                    SqlDataReader rdr;
                    rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }


            }
            catch
            {

                return true;
            }
        }
       
        public DataTable allRentedOutVideo()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from ViewRentedMovies where DateReturned is Null", database_con))
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
        public int changedAvailableStatus(int MovieId, string Status)
        {

            try
            {
                database_con.Open();
                using (SqlCommand cmd = new SqlCommand("update Movie set Available=@Available where MovieId=@MovieId", database_con))
                {
                    cmd.Parameters.AddWithValue("@MovieId", MovieId);
                    cmd.Parameters.AddWithValue("@Available", Status);

                    cmd.ExecuteNonQuery();

                }
                database_con.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int returnedMovie(int ReturnId)
        {

            try
            {
                database_con.Open();
                using (SqlCommand cmd = new SqlCommand("update RentedMovies set DateReturned=@DateReturned where RentedMovieId=@RentedMovieId", database_con))
                {
                    cmd.Parameters.AddWithValue("@RentedMovieId", ReturnId);
                    cmd.Parameters.AddWithValue("@DateReturned", DateTime.Now);

                    cmd.ExecuteNonQuery();

                }
                database_con.Close();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
       
        
        public DataTable getAllPopularVideo()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select MovieId,Title,ReleaseDate,RentalCost,Genre,Count(*) as 'Total Rented' from ViewRentedMovies group by MovieId,Title,ReleaseDate,RentalCost,Genre order by 'Total Rented' desc", database_con))
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
        
        public DataTable getAvailableVideo()
        {
            DataTable dt = new DataTable();
            try
            {

                using (SqlCommand cmd = new SqlCommand("select * from Movie where Available='Yes'", database_con))
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
    }
}
