using System;
using SQLite;

namespace Datarynx.Models.DBModels
{
    public class BaseItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
    }
}
