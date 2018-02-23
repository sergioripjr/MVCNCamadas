using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindApp.Models
{
    public class EditProductViewModel
    {
        public Domain.Product Product { get; set; }
        public List<Domain.Category> Categories { get; set; }
    }
}
