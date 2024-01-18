using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace project_reboque
{
    internal class Banco
    {
        private static SQLiteConnection conect;
        private static SQLiteConnection conectDB()
        {
            conect = new SQLiteConnection("Data Source = " + Global.pathDB);
            conect.Open();
            return conect;
        }
        public static DataTable dql1(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectDB();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_budgets";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch(Exception ex) {
                throw ex;
            }
        }

        public static void newBudget(models.Budget budget)
        {
            try
            {
                var vcon = conectDB();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_budgets (T_NAME, T_DATE, N_VAL) VALUES (@name, @date, @val)";
                cmd.Parameters.AddWithValue("@name", budget.name);
                cmd.Parameters.AddWithValue("@date", budget.date);
                cmd.Parameters.AddWithValue("@val", budget.val);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Orçamento salvo na DB");
            }catch(Exception ex)
            {
                MessageBox.Show("Error to save on DB, contact the developer ASS:ROSSINI");
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        public static DataTable GetDataFromBudget()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = conectDB();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_ID as 'ID', T_NAME as 'Nome', N_VAL as 'Valor', T_DATE as 'Data' FROM tb_budgets";
                da = new SQLiteDataAdapter(cmd.CommandText, conectDB());
                da.Fill(dt);
                vcon.Close();
                return dt;
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
