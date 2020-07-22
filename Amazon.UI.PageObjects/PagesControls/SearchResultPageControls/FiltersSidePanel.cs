using Atata;
using Amazon.UI.PageObjects.Pages;

namespace Amazon.UI.PageObjects.PagesControls.SearchResultPageControls
{
    public class FiltersSidePanel : Control<SearchResultsPage>
    {
        public DepartmentGroup<SearchResultsPage> DepartmentsSection { get; set; }
        
        [FindById("p_n_feature_keywords_six_browse-bin-title")]
        public CustomersReviewsSayGroup<SearchResultsPage> CustomersReviewsSay { get; private set; }

        public PortableBluetoothSpeakerFeaturesGroup<SearchResultsPage> PortableBluetoothSpeakerFeatures { get; private set; }
    }
}
