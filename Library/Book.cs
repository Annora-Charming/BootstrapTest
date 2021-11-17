using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Title { get; set; }
        
        public string Author { get; set; }
        
        public string ISBN { get; set; }
        
        public string PublishingHouse { get; set; }
        
        public string InventoryNumber { get; set; }
        
        public string Description { get; set; }
        
        public string YearOfEdition { get; set; }
        
        public string Genre { get; set; }
        
        public float Rating { get; set; }

        // public byte[] FrontCover { get; set; }
        // public byte[] BackCover { get; set; }
    }
}
