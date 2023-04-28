using System.Collections.Generic;

namespace BankApp.Web.Data.Entities
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        //Nav Props
        public List<Account> Accounts { get; set; }
    }
}
