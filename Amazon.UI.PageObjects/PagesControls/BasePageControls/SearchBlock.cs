using Atata;

namespace Amazon.UI.PageObjects.PagesControls.BasePageControls
{
    public class SearchBlock<TOwner> : Control<TOwner>
        where TOwner : Page<TOwner>
    {
        public TOwner PerformSearch(string searchRequest)
        {
            SearchInput.Set(searchRequest);
            return Submit.Click();
        }

        public TOwner AddSentenceToSearch(string sentence)
        {
            var existingSearchString = SearchInput.Value;
            return PerformSearch($"{existingSearchString} {sentence}");
        }

        [FindById("twotabsearchtextbox")]
        private TextInput<TOwner> SearchInput { get; set; }

        [FindByCss("#nav-search-submit-text+input")]
        [WaitForDocumentReadyState(TriggerEvents.AfterClick)]
        private Clickable<TOwner> Submit { get; set; }
    }
}
