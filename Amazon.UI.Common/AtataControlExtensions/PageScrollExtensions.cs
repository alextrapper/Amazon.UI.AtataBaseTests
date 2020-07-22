using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Atata;
using OpenQA.Selenium;

namespace Amazon.UI.Common.AtataControlExtensions
{
    public static class PageScrollExtensions
    {
        public static void ScrollIntoCenterViaJS<TOwner>(this Control<TOwner> control) 
            where TOwner: Page<TOwner>
            => ((IJavaScriptExecutor)AtataContext.Current.Driver)
                .ExecuteScript("arguments[0].scrollIntoView({block: 'center'})", control.GetScope());
    }
}
