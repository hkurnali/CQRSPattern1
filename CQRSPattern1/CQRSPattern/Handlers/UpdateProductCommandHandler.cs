using CQRSPattern1.CQRSPattern.Commands;
using CQRSPattern1.DAL;

namespace CQRSPattern1.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    { private readonly  Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.ProductName = command.ProductName;
            values.ProductBrand = command.ProductBrand;
            values.ProductStatus = command.ProductStatus;
            values.ProductPrice= command.ProductPrice;
            values.ProductStoct = command.ProductStoct;


            _context.SaveChanges();
        }
    }
}
