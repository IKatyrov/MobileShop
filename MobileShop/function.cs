using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MobileShop
{
    class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RPQO71T;Initial Catalog=mobileshop;Integrated Security=True");
            return conn;

        }

        //query = "select * from newMobile"
        public DataSet getData(String query) //извлечение данных из базы
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query) //вставка, удаление, обновление
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Данные успешно обработаны", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public SqlDataReader getForCombo(String query) //чтение из базы для списка comboBox
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        public IEnumerable<T> FindControls<T>(Control parent) where T : Control //перебор всех компонентов на форме
        {
            foreach (Control control in parent.Controls)
            {
                if (control is T)
                    yield return (T)control;

                foreach (T item in FindControls<T>(control))
                    yield return item;
            }
        }



    }
}
