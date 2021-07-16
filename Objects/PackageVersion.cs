

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataJuggler.UltimateHelper;

#endregion

namespace PackagesCompare.Objects
{

    #region class PackageVersion
    /// <summary>
    /// This class is used to keep track of the four components of a Build Number
    /// 4.3.0.17 for example
    /// </summary>
    public class PackageVersion
    {
        
        #region Private Variables
        private double major;
        private double minor;
        private double build;
        private double revision;
        #endregion

        #region Methods

            #region ToString()
            /// <summary>
            /// method returns the Version String
            /// </summary>
            public override string ToString()
            {
                // Return major
                return Major + "." + Minor + "." + Build + "." + Revision;
            }
            #endregion
            
        #endregion

        #region Properties

            #region Build
            /// <summary>
            /// This property gets or sets the value for 'Build'.
            /// </summary>
            public double Build
            {
                get { return build; }
                set { build = value; }
            }
            #endregion
            
            #region Major
            /// <summary>
            /// This property gets or sets the value for 'Major'.
            /// </summary>
            public double Major
            {
                get { return major; }
                set { major = value; }
            }
            #endregion
            
            #region Minor
            /// <summary>
            /// This property gets or sets the value for 'Minor'.
            /// </summary>
            public double Minor
            {
                get { return minor; }
                set { minor = value; }
            }
            #endregion
            
            #region Revision
            /// <summary>
            /// This property gets or sets the value for 'Revision'.
            /// </summary>
            public double Revision
            {
                get { return revision; }
                set { revision = value; }
            }
            #endregion

            #region Calculation
            /// <summary>
            /// This read only property returns a calculated value
            /// </summary>
            public double Calculation
            {
                get
                {
                    // initial value
                    double temp = (Major * 1000000) + (Minor + 1000) + Build;
                    string temp2 = temp + "." + Revision.ToString();

                    // Set the return value
                    double calculation = NumericHelper.ParseDouble(temp2, 0, -1);

                    // return value
                    return calculation;
                }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
