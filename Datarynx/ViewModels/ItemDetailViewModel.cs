using System;

using Datarynx.Models;

namespace Datarynx.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            
        }
    }
}
