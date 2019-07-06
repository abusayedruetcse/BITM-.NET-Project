using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Models;

namespace StockManagementSystem.StockManagement.Repository
{
    public class StockOutRepository
    {
        string connectionString;
        SqlConnection sqlConnection;
        string commandString;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public StockOutRepository()
        {
            connectionString = @"Server=(local)\SQLEXPRESS; Database=StockManagementDB  ;Integrated Security=True  ";
            sqlConnection = new SqlConnection(connectionString);
        }
        public DataTable DataBindCompanyToComboBox()
        {
            commandString = @"SELECT * FROM Companies";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public DataTable DataBindCategoryToComboBox()
        {
            commandString = @"SELECT * FROM Categories";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public DataTable DataBindCompanyByFilteringToComboBox(int categoryId)
        {
            commandString = @"SELECT DISTINCT com.Name AS Name, i.CompanyId AS ID FROM Companies AS com LEFT JOIN Items AS i ON com.CompanyId=i.CompanyId WHERE i.CategoryId=" + categoryId + "";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public DataTable DataBindCategoryByFilteringToComboBox(int companyId)
        {
            commandString = @"SELECT DISTINCT cat.Name, i.CategoryId FROM Categories AS cat LEFT JOIN Items AS i ON cat.CategoryId=i.CategoryId WHERE i.CompanyId=" + companyId + "";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public DataTable DataBindItemByFilteringToComboBox(int categoryId, int companyId)
        {
            commandString = @"SELECT * FROM Items WHERE CategoryId =" + categoryId + " AND CompanyId=" + companyId + "";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public DataTable GetAvailableQuantityAndReorderLevelFromItem(Item item)
        {
            commandString = @"SELECT * FROM Items WHERE Name='" + item.Name + "' AND CategoryId =" + item.CategoryId + " AND CompanyId=" + item.CompanyId + "";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public int AddStockOut(StockOut stockOut)
        {
            int isExecuted = 0;
            commandString = @"INSERT INTO StockOuts VALUES('" + stockOut.Date + "'," + stockOut.Quantity + "," + stockOut.ItemId + ",'" + stockOut.Action + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return isExecuted;
        }
        public DataTable GetItemById(Item item)
        {
            commandString = @"SELECT * FROM Items WHERE ItemId=" + item.ItemId + "";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public void UpdateItem(Item item)
        {
            int isExecuted = 0;
            commandString = @"UPDATE Items SET AvailableQuantity=" + item.AvailableQuantity + "  WHERE ItemId=" + item.ItemId + "";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
