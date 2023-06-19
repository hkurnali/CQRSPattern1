using CQRSPattern1.CQRSPattern.Commands;
using CQRSPattern1.DAL;

namespace CQRSPattern1.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handler(CreateProductCommand command)
           
        {
            _context.Products.Add(new Product
            {
                ProductBrand = command.ProductBrand,
                ProductName = command.ProductName,
                ProductPrice = command.ProductPrice,
                ProductStatus = true,
                ProductStoct = command.ProductStoct,

            });
        
        _context.SaveChanges();
        }
    }
}
