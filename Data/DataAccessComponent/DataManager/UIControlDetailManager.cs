

#region using statements

using DataAccessComponent.DataManager.Readers;
using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager
{

    #region class UIControlDetailManager
    /// <summary>
    /// This class is used to manage a 'UIControlDetail' object.
    /// </summary>
    public class UIControlDetailManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UIControlDetailManager' object.
        /// </summary>
        public UIControlDetailManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteUIControlDetail()
            /// <summary>
            /// This method deletes a 'UIControlDetail' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteUIControlDetail(DeleteUIControlDetailStoredProcedure deleteUIControlDetailProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteUIControlDetailProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllUIControlDetails()
            /// <summary>
            /// This method fetches a  'List<UIControlDetail>' object.
            /// This method uses the 'UIControlDetails_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<UIControlDetail>'</returns>
            /// </summary>
            public List<UIControlDetail> FetchAllUIControlDetails(FetchAllUIControlDetailsStoredProcedure fetchAllUIControlDetailsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<UIControlDetail> uIControlDetailCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allUIControlDetailsDataSet = this.DataHelper.LoadDataSet(fetchAllUIControlDetailsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allUIControlDetailsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allUIControlDetailsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            uIControlDetailCollection = UIControlDetailReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return uIControlDetailCollection;
            }
            #endregion

            #region FindUIControlDetail()
            /// <summary>
            /// This method finds a  'UIControlDetail' object.
            /// This method uses the 'UIControlDetail_Find' procedure.
            /// </summary>
            /// <returns>A 'UIControlDetail' object.</returns>
            /// </summary>
            public UIControlDetail FindUIControlDetail(FindUIControlDetailStoredProcedure findUIControlDetailProc, DataConnector databaseConnector)
            {
                // Initial Value
                UIControlDetail uIControlDetail = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet uIControlDetailDataSet = this.DataHelper.LoadDataSet(findUIControlDetailProc, databaseConnector);

                    // Verify DataSet Exists
                    if(uIControlDetailDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(uIControlDetailDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load UIControlDetail
                            uIControlDetail = UIControlDetailReader.Load(row);
                        }
                    }
                }

                // return value
                return uIControlDetail;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perorm Initialization For This Object
            /// </summary>
            private void Init()
            {
                // Create DataHelper object
                this.DataHelper = new DataHelper();
            }
            #endregion

            #region InsertUIControlDetail()
            /// <summary>
            /// This method inserts a 'UIControlDetail' object.
            /// This method uses the 'UIControlDetail_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertUIControlDetail(InsertUIControlDetailStoredProcedure insertUIControlDetailProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertUIControlDetailProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateUIControlDetail()
            /// <summary>
            /// This method updates a 'UIControlDetail'.
            /// This method uses the 'UIControlDetail_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateUIControlDetail(UpdateUIControlDetailStoredProcedure updateUIControlDetailProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateUIControlDetailProc, databaseConnector);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region DataHelper
            /// <summary>
            /// This object uses the Microsoft Data
            /// Application Block to execute stored
            /// procedures.
            /// </summary>
            internal DataHelper DataHelper
            {
                get { return dataHelper; }
                set { dataHelper = value; }
            }
            #endregion

            #region DataManager
            /// <summary>
            /// A reference to this objects parent.
            /// </summary>
            internal DataManager DataManager
            {
                get { return dataManager; }
                set { dataManager = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
