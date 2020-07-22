using Atata;

namespace Amazon.UI.PageObjects.PagesControls.SearchResultPageControls
{
    public class PortableBluetoothSpeakerFeaturesGroup<TOwner> : Control<TOwner>
        where TOwner : Page<TOwner>
    {
        public TOwner SelectFeatureKeyword(string keyword)
        {
            var itemToCheck = KeywordsList.Items[item => item.Keyword.Content.Value.Contains(keyword)];
            return itemToCheck.CheckBox.Check();
        }

        [FindByCss("#p_n_feature_keywords_six_browse-bin-title+ul")]
        private UnorderedList<FeatureListItem<TOwner>, TOwner> KeywordsList { get; set; }

        class FeatureListItem<TOwner> : ListItem<TOwner>
            where TOwner : Page<TOwner>
        {
            internal CheckBox<TOwner> CheckBox { get; set;}
            internal Text<TOwner> Keyword { get; set; }
        }
    }
}
