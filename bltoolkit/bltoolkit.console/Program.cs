using BLToolkit.Data;
using BLToolkit.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bltoolkit.console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db =
            new DbManager("PostgreSQL", string.Empty))
            {
                db.SetCommand("DELETE FROM \"Country\"");
                db.ExecuteNonQuery();
            }


            IList<Country> list = new List<Country>(
                new [] {
                    new Country
                    {
                        CountryId = 1,
                        Name = "Test",
                        NativeName = "TestNative",
                        Code = "T1"
                    },
                    new Country
                    {
                        CountryId = 2,
                        Name = "Test2",
                        NativeName = null,
                        Code = "T2"
                    },
                    new Country
                    {
                        CountryId = 3,
                        Name = "Test3",
                        NativeName = null,
                        Code = "T3"
                    },
                });


            using (var db =
            new DbManager("PostgreSQL", string.Empty))
            {
                SqlQuery<Country> q = new SqlQuery<Country>(db);
                q.Insert(list); //ERROR: 42804: column "System" is of type smallint but expression is of type text
                q.Insert(list.Skip(2).First()); //ERROR: 42601: syntax error at or near ":"
                // ?????? q.Update(list);
                // ?????? q.Update(list.Skip(2).First());
            }
        }
    }
}
