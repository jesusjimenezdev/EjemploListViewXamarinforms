using ListasDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListasDemo.Helpers;

namespace ListasDemo.ViewModel
{    
    public class MainPageViewModel
    {
        public ObservableCollection <Grouping<string, Friend>> Friends { get; set; }

        public MainPageViewModel()
        {
            FriendRepository repository = new FriendRepository();
            Friends = repository.GetAllGrouped();
        }
    }
}
