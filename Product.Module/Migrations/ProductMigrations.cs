using OrchardCore.Data.Migration;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;

namespace Product.Module.Migrations
{
    public class ProductMigrations : DataMigration
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public ProductMigrations(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public async Task<int> CreateAsync()
        {
            await _contentDefinitionManager.AlterPartDefinitionAsync("ProductPart", part => part
                .WithField("Price", f => f.OfType("TextField"))
                .WithField("Image", f => f.OfType("TextField"))
                .WithField("Description", f => f.OfType("TextField"))
            );

            await _contentDefinitionManager.AlterTypeDefinitionAsync("Product", type => type
                .WithPart("TitlePart")
                //.WithPart("AutoroutePart", part => part
                //    .WithSetting("AutorouteSettings.Pattern", "{{ ContentItem | display_text | slugify }}")
                //    .WithSetting("AutorouteSettings.AllowCustomPath", "true"))
                .WithPart("ProductPart")
                .Creatable()
                .Listable()
                .Draftable()
            );

            return 1;
        }
    }


}