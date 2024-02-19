namespace TPVLib
{
    public class TicketHeader
    {
       public string CodesBar {  get; set; }
       public long id { get; set; }
       public DateTime date { get; set; }
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
         public TicketHeader header;
         public TicketBody body;

    }
}
