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
            ToDoItems = new ObservableCollection<ToDoItem>();

            ToDoItems.Add(new ToDoItem() { Id = 1, Title = "My first task", Description = "Line up the ducks.", IsCompleted = false });
            ToDoItems.Add(new ToDoItem() { Id = 2, Title = "My second task", Description = "Feed ducks frozen peas.", IsCompleted = false });
        }

        #region Binding Members
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        #endregion

    }
}
