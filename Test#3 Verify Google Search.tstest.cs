using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.TelerikUI.Blazor;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace TestProject1
{

    public class Test_3_Verify_Google_Search : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Enter text 'keyword' in 'QText'")]
        public void Test3_Verify_Google_Search_CodedStep()
        {
            // Enter text 'keyword' in 'QText'
            Actions.SetText(Pages.Google.QText, "keyword");
            
        }
            
        [CodedStep(@"click Search")]
        public void clickSearch()
        {
            // Click submit
            Log.WriteLine("Clicking Submit button >>>>");
            Element submit=ActiveBrowser.Find.ByName("btnK");
            ActiveBrowser.Actions.Click(submit);
            
        }
    
        [CodedStep(@"'Maximize' the browser.")]
        public void Test3_Verify_Google_Search_CodedStep1()
        {
            // 'Maximize' the browser.
            ActiveBrowser.Window.Maximize();
            
        }
    }
}
