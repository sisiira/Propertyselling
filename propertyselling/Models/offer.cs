using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace propertyselling.Models
{
    public class Offer
    {
        public int Id { get; set; }

        public String Author { get; set; }

        public String Phonenumber { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }

        public Double Price { get; set; }

        public String Image { get; set; }

        public Offer()
        {

        }
    }


}