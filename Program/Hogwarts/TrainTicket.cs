using System;
using System.Collections.Generic;

namespace Hogwarts
{
    public class TrainTicket
    {
        public TrainTicket(int[] code)
        {
            Day = code[0];
            StartTimeHour = code[1];
            StartTimeMinute = code[2];
            CabinCode = code[3];
            SeatCode = code[4];
            TicketCode = code;
        }

        //----------------------------------------------------------------

        // Day ,StartTime(Hour), StartTime(Minute),CabinCode, SeatCode
        public int[] TicketCode { get; }

        //----------------------------------------------------------------
        public int Day { get; set; }
        public int StartTimeHour { get; set; }
        public int StartTimeMinute { get; set; }
        public int CabinCode { get; set; }
        public int SeatCode { get; set; }
    }
}