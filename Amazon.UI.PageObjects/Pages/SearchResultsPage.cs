using Amazon.UI.PageObjects.PagesControls.SearchResultPageControls;

namespace Amazon.UI.PageObjects.Pages
{
    public class SearchResultsPage : BasePage<SearchResultsPage>
    {
        public FiltersSidePanel Filters { get; private set; }

        public SearchResultsList SearchResultsList { get; private set; }
    }
}
