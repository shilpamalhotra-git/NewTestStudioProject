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

    public class Test_1_Verify_Form_Submission__1_ : BaseWebAiiTest
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
    
        [CodedStep(@"Navigate to : 'http://demoqa.com/'")]
        public void navigateToSite()
        {
            // Navigate to : 'http://demoqa.com/'
            ActiveBrowser.NavigateTo("http://demoqa.com/");
            Sleeper.sleep(1000);
        }
    
        [CodedStep(@"Click 'PathTag'")]
        public void clickPathTag()
        {
            // Click 'PathTag'
            //Pages.ToolsQA.PathTag.Click(true);
            Element formTag=ActiveBrowser.Find.ByXPath("//h5[contains(text(),'Forms')]");
            ActiveBrowser.Actions.Click(formTag);            
        }
    
        [CodedStep(@"Click 'PracticeFormSpan'")]
        public void clickFormButton()
        {
            // Click 'PracticeFormSpan'
            Pages.ToolsQA0.PracticeFormSpan.Click(true);
            
        }
    
        [CodedStep(@"Enter text 'Shilpa' in 'FirstNameText' - DataDriven: [$(firstname)]")]
        public void enterFirstName()
        {
            // Enter text 'Shilpa' in 'FirstNameText'
            Actions.SetText(Pages.ToolsQA1.FirstNameText, ((string)(System.Convert.ChangeType(Data["firstname"], typeof(string)))));
            
        }
    
        [CodedStep(@"Keyboard (KeyPress) - Tab (1 times) on 'LastNameText'")]
        public void moveToLastName()
        {
            ActiveBrowser.ContentWindow.SetFocus();
            Pages.ToolsQA1.LastNameText.ScrollToVisible();
            Pages.ToolsQA1.LastNameText.Focus();
            ActiveBrowser.Manager.Desktop.KeyBoard.KeyPress(ArtOfTest.WebAii.Win32.KeyBoard.KeysFromString("Tab"), 150, 1);
            ActiveBrowser.WaitUntilReady();
            
        }
    
        [CodedStep(@"Enter text 'Malhotra' in 'LastNameText' - DataDriven: [$(lastname)]")]
        public void enterLastName()
        {
            // Enter text 'Malhotra' in 'LastNameText'
            Actions.SetText(Pages.ToolsQA1.LastNameText, ((string)(System.Convert.ChangeType(Data["lastname"], typeof(string)))));
            
        }
    
        [CodedStep(@"Enter text 'shilpa@gmail.com' in 'UserEmailText' - DataDriven: [$(email)]")]
        public void enterEmail()
        {
            // Enter text 'shilpa@gmail.com' in 'UserEmailText'
            Actions.SetText(Pages.ToolsQA1.UserEmailText, ((string)(System.Convert.ChangeType(Data["email"], typeof(string)))));
            
        }
    
        [CodedStep(@"Click 'FemaleLabelTag'")]
        public void selectLabel()
        {
            // Click 'FemaleLabelTag'
            Pages.ToolsQA1.FemaleLabelTag.Click(true);
            
        }
    
        [CodedStep(@"Enter text '9087654321' in 'UserNumberText'")]
        public void enterPhone()
        {
            // Enter text '9087654321' in 'UserNumberText'
            Actions.SetText(Pages.ToolsQA1.UserNumberText, "9087654321");
            
        }
    
        [CodedStep(@"Click 'SubmitButtonTag'")]
        public void clickSubmit()
        {
            // Click 'SubmitButtonTag'
            Pages.ToolsQA1.SubmitButtonTag.Click(true);
            
        }
    
        [CodedStep(@"Verify element 'ExampleModalSizesTitleLgDiv' 'is' visible.")]
        public void verifyThanksLabel()
        {
            // Verify element 'ExampleModalSizesTitleLgDiv' 'is' visible.
            Pages.ToolsQA1.ExampleModalSizesTitleLgDiv.Wait.ForExists(30000);
            Assert.AreEqual(true, Pages.ToolsQA1.ExampleModalSizesTitleLgDiv.IsVisible());
            
        }
    
        [CodedStep(@"Click 'CloseLargeModalButtonTag'")]
        public void closeModal()
        {
            // Click 'CloseLargeModalButtonTag'
            Pages.ToolsQA1.CloseLargeModalButtonTag.Click(true);            
        }
    }
}
