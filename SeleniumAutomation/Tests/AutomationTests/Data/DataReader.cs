namespace AutomationTests.Data
{
    using System.Configuration;
    using System.Data.OleDb;
    using System.Linq;
    using Dapper;
    using Extensions;

    public class DataReader<T> where T : class
    {
        private const string CONNECTION_STRING = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0;";
        private const string DATA_PATH_KEY = "dataPath";
        private const string DATA_SOURCE_FILE_NAME = "DataSource.xlsx";
        private const string QUERY_TEMPLATE = @"select * from [{0}$] where TestName = '{1}'";

        public T GetData(string test)
        {
            var dataSource = $"{(ConfigurationManager.AppSettings[DATA_PATH_KEY] + DATA_SOURCE_FILE_NAME).ToAbsolutePath()}";
            using (var connection = new OleDbConnection(string.Format(CONNECTION_STRING, dataSource)))
            {
                return connection.Query<T>(string.Format(QUERY_TEMPLATE, typeof(T).Name, test)).FirstOrDefault();
            }
        }
    }
}
