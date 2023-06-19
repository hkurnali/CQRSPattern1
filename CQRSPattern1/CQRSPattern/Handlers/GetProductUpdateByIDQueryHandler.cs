using CQRSPattern1.CQRSPattern.Queries;
using CQRSPattern1.CQRSPattern.Results;
using CQRSPattern1.DAL;

namespace CQRSPattern1.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUptadeQueryResult Handler(GetProductUpdateByIDQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductUptadeQueryResult
            {
                ProductBrand = values.ProductBrand,
                ProductName = values.ProductName,
                ProductID = values.ProductID,
                ProductPrice = values.ProductPrice,
                ProductStatus = values.ProductStatus,
                ProductStoct = values.ProductStoct

            };
        
        
        
        
        
        }
    }
}
