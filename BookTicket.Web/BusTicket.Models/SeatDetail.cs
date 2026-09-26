using System;
using System.Collections.Generic;
using System.Text;

namespace BusTicket.Models
{
    public class SeatDetail
    {
        public int Id { get; set; }
        public int SeatNo { get; set; }
        public string Description { get; set; }
        public int BusId { get; set; }
        public Bus Bus { get; set; }

    }
}
