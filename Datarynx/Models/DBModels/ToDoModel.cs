﻿using SQLite;

namespace Datarynx.Models.DBModels
{
    public class ToDoModel: BaseItem
    {
       public string WeekNo { get; set; }
       public string WeekDate { get; set; }
       public string StoreName { get; set; }
       public string StoreAddress { get; set; }
       public string CodingType { get; set; }
       public string TaskState { get; set; }
    }
}
