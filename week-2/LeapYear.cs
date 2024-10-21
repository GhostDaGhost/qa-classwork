using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

[TestClass]
public partial class LeapTesting
{
    // Your code starts here
    [TestMethod]
    [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
    public void TestMethod1() {
        IsLeap(int.MinValue);
    }
    
    [TestMethod]
    [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
    public void TestMethod2() {
          IsLeap(int.MinValue + 1);
    }

    [TestMethod]
    public void TestMethod3() {
        Assert.AreEqual(false, IsLeap(1582));
    }
    
    [TestMethod]
    [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
    public void TestMethod4() {
        IsLeap(1581);
    }
    
    [TestMethod]
    public void TestMethod5() {
        Assert.AreEqual(false, IsLeap(1583));
    }
    
    [TestMethod]
    public void TestMethod6() {
        Assert.AreEqual(true, IsLeap(1584));
    }
    
    [TestMethod]
    public void TestMethod7() {
        Assert.AreEqual(false, IsLeap(1585));
    }
    
    [TestMethod]
    public void TestMethod8() {
        Assert.AreEqual(false, IsLeap(1599));
    }
    
    [TestMethod]
    public void TestMethod9() {
        Assert.AreEqual(true, IsLeap(1600));
    }
    
    [TestMethod]
    public void TestMethod10() {
        Assert.AreEqual(false, IsLeap(1601));
    }
    
    [TestMethod]
    public void TestMethod11() {
        Assert.AreEqual(false, IsLeap(1699));
    }
    
    [TestMethod]
    public void TestMethod12() {
        Assert.AreEqual(false, IsLeap(1700));
    }
    
    [TestMethod]
    public void TestMethod13() {
        Assert.AreEqual(false, IsLeap(1701));
    }
    
    [TestMethod]
    public void TestMethod14() {
        Assert.AreEqual(false, IsLeap(int.MaxValue - 1));
    }
    
    [TestMethod]
    public void TestMethod15() {
        Assert.AreEqual(false, IsLeap(int.MaxValue));
    }
    // Your code ends here
}
