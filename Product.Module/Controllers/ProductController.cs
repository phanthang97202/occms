using Microsoft.AspNetCore.Mvc;
using OrchardCore.ContentManagement;
using YesSql;
using OrchardCore.ContentManagement.Records;
using Product.Module.RQ_Model; // <- cần cái này cho ContentItemIndex

public class ProductController : Controller
{
    private readonly ISession _session;
    private readonly IContentManager _contentManager;

    public ProductController(ISession session, IContentManager contentManager)
    {
        _session = session;
        _contentManager = contentManager;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _session
            .Query<ContentItem, ContentItemIndex>() // <- lọc theo chỉ mục
            .Where(x => x.ContentType == "Product" && x.Published) // lọc theo tên ContentType
            .ListAsync();

        return View(products);
    }

    public IActionResult Create()
    { 

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductCreateModel model)
    {
        var product = await _contentManager.NewAsync("Product");

        product.DisplayText = model.Title;
        //product.Alter<TitlePart>(x => x.Title = model.Title);
        product.Alter<ContentPart>(x =>
        { 
            x.ContentItem.Content.ProductPart.Price.Text = model.Price;
            x.ContentItem.Content.ProductPart.Image.Text = model.Image;
            x.ContentItem.Content.ProductPart.Description.Text = model.Description;
        });

        await _contentManager.CreateAsync(product, VersionOptions.Published);

        return RedirectToAction("Index");
    }
}
