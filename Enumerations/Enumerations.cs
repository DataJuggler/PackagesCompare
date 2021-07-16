using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackagesCompare.Enumerations
{

    #region enum ComparisonResultEnum
    /// <summary>
    /// This enumeration is used to compare two versions of the same class
    /// </summary>
    public enum ComparisonResultEnum
    {
        TargetAndSourceAreNull = -103,
        SourceIsNull = -102,
        TargetIsNull = -101,
        TargetAndSourceAreNotValid = -52,
        TargetIsNotValid = -51,
        SourceIsNotValid = -50,
        DifferentPackageNames = -100,
        SourceIsNewer = -1,
        SameVersion = 0,
        SourceIsOlder = 1
    }
    #endregion

}
