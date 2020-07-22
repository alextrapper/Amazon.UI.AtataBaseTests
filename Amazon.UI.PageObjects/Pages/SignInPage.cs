using Atata;

namespace Amazon.UI.PageObjects.Pages
{
    [VerifyTitle("Amazon Sign-In")]
    public class SignInPage : Page<SignInPage>
    {
        public SignInPage VerifyHeader()
        {
            Header.ExpectTo.BeVisible();
            return Header.Content.ExpectTo.BeEquivalent("Sign-In");
        }

        private H1<SignInPage> Header { get; set; }
    }
}
