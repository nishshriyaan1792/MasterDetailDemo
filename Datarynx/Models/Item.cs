using System;
using Xamarin.Forms;

namespace Datarynx.Models
{
    public class Item : BindableObject
    {
        public string WeekNo { get; set; }
        public string WeekDate { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public string CodingType { get; set; }
        public string TaskState { get; set; }
        public bool IsStartAuditVisible { get; set; }

    }
}