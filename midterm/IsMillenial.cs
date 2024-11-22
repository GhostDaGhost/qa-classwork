using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

[TestClass]
public partial class MidtermP1
{
    // MOCK FUNCTION FOR TESTING
    public bool IsMillenial(int year) {
        if (year < 1583 || year > DateTime.Now.Year)
            throw new ArgumentOutOfRangeException(nameof(year), "Year must be a valid Gregorian Calendar year.");

        return year >= 1981 && year <= 1996;
    }

    // Your code starts here
    [TestMethod]
    [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
    public void TestMethod1() {
        IsMillenial(int.MinValue);
    }
    
    [TestMethod]
    [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
    public void TestMethod2() {
        IsMillenial(int.MinValue + 1);
    }
    
    [TestMethod]
    public void TestMethod3() {
        Assert.AreEqual(false, IsMillenial(int.MaxValue));
    }
    
    [TestMethod]
    public void TestMethod4() {
        Assert.AreEqual(false, IsMillenial(1980));
    }

    [TestMethod]
    public void TestMethod5() {
        Assert.AreEqual(true, IsMillenial(1981));
    }

    [TestMethod]
    public void TestMethod6() {
        Assert.AreEqual(true, IsMillenial(1982));
    }
 
    [TestMethod]
    public void TestMethod7() {
        Assert.AreEqual(true, IsMillenial(1983));
    }

    [TestMethod]
    public void TestMethod8() {
        Assert.AreEqual(true, IsMillenial(1996));
    }

    [TestMethod]
    public void TestMethod9() {
        Assert.AreEqual(false, IsMillenial(1997));
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
    public void TestMethod10() {
        IsMillenial(1581);
    }

    [TestMethod]
    public void TestMethod11() {
        Assert.AreEqual(false, IsMillenial(1582));
    }

    [TestMethod]
    public void TestMethod12() {
        Assert.AreEqual(false, IsMillenial(1583));
    }

    [TestMethod]
    public void TestMethod13() {
        Assert.AreEqual(false, IsMillenial(int.MaxValue - 1));
    }
    // Your code ends here

}