using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService()
        {
        }

        public SeedingService(SalesWebMvcContext context) 
        { 
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any()) 
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "James", "james@gmail.com", new DateTime(1994, 2, 24), 1500.0, d2);
            Seller s3 = new Seller(1, "Francis", "francis@gmail.com", new DateTime(1998, 4, 07), 1700.0, d4);
            Seller s4 = new Seller(1, "Ana", "ana@gmail.com", new DateTime(1998, 5, 21), 1300.0, d3);
            Seller s5 = new Seller(1, "Thiago", "thiago@gmail.com", new DateTime(1998, 2, 21), 1090.0, d3);
            Seller s6 = new Seller(1, "Rafaela", "rafaela@gmail.com", new DateTime(1998, 3, 21), 1150.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2008, 9, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2008, 9, 25), 900.0, SaleStatus.Billed, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2008, 9, 25), 1100.0, SaleStatus.Billed, s1);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2008, 9, 25), 1200.0, SaleStatus.Billed, s2);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2008, 9, 25), 1400.0, SaleStatus.Billed, s2);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2008, 9, 25), 1000.0, SaleStatus.Billed, s2);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2008, 9, 25), 100.0, SaleStatus.Billed, s3);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2008, 9, 25), 1000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2008, 9, 25), 11200.0, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2008, 9, 25), 1000.0, SaleStatus.Billed, s5);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2008, 9, 25), 1200.0, SaleStatus.Billed, s6);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2008, 9, 25), 1600.0, SaleStatus.Billed, s5);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2008, 9, 25), 5000.0, SaleStatus.Billed, s6);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2008, 9, 25), 11000.0, SaleStatus.Billed, s4);

            _context.Department.AddRange(d1,d2,d3,d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14);

            _context.SaveChanges();
        }

    }
}
