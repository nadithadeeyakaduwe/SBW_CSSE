using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.DataAccess.Repositories
{
    public class InvoiceRepository
    {
        public DataTable GetProdutTypes()
        {
            DataTable Response;
            string query = "SELECT p.Product_Type FROM [Stock].[Product] p";

            Response = Repository.getDataTable(query);

            return Response;
        }

    }
}
