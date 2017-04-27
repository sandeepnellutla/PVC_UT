using System.Collections.Generic;

namespace PVC_UT
{
    public static class UnitTestGlobalVars
    {
        public static PVCodeChallenge.BusinessLogic.BLFactory BLTest = new PVCodeChallenge.BusinessLogic.BLFactory();

        public readonly static Dictionary<int, string> ExpectedResultsForDiagnose14 = new Dictionary<int, string>()
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

        public readonly static Dictionary<int, string> ExpectedResultsForRegister15 = new Dictionary<int, string>()
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

    }
}
