namespace TPVLib
{
    public class TicketHeader
    {

    }
    public class TicketBody
    {
        private TicketLine[] _TicketLines = new TicketLine[0];
    }
    public class TicketLine
    {
        private Product[] products = new Product[0];
        public string? description;
    }
    public class Ticket
    {
         TicketHeader header;
         TicketBody body;

    }
}
