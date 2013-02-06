using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using System;

namespace bltoolkit.console
{
    [TableName(Owner = "public", Name = "\"Country\"")]
    public partial class Country
    {
        [MapField("\"CountryId\""), PrimaryKey(1)]
        public Int32 CountryId { get; set; } // integer
        [MapField("\"Code\"")]
        public String Code { get; set; } // character varying(2)(2)
        [MapField("\"Name\"")]
        public String Name { get; set; } // text
        [MapField("\"NativeName\"")]
        public String NativeName { get; set; } // text
        [MapField("\"System\"")]
        public Int16? System { get; set; } // smallint
    }

}
