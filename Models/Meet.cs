using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class MeetInfo
    {
        public int Id { get; set; }
        public string? Location { get; set; }

        public DateTime Date { get; set; }

        public int NumberOfPeople { get; set; }
    }
}