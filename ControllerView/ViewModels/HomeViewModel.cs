using System.Collections.Generic;
using ControllerView.Models;

namespace ControllerView.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Task> Tasks { get; set; }
    }
}