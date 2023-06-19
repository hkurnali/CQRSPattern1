using CQRSPattern1.CQRSPattern.Queries;
using CQRSPattern1.CQRSPattern.Results;
using CQRSPattern1.DAL;

namespace CQRSPattern1.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Products.Find(query.Id);
           return new GetProductByIDQueryResult

            {
                ProductBrand = values.ProductBrand,
                ProductName = values.ProductName,
                ProductID = values.ProductID,

            };
        }
    }                
}
