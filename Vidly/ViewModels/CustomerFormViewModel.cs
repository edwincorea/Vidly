using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        // If we have new properties in domain object (i.e. fullname), we don't want to pollute entity object. In this case, we reuse entity object.
        public Customer Customer { get; set; }
    }
}