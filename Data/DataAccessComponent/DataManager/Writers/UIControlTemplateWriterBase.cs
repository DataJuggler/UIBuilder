

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

    #region class UIControlTemplateWriterBase
    /// <summary>
    /// This class is used for converting a 'UIControlTemplate' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class UIControlTemplateWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(UIControlTemplate uIControlTemplate)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='uIControlTemplate'>The 'UIControlTemplate' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(UIControlTemplate uIControlTemplate)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (uIControlTemplate != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", uIControlTemplate.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteUIControlTemplateStoredProcedure(UIControlTemplate uIControlTemplate)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteUIControlTemplate'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIControlTemplate_Delete'.
            /// </summary>
            /// <param name="uIControlTemplate">The 'UIControlTemplate' to Delete.</param>
            /// <returns>An instance of a 'DeleteUIControlTemplateStoredProcedure' object.</returns>
            public static DeleteUIControlTemplateStoredProcedure CreateDeleteUIControlTemplateStoredProcedure(UIControlTemplate uIControlTemplate)
            {
                // Initial Value
                DeleteUIControlTemplateStoredProcedure deleteUIControlTemplateStoredProcedure = new DeleteUIControlTemplateStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteUIControlTemplateStoredProcedure.Parameters = CreatePrimaryKeyParameter(uIControlTemplate);

                // return value
                return deleteUIControlTemplateStoredProcedure;
            }
            #endregion

            #region CreateFindUIControlTemplateStoredProcedure(UIControlTemplate uIControlTemplate)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindUIControlTemplateStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIControlTemplate_Find'.
            /// </summary>
            /// <param name="uIControlTemplate">The 'UIControlTemplate' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindUIControlTemplateStoredProcedure CreateFindUIControlTemplateStoredProcedure(UIControlTemplate uIControlTemplate)
            {
                // Initial Value
                FindUIControlTemplateStoredProcedure findUIControlTemplateStoredProcedure = null;

                // verify uIControlTemplate exists
                if(uIControlTemplate != null)
                {
                    // Instanciate findUIControlTemplateStoredProcedure
                    findUIControlTemplateStoredProcedure = new FindUIControlTemplateStoredProcedure();

                    // Now create parameters for this procedure
                    findUIControlTemplateStoredProcedure.Parameters = CreatePrimaryKeyParameter(uIControlTemplate);
                }

                // return value
                return findUIControlTemplateStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(UIControlTemplate uIControlTemplate)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new uIControlTemplate.
            /// </summary>
            /// <param name="uIControlTemplate">The 'UIControlTemplate' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(UIControlTemplate uIControlTemplate)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[11];
                SqlParameter param = null;

                // verify uIControlTemplateexists
                if(uIControlTemplate != null)
                {
                    // Create [ControlType] parameter
                    param = new SqlParameter("@ControlType", uIControlTemplate.ControlType);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [DesignerTemplateId] parameter
                    param = new SqlParameter("@DesignerTemplateId", uIControlTemplate.DesignerTemplateId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [GlobalUsingsTemplateId] parameter
                    param = new SqlParameter("@GlobalUsingsTemplateId", uIControlTemplate.GlobalUsingsTemplateId);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create [Name] parameter
                    param = new SqlParameter("@Name", uIControlTemplate.Name);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create [NugetPackage] parameter
                    param = new SqlParameter("@NugetPackage", uIControlTemplate.NugetPackage);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create [Path] parameter
                    param = new SqlParameter("@Path", uIControlTemplate.Path);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create [ProgramFileTemplateId] parameter
                    param = new SqlParameter("@ProgramFileTemplateId", uIControlTemplate.ProgramFileTemplateId);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create [ProjectTemplateId] parameter
                    param = new SqlParameter("@ProjectTemplateId", uIControlTemplate.ProjectTemplateId);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create [ResourcesTemplateId] parameter
                    param = new SqlParameter("@ResourcesTemplateId", uIControlTemplate.ResourcesTemplateId);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create [ResxTemplateId] parameter
                    param = new SqlParameter("@ResxTemplateId", uIControlTemplate.ResxTemplateId);

                    // set parameters[9]
                    parameters[9] = param;

                    // Create [Version] parameter
                    param = new SqlParameter("@Version", uIControlTemplate.Version);

                    // set parameters[10]
                    parameters[10] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertUIControlTemplateStoredProcedure(UIControlTemplate uIControlTemplate)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertUIControlTemplateStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIControlTemplate_Insert'.
            /// </summary>
            /// <param name="uIControlTemplate"The 'UIControlTemplate' object to insert</param>
            /// <returns>An instance of a 'InsertUIControlTemplateStoredProcedure' object.</returns>
            public static InsertUIControlTemplateStoredProcedure CreateInsertUIControlTemplateStoredProcedure(UIControlTemplate uIControlTemplate)
            {
                // Initial Value
                InsertUIControlTemplateStoredProcedure insertUIControlTemplateStoredProcedure = null;

                // verify uIControlTemplate exists
                if(uIControlTemplate != null)
                {
                    // Instanciate insertUIControlTemplateStoredProcedure
                    insertUIControlTemplateStoredProcedure = new InsertUIControlTemplateStoredProcedure();

                    // Now create parameters for this procedure
                    insertUIControlTemplateStoredProcedure.Parameters = CreateInsertParameters(uIControlTemplate);
                }

                // return value
                return insertUIControlTemplateStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(UIControlTemplate uIControlTemplate)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing uIControlTemplate.
            /// </summary>
            /// <param name="uIControlTemplate">The 'UIControlTemplate' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(UIControlTemplate uIControlTemplate)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[12];
                SqlParameter param = null;

                // verify uIControlTemplateexists
                if(uIControlTemplate != null)
                {
                    // Create parameter for [ControlType]
                    param = new SqlParameter("@ControlType", uIControlTemplate.ControlType);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [DesignerTemplateId]
                    param = new SqlParameter("@DesignerTemplateId", uIControlTemplate.DesignerTemplateId);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [GlobalUsingsTemplateId]
                    param = new SqlParameter("@GlobalUsingsTemplateId", uIControlTemplate.GlobalUsingsTemplateId);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Name]
                    param = new SqlParameter("@Name", uIControlTemplate.Name);

                    // set parameters[3]
                    parameters[3] = param;

                    // Create parameter for [NugetPackage]
                    param = new SqlParameter("@NugetPackage", uIControlTemplate.NugetPackage);

                    // set parameters[4]
                    parameters[4] = param;

                    // Create parameter for [Path]
                    param = new SqlParameter("@Path", uIControlTemplate.Path);

                    // set parameters[5]
                    parameters[5] = param;

                    // Create parameter for [ProgramFileTemplateId]
                    param = new SqlParameter("@ProgramFileTemplateId", uIControlTemplate.ProgramFileTemplateId);

                    // set parameters[6]
                    parameters[6] = param;

                    // Create parameter for [ProjectTemplateId]
                    param = new SqlParameter("@ProjectTemplateId", uIControlTemplate.ProjectTemplateId);

                    // set parameters[7]
                    parameters[7] = param;

                    // Create parameter for [ResourcesTemplateId]
                    param = new SqlParameter("@ResourcesTemplateId", uIControlTemplate.ResourcesTemplateId);

                    // set parameters[8]
                    parameters[8] = param;

                    // Create parameter for [ResxTemplateId]
                    param = new SqlParameter("@ResxTemplateId", uIControlTemplate.ResxTemplateId);

                    // set parameters[9]
                    parameters[9] = param;

                    // Create parameter for [Version]
                    param = new SqlParameter("@Version", uIControlTemplate.Version);

                    // set parameters[10]
                    parameters[10] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", uIControlTemplate.Id);
                    parameters[11] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateUIControlTemplateStoredProcedure(UIControlTemplate uIControlTemplate)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateUIControlTemplateStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIControlTemplate_Update'.
            /// </summary>
            /// <param name="uIControlTemplate"The 'UIControlTemplate' object to update</param>
            /// <returns>An instance of a 'UpdateUIControlTemplateStoredProcedure</returns>
            public static UpdateUIControlTemplateStoredProcedure CreateUpdateUIControlTemplateStoredProcedure(UIControlTemplate uIControlTemplate)
            {
                // Initial Value
                UpdateUIControlTemplateStoredProcedure updateUIControlTemplateStoredProcedure = null;

                // verify uIControlTemplate exists
                if(uIControlTemplate != null)
                {
                    // Instanciate updateUIControlTemplateStoredProcedure
                    updateUIControlTemplateStoredProcedure = new UpdateUIControlTemplateStoredProcedure();

                    // Now create parameters for this procedure
                    updateUIControlTemplateStoredProcedure.Parameters = CreateUpdateParameters(uIControlTemplate);
                }

                // return value
                return updateUIControlTemplateStoredProcedure;
            }
            #endregion

            #region CreateFetchAllUIControlTemplatesStoredProcedure(UIControlTemplate uIControlTemplate)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllUIControlTemplatesStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'UIControlTemplate_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllUIControlTemplatesStoredProcedure' object.</returns>
            public static FetchAllUIControlTemplatesStoredProcedure CreateFetchAllUIControlTemplatesStoredProcedure(UIControlTemplate uIControlTemplate)
            {
                // Initial value
                FetchAllUIControlTemplatesStoredProcedure fetchAllUIControlTemplatesStoredProcedure = new FetchAllUIControlTemplatesStoredProcedure();

                // return value
                return fetchAllUIControlTemplatesStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
