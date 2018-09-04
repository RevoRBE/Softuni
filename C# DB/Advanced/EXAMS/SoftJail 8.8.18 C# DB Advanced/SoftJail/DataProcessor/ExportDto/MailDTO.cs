using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SoftJail.DataProcessor.ExportDto
{
   public class MailDTO
    {
        //[Required]
        public string Description { get; set; }

        //[Required]
        public string Sender { get; set; }

        //[Required]
        //[RegularExpression(@"[A-Za-z0-9 ]+ str\.$")]
        public string Address { get; set; }
    }
}
