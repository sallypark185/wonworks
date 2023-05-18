using System.Data;
using System.Data.SqlClient;

namespace WonWorld.Data
{
    public class DbConnector
    {
        string connString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=M-DB;User ID=sa;Password=dnjs!32433";
        public SqlConnection conn;

        public void Open()
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connString);
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Close()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //DataSet 객체 리턴
        public DataSet GetDataSet(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

      

        public List<T> GetList<T>(IDataReader reader)
        {
            List<T> list = new List<T>();
            try {
                var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                while (reader.Read())
                {
                    var type = typeof(T);
                    T obj = (T)Activator.CreateInstance(type);
                    foreach (var prop in type.GetProperties())
                    {
                        if (!columns.Any(x => x == prop.Name)) continue;
                        var propType = prop.PropertyType;
                        var _value = reader[prop.Name];
                        if (_value.GetType().Name == "DBNull") _value = string.Empty;
                        prop.SetValue(obj, _value);
                    }
                        list.Add(obj);

                }
                return list;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        public bool InsertData(string sql)
        {

            try
            {
                SqlCommand command = new SqlCommand(sql, conn);

                return command.ExecuteNonQuery() > 0 ? true : false;

            }
            catch(Exception ex)
            {
                return false;
            }
           
        }

        public static T ConvertFromDBVal<T>(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return default(T); // returns the default value for the type
            }
            else
            {
                return (T)obj;
            }
        }
    }
}
