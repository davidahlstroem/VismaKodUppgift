using System;

namespace VismaKodUppgift
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int ParkingSpotId { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public double Payment { get; set; }

        public void CalculatePayment(DateTime entry, DateTime exit)
        {
            double costPerMinute = 15.0 / 60.0;
            double costPerDay = 50.0;
            double dayInMinutes = 24.0 * 60.0;

            TimeSpan span = exit.Subtract(entry);
            int timeInDays = (int)span.TotalDays;
            double timeInMinutes = span.TotalMinutes;

            // For every day (24h) add 50kr to Payment and take away 1440 min from timeInMinutes
            for (int i = 0; i < timeInDays; i++)
            {
                Payment += costPerDay;
                timeInMinutes -= dayInMinutes;
            }

            // Add remaining minutes value to Payment
            Payment += timeInMinutes * costPerMinute;
            if (Payment < 0) { Payment = 0; }
        }
    }
}