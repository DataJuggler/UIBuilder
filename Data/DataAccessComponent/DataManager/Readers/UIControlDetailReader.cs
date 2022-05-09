

#region using statements

using ObjectLibrary.BusinessObjects;
using ObjectLibrary.Enumerations;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Readers
{

    #region class UIControlDetailReader
    /// <summary>
    /// This class loads a single 'UIControlDetail' object or a list of type <UIControlDetail>.
    /// </summary>
    public class UIControlDetailReader
    {

        #region Static Methods

            #region Load(DataRow dataRow)
            /// <summary>
            /// This method loads a 'UIControlDetail' object
            /// from the dataRow passed in.
            /// </summary>
            /// <param name='dataRow'>The 'DataRow' to load from.</param>
            /// <returns>A 'UIControlDetail' DataObject.</returns>
            public static UIControlDetail Load(DataRow dataRow)
            {
                // Initial Value
                UIControlDetail uIControlDetail = new UIControlDetail();

                // Create field Integers
                int idfield = 0;
                int indentfield = 1;
                int lineNumberfield = 2;
                int lineTextfield = 3;
                int uIControlIdfield = 4;

                try
                {
                    // Load Each field
                    uIControlDetail.UpdateIdentity(DataHelper.ParseInteger(dataRow.ItemArray[idfield], 0));
                    uIControlDetail.Indent = DataHelper.ParseInteger(dataRow.ItemArray[indentfield], 0);
                    uIControlDetail.LineNumber = DataHelper.ParseInteger(dataRow.ItemArray[lineNumberfield], 0);
                    uIControlDetail.LineText = DataHelper.ParseString(dataRow.ItemArray[lineTextfield]);
                    uIControlDetail.UIControlId = DataHelper.ParseInteger(dataRow.ItemArray[uIControlIdfield], 0);
                }
                catch
                {
                }

                // return value
                return uIControlDetail;
            }
            #endregion

            #region LoadCollection(DataTable dataTable)
            /// <summary>
            /// This method loads a collection of 'UIControlDetail' objects.
            /// from the dataTable.Rows object passed in.
            /// </summary>
            /// <param name='dataTable'>The 'DataTable.Rows' to load from.</param>
            /// <returns>A UIControlDetail Collection.</returns>
            public static List<UIControlDetail> LoadCollection(DataTable dataTable)
            {
                // Initial Value
                List<UIControlDetail> uIControlDetails = new List<UIControlDetail>();

                try
                {
                    // Load Each row In DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Create 'UIControlDetail' from rows
                        UIControlDetail uIControlDetail = Load(row);

                        // Add this object to collection
                        uIControlDetails.Add(uIControlDetail);
                    }
                }
                catch
                {
                }

                // return value
                return uIControlDetails;
            }
            #endregion

        #endregion

    }
    #endregion

}
