using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TravelTour.Controller;
using TravelTour.Utils;
using TravelTour.Model;

namespace TravelTour.Controller
{
    internal class InforController : IController
    {
        private List<IModel> items;
        private string connectionString;

        public InforController(string connectionString)
        {
            this.connectionString = connectionString;
            this.items = new List<IModel>();
        }

        public List<IModel> Items
        {
            get
            {
                return this.items;
            }
        }

        public bool Create(IModel model)
        {
            if (model is InforModel infor)
            {
                using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
                {
                    string query = "INSERT INTO infor (ID, Name, ImageUrl, Date, Location, Sex, Age) VALUES (@ID, @Name, @ImageUrl, @Date, @Location, @Sex, @Age)";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ID", infor.ID),
                        new SqlParameter("@Name", infor.Name),
                        new SqlParameter("@ImageUrl", infor.ImageUrl),
                        new SqlParameter("@Date", infor.Date),
                        new SqlParameter("@Location", infor.Location),
                        new SqlParameter("@Sex", infor.Sex),
                        new SqlParameter("@Age", infor.Age)
                    };

                    int result = dbHelper.ExecuteNonQuery(query, parameters);
                    return result > 0;
                }
            }
            return false;
        }

        public bool Update(IModel model)
        {
            if (model is InforModel infor)
            {
                using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
                {
                    string query = "UPDATE infor SET Name = @Name, ImageUrl = @ImageUrl, Date = @Date, Location = @Location, Sex = @Sex, Age = @Age WHERE ID = @ID";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@ID", infor.ID),
                new SqlParameter("@Name", infor.Name),
                new SqlParameter("@ImageUrl", infor.ImageUrl),
                new SqlParameter("@Date", infor.Date),
                new SqlParameter("@Location", infor.Location),
                new SqlParameter("@Sex", infor.Sex),
                new SqlParameter("@Age", infor.Age)
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
                string query = "DELETE FROM infor WHERE ID = @ID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", id)
                };

                int result = dbHelper.ExecuteNonQuery(query, parameters);
                return result > 0;
            }
        }

        public IModel Read(object id)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT * FROM infor WHERE ID = @ID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", id)
                };

                DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return new InforModel
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Name = row["Name"].ToString(),
                        ImageUrl = row["ImageUrl"].ToString(),
                        Date = Convert.ToDateTime(row["Date"]),
                        Location = row["Location"].ToString(),
                        Sex = row["Sex"].ToString(),
                        Age = Convert.ToInt32(row["Age"])
                    };
                }
            }
            return null;
        }

        public bool Load()
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT * FROM infor";
                DataTable dataTable = dbHelper.ExecuteQuery(query);

                items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    items.Add(new InforModel
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Name = row["Name"].ToString(),
                        ImageUrl = row["ImageUrl"].ToString(),
                        Date = Convert.ToDateTime(row["Date"]),
                        Location = row["Location"].ToString(),
                        Sex = row["Sex"].ToString(),
                        Age = Convert.ToInt32(row["Age"])
                    });
                }

                return items.Count > 0;
            }
        }

        public bool Load(object id)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT * FROM infor WHERE ID = @ID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", id)
                };

                DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    items.Clear(); // Clear current items list to store only the loaded item
                    items.Add(new InforModel
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Name = row["Name"].ToString(),
                        ImageUrl = row["ImageUrl"].ToString(),
                        Date = Convert.ToDateTime(row["Date"]),
                        Location = row["Location"].ToString(),
                        Sex = row["Sex"].ToString(),
                        Age = Convert.ToInt32(row["Age"])
                    });

                    return true;
                }
            }
            return false;
        }

        public bool IsExist(object id)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT COUNT(*) FROM infor WHERE ID = @ID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", id)
                };

                int count = (int)dbHelper.ExecuteScalar(query, parameters);
                return count > 0;
            }
        }

        public bool IsExist(IModel model)
        {
            if (model is InforModel infor)
            {
                return IsExist(infor.ID);
            }
            return false;
        }
    }
}
