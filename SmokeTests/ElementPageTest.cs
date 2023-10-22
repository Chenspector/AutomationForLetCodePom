using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationForLetCodePom;

namespace SmokeTests
{
   
    [TestClass]
    public class ElementPageTest:TestFather
    {
        [TestMethod]
        public void Can_Enter_Elements_Page()
        {
            ElementsPage.GoTo();
            Assert.IsTrue(ElementsPage.IsAt);
        }
        [TestMethod]
        public void Can_Search_For_Github_User()
        {
            string userName = "tomsmith";
            bool elementExists = false;
            ElementsPage.GoTo();
            ElementsPage.CanSearchForGithubUser(ref userName, ref elementExists);
            Assert.IsTrue(elementExists == true, "Could not search for github user");
        }
        [TestMethod]
        public void Can_List_All_User_Repos()
        {
            string userName = "tomsmith";
            bool elementExists = false;
            List<string> list = new List<string>();
            ElementsPage.GoTo();
            ElementsPage.CanSearchForGithubUser(ref userName, ref elementExists);
            ElementsPage.CanListAllUserRepos(ref list);
            Assert.IsTrue(list.Count > 0, "Could not list user repos");
        }
    }
}
