using Atata;
using Amazon.UI.PageObjects.PagesControls.BasePageControls;

namespace Amazon.UI.PageObjects.Pages
{
    [WaitForDocumentReadyState(on: TriggerEvents.Init | TriggerEvents.BeforeAnyAction, AppliesTo = TriggerScope.Children)]
    [WaitUntilEnabled]
    public abstract class BasePage<TOwner> : Page<TOwner>
        where TOwner : Page<TOwner>
    {
        public SearchBlock<TOwner> Search { get; set; }
    }
}
