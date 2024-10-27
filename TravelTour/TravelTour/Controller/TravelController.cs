using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TravelTour.Utils;
using TravelTour.Model;

namespace TravelTour.Controller
{
    internal class TravelController : IController
    {
        private List<IModel> items;
        private string connectionString;

        public TravelController(string connectionString)
        {
            this.connectionString = connectionString;
            this.items = new List<IModel>();
        }

        public List<IModel> Items
        {
            get { return this.items; }
        }

        public DataTable LoadAll()
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT * FROM travel";
                DataTable dataTable = dbHelper.ExecuteQuery(query);
                return dataTable;
            }
        }

        public bool Create(IModel model)
        {
            if (model is TravelModel travel)
            {
                using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
                {
                    string query = "INSERT INTO travel (Nametv, datestart, dateend, description, location, typetv, ImageUrl, quantity) VALUES (@Nametv, @DateStart, @DateEnd, @Description, @Location, @TypeTv, @ImageUrl, @Quantity)";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@Nametv", travel.Nametv),
                        new SqlParameter("@DateStart", travel.DateStart),
                        new SqlParameter("@DateEnd", travel.DateEnd),
                        new SqlParameter("@Description", travel.Description),
                        new SqlParameter("@Location", travel.Location),
                        new SqlParameter("@TypeTv", travel.TypeTv),
                        new SqlParameter("@ImageUrl", travel.ImageUrl),
                        new SqlParameter("@Quantity", travel.Quantity)
                    };

                    int result = dbHelper.ExecuteNonQuery(query, parameters);
                    return result > 0;
                }
            }
            return false;
        }

        public bool Update(IModel model)
        {
            if (model is TravelModel travel)
            {
                using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
                {
                    string query = "UPDATE travel SET Nametv = @Nametv, datestart = @DateStart, dateend = @DateEnd, description = @Description, location = @Location, typetv = @TypeTv, ImageUrl = @ImageUrl, quantity = @Quantity WHERE IDtv = @IDtv";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@IDtv", travel.IDtv),
                        new SqlParameter("@Nametv", travel.Nametv),
                        new SqlParameter("@DateStart", travel.DateStart),
                        new SqlParameter("@DateEnd", travel.DateEnd),
                        new SqlParameter("@Description", travel.Description),
                        new SqlParameter("@Location", travel.Location),
                        new SqlParameter("@TypeTv", travel.TypeTv),
                        new SqlParameter("@ImageUrl", travel.ImageUrl),
                        new SqlParameter("@Quantity", travel.Quantity)
                    };

                    int result = dbHelper.ExecuteNonQuery(query, parameters);
                    return result > 0;
                }
            }
            return false;
        }

        public bool Delete(object id)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "DELETE FROM travel WHERE IDtv = @IDtv";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDtv", id)
                };

                int result = dbHelper.ExecuteNonQuery(query, parameters);
                return result > 0;
            }
        }

        public IModel Read(object id)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT * FROM travel WHERE IDtv = @IDtv";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@IDtv", id)
                };

                DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return new TravelModel
                    {
                        IDtv = Convert.ToInt32(row["IDtv"]),
                        Nametv = row["Nametv"].ToString(),
                        DateStart = Convert.ToDateTime(row["datestart"]),
                        DateEnd = Convert.ToDateTime(row["dateend"]),
                        Description = row["description"].ToString(),
                        Location = row["location"].ToString(),
                        TypeTv = row["typetv"].ToString(),
                        ImageUrl = row["ImageUrl"].ToString(),
                        Quantity = Convert.ToInt32(row["quantity"])
                    };
                }
            }
            return null;
        }

        public bool IsExist(object id)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT COUNT(*) FROM travel WHERE IDtv = @IDtv";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDtv", id)
                };

                int count = (int)dbHelper.ExecuteScalar(query, parameters);
                return count > 0;
            }
        }

        public bool IsExist(IModel model)
        {
            if (model is TravelModel travel)
            {
                return IsExist(travel.IDtv);
            }
            return false;
        }
    }
}
