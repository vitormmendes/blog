using (var connection = new System.Data.SqlClient.SqlConnection())
using (var command = new System.Data.SqlClient.SqlCommand("SELECT TOP 1 Data FROM MinhaTabela", connection))
{
    connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

    connection.Open();

    using (var dataReader = command.ExecuteReader())
    {
        if (dataReader.Read())
        {
            Response.Write(dataReader["Data"].ToString());
        }
    }
}