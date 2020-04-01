using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ControllerView.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string ColorHex { get; set; }
        public bool IsDone { get; set; }
    }
}