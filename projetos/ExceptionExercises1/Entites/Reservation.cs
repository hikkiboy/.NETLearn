using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using ExceptionExercises1.Entites.Exceptions;

namespace ExceptionExercises1.Entites
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }

        public DateTime Checkin { get; set; }

        public DateTime Checkout { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void updateDates(DateTime checkin, DateTime checkout)
        {
            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "ROOM: "
                + RoomNumber
                + ", Check in"
                + Checkin.ToString("dd/MM/yyyy")
                + ", Check out: "
                + Checkout.ToString("dd/mm/yyyy")
                + ", "
                + duration();

        }
    }
}
