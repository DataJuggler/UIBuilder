

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

    #region class UIControlDetailWriterBase
    /// <summary>
    /// This class is used for converting a 'UIControlDetail' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class UIControlDetailWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(UIControlDetail uIControlDetail)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='uIControlDetail'>The 'UIControlDetail' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(UIControlDetail uIControlDetail)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (uIControlDetail != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", uIControlDetail.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteUIControlDetailStoredProcedure(UIControlDetail uIControlDetail)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteUIControlDetail'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIControlDetail_Delete'.
            /// </summary>
            /// <param name="uIControlDetail">The 'UIControlDetail' to Delete.</param>
            /// <returns>An instance of a 'DeleteUIControlDetailStoredProcedure' object.</returns>
            public static DeleteUIControlDetailStoredProcedure CreateDeleteUIControlDetailStoredProcedure(UIControlDetail uIControlDetail)
            {
                // Initial Value
                DeleteUIControlDetailStoredProcedure deleteUIControlDetailStoredProcedure = new DeleteUIControlDetailStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteUIControlDetailStoredProcedure.Parameters = CreatePrimaryKeyParameter(uIControlDetail);

                // return value
                return deleteUIControlDetailStoredProcedure;
            }
            #endregion

            #region CreateFindUIControlDetailStoredProcedure(UIControlDetail uIControlDetail)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindUIControlDetailStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIControlDetail_Find'.
            /// </summary>
            /// <param name="uIControlDetail">The 'UIControlDetail' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindUIControlDetailStoredProcedure CreateFindUIControlDetailStoredProcedure(UIControlDetail uIControlDetail)
            {
                // Initial Value
                FindUIControlDetailStoredProcedure findUIControlDetailStoredProcedure = null;

                // verify uIControlDetail exists
                if(uIControlDetail != null)
                {
                    // Instanciate findUIControlDetailStoredProcedure
                    findUIControlDetailStoredProcedure = new FindUIControlDetailStoredProcedure();

                    // Now create parameters for this procedure
                    findUIControlDetailStoredProcedure.Parameters = CreatePrimaryKeyParameter(uIControlDetail);
                }

                // return value
                return findUIControlDetailStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(UIControlDetail uIControlDetail)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new uIControlDetail.
            /// </summary>
            /// <param name="uIControlDetail">The 'UIControlDetail' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(UIControlDetail uIControlDetail)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[4];
                SqlParameter param = null;

                // verify uIControlDetailexists
                if(uIControlDetail != null)
                {
                    // Create [Indent] parameter
                    param = new SqlParameter("@Indent", uIControlDetail.Indent);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [LineNumber] parameter
                    param = new SqlParameter("@LineNumber", uIControlDetail.LineNumber);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [LineText] parameter
                    param = new SqlParameter("@LineText", uIControlDetail.LineText);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [UIControlId] parameter
                    param = new SqlParameter("@UIControlId", uIControlDetail.UIControlId);

                    // set parameters[3]
                    parameters[3] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertUIControlDetailStoredProcedure(UIControlDetail uIControlDetail)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertUIControlDetailStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIControlDetail_Insert'.
            /// </summary>
            /// <param name="uIControlDetail"The 'UIControlDetail' object to insert</param>
            /// <returns>An instance of a 'InsertUIControlDetailStoredProcedure' object.</returns>
            public static InsertUIControlDetailStoredProcedure CreateInsertUIControlDetailStoredProcedure(UIControlDetail uIControlDetail)
            {
                // Initial Value
                InsertUIControlDetailStoredProcedure insertUIControlDetailStoredProcedure = null;

                // verify uIControlDetail exists
                if(uIControlDetail != null)
                {
                    // Instanciate insertUIControlDetailStoredProcedure
                    insertUIControlDetailStoredProcedure = new InsertUIControlDetailStoredProcedure();

                    // Now create parameters for this procedure
                    insertUIControlDetailStoredProcedure.Parameters = CreateInsertParameters(uIControlDetail);
                }

                // return value
                return insertUIControlDetailStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(UIControlDetail uIControlDetail)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing uIControlDetail.
            /// </summary>
            /// <param name="uIControlDetail">The 'UIControlDetail' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(UIControlDetail uIControlDetail)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[5];
                SqlParameter param = null;

                // verify uIControlDetailexists
                if(uIControlDetail != null)
                {
                    // Create parameter for [Indent]
                    param = new SqlParameter("@Indent", uIControlDetail.Indent);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [LineNumber]
                    param = new SqlParameter("@LineNumber", uIControlDetail.LineNumber);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [LineText]
                    param = new SqlParameter("@LineText", uIControlDetail.LineText);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [UIControlId]
                    param = new SqlParameter("@UIControlId", uIControlDetail.UIControlId);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", uIControlDetail.Id);
                    parameters[4] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateUIControlDetailStoredProcedure(UIControlDetail uIControlDetail)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateUIControlDetailStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIControlDetail_Update'.
            /// </summary>
            /// <param name="uIControlDetail"The 'UIControlDetail' object to update</param>
            /// <returns>An instance of a 'UpdateUIControlDetailStoredProcedure</returns>
            public static UpdateUIControlDetailStoredProcedure CreateUpdateUIControlDetailStoredProcedure(UIControlDetail uIControlDetail)
            {
                // Initial Value
                UpdateUIControlDetailStoredProcedure updateUIControlDetailStoredProcedure = null;

                // verify uIControlDetail exists
                if(uIControlDetail != null)
                {
                    // Instanciate updateUIControlDetailStoredProcedure
                    updateUIControlDetailStoredProcedure = new UpdateUIControlDetailStoredProcedure();

                    // Now create parameters for this procedure
                    updateUIControlDetailStoredProcedure.Parameters = CreateUpdateParameters(uIControlDetail);
                }

                // return value
                return updateUIControlDetailStoredProcedure;
            }
            #endregion

            #region CreateFetchAllUIControlDetailsStoredProcedure(UIControlDetail uIControlDetail)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllUIControlDetailsStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIControlDetail_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllUIControlDetailsStoredProcedure' object.</returns>
            public static FetchAllUIControlDetailsStoredProcedure CreateFetchAllUIControlDetailsStoredProcedure(UIControlDetail uIControlDetail)
            {
                // Initial value
                FetchAllUIControlDetailsStoredProcedure fetchAllUIControlDetailsStoredProcedure = new FetchAllUIControlDetailsStoredProcedure();

                // return value
                return fetchAllUIControlDetailsStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
