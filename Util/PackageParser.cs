

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackagesCompare.Objects;
using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Objects;
using System.IO;

#endregion

namespace PackagesCompare.Util
{

    #region class PackageParser
    /// <summary>
    /// This class is used to parse a Packages.config file to load a list of Package objects
    /// </summary>
    public class PackageParser
    {
        
        #region Methods

            #region Parse(string path)
            /// <summary>
            /// This method returns a list of
            /// </summary>
            public static List<Package> Parse(string path)
            {
                // initial value
                List<Package> packages = null;

                // local
                bool useXml = false;
                // bool useJson = false;

                // If the path string exists
                if (TextHelper.Exists(path))
                {
                    // Get the fileInfo
                    FileInfo fileInfo = new FileInfo(path);

                    // if we are parsing a config file
                    if (fileInfo.Extension == ".config")
                    {
                        // useXml
                        useXml = true;
                    }
                    else if (fileInfo.Extension == ".json")
                    {
                        // useJson
                        // useJson = true;
                    }

                    // parse the text lines
                    List<TextLine> lines = WordParser.GetTextLines(File.ReadAllText(path));

                    // If the lines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(lines))
                    {
                        // Create a new collection of 'Package' objects.
                        packages = new List<Package>();

                        // Iterate the collection of TextLine objects
                        foreach (TextLine line in lines)
                        {
                            // if the value for useXml is true
                            if (useXml)
                            {
                                // if this line starts with Package                                
                                if ((line.Text.Trim().StartsWith("<package")) && (!TextHelper.Equals(line.Text, "<packages>")))
                                {
                                    // Create a new instance of a 'Package' object.
                                    Package package = new Package();

                                    // Parse out the name
                                    package.Name = ParseName(line.Text);

                                    // Parse out the RawVersion
                                    package.RawVersion = ParseVersion(line.Text);

                                    // Parse out the targetFramework (only for Packages.config files)
                                    package.TargetFramework = ParseTargetFramework(line.Text);

                                    // Add this package
                                    packages.Add(package);
                                }
                            }
                        }
                    }
                }
                
                // return value
                return packages;
            }
            #endregion
            
            #region ParseName(string text)
            /// <summary>
            /// This method returns the Name
            /// </summary>
            public static string ParseName(string text)
            {
                // initial value
                string name = "";

                // If the text string exists
                if (TextHelper.Exists(text))
                {
                    // get the startIndex
                    int startIndex = text.IndexOf("id=") + 4;
                    int endIndex = text.IndexOf('"', startIndex);
                    int len = endIndex - startIndex;

                    // parse out the name
                    name = text.Substring(startIndex, len);
                }
                
                // return value
                return name;
            }
            #endregion
            
            #region ParseTargetFramework(string text)
            /// <summary>
            /// This method returns the Target Framework
            /// </summary>
            public static string ParseTargetFramework(string text)
            {
                 // initial value
                string targetFramework = "";

                // If the text string exists
                if (TextHelper.Exists(text))
                {
                    // get the startIndex
                    int startIndex = text.IndexOf("targetFramework=") + 17;
                    int endIndex = text.IndexOf('"', startIndex);
                    int len = endIndex - startIndex;

                    // parse out the name
                    targetFramework = text.Substring(startIndex, len);
                }
                
                // return value
                return targetFramework;
            }
            #endregion
            
            #region ParseVersion(string text)
            /// <summary>
            /// This method returns the Version
            /// </summary>
            public static string ParseVersion(string text)
            {
                // initial value
                string version = "";

                // If the text string exists
                if (TextHelper.Exists(text))
                {
                    // get the startIndex
                    int startIndex = text.IndexOf("version=") + 9;
                    int endIndex = text.IndexOf('"', startIndex);
                    int len = endIndex - startIndex;

                    // parse out the name
                    version = text.Substring(startIndex, len);
                }
                
                // return value
                return version;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
