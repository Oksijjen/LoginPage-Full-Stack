using Core.Domain;
using System;
using System.Collections.Generic;

namespace LoginPage.Model.Entity
{
    public partial class User : AudiTableEntity, IBaseDomain
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }

    }
}
