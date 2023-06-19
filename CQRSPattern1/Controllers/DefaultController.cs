using CQRSPattern1.CQRSPattern.Commands;
using CQRSPattern1.CQRSPattern.Handlers;
using CQRSPattern1.CQRSPattern.Queries;
using CQRSPattern1.CQRSPattern.Results;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPattern1.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly GetProductByIDQueryHandler _getProductByIDQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductUpdateByIDQueryHandler _getProductUpdateByIDQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, GetProductByIDQueryHandler getProductByIDQueryHandler, CreateProductCommandHandler createProductCommandHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductUpdateByIDQueryHandler getProductUpdateByIDQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _getProductByIDQueryHandler = getProductByIDQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getProductUpdateByIDQueryHandler = getProductUpdateByIDQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }


        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        public IActionResult GetProduct(int id) 
        
        {

            var values = _getProductByIDQueryHandler.Handle(new GetProductByIDQuery(id));
        return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handler(command);
            return RedirectToAction("Index");
        }
        
        public IActionResult DeleteProduct(int id)
        {

            _removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {


            var values=_getProductUpdateByIDQueryHandler.Handler(new GetProductUpdateByIDQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {


            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
