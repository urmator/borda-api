using System;
using System.Collections.Generic;
using System.Text;

namespace borda_api.Data.Models
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime AppTime { get; set; }
    }
}
