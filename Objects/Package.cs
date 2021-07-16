

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Objects;

#endregion

namespace PackagesCompare.Objects
{

    #region class Package
    /// <summary>
    /// This class is used to keep track of a package, and its PackageVersion
    /// </summary>
    public class Package
    {
        
        #region Private Variables
        private string name;
        private PackageVersion version;
        private string rawVersion;
        private string targetFramework;
        private bool foundInLatest;
        #endregion

        #region Methods

            #region ToString()
            /// <summary>
            /// method returns the String
            /// </summary>
            public override string ToString()
            {
                // return value
                return this.Name;
            }
            #endregion
            
        #endregion

        #region Properties

        #region FoundInLatest
        /// <summary>
        /// This property gets or sets the value for 'FoundInLatest'.
        /// </summary>
        public bool FoundInLatest
            {
                get { return foundInLatest; }
                set { foundInLatest = value; }
            }
            #endregion
            
            #region HasName
            /// <summary>
            /// This property returns true if the 'Name' exists.
            /// </summary>
            public bool HasName
            {
                get
                {
                    // initial value
                    bool hasName = (!String.IsNullOrEmpty(this.Name));
                    
                    // return value
                    return hasName;
                }
            }
            #endregion
            
            #region HasVersion
            /// <summary>
            /// This property returns true if this object has a 'Version'.
            /// </summary>
            public bool HasVersion
            {
                get
                {
                    // initial value
                    bool hasVersion = (this.Version != null);
                    
                    // return value
                    return hasVersion;
                }
            }
            #endregion
            
            #region IsValid
            /// <summary>
            /// This read only property returns the value for 'IsValid'.
            /// </summary>
            public bool IsValid
            {
                get
                {
                    // return true if both exist
                    return (this.HasVersion && this.HasName);
                }
            }
            #endregion
            
            #region Name
            /// <summary>
            /// This property gets or sets the value for 'Name'.
            /// </summary>
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            #endregion
            
            #region RawVersion
            /// <summary>
            /// This property gets or sets the value for 'RawVersion'.
            /// </summary>
            public string RawVersion
            {
                get { return rawVersion; }
                set 
                { 
                    // this method is used the Package parser to set this from Xml
                    rawVersion = value;

                    // create a delimiter to use
                    char[] delimiter = new char[] { '.' };

                    // If the rawVersion string exists
                    if (TextHelper.Exists(rawVersion))
                    {
                        // Parse the words
                        List<Word> words = WordParser.GetWords(rawVersion, delimiter);

                        // If the words collection exists and has one or more items
                        if (ListHelper.HasXOrMoreItems(words, 3))
                        {
                            // Create the package version
                            this.Version = new PackageVersion();
                            this.Version.Major = NumericHelper.ParseInteger(words[0].Text, 0, 0);
                            this.Version.Minor = NumericHelper.ParseInteger(words[1].Text, 0, 0);
                            this.Version.Build  = NumericHelper.ParseInteger(words[2].Text, 0, 0);
                        }
                    }
                }
            }
            #endregion
            
            #region TargetFramework
            /// <summary>
            /// This property gets or sets the value for 'TargetFramework'.
            /// </summary>
            public string TargetFramework
            {
                get { return targetFramework; }
                set { targetFramework = value; }
            }
            #endregion
            
            #region Version
            /// <summary>
            /// This property gets or sets the value for 'Version'.
            /// </summary>
            public PackageVersion Version
            {
                get { return version; }
                set { version = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
