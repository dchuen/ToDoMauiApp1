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
            ToDoItems = GetDefaultToDoItems();
        }

        #region Binding Members
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        #endregion


        ObservableCollection<ToDoItem> GetDefaultToDoItems()
        {
            ObservableCollection<ToDoItem> Result = new ObservableCollection<ToDoItem>();

            Result.Add(new ToDoItem() { Id = 1, Title = "Bring a Fishing Pole to an Aquarium", Description = "No need to use it. Just bringing it along will have people confused.  If the funny looks you’re getting aren’t confused looking enough, carry an 20L empty bucket.", IsCompleted = false });
            Result.Add(new ToDoItem() { Id = 2, Title = "Feed ducks", Description = "Feed ducks frozen peas.", IsCompleted = false });
            Result.Add(new ToDoItem() { Id = 3, Title = "Speak In Third Person All Day", Description = "Not once say “I”, “me”, or even “us”. Of all the funny things bucket list ideas, this is probably the least weird one, but it can be surprisingly challenging.", IsCompleted = false });
            Result.Add(new ToDoItem() { Id = 4, Title = "Teach a parrot to ask for help", Description = "Buy a parrot.Teach the parrot to say,”Help! I’ve been turned into a parrot!”", IsCompleted = false });

            return Result;
        }
    }
}
