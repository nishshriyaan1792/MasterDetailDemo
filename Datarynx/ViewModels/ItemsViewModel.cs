
using Xamarin.Forms;
using Datarynx.Models;
using Datarynx.Views;
using Datarynx.Models.DBModels;
using System.Collections.Generic;

namespace Datarynx.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {

        List<Item> _records = new List<Item>();
        public List<Item> Records
        {
            get
            {
                return _records;
            }

            set
            {
                _records = value;
                OnPropertyChanged(nameof(Records));
            }
        }

        public Command LoadItemsCommand { get; set; }
        readonly Database database;


        public ItemsViewModel()
        {
            Title = "To-Do List";
            database = new Database("Datarynx");
            database.CreateTable<ToDoModel>();
            LoadData();
        }

        void Add()
        {
            database.DeleteAll<ToDoModel>();
            var record1 = new ToDoModel
              {
                       WeekNo = "wk35",
                       WeekDate = "08-09",
                       StoreName = "34492783/NEW RANDOLPH STORE0045",
                       StoreAddress = "630 3RD ST WEST, RANDOLPH AFB,TX,78150",
                       CodingType = "Item Coding",
                       TaskState = "Not Started"
             };
            database.SaveItem(record1);

            var record2 = new ToDoModel
            {
                        WeekNo = "wk35",
                        WeekDate = "08-09",
                        StoreName = "34492783/NEW RANDOLPH STORE0045",
                        StoreAddress = "630 3RD ST WEST, RANDOLPH AFB,TX,78150",
                        CodingType = "Item Coding",
                        TaskState = "Not Started"
            };
            database.SaveItem(record2);

            var record3 = new ToDoModel
            {
                        WeekNo = "wk35",
                        WeekDate = "08-09",
                        StoreName = "34492783/NEW RANDOLPH STORE0045",
                        StoreAddress = "630 3RD ST WEST, RANDOLPH AFB,TX,78150",
                        CodingType = "Item Coding",
                        TaskState = "In-Progress"
            };
            database.SaveItem(record3);

        }

        void LoadData()
        {
            Add();
            var data = database.GetItems<ToDoModel>();
            
            foreach (var item in data)
            {
                Records.Add(new Item()
                {
                    WeekNo = item.WeekNo,
                    WeekDate = item.WeekDate,
                    StoreName = item.StoreName,
                    StoreAddress = item.StoreAddress,
                    TaskState = item.TaskState,
                    IsStartAuditVisible = item.TaskState == "Not Started" ? true : false
                });
            }
        }
    }
}