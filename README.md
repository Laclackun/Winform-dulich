Cant connect to sql ?
1. In "Utils" -> DatabaseHelper -> Change your Data Source.
2. "public DatabaseHelper(string connectionString)
        {
                _connection = new SqlConnection("your data source here");
        }
"
3. ex:"Data Source=PCTRAN;Initial Catalog=dulich;Integrated Security=True"
4. Rebuild the Travelexe (Setup for .exe) again.

What username to login ?
1. quyquynh (admin) : 12345
2. trantran (staff) : 09876
3. uyDuong (Customer) : ABC

Cant Create New when alread hit information in DataGridView ?
-> Click Button "Back" and try it again in that view.

How to setup .exe ?
-> First Open Folder "Travelexe" -> "Debug" -> Setup.
(Dont setup the folder in C:/ pls)

Thanks!
