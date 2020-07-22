using Amazon.UI.Common.AtataControlExtensions;
using Amazon.UI.PageObjects.Pages;
using Atata;
using System.Linq;

namespace Amazon.UI.PageObjects.PagesControls.SearchResultPageControls
{
    public class SearchResultsList : Control<SearchResultsPage>
    {
        public ItemPage OpenItemPage(string itemTitle)
        {
            var itemToOpen = ResultsList.Items.FirstOrDefault(item => item.ItemTitle.Content.Value.Contains(itemTitle));
            itemToOpen?.ScrollIntoCenterViaJS();
            return itemToOpen?.ItemTitle.ClickAndGo<ItemPage>();
        }

        private ItemsControl<SearchResultListItem, SearchResultsPage> ResultsList { get; set; }

        [ControlDefinition("div[@data-component-type='s-search-result']")]
        private class SearchResultListItem : Control<SearchResultsPage>
        { 
            [FindByCss("h2")]
            internal Link<SearchResultsPage> ItemTitle { get; set; }
        }
    }
}
