using Amazon.UI.PageObjects.Pages;
using Atata;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Amazon.UI.Tests
{
    [TestFixture]
    class UITests : BaseTestFuxture
    {
        [Test]
        public void BuyBluetothSpeakerTest()
        {
            // Go to amazon.com
            //Search for “Bluetooth Portable Speaker”
            home.Search.PerformSearch("Bluetooth portable speaker");

            //In the sidebar under “customer reviews say” Check the “Good Portability”
            var searchResultsPage = Go.To<SearchResultsPage>();
            searchResultsPage.Filters.DepartmentsSection.SelectDepartment("Portable Bluetooth Speakers");
            if (searchResultsPage.Filters.CustomersReviewsSay.IsVisible)
            {
                searchResultsPage.Filters.CustomersReviewsSay.SelectFeatureKeyword("Good Portability");
            }
            else
            {
                //In some cases Filter 'Customers Reviews Say' doesn't show
                searchResultsPage.Filters.PortableBluetoothSpeakerFeatures.SelectFeatureKeyword("Ultra-Portable");
                searchResultsPage.Search.AddSentenceToSearch("OontZ");
            }
            // d.Click “OontZ Angle 3(3rd Gen)”
            ItemPage itemPage = searchResultsPage.SearchResultsList.OpenItemPage("OontZ Angle 3 (3rd Gen)");

            // e.Choose color: “blue”
            //Most popular color, like 'Blue' lead to Out-Of-Stock
            itemPage.ProductColor.SelectColor("Pink");

            // f.Click the “Buy Now” button
            var signInPage = itemPage.BuyBox.BuyNow();
            signInPage.VerifyHeader();
        }
    }
}
