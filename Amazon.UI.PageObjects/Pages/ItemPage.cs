using Atata;
using Amazon.UI.PageObjects.PagesControls.ItemPageControls;

namespace Amazon.UI.PageObjects.Pages
{
    [VerifyTitle(TermMatch.StartsWith, "Amazon.com")]
    public class ItemPage : BasePage<ItemPage>
    {
        public ItemColorSelector ProductColor { get; private set; }

        public BuyBoxControl BuyBox { get; private set; }
    }
}
