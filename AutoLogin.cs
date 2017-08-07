using System;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace BelarcAutoLogin
{
    class Login: System.Web.SessionState.IRequiresSessionState
    {
        static void Main(string[] args)
        {
         Restart:
            //I had to define the strings because if I put string XXX = Console.Readline it would require another entry to move forward
            //Not for sure why that is, but this seems to fix that issue
            string XXX;
            string XXXX;
            //This is the only way to get IE to work with a GPO change
            //Since this is a single (and rather simple) site, this doesn't cause problems.
            //But this may break things for you, so be leary
            var options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            Console.WriteLine("User Input");
            string value = Console.ReadLine();
            double inputAsANumber;
            if (double.TryParse(value, out inputAsANumber))
                
            switch (value)
                {
                    
                    case "1":
                        Console.WriteLine("What is the [User Input]:");
                        pcn = Console.ReadLine();
                        
                        IWebDriver browser = new InternetExplorerDriver(options);
                        browser.Url = "http://somesite.com/foo/bar";
                        browser.FindElement(By.Name("userName")).SendKeys("username");
                        browser.FindElement(By.Name("password")).SendKeys("password");
                        browser.FindElement(By.Name("Login")).Submit();
                        browser.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(500));
                        //Commenting out things I had to do to move the site to another page. 
                        //You probably won't have this issue
                        //browser.SwitchTo().Frame("leftFrame");
                        //browser.FindElement(By.XPath("/html / body / div / div / div[13] / div[2] / div[1] / span / a")).GetAttribute("href");
                        //browser.Url = browser.FindElement(By.XPath("/html / body / div / div / div[13] / div[2] / div[1] / span / a")).GetAttribute("href");
                        browser.FindElement(By.Name("DisplayedPCName")).SendKeys(XXX);
                        browser.FindElement(By.ClassName("bodytxtsmall")).SendKeys(OpenQA.Selenium.Keys.Enter);
                        break;
                    case "2":
                        Console.WriteLine("What is the username?:");
                        usrnam = (Console.ReadLine());
                        IWebDriver browser2 = new InternetExplorerDriver(options);
                        browser2.Url = "http://somesite.com/foo/bar";
                        browser2.FindElement(By.Name("userName")).SendKeys("username");
                        browser2.FindElement(By.Name("password")).SendKeys("password");
                        browser2.FindElement(By.Name("Login")).Submit();
                        browser2.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(500));
                        //Commenting out things I had to do to move the site to another page. 
                        //You probably won't have this issue
                        //For some reason IE doesn't play nice with Selenium and other frames. Works great without this mess in Chrome
                        //And I imagine in Firefox
                        //browser2.SwitchTo().Frame("leftFrame");
                        //Same here with having to use an XPath. The name is defined and not used elsewhere, but this required an XPath
                        //browser2.FindElement(By.XPath("/html / body / div / div / div[13] / div[2] / div[2 ]/ span / a")).GetAttribute("href");
                        //browser2.Url = browser2.FindElement(By.XPath("/html / body/ div / div / div[13] / div[2] / div[2] / span / a")).GetAttribute("href");
                        browser2.FindElement(By.Name("DisplayedUser")).SendKeys(XXXX);
                        browser2.FindElement(By.ClassName("bodytxtsmall")).SendKeys(OpenQA.Selenium.Keys.Enter);
                        break;
                    default:
                        Console.WriteLine("Please enter 1 or 2.");
                        goto Restart;
                    
                }
                else
                {
                Console.WriteLine("Please select 1 or 2.");
                }
            Console.ReadLine();
   






        }
    }
}
