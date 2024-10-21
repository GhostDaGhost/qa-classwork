using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public partial class CreditScore
{
    enum ScoreType
    {
        FICO,
        Vantage
    }
    string QualifyScore(ScoreType type, int actualScore)
    {
        //Your code starts here
        if (type == ScoreType.FICO) {
            if (actualScore >= 851 || actualScore < 300) {
                throw new ArgumentOutOfRangeException();
            } else if (actualScore >= 800) {
                return "Exceptional";
            } else if (actualScore >= 740) {
                return "Very Good";
            } else if (actualScore >= 670) {
                return "Good";
            } else if (actualScore >= 580) {
                return "Fair";
            } else {
                return "Poor";
            }
        } else if (type == ScoreType.Vantage) {
            if (actualScore >= 851 || actualScore < 300) {
                throw new ArgumentOutOfRangeException();
            } else if (actualScore >= 781) {
                return "Excellent";
            } else if (actualScore >= 661) {
                return "Good";
            } else if (actualScore >= 601) {
                return "Fair";
            } else if (actualScore >= 500) {
                return "Poor";
            } else {
                return "Very Poor";
            }
        }

        throw new ArgumentException("Invalid score type.");
        //Your code ends here
    }
}
