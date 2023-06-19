using CQRSPattern1.CQRSPattern.Results;
using CQRSPattern1.DAL;

namespace CQRSPattern1.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x =>
            new GetProductQueryResult
            {
                ProductBrand = x.ProductBrand,
                ProductName = x.ProductName,
                ProductID = x.ProductID,
                ProductPrice = x.ProductPrice,
                ProductStatus = x.ProductStatus,
                ProductStoct = x.ProductStoct

            }).ToList();
            return values;
        
        
        }
    }
}
