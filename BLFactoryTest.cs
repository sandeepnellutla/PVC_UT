using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;


namespace PVC_UT
{
    [TestClass]
    public class BLFactoryTest
    {
        /// <summary>
        /// Unit Test For Register
        /// Create Manual Dictory for 15 values.
        /// Among them as per the test: 3,6,12 should say 'Register'
        /// Among them as per the test:5,10 should say 'Patient'
        /// Finally 15 should say 'Register'&'Patient'
        /// </summary>
        [TestMethod]
        public void ShouldReturnValues10ForRegister()
        {
            PVCodeChallenge.BusinessLogic.BLFactory bltest = new PVCodeChallenge.BusinessLogic.BLFactory();
            Dictionary<int, string> MatchResults = new Dictionary<int, string>()
            {
                {1,"1" },
                {2,"2" },
                {3,"'Register'" },
                {4,"4" },
                {5,"'Patient'" },
                {6,"'Register'" },
                {7,"7" },
                {8,"8" },
                {9,"'Register'" },
                {10,"'Patient'" },
                {11,"11" },
                {12,"'Register'" },
                {13,"13" },
                {14,"14" },
                {15,"'Register'&'Patient'" }
            };

            Dictionary<int, string> OutputResults = bltest.GetNumbersForRegister(1, 15);

            int mismatches = OutputResults.Where(entry => MatchResults[entry.Key] != entry.Value)
                        .ToDictionary(entry => entry.Key, entry => entry.Value).Count();

            Assert.AreEqual(mismatches, 0);
        }

        /// <summary>
        /// Unit Test For Diagnose
        /// Create Manual Dictory for 14 values.
        /// Among them as per the test: 2,4,6,8,10,12 should say 'Diagnose'
        /// Among them as per the test:7 should say 'Patient'
        /// Finally 14 should say 'Diagnose'&'Patient'
        /// </summary>
        [TestMethod]
        public void ShouldReturnValues10ForDiagnose()
        {
            PVCodeChallenge.BusinessLogic.BLFactory bltest = new PVCodeChallenge.BusinessLogic.BLFactory();
            Dictionary<int, string> MatchResults = new Dictionary<int, string>()
            {
                {1,"1" },
                {2,"'Diagnose'" },
                {3,"3" },
                {4,"'Diagnose'" },
                {5,"5" },
                {6,"'Diagnose'" },
                {7,"'Patient'" },
                {8,"'Diagnose'" },
                {9,"9" },
                {10,"'Diagnose'" },
                {11,"11" },
                {12,"'Diagnose'" },
                {13,"13" },
                {14,"'Diagnose'&'Patient'" }
            };

            Dictionary<int, string> OutputResults = bltest.GetNumbersForDiagnose(1, 14);

            int mismatches = OutputResults.Where(entry => MatchResults[entry.Key] != entry.Value)
                        .ToDictionary(entry => entry.Key, entry => entry.Value).Count();

            // Check for any mismatches
            Assert.AreEqual(mismatches, 0);
        }

    }
}
