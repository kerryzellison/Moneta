using Microsoft.Data.Sqlite;
using MonetaFMS.Interfaces;
using MonetaFMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetaFMS.Services
{
    public abstract class AbstractTableService<T> : ITableService<T> where T : Record
    {
        protected IDBService DBService { get; set; }
        
        protected abstract string TableName { get; }

        protected AbstractTableService(IDBService dBService)
        {
            DBService = dBService;
        }

        #region ITableService
        public List<T> AllItems { get; set; }
        public abstract T CreateEntry(T newValue);
        public abstract bool DeleteEntry(T deletedValue);
        public virtual T ReadEntry(int id) => AllItems?.FirstOrDefault(i => i.Id == id);
        public abstract bool UpdateEntry(T updatedValue);
        #endregion

        protected abstract void SetParameters(SqliteCommand command, T val);

        protected virtual List<T> GetAllFromDB()
        {
            List<T> allItems = new List<T>();

            try
            {
                using (SqliteConnection db = new SqliteConnection(DBService.DBConnectionString))
                {
                    db.Open();

                    SqliteCommand command = new SqliteCommand($"SELECT * FROM {TableName};", db);

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            allItems.Add(ParseFromReader(reader));
                        }
                        catch
                        {
                            // Invalid entry read
                        }
                    }
                }
            }
            catch (SqliteException)
            {
                return new List<T>();
            }

            return allItems;
        }

        protected abstract T ParseFromReader(SqliteDataReader reader);
        
        protected decimal ConvertToDollars(int cents) => cents / (decimal)100;
        protected int ConvertToCents(decimal dollars) => (int)(dollars * 100);
    }
}
