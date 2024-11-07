using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TravelTour.Utils;
using TravelTour.Model;

namespace TravelTour.Controller
{
    internal class TourController : IController
    {
        private List<IModel> items;
        private string connectionString;

        public TourController(string connectionString)
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
                string query = "SELECT * FROM tour";
                DataTable dataTable = dbHelper.ExecuteQuery(query);
                return dataTable;
            }
        }

        public bool Create(IModel model)
        {
            if (model is TourModel tour)
            {
                using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
                {
                    string query = "INSERT INTO tour (ID, IDtv, booking_date, quantity) VALUES (@ID, @IDtv, @BookingDate, @Quantity)";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ID", tour.ID),
                        new SqlParameter("@IDtv", tour.IDtv),
                        new SqlParameter("@BookingDate", tour.BookingDate),
                        new SqlParameter("@Quantity", tour.Quantity)
                    };

                    int result = dbHelper.ExecuteNonQuery(query, parameters);
                    return result > 0;
                }
            }
            return false;
        }

        public bool Update(IModel model)
        {
            if (model is TourModel tour)
            {
                using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
                {
                    string query = "UPDATE tour SET ID = @ID, IDtv = @IDtv, booking_date = @BookingDate, quantity = @Quantity WHERE IDtour = @IDtour";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@IDtour", tour.IDtour),
                        new SqlParameter("@ID", tour.ID),
                        new SqlParameter("@IDtv", tour.IDtv),
                        new SqlParameter("@BookingDate", tour.BookingDate),
                        new SqlParameter("@Quantity", tour.Quantity)
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
                string query = "DELETE FROM tour WHERE IDtour = @IDtour";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDtour", id)
                };

                int result = dbHelper.ExecuteNonQuery(query, parameters);
                return result > 0;
            }
        }

        public IModel Read(object id)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT * FROM tour WHERE IDtour = @IDtour";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDtour", id)
                };

                DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return new TourModel
                    {
                        IDtour = Convert.ToInt32(row["IDtour"]),
                        ID = Convert.ToInt32(row["ID"]),
                        IDtv = Convert.ToInt32(row["IDtv"]),
                        BookingDate = Convert.ToDateTime(row["booking_date"]),
                        Quantity = Convert.ToInt32(row["quantity"])
                    };
                }
            }
            return null;
        }

        public bool Load()
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT * FROM tour";
                DataTable dataTable = dbHelper.ExecuteQuery(query);
        
                items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    items.Add(new TourModel
                    {
                        IDtour = Convert.ToInt32(row["IDtour"]),
                        ID = Convert.ToInt32(row["ID"]),
                        IDtv = Convert.ToInt32(row["IDtv"]),
                        BookingDate = Convert.ToDateTime(row["booking_date"]),
                        Quantity = Convert.ToInt32(row["quantity"])
                    });
                }
                return items.Count > 0;
            }
        }
        
        public bool Load(object id)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT * FROM tour WHERE IDtour = @IDtour";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDtour", id)
                };
        
                DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    items.Clear(); // Xóa danh sách hiện tại để chỉ lưu bản ghi đã tải
                    items.Add(new TourModel
                    {
                        IDtour = Convert.ToInt32(row["IDtour"]),
                        ID = Convert.ToInt32(row["ID"]),
                        IDtv = Convert.ToInt32(row["IDtv"]),
                        BookingDate = Convert.ToDateTime(row["booking_date"]),
                        Quantity = Convert.ToInt32(row["quantity"])
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
                string query = "SELECT COUNT(*) FROM tour WHERE IDtour = @IDtour";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@IDtour", id)
                };

                int count = (int)dbHelper.ExecuteScalar(query, parameters);
                return count > 0;
            }
        }

        public bool IsExist(IModel model)
        {
            if (model is TourModel tour)
            {
                return IsExist(tour.IDtour);
            }
            return false;
        }
    }
}
