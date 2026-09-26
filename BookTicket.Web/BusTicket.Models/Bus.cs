using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusTicket.Models
{
    public class Bus
    {
        public int Id { get; set; }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public string BusNumber { get; set; }
        public string SeatCapacity { get; set; }
    }
}
