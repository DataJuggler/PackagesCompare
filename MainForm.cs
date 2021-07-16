

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PackagesCompare.Objects;
using PackagesCompare.Util;
using DataJuggler.UltimateHelper;

#endregion

namespace PackagesCompare
{

    #region class MainForm
    /// <summary>
    /// This is the MainForm for this app
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion
        
        #region Events
            
            #region CompareButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'CompareButton' is clicked.
            /// </summary>
            private void CompareButton_Click(object sender, EventArgs e)
            {
                // Load the Packages
                List<Package> sourcePackages = PackageParser.Parse(this.SourceControl.Text);
                List<Package> targetPackages = PackageParser.Parse(this.TargetControl.Text);                
                StringBuilder sb = new StringBuilder();

                // To Do: Now do the Comparison Report
                if (ListHelper.HasOneOrMoreItems(sourcePackages, targetPackages))
                {
                    // Iterate the collection of Package objects
                    foreach (Package source in sourcePackages)
                    {
                        // Now found in the latest
                        source.FoundInLatest = false;

                        // Iterate the collection of Package objects
                        foreach (Package target in targetPackages)
                        {
                            // if the strings match                            
                            if (TextHelper.IsEqual(source.Name, target.Name))
                            {
                                // Update the value
                                target.FoundInLatest = true;

                                // Set to FoundInLatest true
                                source.FoundInLatest = true;

                                // exit inner loop
                                break;
                            }
                        }
                    }

                    // get the new packages
                    List<Package> newPackages = targetPackages.Where(x => x.FoundInLatest == false).ToList();

                    // If the newPackages collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(newPackages))
                    {
                        // Show a header
                        sb.Append("New Packages: ");

                        // Add a new line
                        sb.Append(Environment.NewLine);

                        // Iterate the collection of Package objects
                        foreach (Package package in newPackages)
                        {
                            // add to this string
                            sb.Append(package.Name);                            
                            sb.Append(Environment.NewLine);
                            sb.Append(package.Version);
                            sb.Append(Environment.NewLine);
                            sb.Append(Environment.NewLine);
                        }
                    }

                    // Add a new line
                    sb.Append(Environment.NewLine);

                    // Get the removed packages
                    List<Package> removedPackages = sourcePackages.Where(x => x.FoundInLatest == false).ToList();

                    // If the removedPackages collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(removedPackages))
                    {
                        // Show a header
                        sb.Append("Removed Packages: ");

                        // Add a new line
                        sb.Append(Environment.NewLine);

                        // Iterate the collection of Package objects
                        foreach (Package package in removedPackages)
                        {
                            // add to this string
                            sb.Append(package.Name);                            
                            sb.Append(Environment.NewLine);
                            sb.Append(package.Version);
                            sb.Append(Environment.NewLine);
                            sb.Append(Environment.NewLine);
                        }
                    }

                    // get the results
                    string results = sb.ToString();

                    // Copy to clipboard
                    Clipboard.SetText(results);

                    // Finished for now
                    MessageBox.Show("The output has been copied to your clipboard. Paste into Notepad or Excel to view", "Analysis Complete");
                }
            }

        #endregion

        #endregion

    }
    #endregion

}
