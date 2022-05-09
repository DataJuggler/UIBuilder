

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using Microsoft.Data.SqlClient;
using ObjectLibrary.BusinessObjects;
using System;
using System.Data;

#endregion


namespace DataAccessComponent.DataManager.Writers
{

    #region class UIProjectWriterBase
    /// <summary>
    /// This class is used for converting a 'UIProject' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class UIProjectWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(UIProject uIProject)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='uIProject'>The 'UIProject' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(UIProject uIProject)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (uIProject != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", uIProject.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteUIProjectStoredProcedure(UIProject uIProject)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteUIProject'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIProject_Delete'.
            /// </summary>
            /// <param name="uIProject">The 'UIProject' to Delete.</param>
            /// <returns>An instance of a 'DeleteUIProjectStoredProcedure' object.</returns>
            public static DeleteUIProjectStoredProcedure CreateDeleteUIProjectStoredProcedure(UIProject uIProject)
            {
                // Initial Value
                DeleteUIProjectStoredProcedure deleteUIProjectStoredProcedure = new DeleteUIProjectStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteUIProjectStoredProcedure.Parameters = CreatePrimaryKeyParameter(uIProject);

                // return value
                return deleteUIProjectStoredProcedure;
            }
            #endregion

            #region CreateFindUIProjectStoredProcedure(UIProject uIProject)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindUIProjectStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIProject_Find'.
            /// </summary>
            /// <param name="uIProject">The 'UIProject' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindUIProjectStoredProcedure CreateFindUIProjectStoredProcedure(UIProject uIProject)
            {
                // Initial Value
                FindUIProjectStoredProcedure findUIProjectStoredProcedure = null;

                // verify uIProject exists
                if(uIProject != null)
                {
                    // Instanciate findUIProjectStoredProcedure
                    findUIProjectStoredProcedure = new FindUIProjectStoredProcedure();

                    // Now create parameters for this procedure
                    findUIProjectStoredProcedure.Parameters = CreatePrimaryKeyParameter(uIProject);
                }

                // return value
                return findUIProjectStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(UIProject uIProject)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new uIProject.
            /// </summary>
            /// <param name="uIProject">The 'UIProject' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(UIProject uIProject)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[4];
                SqlParameter param = null;

                // verify uIProjectexists
                if(uIProject != null)
                {
                    // Create [IsBlazor] parameter
                    param = new SqlParameter("@IsBlazor", uIProject.IsBlazor);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [IsWindowsForm] parameter
                    param = new SqlParameter("@IsWindowsForm", uIProject.IsWindowsForm);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", uIProject.Name);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [UIControlTemplateId] parameter
                    param = new SqlParameter("@UIControlTemplateId", uIProject.UIControlTemplateId);

                    // set parameters[3]
                    parameters[3] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertUIProjectStoredProcedure(UIProject uIProject)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertUIProjectStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIProject_Insert'.
            /// </summary>
            /// <param name="uIProject"The 'UIProject' object to insert</param>
            /// <returns>An instance of a 'InsertUIProjectStoredProcedure' object.</returns>
            public static InsertUIProjectStoredProcedure CreateInsertUIProjectStoredProcedure(UIProject uIProject)
            {
                // Initial Value
                InsertUIProjectStoredProcedure insertUIProjectStoredProcedure = null;

                // verify uIProject exists
                if(uIProject != null)
                {
                    // Instanciate insertUIProjectStoredProcedure
                    insertUIProjectStoredProcedure = new InsertUIProjectStoredProcedure();

                    // Now create parameters for this procedure
                    insertUIProjectStoredProcedure.Parameters = CreateInsertParameters(uIProject);
                }

                // return value
                return insertUIProjectStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(UIProject uIProject)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing uIProject.
            /// </summary>
            /// <param name="uIProject">The 'UIProject' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(UIProject uIProject)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[5];
                SqlParameter param = null;

                // verify uIProjectexists
                if(uIProject != null)
                {
                    // Create parameter for [IsBlazor]
                    param = new SqlParameter("@IsBlazor", uIProject.IsBlazor);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [IsWindowsForm]
                    param = new SqlParameter("@IsWindowsForm", uIProject.IsWindowsForm);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", uIProject.Name);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [UIControlTemplateId]
                    param = new SqlParameter("@UIControlTemplateId", uIProject.UIControlTemplateId);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", uIProject.Id);
                    parameters[4] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateUIProjectStoredProcedure(UIProject uIProject)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateUIProjectStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIProject_Update'.
            /// </summary>
            /// <param name="uIProject"The 'UIProject' object to update</param>
            /// <returns>An instance of a 'UpdateUIProjectStoredProcedure</returns>
            public static UpdateUIProjectStoredProcedure CreateUpdateUIProjectStoredProcedure(UIProject uIProject)
            {
                // Initial Value
                UpdateUIProjectStoredProcedure updateUIProjectStoredProcedure = null;

                // verify uIProject exists
                if(uIProject != null)
                {
                    // Instanciate updateUIProjectStoredProcedure
                    updateUIProjectStoredProcedure = new UpdateUIProjectStoredProcedure();

                    // Now create parameters for this procedure
                    updateUIProjectStoredProcedure.Parameters = CreateUpdateParameters(uIProject);
                }

                // return value
                return updateUIProjectStoredProcedure;
            }
            #endregion

            #region CreateFetchAllUIProjectsStoredProcedure(UIProject uIProject)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllUIProjectsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIProject_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllUIProjectsStoredProcedure' object.</returns>
            public static FetchAllUIProjectsStoredProcedure CreateFetchAllUIProjectsStoredProcedure(UIProject uIProject)
            {
                // Initial value
                FetchAllUIProjectsStoredProcedure fetchAllUIProjectsStoredProcedure = new FetchAllUIProjectsStoredProcedure();

                // return value
                return fetchAllUIProjectsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
