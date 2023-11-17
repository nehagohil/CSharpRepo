using System;


namespace IntroductionToCsharp
{
    public class NullColaesingOperator
    {
        public void nulldemo()
        {
            //nullable type

            //bool? AreYouMajor = null;

            //if(AreYouMajor == true)
            //{
            //    Console.WriteLine(" User is Major");
            //}
            //else if(AreYouMajor ==false)
            //{
            //    Console.WriteLine(" User is not a Major");
            //}
            //else
            //{
            //    Console.WriteLine(" User has not entered any choices");
            //}

            //without null colaesing operator

            //int? TicketsOnsale = 10;
            //int AvailableTickets;

            //if(TicketsOnsale ==null)
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    AvailableTickets = TicketsOnsale.Value; //(int)TicketsOnsale;
            //}
            //Console.WriteLine("Available Tickets= {0}",AvailableTickets);

            //null colaesing operator

            int? TicketsOnsale = null;
            int AvailableTickets;

            AvailableTickets = TicketsOnsale ?? 0;
            Console.WriteLine("Available Tickets= {0}", AvailableTickets);
        }
    }
}
