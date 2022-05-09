

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

    #region class UIProjectManager
    /// <summary>
    /// This class is used to manage a 'UIProject' object.
    /// </summary>
    public class UIProjectManager
    {

        #region Private Variables
        private DataManager dataManager;
        private DataHelper dataHelper;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'UIProjectManager' object.
        /// </summary>
        public UIProjectManager(DataManager dataManagerArg)
        {
            // Set DataManager
            this.DataManager = dataManagerArg;

            // Perform Initialization
            Init();
        }
        #endregion

        #region Methods

            #region DeleteUIProject()
            /// <summary>
            /// This method deletes a 'UIProject' object.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool DeleteUIProject(DeleteUIProjectStoredProcedure deleteUIProjectProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool deleted = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    deleted = this.DataHelper.DeleteRecord(deleteUIProjectProc, databaseConnector);
                }

                // return value
                return deleted;
            }
            #endregion

            #region FetchAllUIProjects()
            /// <summary>
            /// This method fetches a  'List<UIProject>' object.
            /// This method uses the 'UIProjects_FetchAll' procedure.
            /// </summary>
            /// <returns>A 'List<UIProject>'</returns>
            /// </summary>
            public List<UIProject> FetchAllUIProjects(FetchAllUIProjectsStoredProcedure fetchAllUIProjectsProc, DataConnector databaseConnector)
            {
                // Initial Value
                List<UIProject> uIProjectCollection = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet allUIProjectsDataSet = this.DataHelper.LoadDataSet(fetchAllUIProjectsProc, databaseConnector);

                    // Verify DataSet Exists
                    if(allUIProjectsDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataTable table = this.DataHelper.ReturnFirstTable(allUIProjectsDataSet);

                        // if table exists
                        if(table != null)
                        {
                            // Load Collection
                            uIProjectCollection = UIProjectReader.LoadCollection(table);
                        }
                    }
                }

                // return value
                return uIProjectCollection;
            }
            #endregion

            #region FindUIProject()
            /// <summary>
            /// This method finds a  'UIProject' object.
            /// This method uses the 'UIProject_Find' procedure.
            /// </summary>
            /// <returns>A 'UIProject' object.</returns>
            /// </summary>
            public UIProject FindUIProject(FindUIProjectStoredProcedure findUIProjectProc, DataConnector databaseConnector)
            {
                // Initial Value
                UIProject uIProject = null;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // First Get Dataset
                    DataSet uIProjectDataSet = this.DataHelper.LoadDataSet(findUIProjectProc, databaseConnector);

                    // Verify DataSet Exists
                    if(uIProjectDataSet != null)
                    {
                        // Get DataTable From DataSet
                        DataRow row = this.DataHelper.ReturnFirstRow(uIProjectDataSet);

                        // if row exists
                        if(row != null)
                        {
                            // Load UIProject
                            uIProject = UIProjectReader.Load(row);
                        }
                    }
                }

                // return value
                return uIProject;
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

            #region InsertUIProject()
            /// <summary>
            /// This method inserts a 'UIProject' object.
            /// This method uses the 'UIProject_Insert' procedure.
            /// </summary>
            /// <returns>The identity value of the new record.</returns>
            /// </summary>
            public int InsertUIProject(InsertUIProjectStoredProcedure insertUIProjectProc, DataConnector databaseConnector)
            {
                // Initial Value
                int newIdentity = -1;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Non Query
                    newIdentity = this.DataHelper.InsertRecord(insertUIProjectProc, databaseConnector);
                }

                // return value
                return newIdentity;
            }
            #endregion

            #region UpdateUIProject()
            /// <summary>
            /// This method updates a 'UIProject'.
            /// This method uses the 'UIProject_Update' procedure.
            /// </summary>
            /// <returns>True if successful false if not.</returns>
            /// </summary>
            public bool UpdateUIProject(UpdateUIProjectStoredProcedure updateUIProjectProc, DataConnector databaseConnector)
            {
                // Initial Value
                bool saved = false;

                // Verify database connection is connected
                if ((databaseConnector != null) && (databaseConnector.Connected))
                {
                    // Execute Update.
                    saved = this.DataHelper.UpdateRecord(updateUIProjectProc, databaseConnector);
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
