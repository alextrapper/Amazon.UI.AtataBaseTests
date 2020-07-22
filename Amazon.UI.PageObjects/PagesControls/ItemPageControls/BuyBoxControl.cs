using Atata;
using Amazon.UI.PageObjects.Pages;

namespace Amazon.UI.PageObjects.PagesControls.ItemPageControls
{
    public class BuyBoxControl : Control<ItemPage>
    {
        public SignInPage BuyNow()
            => BuyNowButton.ClickAndGo<SignInPage>();

        [FindById("buyNow")]        
        private Clickable<ItemPage> BuyNowButton { get; set; }
    }
}
