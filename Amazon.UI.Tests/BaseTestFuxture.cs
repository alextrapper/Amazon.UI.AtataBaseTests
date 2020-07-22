using Amazon.UI.PageObjects.Pages;
using Atata;
using NUnit.Framework;

namespace Amazon.UI.Tests
{
    [TestFixture]
    public class BaseTestFuxture
    {
        protected HomePage home;

        [SetUp]
        public void SetUp()
        {
            AtataContext.Configure().ApplyJsonConfig().Build();
            home = Go.To<HomePage>();
        }

        [TearDown]
        public void TearDown() 
            => AtataContext.Current?.CleanUp();
    }
}
