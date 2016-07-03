using Newtonsoft.Json;
using MySql.Data.MySqlClient;

namespace borkedLabs.CrestScribe.Settings
{
    public class DatabaseSettings
    {
        private string _host;

        [JsonProperty("host")]
        public string Host
        {
            get
            {
                return _host;
            }
            set
            {
                _host = value;
                _connectionString = string.Empty;
            }
        }
        
        private uint _port;

        [JsonProperty("port")]
        public uint Port
        {
            get
            {
                return _port;
            }
            set
            {
                _port = value;
                _connectionString = string.Empty;
            }
        }
        
        private string _schema;

        [JsonProperty("schema")]
        public string Schema
        {
            get
            {
                return _schema;
            }
            set
            {
                _schema = value;
                _connectionString = string.Empty;
            }
        }

        private string _user;

        [JsonProperty("user")]
        public string User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                _connectionString = string.Empty;
            }
        }

        private string _password;

        [JsonProperty("password")]
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                _connectionString = string.Empty;
            }
        }

        [JsonIgnore]
        private string _connectionString = string.Empty;

        [JsonIgnore]
        public string ConnectionString
        {
            get
            {
                if(_connectionString != string.Empty)
                {
                    return _connectionString;
                }

                var cs = new MySqlConnectionStringBuilder();
                cs.Server = ScribeSettings.Settings.Database.Host;
                cs.UserID = ScribeSettings.Settings.Database.User;
                cs.Password = ScribeSettings.Settings.Database.Password;
                cs.Database = ScribeSettings.Settings.Database.Schema;
                cs.Port = ScribeSettings.Settings.Database.Port;

                _connectionString = cs.ToString();

                return _connectionString;
            }
        }
    }
}
