using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBTool
{
    internal class Database
    {
        SqliteConnection sql;

        void InitConnection()
        {
            sql = new SqliteConnection("Data Source=config.sqlite; Verison=3; New=true; Compress=False");
            try
            {
                sql.Open();
            } catch(Exception ex)
            {
                Wspolne.log.LogSave("");
            }
        }
    }
}
