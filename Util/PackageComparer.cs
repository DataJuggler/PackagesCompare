

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackagesCompare.Enumerations;
using PackagesCompare.Objects;
using DataJuggler.UltimateHelper;

#endregion

namespace PackagesCompare.Util
{

    #region class PackageComparer
    /// <summary>
    /// This class is used to compare two Package versions.
    /// </summary>
    public class PackageComparer
    {
        
        #region Methods

            #region Compare(Compare(Package source, Package target)
            /// <summary>
            /// This method returns the result of comparing two package versions
            /// </summary>
            public static ComparisonResultEnum Compare(Package source, Package target)
            {
                // initial value
                ComparisonResultEnum comparison = ComparisonResultEnum.TargetAndSourceAreNull;

                // if both objects exist
                if (NullHelper.Exists(source, target))
                {
                    // if both packages are valid
                    if (source.IsValid && target.IsValid)
                    {
                        // if the source and target names match                    
                        if (TextHelper.IsEqual(source.Name, target.Name))
                        {
                            // now we can compare Version numbers
                            
                            // if the Version's match, than we don't have to go further
                            if (TextHelper.IsEqual(source.Version.ToString(), target.Version.ToString()))
                            {
                                // Set the result
                                comparison = ComparisonResultEnum.SameVersion;
                            }
                            else if (source.Version.Calculation < target.Version.Calculation)
                            {
                                // Set the result
                                comparison = ComparisonResultEnum.SourceIsOlder;
                            }
                            else if (source.Version.Calculation > target.Version.Calculation)
                            {
                                // Set the result
                                comparison = ComparisonResultEnum.SourceIsNewer;
                            }
                        }
                        else
                        {
                            // not the same package
                            comparison = ComparisonResultEnum.DifferentPackageNames;
                        }
                    }
                    else if (source.IsValid)
                    {
                        // The Target is not valid
                        comparison = ComparisonResultEnum.TargetIsNotValid;
                    }
                    else if (target.IsValid)
                    {
                        // The Source is not valid
                        comparison = ComparisonResultEnum.SourceIsNotValid;
                    }
                    else
                    {
                        // Both are not violence
                        comparison = ComparisonResultEnum.TargetAndSourceAreNotValid;
                    }
                }
                else if (NullHelper.Exists(source))
                {
                    // The Target Exists, but the Source doesn't
                    comparison = ComparisonResultEnum.TargetIsNull;
                }
                else if (NullHelper.Exists(target))
                {
                    // The Target Exists, but the Source doesn't
                    comparison = ComparisonResultEnum.SourceIsNull;
                }

                // return value
                return comparison;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
