using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWannabe
{
    public class Query
    {
        public static List<object[]> Get()
        {
            List<object[]> executedQueries = new List<object[]>();

            List<object[]> unexecutedQueries = QueryDBHandler.Get();

            string email = CredentialHandler.getCurrentUser().getEmail();
            email = email.Replace("'", "''");

            foreach (object[] query in unexecutedQueries)
            {
                string name = query[0].ToString();
                string type = query[1].ToString();
                string field = query[2].ToString();
                executedQueries.Add(new object[] { name,
                    QueryDBHandler.execQuery(email, type, field) });
            }

            return executedQueries;
        }
    }
}
