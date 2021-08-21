using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;

namespace CinemaBox {
    class DataBaseSQL {
        public static OleDbConnection connectionDB;
        public static OleDbDataAdapter adapterDB;
        public static DataSet dataSetDB;
        public static BindingSource bindingSourceDB;

        public void ConnectToBD() {
            connectionDB = new OleDbConnection();
            bindingSourceDB = new BindingSource();
            connectionDB.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                 "Data Source=" + Directory.GetCurrentDirectory() + "\\Cinema.mdb";
            SettingConnectionString.SetConnectionString = connectionDB.ConnectionString;
        }

        /// <summary>
        /// Основной запрос вывода таблиц в DGV
        /// </summary>
        /// <param name="query">SQL query</param>
        /// <param name="DGV">DataGridView</param>
        /// <param name="form">Form</param>
        public void MainQuery(string query, DataGridView DGV, Form form) {
            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            OleDbCommand selProduct = new OleDbCommand(query, connectionDB);
            adapterDB = new OleDbDataAdapter(selProduct);
            dataSetDB = new DataSet();
            adapterDB.Fill(dataSetDB);
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
            bindingSourceDB.DataSource = dataSetDB.Tables[0];
            DataGridDB(DGV, form);
        }

        void DataGridDB(DataGridView DGV, Form form) {
            DGV.ScrollBars = ScrollBars.Both;
            /*DGV.Height = form.Height - 100;
            DGV.Width = form.Width - 310;*/

            DGV.AutoGenerateColumns = true;
            DGV.DataSource = bindingSourceDB;
            DGV.AutoResizeColumns();

            DGV.DefaultCellStyle.Font = new Font("Bahnschrift", 9);
            DGV.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV.RowHeadersVisible = false;

            DGV.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 9, FontStyle.Bold);
            DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(168, 47, 99);
        }
        /// <summary>
        /// Выборка из таблиц
        /// </summary>
        /// <param name="sel">Select</param>
        /// <param name="from">From</param>
        public void SelectSQL(string sel, string from) {
            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            OleDbCommand selSQL = new OleDbCommand();
            selSQL = connectionDB.CreateCommand();
            selSQL.Connection = connectionDB;
            selSQL.CommandText = $"select {sel} from {from}";
            selSQL.ExecuteNonQuery();
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
        }
        /// <summary>
        /// Выборка из таблиц
        /// </summary>
        /// <param name="sel">Select</param>
        /// <param name="from">From</param>
        /// <param name="where">Where</param>
        public void SelectSQL(string sel, string from, string where) {
            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            OleDbCommand selSQL = new OleDbCommand();
            selSQL = connectionDB.CreateCommand();
            selSQL.Connection = connectionDB;
            selSQL.CommandText = $"select {sel} from {from} where {where}";
            selSQL.ExecuteNonQuery();
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
        }
        /// <summary>
        /// Выборка из таблиц
        /// </summary>
        /// <param name="sel">Select</param>
        /// <param name="from">From</param>
        /// <param name="where">Where</param>
        /// <param name="order">Order by</param>
        public void SelectSQL(string sel, string from, string where, string order) {
            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            OleDbCommand selSQL = new OleDbCommand();
            selSQL = connectionDB.CreateCommand();
            selSQL.Connection = connectionDB;
            selSQL.CommandText = $"select {sel} from {from} where {where} order by {order}";
            selSQL.ExecuteNonQuery();
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
        }
        /// <summary>
        /// Выборка из таблицы Трансформом для отчетов
        /// </summary>
        /// <param name="trans">Transform</param>
        /// <param name="sel">Select</param>
        /// <param name="from">From</param>
        /// <param name="where">Where</param>
        /// <param name="group">Group by</param>
        /// <param name="order">Order by</param>
        /// <param name="pivot">Pivot</param>
        public void TransformSQL(string trans, string sel, string from, string where, string group, string order, string pivot, DataGridView DGV, Form form) {
            string query = $"transform {trans} select {sel} from {from} where {where} group by {group} order by {order} pivot {pivot}";

            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            OleDbCommand selProduct = new OleDbCommand(query, connectionDB);
            adapterDB = new OleDbDataAdapter(selProduct);
            dataSetDB = new DataSet();
            adapterDB.Fill(dataSetDB);
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
            bindingSourceDB.DataSource = dataSetDB.Tables[0];
            DataGridDB(DGV, form);
        }
        /// <summary>
        /// Удалить из таблицы FROM значение DEL по услувию WHERE
        /// </summary>
        /// <param name="del">Delete value</param>
        /// <param name="from">From table</param>
        /// <param name="where">Delete condition</param>
        public void DeleteSQL(string del, string from, string where) {
            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            OleDbCommand delSQL = new OleDbCommand();
            delSQL = connectionDB.CreateCommand();
            delSQL.Connection = connectionDB;
            delSQL.CommandText = $"delete {del} from {from} where {where}";
            Debug.WriteLine(delSQL.CommandText);
            delSQL.ExecuteNonQuery();
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
        }
        /// <summary>
        /// Обновление значения VALUE в таблице TABLE по условию WHERE
        /// </summary>
        /// <param name="table">Updatable table</param>
        /// <param name="value">Updatable value</param>
        /// <param name="where">Update condition</param>
        public void updateSQL(string table, string value, string where) {
            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            OleDbCommand updSQL = new OleDbCommand();
            updSQL = connectionDB.CreateCommand();
            updSQL.Connection = connectionDB;
            updSQL.CommandText = $"update {table} set {value} where {where}";
            Debug.WriteLine($"update {table} set {value} where {where}");
            updSQL.ExecuteNonQuery();
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
        }
        /// <summary>
        /// Добавление записи[по колонкам COLUMNS] в таблицу TABLE значений VALUES
        /// Добавление уже выбранных программно записей 
        /// </summary>
        /// <param name="table">Table</param>
        /// <param name="columns">Insert columns</param>
        /// <param name="values">Insert values</param>
        public void InsertValueSQL(string table, string columns, string values) {
            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            OleDbCommand updSQL = new OleDbCommand();
            updSQL = connectionDB.CreateCommand();
            updSQL.Connection = connectionDB;
            updSQL.CommandText = $"insert into {table}({columns}) values({values})";
            Debug.WriteLine(updSQL.CommandText);
            updSQL.ExecuteNonQuery();
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
        }
        /// <summary>
        /// Добавление записи[по колонкам COLUMNS] в таблицу TABLE значений VALUES
        /// Добавление записей из других таблиц
        /// </summary>
        /// <param name="table">Table</param>
        /// <param name="columns">Insert columns</param>
        /// <param name="sel">Insert values</param>
        /// <param name="from">Insert from tables</param>
        public void InsertSelectSQL(string table, string columns, string sel, string from) {
            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            OleDbCommand updSQL = new OleDbCommand();
            updSQL = connectionDB.CreateCommand();
            updSQL.Connection = connectionDB;
            updSQL.CommandText = $"insert into {table}({columns}) select {sel} from {from}";
            updSQL.ExecuteNonQuery();
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
        }

        /// <summary>
        /// Выбрать целочисленное значение SEL из таблицы FROM
        /// </summary>
        /// <param name="sel">Select value</param>
        /// <param name="from">Table</param>
        /// <param name="where">Where</param>
        /// <returns>Int value SELECT from table 'FROM'</returns>
        public int SelectIntSQL(string sel, string from, string where) {
            if (connectionDB.State != ConnectionState.Open) connectionDB.Open();
            OleDbCommand compossion = new OleDbCommand($"SELECT {sel} FROM {from} where {where}", connectionDB);
            Debug.WriteLine($"SELECT {sel} FROM {from} where {where}");
            OleDbDataReader readcompossion = compossion.ExecuteReader();
            while (readcompossion.Read()) {
                return Convert.ToInt32(readcompossion[$"{sel}"]);
            }
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
            return 0;
        }

        public DateTime SelectDateTimeSQL(string sel, string from, string where) {
            if (connectionDB.State != ConnectionState.Open) connectionDB.Open();
            OleDbCommand compossion = new OleDbCommand($"SELECT {sel} FROM {from} where {where}", connectionDB);
            OleDbDataReader readcompossion = compossion.ExecuteReader();
            while (readcompossion.Read()) {
                return DateTime.Parse(readcompossion[$"{sel}"].ToString());
            }
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
            return default;
        }

        /// <summary>
        /// Выбрать строковое значение SEL из таблицы FROM
        /// </summary>
        /// <param name="sel">Select value</param>
        /// <param name="from">Table</param>
        /// <param name="where">Where</param>
        /// <returns>String value SELECT from table 'FROM'</returns>
        public string SelectStringSQL(string sel, string from, string where) {
            if (connectionDB.State != ConnectionState.Open) connectionDB.Open();
            OleDbCommand compossion = new OleDbCommand($"SELECT {sel} FROM {from} where {where}", connectionDB);
            OleDbDataReader readcompossion = compossion.ExecuteReader();
            while (readcompossion.Read()) {
                return readcompossion[$"{sel}"].ToString();
            }
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
            return string.Empty;
        }
        /// <summary>
        /// Добавляет значения SEL из FROM в порядке ORDER в ChekedListBox CLB
        /// </summary>
        /// <param name="clb">ChekedListBox</param>
        /// <param name="sel">Add value</param>
        /// <param name="from">Table</param>
        /// <param name="order">Order by</param>
        public void AddInCheckedListBoxSQL(CheckedListBox clb, string sel, string from, string order) {
            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            clb.Items.Clear();
            OleDbCommand clbReader = new OleDbCommand();
            clbReader = connectionDB.CreateCommand();
            clbReader.CommandText = $"select {sel} from {from} order by {order}";
            clbReader.Connection = connectionDB;
            OleDbDataReader reader = clbReader.ExecuteReader();
            while (reader.Read()) {
                clb.Items.Add(reader[$"{sel}"].ToString());
            }
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
        }
        /// <summary>
        /// Добавляет значения SEL из FROM в порядке ORDER в ComboBox CB
        /// </summary>
        /// <param name="CB">ComboBox</param>
        /// <param name="sel">Add value</param>
        /// <param name="from">Table</param>
        /// <param name="order">Order by</param>
        public void AddInComboBoxSQL(ComboBox CB, string sel, string from, string order) {
            CB.Items.Clear();
            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            CB.Items.Clear();
            OleDbCommand clbReader = new OleDbCommand();
            clbReader = connectionDB.CreateCommand();
            clbReader.CommandText = $"select {sel} from {from} order by {order}";
            clbReader.Connection = connectionDB;
            OleDbDataReader reader = clbReader.ExecuteReader();
            while (reader.Read()) {
                CB.Items.Add(reader[$"{sel}"]);
            }
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
        }

        public void AddInComboBoxSQL(ComboBox CB, string sel, string from, string order, string fVar, string sVar) {
            CB.Items.Clear();
            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            CB.Items.Clear();
            OleDbCommand clbReader = new OleDbCommand();
            clbReader = connectionDB.CreateCommand();
            clbReader.CommandText = $"select {sel} from {from} order by {order}";
            clbReader.Connection = connectionDB;
            OleDbDataReader reader = clbReader.ExecuteReader();
            while (reader.Read()) {
                CB.Items.Add(reader[$"{fVar}"] + "-" + reader[$"{sVar}"]);
            }
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
        }

        public void Drop(string table) {
            if (connectionDB.State == ConnectionState.Closed) connectionDB.Open();
            OleDbCommand clbReader = new OleDbCommand();
            clbReader = connectionDB.CreateCommand();
            clbReader.CommandText = $"drop table {table}";
            clbReader.Connection = connectionDB;
            Debug.WriteLine(clbReader.CommandText);
            clbReader.ExecuteReader();
            if (connectionDB.State == ConnectionState.Open) connectionDB.Close();
        }
    }
    public class SettingConnectionString {
        public static string SetConnectionString { get; set; }
    }
}
