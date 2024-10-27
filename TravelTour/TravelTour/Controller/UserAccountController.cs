using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TravelTour.Controller;
using TravelTour.Utils;
using TravelTour.Model;

namespace TravelTour.Controller
{
    internal class UserAccountController : IController
    {
        private List<IModel> items;
        private string connectionString;

        public UserAccountController(string connectionString)
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

        public DataTable LoadAll()
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT * FROM account";
                DataTable dataTable = dbHelper.ExecuteQuery(query);
                return dataTable;
            }
        }

        // Hàm kiểm tra xem tài khoản có hợp lệ hay không
        public bool ValidateLogin(string username, string password)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                // Truy vấn kiểm tra tài khoản trong database
                string query = "SELECT COUNT(*) FROM account WHERE username = @username AND password = @password";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@username", username),
            new SqlParameter("@password", password)
                };

                // Kiểm tra nếu kết quả trả về lớn hơn 0, nghĩa là tài khoản hợp lệ
                int count = (int)dbHelper.ExecuteScalar(query, parameters);
                return count > 0;  // Trả về true nếu có tài khoản khớp, false nếu không
            }
        }

        public UserAccountModel GetUserByUsername(string username)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                // Truy vấn để lấy thông tin tài khoản dựa trên tên đăng nhập
                string query = "SELECT * FROM account WHERE username = @username";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@username", username)
                };

                DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);

                if (dataTable.Rows.Count > 0)
                {
                    // Giả sử bảng account có các cột: ID, username, password, và role
                    DataRow row = dataTable.Rows[0];
                    return new UserAccountModel
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Username = row["username"].ToString(),
                        Password = row["password"].ToString(),
                        Role = row["role"].ToString()
                    };
                }
                return null; // Trả về null nếu không tìm thấy người dùng
            }
        }

        public bool Create(IModel model)
        {
            if (model is UserAccountModel userAccount)
            {
                using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
                {
                    string query = "INSERT INTO account (username, password, role) VALUES (@username, @password, @role)";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@username", userAccount.Username),
                        new SqlParameter("@password", userAccount.Password),
                        new SqlParameter("@role", userAccount.Role)
                    };

                    int result = dbHelper.ExecuteNonQuery(query, parameters);
                    return result > 0;  // Trả về true nếu thêm thành công
                }
            }
            return false;
        }

        public bool Update(IModel model)
        {
            if (model is UserAccountModel userAccount)
            {
                using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
                {
                    string query = "UPDATE account SET username = @username, password = @password, role = @role WHERE ID = @ID";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ID", userAccount.ID),
                        new SqlParameter("@username", userAccount.Username),
                        new SqlParameter("@password", userAccount.Password),
                        new SqlParameter("@role", userAccount.Role)
                    };

                    int result = dbHelper.ExecuteNonQuery(query, parameters);
                    return result > 0;  // Trả về true nếu cập nhật thành công
                }
            }
            return false;
        }

        public bool Delete(object id)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "DELETE FROM account WHERE ID = @ID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", id)
                };

                int result = dbHelper.ExecuteNonQuery(query, parameters);
                return result > 0; // Trả về true nếu xóa thành công
            }
        }

        public IModel Read(object id)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT * FROM account WHERE ID = @ID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", id)
                };

                DataTable dataTable = dbHelper.ExecuteQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    return new UserAccountModel
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Username = row["username"].ToString(),
                        Password = row["password"].ToString(),
                        Role = row["role"].ToString()
                    };
                }
            }
            return null;  // Trả về null nếu không tìm thấy
        }

        public bool IsExist(object id)
        {
            using (DatabaseHelper dbHelper = new DatabaseHelper(connectionString))
            {
                string query = "SELECT COUNT(*) FROM account WHERE ID = @ID";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ID", id)
                };

                int count = (int)dbHelper.ExecuteScalar(query, parameters);
                return count > 0;  // Trả về true nếu tồn tại
            }
        }

        public bool IsExist(IModel model)
        {
            if (model is UserAccountModel userAccount)
            {
                return IsExist(userAccount.ID); // Kiểm tra dựa trên ID
            }
            return false;
        }
    }
}
