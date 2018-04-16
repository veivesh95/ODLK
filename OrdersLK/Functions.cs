using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersLK
{
    public class Functions
    {
        public static SqlConnection con = ConnectionManager.GetConnection();
        static Regex ValidEmailRegex = CreateValidEmailRegex();

        //to get the next id for the given table
        public static String getNextID(String col, String table, String prefix)
        {
            int id = 0;
            String query = "select max (substring(" + col + ",4,len(" + col + "))) as id from " + table;
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "table");
                DataTable dt = ds.Tables["table"];
                foreach (DataRow dr in dt.Rows)
                {

                    if (dr["id"].ToString() == "")
                        id = 10000;
                    else
                        id = int.Parse(dr["id"].ToString()) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return prefix + id;
        }

        //to excute the non return query
        public static void ExecuteQuery(String query)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        //to display data in the grid view table
        public static void DisplayData(String table, DataGridView dataGridView)
        {
            try
            {
                string query = "select * from " + table + " order by Date Desc";
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(query, con);
                adapt.Fill(dt);
                dataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //to display data in the datagridview
        public static void loadTable(string query, DataGridView dvg)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
                dvg.DataSource = dt;
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }//method




        public static void LoadComboBox(string table, ComboBox combo, String colName)
        {
            try
            {
                string query = "select Distinct Catergory from " + table;
                combo.Items.Clear();
                con.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
                DataSet ds1 = new DataSet();
                sda1.Fill(ds1, "Table");
                DataTable dt1 = ds1.Tables["Table"];
                combo.Items.Add("ALL");
                foreach (DataRow dr in dt1.Rows)
                {
                    combo.Items.Add(dr[colName].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }//method


        public static DataTable getData(String query)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter(query, con);
                adapt.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }



        //public static bool isNumber(string values)
        //{
        //    Regex r = new Regex(@"^[0-9]+$");
        //    if (r.IsMatch(values))
        //        return true;
        //    return false;

        //}

        //public static bool isText(string values)
        //{
        //    Regex r = new Regex(@"^[a-zA-Z]+$");
        //    if (r.IsMatch(values))
        //        return true;
        //    return false;

        //}

        public static String getVal(String colname, String query)
        {

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "table");
                DataTable dt = ds.Tables["table"];
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[colname].ToString() != "")
                        return dr[colname].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return "0";
        }

        public static void ComboWithKey(ComboBox combo, string query, string key, string value)
        {
            try
            {
                combo.Items.Clear();
                con.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
                DataSet ds1 = new DataSet();
                sda1.Fill(ds1, "Table");
                DataTable dt1 = ds1.Tables["Table"];

                foreach (DataRow dr in dt1.Rows)
                {
                    combo.Items.Add(new KeyValuePair<String, String>(dr[key].ToString(), dr[value].ToString()));
                    combo.ValueMember = "Key";
                    combo.DisplayMember = "Value";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }


        public static bool isLetter(String text)
        {
            bool hasLetter = false;
            foreach (char letter in text)
            {
                if (char.IsLetter(letter))
                {
                    hasLetter = true;
                    return hasLetter;
                }
            }
            return hasLetter;
        }


        public static void delOrderItems(String query)// SqlConnection con)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "table");
                DataTable dt = ds.Tables["table"];
                con.Close();
                foreach (DataRow dr in dt.Rows)
                {
                    string productid = dr["ProductId"].ToString();
                    int quantity = int.Parse(dr["Quantity"].ToString());
                    string query1 = "select QuantityAvailable from Product where ProductId = '" + productid + "'";
                    int availableqty = int.Parse(Functions.getVal("QuantityAvailable", query1));
                    int totalquantity = quantity + availableqty;
                    string updtprdqry = "Update Product set QuantityAvailable = " + totalquantity + " where ProductId = '" + productid + "'";
                    Functions.ExecuteQuery(updtprdqry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }

        }


        public static bool isNumber(String text)
        {
            bool hasNumber = false;
            foreach (char number in text)
            {
                if (char.IsDigit(number))
                {
                    hasNumber = true;
                    return hasNumber;
                }
            }
            return hasNumber;
        }

        public static bool IsAllLettersOrDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }


        public static bool isMaxLength(int text)
        {
            bool hasMax = false;

            if (text > 10)
            {
                hasMax = true;
                return hasMax;
            }



            return hasMax;
        }



        public static String getValue(String table, String col, String choice, String wanted)
        {
            String query_ = "SELECT * FROM " + table + " WHERE " + col + "='" + choice + "'";
            String output = "";
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query_, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                output = dt.Rows[0][wanted].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
            return output;
        }

        public static String getData(String table, String column, String search, String resultColumn)
        {
            String query_ = "SELECT * FROM " + table + " WHERE " + column + " ='" + search + "'";
            String output = "";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query_, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                output = dt.Rows[0][resultColumn].ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return output;
        }


        public static void LoadComboBoxes(string query, ComboBox combo, String colName)
        {
            try
            {
                combo.Items.Clear();
                con.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
                DataSet ds1 = new DataSet();
                sda1.Fill(ds1, "Table");
                DataTable dt1 = ds1.Tables["Table"];

                foreach (DataRow dr in dt1.Rows)
                {
                    combo.Items.Add(dr[colName].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public static DataTable showOrderedTableSales()
        {
            String query = "SELECT OrderId, OrderDate, OrderStatus, PaymentStatus, CustomerId, EmpId, TotalAmount FROM Orders WHERE OrderStatus = 'Confirmed' ORDER BY OrderDate ASC, OrderId ASC";
            DataTable data = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(data);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
            return data;
        }

        public static DataTable showTableSales()
        {
            String query = "SELECT OrderId, OrderDate, OrderStatus, PaymentStatus, CustomerId, EmpId, TotalAmount FROM Orders";
            DataTable data = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(data);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
            return data;
        }

        public static DataTable showTable(String table)
        {
            String query = "SELECT * FROM " + table;
            DataTable data = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(data);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
            return data;
        }

        public static DataTable searchSalesTable(String searchColumn, String searchKey)
        {
            String query = "SELECT OrderId, OrderDate, OrderStatus, PaymentStatus, CustomerId, EmpId, TotalAmount FROM Orders WHERE " + searchColumn + " LIKE '%" + searchKey + "%'";
            DataTable data = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(data);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
            return data;
        }

        public static void UpdateCancelledOrder(String orderId)
        {
            int exQuantity = 0, orderQuantity = 0;
            String product = "";

            String getOrderItemDetails = "SELECT ProductId, Quantity FROM OrderItem WHERE OrderId = '" + orderId + "'";
            String updateStatus = "UPDATE Orders SET OrderStatus = 'Cancelled' WHERE OrderId = '" + orderId + "'";
            String updateQuantity = "UPDATE Product SET QuantityAvailable = " + (exQuantity + orderQuantity) + " WHERE ProductId = '" + product + "'";

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(getOrderItemDetails, con);
                DataSet ds1 = new DataSet();
                sda.Fill(ds1, "Table");
                DataTable dt1 = ds1.Tables["Table"];

                foreach (DataRow dr in dt1.Rows)
                {
                    product = dr["ProductId"].ToString();
                    orderQuantity = Int32.Parse(dr["Quantity"].ToString());
                    exQuantity = Int32.Parse(Functions.getData("Product", "ProductId", product, "QuantityAvailable"));
                    updateQuantity = "UPDATE Product SET QuantityAvailable = " + (exQuantity + orderQuantity) + " WHERE ProductId = '" + product + "'";

                    Functions.ExecuteQuery2(updateQuantity);
                }
                Functions.ExecuteQuery2(updateStatus);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable searchTable(String table, String column, String searchKey)
        {
            String query = "SELECT * FROM " + table + " WHERE " + column + " LIKE '%" + searchKey + "%'";
            DataTable data = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(data);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
            return data;
        }

        public static void ExecuteQuery2(String query)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public static void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        public static void FillList(String table, String col, String orderTerm, ListBox list)
        {
            String query_ = "SELECT * FROM " + table + " ORDER BY " + orderTerm;
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query_, con);
                DataSet ds1 = new DataSet();
                sda.Fill(ds1, "Table");
                DataTable dt1 = ds1.Tables["Table"];

                foreach (DataRow dr in dt1.Rows)
                {
                    string name = dr[col].ToString();
                    list.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable GetListData(String table, String col, String listString)
        {
            String query_ = "SELECT * FROM " + table + " WHERE " + col + " = '" + listString + "'";
            DataTable result = null;

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query_, con);
                DataSet ds1 = new DataSet();
                sda.Fill(ds1, "Table");
                DataTable dt1 = ds1.Tables["Table"];
                result = dt1;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

        public static DataTable searchPendingOrdersTable(String searchColumn, String searchKey)
        {
            String query = "SELECT OrderId, OrderDate, OrderStatus, PaymentStatus, CustomerId, EmpId, TotalAmount FROM Orders WHERE " + searchColumn + " LIKE '%" + searchKey + "%' AND OrderStatus = 'Confirmed'";
            DataTable data = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(data);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
            return data;
        }

        public static DataTable showTableSales(Int32 month)
        {
            String query = "SELECT OrderId, OrderDate, OrderStatus, PaymentStatus, CustomerId, EmpId, TotalAmount FROM Orders WHERE MONTH(OrderDate) = '" + month + "'";
            DataTable data = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(data);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
            return data;
        }

        public static DataTable showTableSales(String status)
        {
            String query = "SELECT OrderId, OrderDate, OrderStatus, PaymentStatus, CustomerId, EmpId, TotalAmount FROM Orders WHERE OrderStatus = '" + status + "'";
            DataTable data = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(data);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
            return data;
        }


        //validation methods

        public static bool isText(string values)
        {
            Regex r = new Regex(@"^[a-zA-Z]+$");
            if (r.IsMatch(values))
                return true;
            return false;

        }

        public static bool isName(string values)
        {
            var name = values.Trim();
            if (Regex.IsMatch(name, @"^[\p{L} \.\-]+$"))
                return true;
            return false;


        }

        public static bool isValid(string emailaddress)
        {
            if (emailaddress != "" && emailaddress != null)
            {
                try
                {
                    MailAddress m = new MailAddress(emailaddress);
                    return true;
                }

                catch (FormatException)
                {
                    return false;
                }
            }
            else return false;

        }

        public static bool isContact(String number)
        {
            Regex phoneNumpattern = new Regex(@"(?<!\d)\d{10}$");
            if (phoneNumpattern.IsMatch(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
