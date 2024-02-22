namespace TPVLib
{
    public class TicketHeader
    {
       public string? CodesBar {  get; set; }
       public long id { get; set; }
       public DateTime date { get; set; }

        public TicketHeader Clone()
        {
            TicketHeader header = new TicketHeader();
            header.CodesBar = CodesBar;
            header.id = id;
            header.date = date;
            return header;
            
        }
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
         public TicketHeader header = new TicketHeader();
         public TicketBody body = new TicketBody();

        public Ticket Clone()
        {
            Ticket ticket = new Ticket();
            ticket.header = header;
            ticket.body = body;
            return ticket;
        }
    }
}
