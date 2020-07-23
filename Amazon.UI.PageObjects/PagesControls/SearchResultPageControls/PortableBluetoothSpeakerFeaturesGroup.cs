using Amazon.UI.Common.AtataControlExtensions;
using Atata;
using OpenQA.Selenium;

namespace Amazon.UI.PageObjects.PagesControls.SearchResultPageControls
{    
    public class PortableBluetoothSpeakerFeaturesGroup<TOwner> : Control<TOwner>
        where TOwner : Page<TOwner>
    {
        public TOwner SelectFeatureKeyword(string keyword)
        {
            var itemToCheck = KeywordsList.Items[item => item.Value.Contains(keyword)];
            itemToCheck.ScrollIntoCenterViaJS();
            ((IJavaScriptExecutor)AtataContext.Current.Driver)
                .ExecuteScript($"document.querySelector('[aria-label=\"{keyword}\"] span span').click()");
            return Owner;
        }

        [FindByCss("#p_n_feature_eleven_browse-bin-title+ul")]
        private UnorderedList<Text<TOwner>, TOwner> KeywordsList { get; set; }
    }
}
