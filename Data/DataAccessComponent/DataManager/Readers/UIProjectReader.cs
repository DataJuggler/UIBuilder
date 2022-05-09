

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class UIProjectReader
    /// <summary>
    /// This class loads a single 'UIProject' object or a list of type <UIProject>.
    /// </summary>
    public class UIProjectReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'UIProject' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'UIProject' DataObject.</returns>
            public static UIProject Load(DataRow dataRow)
            {
                // Initial Value
                UIProject uIProject = new UIProject();

                // Create field Integers
                int idfield = 0;
                int isBlazorfield = 1;
                int isWindowsFormfield = 2;
                int namefield = 3;
                int uIControlTemplateIdfield = 4;

                try
                {
                    // Load Each field
                    uIProject.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    uIProject.IsBlazor = DataHelper.ParseBoolean(dataRow.ItemArray[isBlazorfield], false);
                    uIProject.IsWindowsForm = DataHelper.ParseBoolean(dataRow.ItemArray[isWindowsFormfield], false);
                    uIProject.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    uIProject.UIControlTemplateId = DataHelper.ParseInteger(dataRow.ItemArray[uIControlTemplateIdfield], 0);
                }
                catch
                {
                }

                // return value
                return uIProject;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'UIProject' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A UIProject Collection.</returns>
            public static List<UIProject> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<UIProject> uIProjects = new List<UIProject>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'UIProject' from rows
                        UIProject uIProject = Load(row);

                        // Add this object to collection
                        uIProjects.Add(uIProject);
                    }
                }
                catch
                {
                }

                // return value
                return uIProjects;
            }
            #endregion

        #endregion

    }
    #endregion

}
