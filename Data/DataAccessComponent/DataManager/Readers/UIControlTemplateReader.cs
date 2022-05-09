

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class UIControlTemplateReader
    /// <summary>
    /// This class loads a single 'UIControlTemplate' object or a list of type <UIControlTemplate>.
    /// </summary>
    public class UIControlTemplateReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'UIControlTemplate' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'UIControlTemplate' DataObject.</returns>
            public static UIControlTemplate Load(DataRow dataRow)
            {
                // Initial Value
                UIControlTemplate uIControlTemplate = new UIControlTemplate();

                // Create field Integers
                int controlTypefield = 0;
                int designerTemplateIdfield = 1;
                int globalUsingsTemplateIdfield = 2;
                int idfield = 3;
                int namefield = 4;
                int nugetPackagefield = 5;
                int pathfield = 6;
                int programFileTemplateIdfield = 7;
                int projectTemplateIdfield = 8;
                int resourcesTemplateIdfield = 9;
                int resxTemplateIdfield = 10;
                int versionfield = 11;

                try
                {
                    // Load Each field
                    uIControlTemplate.ControlType = DataHelper.ParseInteger(dataRow.ItemArray[controlTypefield], 0);
                    uIControlTemplate.DesignerTemplateId = DataHelper.ParseInteger(dataRow.ItemArray[designerTemplateIdfield], 0);
                    uIControlTemplate.GlobalUsingsTemplateId = DataHelper.ParseInteger(dataRow.ItemArray[globalUsingsTemplateIdfield], 0);
                    uIControlTemplate.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    uIControlTemplate.Name = DataHelper.ParseString(dataRow.ItemArray[namefield]);
                    uIControlTemplate.NugetPackage = DataHelper.ParseString(dataRow.ItemArray[nugetPackagefield]);
                    uIControlTemplate.Path = DataHelper.ParseString(dataRow.ItemArray[pathfield]);
                    uIControlTemplate.ProgramFileTemplateId = DataHelper.ParseInteger(dataRow.ItemArray[programFileTemplateIdfield], 0);
                    uIControlTemplate.ProjectTemplateId = DataHelper.ParseInteger(dataRow.ItemArray[projectTemplateIdfield], 0);
                    uIControlTemplate.ResourcesTemplateId = DataHelper.ParseInteger(dataRow.ItemArray[resourcesTemplateIdfield], 0);
                    uIControlTemplate.ResxTemplateId = DataHelper.ParseInteger(dataRow.ItemArray[resxTemplateIdfield], 0);
                    uIControlTemplate.Version = DataHelper.ParseString(dataRow.ItemArray[versionfield]);
                }
                catch
                {
                }

                // return value
                return uIControlTemplate;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'UIControlTemplate' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A UIControlTemplate Collection.</returns>
            public static List<UIControlTemplate> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<UIControlTemplate> uIControlTemplates = new List<UIControlTemplate>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'UIControlTemplate' from rows
                        UIControlTemplate uIControlTemplate = Load(row);

                        // Add this object to collection
                        uIControlTemplates.Add(uIControlTemplate);
                    }
                }
                catch
                {
                }

                // return value
                return uIControlTemplates;
            }
            #endregion

        #endregion

    }
    #endregion

}
