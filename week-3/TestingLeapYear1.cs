using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public partial class LeapYearTestClass
{
    private static IWebDriver driver = new ChromeDriver();
    [TestMethod]
    public void TestLeapYear()
    {
	// Your code starts here
        driver.Navigate().GoToUrl("https://www.onlineconversion.com/leapyear.htm");
        driver.FindElement(By.Name("year")).Click();
        driver.FindElement(By.Name("year")).Clear();
        driver.FindElement(By.Name("year")).SendKeys("1582");
        driver.FindElement(By.XPath("//input[@value='Check Year']")).Click();
        Assert.AreEqual("not a leap year.", driver.FindElement(By.Name("result")).GetAttribute("value"));
	// Your code ends here
    }
}
