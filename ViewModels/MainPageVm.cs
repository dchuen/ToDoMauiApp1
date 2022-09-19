using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    internal class MainPageVm
    {
        public MainPageVm()
        {
            ToDoItems = ToDoItem.GetDefaultToDoItems();
        }

        #region Binding Members
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        #endregion

    }
}
