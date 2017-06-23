namespace awEntities.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ContactType
    {
        public int ContactTypeID { get; set; }

        public string Name { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
