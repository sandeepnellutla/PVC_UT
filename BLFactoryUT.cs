using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PVC_UT
{
    /// <summary>
    /// Unit Class that calls in GlobalVars.cs static class for variables
    /// </summary>
    [TestClass]
    public class BLFactoryUT
    {
        /// <summary>
        /// Unit Test Class checking for individual Values for Register Event
        /// </summary>
        [TestMethod]
        public void CheckForRegisterEvent()
        {
            Dictionary<int, string> OutputResults = UnitTestGlobalVars.BLTest.GetNumbersForRegister(1, 15);

            Assert.AreEqual(OutputResults[3].ToString(), "'Register'");
            Assert.AreEqual(OutputResults[5].ToString(), "'Patient'");
            Assert.AreEqual(OutputResults[6].ToString(), "'Register'");
            Assert.AreEqual(OutputResults[10].ToString(), "'Patient'");
            Assert.AreEqual(OutputResults[12].ToString(), "'Register'");
            Assert.AreEqual(OutputResults[13].ToString(), "13");
            Assert.AreEqual(OutputResults[15].ToString(), "'Register'&'Patient'");
        }

        /// <summary>
        /// Unit Test Class checking for individual Values for Diagnose Event
        /// </summary>
        [TestMethod]
        public void CheckForDiagnoseEvent()
        {
            Dictionary<int, string> OutputResults = UnitTestGlobalVars.BLTest.GetNumbersForDiagnose(1, 30);

            Assert.AreEqual(OutputResults[2].ToString(), "'Diagnose'");
            Assert.AreEqual(OutputResults[7].ToString(), "'Patient'");
            Assert.AreEqual(OutputResults[6].ToString(), "'Diagnose'");
            Assert.AreEqual(OutputResults[10].ToString(), "'Diagnose'");
            Assert.AreEqual(OutputResults[12].ToString(), "'Diagnose'");
            Assert.AreEqual(OutputResults[13].ToString(), "13");
            Assert.AreEqual(OutputResults[14].ToString(), "'Diagnose'&'Patient'");
            Assert.AreEqual(OutputResults[28].ToString(), "'Diagnose'&'Patient'");
        }

    }
}
