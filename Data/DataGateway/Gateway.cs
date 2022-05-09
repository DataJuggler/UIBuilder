
#region using statements

using ApplicationLogicComponent.Controllers;
using ApplicationLogicComponent.DataOperations;
using DataAccessComponent.DataManager;
using ObjectLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

#endregion

namespace DataGateway
{

    #region class Gateway
    /// <summary>
    /// This class is used to manage DataOperations
    /// between the client and the DataAccessComponent.
    /// Do not change the method name or the parameters for the
    /// code generated methods or they will be recreated the next 
    /// time you code generate with DataTier.Net. If you need additional
    /// parameters passed to a method either create an override or
    /// add or set properties to the temp object that is passed in.
    /// </summary>
    public class Gateway
    {

        #region Private Variables
        private ApplicationController appController;
        private string connectionName;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a Gateway object.
        /// </summary>
        public Gateway(string connectionName = "")
        {
            // store the ConnectionName
            this.ConnectionName = connectionName;

            // Perform Initializations for this object
            Init();
        }
        #endregion

        #region Methods
        
            #region DeleteAdmin(int adminId, Admin tempAdmin = null)
            /// <summary>
            /// This method is used to delete Admin objects.
            /// </summary>
            /// <param name="adminId">Delete the Admin with this adminId</param>
            /// <param name="tempAdmin">Pass in a tempAdmin to perform a custom delete.</param>
            public bool DeleteAdmin(int adminId, Admin tempAdmin = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempAdmin does not exist
                    if (tempAdmin == null)
                    {
                        // create a temp Admin
                        tempAdmin = new Admin();
                    }
        
                    // if the adminId is set
                    if (adminId > 0)
                    {
                        // set the primary key
                        tempAdmin.UpdateIdentity(adminId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.AdminController.Delete(tempAdmin);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteControlInfo(int id, ControlInfo tempControlInfo = null)
            /// <summary>
            /// This method is used to delete ControlInfo objects.
            /// </summary>
            /// <param name="id">Delete the ControlInfo with this id</param>
            /// <param name="tempControlInfo">Pass in a tempControlInfo to perform a custom delete.</param>
            public bool DeleteControlInfo(int id, ControlInfo tempControlInfo = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempControlInfo does not exist
                    if (tempControlInfo == null)
                    {
                        // create a temp ControlInfo
                        tempControlInfo = new ControlInfo();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempControlInfo.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.ControlInfoController.Delete(tempControlInfo);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteControlInfoDetail(int id, ControlInfoDetail tempControlInfoDetail = null)
            /// <summary>
            /// This method is used to delete ControlInfoDetail objects.
            /// </summary>
            /// <param name="id">Delete the ControlInfoDetail with this id</param>
            /// <param name="tempControlInfoDetail">Pass in a tempControlInfoDetail to perform a custom delete.</param>
            public bool DeleteControlInfoDetail(int id, ControlInfoDetail tempControlInfoDetail = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempControlInfoDetail does not exist
                    if (tempControlInfoDetail == null)
                    {
                        // create a temp ControlInfoDetail
                        tempControlInfoDetail = new ControlInfoDetail();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempControlInfoDetail.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.ControlInfoDetailController.Delete(tempControlInfoDetail);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteCustomReader(int customReaderId, CustomReader tempCustomReader = null)
            /// <summary>
            /// This method is used to delete CustomReader objects.
            /// </summary>
            /// <param name="customReaderId">Delete the CustomReader with this customReaderId</param>
            /// <param name="tempCustomReader">Pass in a tempCustomReader to perform a custom delete.</param>
            public bool DeleteCustomReader(int customReaderId, CustomReader tempCustomReader = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCustomReader does not exist
                    if (tempCustomReader == null)
                    {
                        // create a temp CustomReader
                        tempCustomReader = new CustomReader();
                    }
        
                    // if the customReaderId is set
                    if (customReaderId > 0)
                    {
                        // set the primary key
                        tempCustomReader.UpdateIdentity(customReaderId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.CustomReaderController.Delete(tempCustomReader);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteDTNDatabase(int databaseId, DTNDatabase tempDTNDatabase = null)
            /// <summary>
            /// This method is used to delete DTNDatabase objects.
            /// </summary>
            /// <param name="databaseId">Delete the DTNDatabase with this databaseId</param>
            /// <param name="tempDTNDatabase">Pass in a tempDTNDatabase to perform a custom delete.</param>
            public bool DeleteDTNDatabase(int databaseId, DTNDatabase tempDTNDatabase = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempDTNDatabase does not exist
                    if (tempDTNDatabase == null)
                    {
                        // create a temp DTNDatabase
                        tempDTNDatabase = new DTNDatabase();
                    }
        
                    // if the databaseId is set
                    if (databaseId > 0)
                    {
                        // set the primary key
                        tempDTNDatabase.UpdateIdentity(databaseId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.DTNDatabaseController.Delete(tempDTNDatabase);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteDTNField(int fieldId, DTNField tempDTNField = null)
            /// <summary>
            /// This method is used to delete DTNField objects.
            /// </summary>
            /// <param name="fieldId">Delete the DTNField with this fieldId</param>
            /// <param name="tempDTNField">Pass in a tempDTNField to perform a custom delete.</param>
            public bool DeleteDTNField(int fieldId, DTNField tempDTNField = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempDTNField does not exist
                    if (tempDTNField == null)
                    {
                        // create a temp DTNField
                        tempDTNField = new DTNField();
                    }
        
                    // if the fieldId is set
                    if (fieldId > 0)
                    {
                        // set the primary key
                        tempDTNField.UpdateIdentity(fieldId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.DTNFieldController.Delete(tempDTNField);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteDTNProcedure(int procedureId, DTNProcedure tempDTNProcedure = null)
            /// <summary>
            /// This method is used to delete DTNProcedure objects.
            /// </summary>
            /// <param name="procedureId">Delete the DTNProcedure with this procedureId</param>
            /// <param name="tempDTNProcedure">Pass in a tempDTNProcedure to perform a custom delete.</param>
            public bool DeleteDTNProcedure(int procedureId, DTNProcedure tempDTNProcedure = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempDTNProcedure does not exist
                    if (tempDTNProcedure == null)
                    {
                        // create a temp DTNProcedure
                        tempDTNProcedure = new DTNProcedure();
                    }
        
                    // if the procedureId is set
                    if (procedureId > 0)
                    {
                        // set the primary key
                        tempDTNProcedure.UpdateIdentity(procedureId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.DTNProcedureController.Delete(tempDTNProcedure);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteDTNTable(int tableId, DTNTable tempDTNTable = null)
            /// <summary>
            /// This method is used to delete DTNTable objects.
            /// </summary>
            /// <param name="tableId">Delete the DTNTable with this tableId</param>
            /// <param name="tempDTNTable">Pass in a tempDTNTable to perform a custom delete.</param>
            public bool DeleteDTNTable(int tableId, DTNTable tempDTNTable = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempDTNTable does not exist
                    if (tempDTNTable == null)
                    {
                        // create a temp DTNTable
                        tempDTNTable = new DTNTable();
                    }
        
                    // if the tableId is set
                    if (tableId > 0)
                    {
                        // set the primary key
                        tempDTNTable.UpdateIdentity(tableId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.DTNTableController.Delete(tempDTNTable);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteEnumeration(int enumerationId, Enumeration tempEnumeration = null)
            /// <summary>
            /// This method is used to delete Enumeration objects.
            /// </summary>
            /// <param name="enumerationId">Delete the Enumeration with this enumerationId</param>
            /// <param name="tempEnumeration">Pass in a tempEnumeration to perform a custom delete.</param>
            public bool DeleteEnumeration(int enumerationId, Enumeration tempEnumeration = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempEnumeration does not exist
                    if (tempEnumeration == null)
                    {
                        // create a temp Enumeration
                        tempEnumeration = new Enumeration();
                    }
        
                    // if the enumerationId is set
                    if (enumerationId > 0)
                    {
                        // set the primary key
                        tempEnumeration.UpdateIdentity(enumerationId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.EnumerationController.Delete(tempEnumeration);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteFieldSet(int fieldSetId, FieldSet tempFieldSet = null)
            /// <summary>
            /// This method is used to delete FieldSet objects.
            /// </summary>
            /// <param name="fieldSetId">Delete the FieldSet with this fieldSetId</param>
            /// <param name="tempFieldSet">Pass in a tempFieldSet to perform a custom delete.</param>
            public bool DeleteFieldSet(int fieldSetId, FieldSet tempFieldSet = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempFieldSet does not exist
                    if (tempFieldSet == null)
                    {
                        // create a temp FieldSet
                        tempFieldSet = new FieldSet();
                    }
        
                    // if the fieldSetId is set
                    if (fieldSetId > 0)
                    {
                        // set the primary key
                        tempFieldSet.UpdateIdentity(fieldSetId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.FieldSetController.Delete(tempFieldSet);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteFieldSetField(int fieldSetFieldId, FieldSetField tempFieldSetField = null)
            /// <summary>
            /// This method is used to delete FieldSetField objects.
            /// </summary>
            /// <param name="fieldSetFieldId">Delete the FieldSetField with this fieldSetFieldId</param>
            /// <param name="tempFieldSetField">Pass in a tempFieldSetField to perform a custom delete.</param>
            public bool DeleteFieldSetField(int fieldSetFieldId, FieldSetField tempFieldSetField = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempFieldSetField does not exist
                    if (tempFieldSetField == null)
                    {
                        // create a temp FieldSetField
                        tempFieldSetField = new FieldSetField();
                    }
        
                    // if the fieldSetFieldId is set
                    if (fieldSetFieldId > 0)
                    {
                        // set the primary key
                        tempFieldSetField.UpdateIdentity(fieldSetFieldId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.FieldSetFieldController.Delete(tempFieldSetField);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteMethod(int methodId, Method tempMethod = null)
            /// <summary>
            /// This method is used to delete Method objects.
            /// </summary>
            /// <param name="methodId">Delete the Method with this methodId</param>
            /// <param name="tempMethod">Pass in a tempMethod to perform a custom delete.</param>
            public bool DeleteMethod(int methodId, Method tempMethod = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempMethod does not exist
                    if (tempMethod == null)
                    {
                        // create a temp Method
                        tempMethod = new Method();
                    }
        
                    // if the methodId is set
                    if (methodId > 0)
                    {
                        // set the primary key
                        tempMethod.UpdateIdentity(methodId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.MethodController.Delete(tempMethod);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteProject(int projectId, Project tempProject = null)
            /// <summary>
            /// This method is used to delete Project objects.
            /// </summary>
            /// <param name="projectId">Delete the Project with this projectId</param>
            /// <param name="tempProject">Pass in a tempProject to perform a custom delete.</param>
            public bool DeleteProject(int projectId, Project tempProject = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempProject does not exist
                    if (tempProject == null)
                    {
                        // create a temp Project
                        tempProject = new Project();
                    }
        
                    // if the projectId is set
                    if (projectId > 0)
                    {
                        // set the primary key
                        tempProject.UpdateIdentity(projectId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.ProjectController.Delete(tempProject);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteProjectReference(int referencesId, ProjectReference tempProjectReference = null)
            /// <summary>
            /// This method is used to delete ProjectReference objects.
            /// </summary>
            /// <param name="referencesId">Delete the ProjectReference with this referencesId</param>
            /// <param name="tempProjectReference">Pass in a tempProjectReference to perform a custom delete.</param>
            public bool DeleteProjectReference(int referencesId, ProjectReference tempProjectReference = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempProjectReference does not exist
                    if (tempProjectReference == null)
                    {
                        // create a temp ProjectReference
                        tempProjectReference = new ProjectReference();
                    }
        
                    // if the referencesId is set
                    if (referencesId > 0)
                    {
                        // set the primary key
                        tempProjectReference.UpdateIdentity(referencesId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.ProjectReferenceController.Delete(tempProjectReference);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteReferencesSet(int referencesSetId, ReferencesSet tempReferencesSet = null)
            /// <summary>
            /// This method is used to delete ReferencesSet objects.
            /// </summary>
            /// <param name="referencesSetId">Delete the ReferencesSet with this referencesSetId</param>
            /// <param name="tempReferencesSet">Pass in a tempReferencesSet to perform a custom delete.</param>
            public bool DeleteReferencesSet(int referencesSetId, ReferencesSet tempReferencesSet = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempReferencesSet does not exist
                    if (tempReferencesSet == null)
                    {
                        // create a temp ReferencesSet
                        tempReferencesSet = new ReferencesSet();
                    }
        
                    // if the referencesSetId is set
                    if (referencesSetId > 0)
                    {
                        // set the primary key
                        tempReferencesSet.UpdateIdentity(referencesSetId);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.ReferencesSetController.Delete(tempReferencesSet);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteUIControlDetail(int id, UIControlDetail tempUIControlDetail = null)
            /// <summary>
            /// This method is used to delete UIControlDetail objects.
            /// </summary>
            /// <param name="id">Delete the UIControlDetail with this id</param>
            /// <param name="tempUIControlDetail">Pass in a tempUIControlDetail to perform a custom delete.</param>
            public bool DeleteUIControlDetail(int id, UIControlDetail tempUIControlDetail = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempUIControlDetail does not exist
                    if (tempUIControlDetail == null)
                    {
                        // create a temp UIControlDetail
                        tempUIControlDetail = new UIControlDetail();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempUIControlDetail.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.UIControlDetailController.Delete(tempUIControlDetail);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteUIControlTemplate(int id, UIControlTemplate tempUIControlTemplate = null)
            /// <summary>
            /// This method is used to delete UIControlTemplate objects.
            /// </summary>
            /// <param name="id">Delete the UIControlTemplate with this id</param>
            /// <param name="tempUIControlTemplate">Pass in a tempUIControlTemplate to perform a custom delete.</param>
            public bool DeleteUIControlTemplate(int id, UIControlTemplate tempUIControlTemplate = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempUIControlTemplate does not exist
                    if (tempUIControlTemplate == null)
                    {
                        // create a temp UIControlTemplate
                        tempUIControlTemplate = new UIControlTemplate();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempUIControlTemplate.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.UIControlTemplateController.Delete(tempUIControlTemplate);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteUIField(int id, UIField tempUIField = null)
            /// <summary>
            /// This method is used to delete UIField objects.
            /// </summary>
            /// <param name="id">Delete the UIField with this id</param>
            /// <param name="tempUIField">Pass in a tempUIField to perform a custom delete.</param>
            public bool DeleteUIField(int id, UIField tempUIField = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempUIField does not exist
                    if (tempUIField == null)
                    {
                        // create a temp UIField
                        tempUIField = new UIField();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempUIField.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.UIFieldController.Delete(tempUIField);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteUIObject(int id, UIObject tempUIObject = null)
            /// <summary>
            /// This method is used to delete UIObject objects.
            /// </summary>
            /// <param name="id">Delete the UIObject with this id</param>
            /// <param name="tempUIObject">Pass in a tempUIObject to perform a custom delete.</param>
            public bool DeleteUIObject(int id, UIObject tempUIObject = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempUIObject does not exist
                    if (tempUIObject == null)
                    {
                        // create a temp UIObject
                        tempUIObject = new UIObject();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempUIObject.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.UIObjectController.Delete(tempUIObject);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteUIProject(int id, UIProject tempUIProject = null)
            /// <summary>
            /// This method is used to delete UIProject objects.
            /// </summary>
            /// <param name="id">Delete the UIProject with this id</param>
            /// <param name="tempUIProject">Pass in a tempUIProject to perform a custom delete.</param>
            public bool DeleteUIProject(int id, UIProject tempUIProject = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempUIProject does not exist
                    if (tempUIProject == null)
                    {
                        // create a temp UIProject
                        tempUIProject = new UIProject();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempUIProject.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.UIProjectController.Delete(tempUIProject);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region DeleteUserInterface(int id, UserInterface tempUserInterface = null)
            /// <summary>
            /// This method is used to delete UserInterface objects.
            /// </summary>
            /// <param name="id">Delete the UserInterface with this id</param>
            /// <param name="tempUserInterface">Pass in a tempUserInterface to perform a custom delete.</param>
            public bool DeleteUserInterface(int id, UserInterface tempUserInterface = null)
            {
                // initial value
                bool deleted = false;
        
                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempUserInterface does not exist
                    if (tempUserInterface == null)
                    {
                        // create a temp UserInterface
                        tempUserInterface = new UserInterface();
                    }
        
                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempUserInterface.UpdateIdentity(id);
                    }
        
                    // perform the delete
                    deleted = this.AppController.ControllerManager.UserInterfaceController.Delete(tempUserInterface);
                }
        
                // return value
                return deleted;
            }
            #endregion
        
            #region ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            /// <summary>
            /// This method Executes a Non Query StoredProcedure
            /// </summary>
            public PolymorphicObject ExecuteNonQuery(string procedureName, SqlParameter[] sqlParameters)
            {
                // initial value
                PolymorphicObject returnValue = new PolymorphicObject();

                // locals
                List<PolymorphicObject> parameters = new List<PolymorphicObject>();

                // create the parameters
                PolymorphicObject procedureNameParameter = new PolymorphicObject();
                PolymorphicObject sqlParametersParameter = new PolymorphicObject();

                // if the procedureName exists
                if (!String.IsNullOrEmpty(procedureName))
                {
                    // Create an instance of the SystemMethods object
                    SystemMethods systemMethods = new SystemMethods();

                    // setup procedureNameParameter
                    procedureNameParameter.Name = "ProcedureName";
                    procedureNameParameter.Text = procedureName;

                    // setup sqlParametersParameter
                    sqlParametersParameter.Name = "SqlParameters";
                    sqlParametersParameter.ObjectValue = sqlParameters;

                    // Add these parameters to the parameters
                    parameters.Add(procedureNameParameter);
                    parameters.Add(sqlParametersParameter);

                    // get the dataConnector
                    DataAccessComponent.DataManager.DataConnector dataConnector = GetDataConnector();

                    // Execute the query
                    returnValue = systemMethods.ExecuteNonQuery(parameters, dataConnector);
                }

                // return value
                return returnValue;
            }
            #endregion

            #region FindAdmin(int adminId, Admin tempAdmin = null)
            /// <summary>
            /// This method is used to find 'Admin' objects.
            /// </summary>
            /// <param name="adminId">Find the Admin with this adminId</param>
            /// <param name="tempAdmin">Pass in a tempAdmin to perform a custom find.</param>
            public Admin FindAdmin(int adminId, Admin tempAdmin = null)
            {
                // initial value
                Admin admin = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempAdmin does not exist
                    if (tempAdmin == null)
                    {
                        // create a temp Admin
                        tempAdmin = new Admin();
                    }

                    // if the adminId is set
                    if (adminId > 0)
                    {
                        // set the primary key
                        tempAdmin.UpdateIdentity(adminId);
                    }

                    // perform the find
                    admin = this.AppController.ControllerManager.AdminController.Find(tempAdmin);
                }

                // return value
                return admin;
            }
            #endregion

            #region FindControlInfo(int id, ControlInfo tempControlInfo = null)
            /// <summary>
            /// This method is used to find 'ControlInfo' objects.
            /// </summary>
            /// <param name="id">Find the ControlInfo with this id</param>
            /// <param name="tempControlInfo">Pass in a tempControlInfo to perform a custom find.</param>
            public ControlInfo FindControlInfo(int id, ControlInfo tempControlInfo = null)
            {
                // initial value
                ControlInfo controlInfo = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempControlInfo does not exist
                    if (tempControlInfo == null)
                    {
                        // create a temp ControlInfo
                        tempControlInfo = new ControlInfo();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempControlInfo.UpdateIdentity(id);
                    }

                    // perform the find
                    controlInfo = this.AppController.ControllerManager.ControlInfoController.Find(tempControlInfo);
                }

                // return value
                return controlInfo;
            }
            #endregion

            #region FindControlInfoDetail(int id, ControlInfoDetail tempControlInfoDetail = null)
            /// <summary>
            /// This method is used to find 'ControlInfoDetail' objects.
            /// </summary>
            /// <param name="id">Find the ControlInfoDetail with this id</param>
            /// <param name="tempControlInfoDetail">Pass in a tempControlInfoDetail to perform a custom find.</param>
            public ControlInfoDetail FindControlInfoDetail(int id, ControlInfoDetail tempControlInfoDetail = null)
            {
                // initial value
                ControlInfoDetail controlInfoDetail = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempControlInfoDetail does not exist
                    if (tempControlInfoDetail == null)
                    {
                        // create a temp ControlInfoDetail
                        tempControlInfoDetail = new ControlInfoDetail();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempControlInfoDetail.UpdateIdentity(id);
                    }

                    // perform the find
                    controlInfoDetail = this.AppController.ControllerManager.ControlInfoDetailController.Find(tempControlInfoDetail);
                }

                // return value
                return controlInfoDetail;
            }
            #endregion

            #region FindCustomReader(int customReaderId, CustomReader tempCustomReader = null)
            /// <summary>
            /// This method is used to find 'CustomReader' objects.
            /// </summary>
            /// <param name="customReaderId">Find the CustomReader with this customReaderId</param>
            /// <param name="tempCustomReader">Pass in a tempCustomReader to perform a custom find.</param>
            public CustomReader FindCustomReader(int customReaderId, CustomReader tempCustomReader = null)
            {
                // initial value
                CustomReader customReader = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempCustomReader does not exist
                    if (tempCustomReader == null)
                    {
                        // create a temp CustomReader
                        tempCustomReader = new CustomReader();
                    }

                    // if the customReaderId is set
                    if (customReaderId > 0)
                    {
                        // set the primary key
                        tempCustomReader.UpdateIdentity(customReaderId);
                    }

                    // perform the find
                    customReader = this.AppController.ControllerManager.CustomReaderController.Find(tempCustomReader);
                }

                // return value
                return customReader;
            }
            #endregion

            #region FindDTNDatabase(int databaseId, DTNDatabase tempDTNDatabase = null)
            /// <summary>
            /// This method is used to find 'DTNDatabase' objects.
            /// </summary>
            /// <param name="databaseId">Find the DTNDatabase with this databaseId</param>
            /// <param name="tempDTNDatabase">Pass in a tempDTNDatabase to perform a custom find.</param>
            public DTNDatabase FindDTNDatabase(int databaseId, DTNDatabase tempDTNDatabase = null)
            {
                // initial value
                DTNDatabase dTNDatabase = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempDTNDatabase does not exist
                    if (tempDTNDatabase == null)
                    {
                        // create a temp DTNDatabase
                        tempDTNDatabase = new DTNDatabase();
                    }

                    // if the databaseId is set
                    if (databaseId > 0)
                    {
                        // set the primary key
                        tempDTNDatabase.UpdateIdentity(databaseId);
                    }

                    // perform the find
                    dTNDatabase = this.AppController.ControllerManager.DTNDatabaseController.Find(tempDTNDatabase);
                }

                // return value
                return dTNDatabase;
            }
            #endregion

            #region FindDTNField(int fieldId, DTNField tempDTNField = null)
            /// <summary>
            /// This method is used to find 'DTNField' objects.
            /// </summary>
            /// <param name="fieldId">Find the DTNField with this fieldId</param>
            /// <param name="tempDTNField">Pass in a tempDTNField to perform a custom find.</param>
            public DTNField FindDTNField(int fieldId, DTNField tempDTNField = null)
            {
                // initial value
                DTNField dTNField = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempDTNField does not exist
                    if (tempDTNField == null)
                    {
                        // create a temp DTNField
                        tempDTNField = new DTNField();
                    }

                    // if the fieldId is set
                    if (fieldId > 0)
                    {
                        // set the primary key
                        tempDTNField.UpdateIdentity(fieldId);
                    }

                    // perform the find
                    dTNField = this.AppController.ControllerManager.DTNFieldController.Find(tempDTNField);
                }

                // return value
                return dTNField;
            }
            #endregion

            #region FindDTNProcedure(int procedureId, DTNProcedure tempDTNProcedure = null)
            /// <summary>
            /// This method is used to find 'DTNProcedure' objects.
            /// </summary>
            /// <param name="procedureId">Find the DTNProcedure with this procedureId</param>
            /// <param name="tempDTNProcedure">Pass in a tempDTNProcedure to perform a custom find.</param>
            public DTNProcedure FindDTNProcedure(int procedureId, DTNProcedure tempDTNProcedure = null)
            {
                // initial value
                DTNProcedure dTNProcedure = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempDTNProcedure does not exist
                    if (tempDTNProcedure == null)
                    {
                        // create a temp DTNProcedure
                        tempDTNProcedure = new DTNProcedure();
                    }

                    // if the procedureId is set
                    if (procedureId > 0)
                    {
                        // set the primary key
                        tempDTNProcedure.UpdateIdentity(procedureId);
                    }

                    // perform the find
                    dTNProcedure = this.AppController.ControllerManager.DTNProcedureController.Find(tempDTNProcedure);
                }

                // return value
                return dTNProcedure;
            }
            #endregion

            #region FindDTNTable(int tableId, DTNTable tempDTNTable = null)
            /// <summary>
            /// This method is used to find 'DTNTable' objects.
            /// </summary>
            /// <param name="tableId">Find the DTNTable with this tableId</param>
            /// <param name="tempDTNTable">Pass in a tempDTNTable to perform a custom find.</param>
            public DTNTable FindDTNTable(int tableId, DTNTable tempDTNTable = null)
            {
                // initial value
                DTNTable dTNTable = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempDTNTable does not exist
                    if (tempDTNTable == null)
                    {
                        // create a temp DTNTable
                        tempDTNTable = new DTNTable();
                    }

                    // if the tableId is set
                    if (tableId > 0)
                    {
                        // set the primary key
                        tempDTNTable.UpdateIdentity(tableId);
                    }

                    // perform the find
                    dTNTable = this.AppController.ControllerManager.DTNTableController.Find(tempDTNTable);
                }

                // return value
                return dTNTable;
            }
            #endregion

            #region FindEnumeration(int enumerationId, Enumeration tempEnumeration = null)
            /// <summary>
            /// This method is used to find 'Enumeration' objects.
            /// </summary>
            /// <param name="enumerationId">Find the Enumeration with this enumerationId</param>
            /// <param name="tempEnumeration">Pass in a tempEnumeration to perform a custom find.</param>
            public Enumeration FindEnumeration(int enumerationId, Enumeration tempEnumeration = null)
            {
                // initial value
                Enumeration enumeration = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempEnumeration does not exist
                    if (tempEnumeration == null)
                    {
                        // create a temp Enumeration
                        tempEnumeration = new Enumeration();
                    }

                    // if the enumerationId is set
                    if (enumerationId > 0)
                    {
                        // set the primary key
                        tempEnumeration.UpdateIdentity(enumerationId);
                    }

                    // perform the find
                    enumeration = this.AppController.ControllerManager.EnumerationController.Find(tempEnumeration);
                }

                // return value
                return enumeration;
            }
            #endregion

            #region FindFieldSet(int fieldSetId, FieldSet tempFieldSet = null)
            /// <summary>
            /// This method is used to find 'FieldSet' objects.
            /// </summary>
            /// <param name="fieldSetId">Find the FieldSet with this fieldSetId</param>
            /// <param name="tempFieldSet">Pass in a tempFieldSet to perform a custom find.</param>
            public FieldSet FindFieldSet(int fieldSetId, FieldSet tempFieldSet = null)
            {
                // initial value
                FieldSet fieldSet = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempFieldSet does not exist
                    if (tempFieldSet == null)
                    {
                        // create a temp FieldSet
                        tempFieldSet = new FieldSet();
                    }

                    // if the fieldSetId is set
                    if (fieldSetId > 0)
                    {
                        // set the primary key
                        tempFieldSet.UpdateIdentity(fieldSetId);
                    }

                    // perform the find
                    fieldSet = this.AppController.ControllerManager.FieldSetController.Find(tempFieldSet);
                }

                // return value
                return fieldSet;
            }
            #endregion

            #region FindFieldSetField(int fieldSetFieldId, FieldSetField tempFieldSetField = null)
            /// <summary>
            /// This method is used to find 'FieldSetField' objects.
            /// </summary>
            /// <param name="fieldSetFieldId">Find the FieldSetField with this fieldSetFieldId</param>
            /// <param name="tempFieldSetField">Pass in a tempFieldSetField to perform a custom find.</param>
            public FieldSetField FindFieldSetField(int fieldSetFieldId, FieldSetField tempFieldSetField = null)
            {
                // initial value
                FieldSetField fieldSetField = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempFieldSetField does not exist
                    if (tempFieldSetField == null)
                    {
                        // create a temp FieldSetField
                        tempFieldSetField = new FieldSetField();
                    }

                    // if the fieldSetFieldId is set
                    if (fieldSetFieldId > 0)
                    {
                        // set the primary key
                        tempFieldSetField.UpdateIdentity(fieldSetFieldId);
                    }

                    // perform the find
                    fieldSetField = this.AppController.ControllerManager.FieldSetFieldController.Find(tempFieldSetField);
                }

                // return value
                return fieldSetField;
            }
            #endregion

            #region FindMethod(int methodId, Method tempMethod = null)
            /// <summary>
            /// This method is used to find 'Method' objects.
            /// </summary>
            /// <param name="methodId">Find the Method with this methodId</param>
            /// <param name="tempMethod">Pass in a tempMethod to perform a custom find.</param>
            public Method FindMethod(int methodId, Method tempMethod = null)
            {
                // initial value
                Method method = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempMethod does not exist
                    if (tempMethod == null)
                    {
                        // create a temp Method
                        tempMethod = new Method();
                    }

                    // if the methodId is set
                    if (methodId > 0)
                    {
                        // set the primary key
                        tempMethod.UpdateIdentity(methodId);
                    }

                    // perform the find
                    method = this.AppController.ControllerManager.MethodController.Find(tempMethod);
                }

                // return value
                return method;
            }
            #endregion

            #region FindProject(int projectId, Project tempProject = null)
            /// <summary>
            /// This method is used to find 'Project' objects.
            /// </summary>
            /// <param name="projectId">Find the Project with this projectId</param>
            /// <param name="tempProject">Pass in a tempProject to perform a custom find.</param>
            public Project FindProject(int projectId, Project tempProject = null)
            {
                // initial value
                Project project = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempProject does not exist
                    if (tempProject == null)
                    {
                        // create a temp Project
                        tempProject = new Project();
                    }

                    // if the projectId is set
                    if (projectId > 0)
                    {
                        // set the primary key
                        tempProject.UpdateIdentity(projectId);
                    }

                    // perform the find
                    project = this.AppController.ControllerManager.ProjectController.Find(tempProject);
                }

                // return value
                return project;
            }
            #endregion

            #region FindProjectReference(int referencesId, ProjectReference tempProjectReference = null)
            /// <summary>
            /// This method is used to find 'ProjectReference' objects.
            /// </summary>
            /// <param name="referencesId">Find the ProjectReference with this referencesId</param>
            /// <param name="tempProjectReference">Pass in a tempProjectReference to perform a custom find.</param>
            public ProjectReference FindProjectReference(int referencesId, ProjectReference tempProjectReference = null)
            {
                // initial value
                ProjectReference projectReference = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempProjectReference does not exist
                    if (tempProjectReference == null)
                    {
                        // create a temp ProjectReference
                        tempProjectReference = new ProjectReference();
                    }

                    // if the referencesId is set
                    if (referencesId > 0)
                    {
                        // set the primary key
                        tempProjectReference.UpdateIdentity(referencesId);
                    }

                    // perform the find
                    projectReference = this.AppController.ControllerManager.ProjectReferenceController.Find(tempProjectReference);
                }

                // return value
                return projectReference;
            }
            #endregion

            #region FindReferencesSet(int referencesSetId, ReferencesSet tempReferencesSet = null)
            /// <summary>
            /// This method is used to find 'ReferencesSet' objects.
            /// </summary>
            /// <param name="referencesSetId">Find the ReferencesSet with this referencesSetId</param>
            /// <param name="tempReferencesSet">Pass in a tempReferencesSet to perform a custom find.</param>
            public ReferencesSet FindReferencesSet(int referencesSetId, ReferencesSet tempReferencesSet = null)
            {
                // initial value
                ReferencesSet referencesSet = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempReferencesSet does not exist
                    if (tempReferencesSet == null)
                    {
                        // create a temp ReferencesSet
                        tempReferencesSet = new ReferencesSet();
                    }

                    // if the referencesSetId is set
                    if (referencesSetId > 0)
                    {
                        // set the primary key
                        tempReferencesSet.UpdateIdentity(referencesSetId);
                    }

                    // perform the find
                    referencesSet = this.AppController.ControllerManager.ReferencesSetController.Find(tempReferencesSet);
                }

                // return value
                return referencesSet;
            }
            #endregion

            #region FindUIControlDetail(int id, UIControlDetail tempUIControlDetail = null)
            /// <summary>
            /// This method is used to find 'UIControlDetail' objects.
            /// </summary>
            /// <param name="id">Find the UIControlDetail with this id</param>
            /// <param name="tempUIControlDetail">Pass in a tempUIControlDetail to perform a custom find.</param>
            public UIControlDetail FindUIControlDetail(int id, UIControlDetail tempUIControlDetail = null)
            {
                // initial value
                UIControlDetail uIControlDetail = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempUIControlDetail does not exist
                    if (tempUIControlDetail == null)
                    {
                        // create a temp UIControlDetail
                        tempUIControlDetail = new UIControlDetail();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempUIControlDetail.UpdateIdentity(id);
                    }

                    // perform the find
                    uIControlDetail = this.AppController.ControllerManager.UIControlDetailController.Find(tempUIControlDetail);
                }

                // return value
                return uIControlDetail;
            }
            #endregion

            #region FindUIControlTemplate(int id, UIControlTemplate tempUIControlTemplate = null)
            /// <summary>
            /// This method is used to find 'UIControlTemplate' objects.
            /// </summary>
            /// <param name="id">Find the UIControlTemplate with this id</param>
            /// <param name="tempUIControlTemplate">Pass in a tempUIControlTemplate to perform a custom find.</param>
            public UIControlTemplate FindUIControlTemplate(int id, UIControlTemplate tempUIControlTemplate = null)
            {
                // initial value
                UIControlTemplate uIControlTemplate = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempUIControlTemplate does not exist
                    if (tempUIControlTemplate == null)
                    {
                        // create a temp UIControlTemplate
                        tempUIControlTemplate = new UIControlTemplate();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempUIControlTemplate.UpdateIdentity(id);
                    }

                    // perform the find
                    uIControlTemplate = this.AppController.ControllerManager.UIControlTemplateController.Find(tempUIControlTemplate);
                }

                // return value
                return uIControlTemplate;
            }
            #endregion

            #region FindUIField(int id, UIField tempUIField = null)
            /// <summary>
            /// This method is used to find 'UIField' objects.
            /// </summary>
            /// <param name="id">Find the UIField with this id</param>
            /// <param name="tempUIField">Pass in a tempUIField to perform a custom find.</param>
            public UIField FindUIField(int id, UIField tempUIField = null)
            {
                // initial value
                UIField uIField = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempUIField does not exist
                    if (tempUIField == null)
                    {
                        // create a temp UIField
                        tempUIField = new UIField();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempUIField.UpdateIdentity(id);
                    }

                    // perform the find
                    uIField = this.AppController.ControllerManager.UIFieldController.Find(tempUIField);
                }

                // return value
                return uIField;
            }
            #endregion

            #region FindUIObject(int id, UIObject tempUIObject = null)
            /// <summary>
            /// This method is used to find 'UIObject' objects.
            /// </summary>
            /// <param name="id">Find the UIObject with this id</param>
            /// <param name="tempUIObject">Pass in a tempUIObject to perform a custom find.</param>
            public UIObject FindUIObject(int id, UIObject tempUIObject = null)
            {
                // initial value
                UIObject uIObject = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempUIObject does not exist
                    if (tempUIObject == null)
                    {
                        // create a temp UIObject
                        tempUIObject = new UIObject();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempUIObject.UpdateIdentity(id);
                    }

                    // perform the find
                    uIObject = this.AppController.ControllerManager.UIObjectController.Find(tempUIObject);
                }

                // return value
                return uIObject;
            }
            #endregion

            #region FindUIProject(int id, UIProject tempUIProject = null)
            /// <summary>
            /// This method is used to find 'UIProject' objects.
            /// </summary>
            /// <param name="id">Find the UIProject with this id</param>
            /// <param name="tempUIProject">Pass in a tempUIProject to perform a custom find.</param>
            public UIProject FindUIProject(int id, UIProject tempUIProject = null)
            {
                // initial value
                UIProject uIProject = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempUIProject does not exist
                    if (tempUIProject == null)
                    {
                        // create a temp UIProject
                        tempUIProject = new UIProject();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempUIProject.UpdateIdentity(id);
                    }

                    // perform the find
                    uIProject = this.AppController.ControllerManager.UIProjectController.Find(tempUIProject);
                }

                // return value
                return uIProject;
            }
            #endregion

            #region FindUserInterface(int id, UserInterface tempUserInterface = null)
            /// <summary>
            /// This method is used to find 'UserInterface' objects.
            /// </summary>
            /// <param name="id">Find the UserInterface with this id</param>
            /// <param name="tempUserInterface">Pass in a tempUserInterface to perform a custom find.</param>
            public UserInterface FindUserInterface(int id, UserInterface tempUserInterface = null)
            {
                // initial value
                UserInterface userInterface = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // if the tempUserInterface does not exist
                    if (tempUserInterface == null)
                    {
                        // create a temp UserInterface
                        tempUserInterface = new UserInterface();
                    }

                    // if the id is set
                    if (id > 0)
                    {
                        // set the primary key
                        tempUserInterface.UpdateIdentity(id);
                    }

                    // perform the find
                    userInterface = this.AppController.ControllerManager.UserInterfaceController.Find(tempUserInterface);
                }

                // return value
                return userInterface;
            }
            #endregion

            #region GetDataConnector()
            /// <summary>
            /// This method (safely) returns the Data Connector from the
            /// AppController.DataBridget.DataManager.DataConnector
            /// </summary>
            private DataConnector GetDataConnector()
            {
                // initial value
                DataConnector dataConnector = null;

                // if the AppController exists
                if (this.AppController != null)
                {
                    // return the DataConnector from the AppController
                    dataConnector = this.AppController.GetDataConnector();
                }

                // return value
                return dataConnector;
            }
            #endregion

            #region GetLastException()
            /// <summary>
            /// This method returns the last Exception from the AppController if one exists.
            /// Always test for null before refeferencing the Exception returned as it will be null 
            /// if no errors were encountered.
            /// </summary>
            /// <returns></returns>
            public Exception GetLastException()
            {
                // initial value
                Exception exception = null;

                // If the AppController object exists
                if (this.HasAppController)
                {
                    // return the Exception from the AppController
                    exception = this.AppController.Exception;

                    // Set to null after the exception is retrieved so it does not return again
                    this.AppController.Exception = null;
                }

                // return value
                return exception;
            }
            #endregion

            #region Init()
            /// <summary>
            /// Perform Initializations for this object.
            /// </summary>
            private void Init()
            {
                // Create Application Controller
                this.AppController = new ApplicationController(ConnectionName);
            }
            #endregion

            #region LoadAdmins(Admin tempAdmin = null)
            /// <summary>
            /// This method loads a collection of 'Admin' objects.
            /// </summary>
            public List<Admin> LoadAdmins(Admin tempAdmin = null)
            {
                // initial value
                List<Admin> admins = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    admins = this.AppController.ControllerManager.AdminController.FetchAll(tempAdmin);
                }

                // return value
                return admins;
            }
            #endregion

            #region LoadControlInfoDetails(ControlInfoDetail tempControlInfoDetail = null)
            /// <summary>
            /// This method loads a collection of 'ControlInfoDetail' objects.
            /// </summary>
            public List<ControlInfoDetail> LoadControlInfoDetails(ControlInfoDetail tempControlInfoDetail = null)
            {
                // initial value
                List<ControlInfoDetail> controlInfoDetails = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    controlInfoDetails = this.AppController.ControllerManager.ControlInfoDetailController.FetchAll(tempControlInfoDetail);
                }

                // return value
                return controlInfoDetails;
            }
            #endregion

            #region LoadControlInfos(ControlInfo tempControlInfo = null)
            /// <summary>
            /// This method loads a collection of 'ControlInfo' objects.
            /// </summary>
            public List<ControlInfo> LoadControlInfos(ControlInfo tempControlInfo = null)
            {
                // initial value
                List<ControlInfo> controlInfos = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    controlInfos = this.AppController.ControllerManager.ControlInfoController.FetchAll(tempControlInfo);
                }

                // return value
                return controlInfos;
            }
            #endregion

            #region LoadCustomReaders(CustomReader tempCustomReader = null)
            /// <summary>
            /// This method loads a collection of 'CustomReader' objects.
            /// </summary>
            public List<CustomReader> LoadCustomReaders(CustomReader tempCustomReader = null)
            {
                // initial value
                List<CustomReader> customReaders = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    customReaders = this.AppController.ControllerManager.CustomReaderController.FetchAll(tempCustomReader);
                }

                // return value
                return customReaders;
            }
            #endregion

            #region LoadDTNDatabases(DTNDatabase tempDTNDatabase = null)
            /// <summary>
            /// This method loads a collection of 'DTNDatabase' objects.
            /// </summary>
            public List<DTNDatabase> LoadDTNDatabases(DTNDatabase tempDTNDatabase = null)
            {
                // initial value
                List<DTNDatabase> dTNDatabases = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    dTNDatabases = this.AppController.ControllerManager.DTNDatabaseController.FetchAll(tempDTNDatabase);
                }

                // return value
                return dTNDatabases;
            }
            #endregion

            #region LoadDTNFields(DTNField tempDTNField = null)
            /// <summary>
            /// This method loads a collection of 'DTNField' objects.
            /// </summary>
            public List<DTNField> LoadDTNFields(DTNField tempDTNField = null)
            {
                // initial value
                List<DTNField> dTNFields = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    dTNFields = this.AppController.ControllerManager.DTNFieldController.FetchAll(tempDTNField);
                }

                // return value
                return dTNFields;
            }
            #endregion

            #region LoadDTNProcedures(DTNProcedure tempDTNProcedure = null)
            /// <summary>
            /// This method loads a collection of 'DTNProcedure' objects.
            /// </summary>
            public List<DTNProcedure> LoadDTNProcedures(DTNProcedure tempDTNProcedure = null)
            {
                // initial value
                List<DTNProcedure> dTNProcedures = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    dTNProcedures = this.AppController.ControllerManager.DTNProcedureController.FetchAll(tempDTNProcedure);
                }

                // return value
                return dTNProcedures;
            }
            #endregion

            #region LoadDTNTables(DTNTable tempDTNTable = null)
            /// <summary>
            /// This method loads a collection of 'DTNTable' objects.
            /// </summary>
            public List<DTNTable> LoadDTNTables(DTNTable tempDTNTable = null)
            {
                // initial value
                List<DTNTable> dTNTables = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    dTNTables = this.AppController.ControllerManager.DTNTableController.FetchAll(tempDTNTable);
                }

                // return value
                return dTNTables;
            }
            #endregion

            #region LoadEnumerations(Enumeration tempEnumeration = null)
            /// <summary>
            /// This method loads a collection of 'Enumeration' objects.
            /// </summary>
            public List<Enumeration> LoadEnumerations(Enumeration tempEnumeration = null)
            {
                // initial value
                List<Enumeration> enumerations = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    enumerations = this.AppController.ControllerManager.EnumerationController.FetchAll(tempEnumeration);
                }

                // return value
                return enumerations;
            }
            #endregion

            #region LoadFieldSetFields(FieldSetField tempFieldSetField = null)
            /// <summary>
            /// This method loads a collection of 'FieldSetField' objects.
            /// </summary>
            public List<FieldSetField> LoadFieldSetFields(FieldSetField tempFieldSetField = null)
            {
                // initial value
                List<FieldSetField> fieldSetFields = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    fieldSetFields = this.AppController.ControllerManager.FieldSetFieldController.FetchAll(tempFieldSetField);
                }

                // return value
                return fieldSetFields;
            }
            #endregion

            #region LoadFieldSetFieldViews(FieldSetFieldView tempFieldSetFieldView = null)
            /// <summary>
            /// This method loads a collection of 'FieldSetFieldView' objects.
            /// </summary>
            public List<FieldSetFieldView> LoadFieldSetFieldViews(FieldSetFieldView tempFieldSetFieldView = null)
            {
                // initial value
                List<FieldSetFieldView> fieldSetFieldViews = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    fieldSetFieldViews = this.AppController.ControllerManager.FieldSetFieldViewController.FetchAll(tempFieldSetFieldView);
                }

                // return value
                return fieldSetFieldViews;
            }
            #endregion

            #region LoadFieldSets(FieldSet tempFieldSet = null)
            /// <summary>
            /// This method loads a collection of 'FieldSet' objects.
            /// </summary>
            public List<FieldSet> LoadFieldSets(FieldSet tempFieldSet = null)
            {
                // initial value
                List<FieldSet> fieldSets = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    fieldSets = this.AppController.ControllerManager.FieldSetController.FetchAll(tempFieldSet);
                }

                // return value
                return fieldSets;
            }
            #endregion

            #region LoadFieldViews(FieldView tempFieldView = null)
            /// <summary>
            /// This method loads a collection of 'FieldView' objects.
            /// </summary>
            public List<FieldView> LoadFieldViews(FieldView tempFieldView = null)
            {
                // initial value
                List<FieldView> fieldViews = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    fieldViews = this.AppController.ControllerManager.FieldViewController.FetchAll(tempFieldView);
                }

                // return value
                return fieldViews;
            }
            #endregion

            #region LoadMethods(Method tempMethod = null)
            /// <summary>
            /// This method loads a collection of 'Method' objects.
            /// </summary>
            public List<Method> LoadMethods(Method tempMethod = null)
            {
                // initial value
                List<Method> methods = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    methods = this.AppController.ControllerManager.MethodController.FetchAll(tempMethod);
                }

                // return value
                return methods;
            }
            #endregion

            #region LoadProjectReferences(ProjectReference tempProjectReference = null)
            /// <summary>
            /// This method loads a collection of 'ProjectReference' objects.
            /// </summary>
            public List<ProjectReference> LoadProjectReferences(ProjectReference tempProjectReference = null)
            {
                // initial value
                List<ProjectReference> projectReferences = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    projectReferences = this.AppController.ControllerManager.ProjectReferenceController.FetchAll(tempProjectReference);
                }

                // return value
                return projectReferences;
            }
            #endregion

            #region LoadProjectReferencesViews(ProjectReferencesView tempProjectReferencesView = null)
            /// <summary>
            /// This method loads a collection of 'ProjectReferencesView' objects.
            /// </summary>
            public List<ProjectReferencesView> LoadProjectReferencesViews(ProjectReferencesView tempProjectReferencesView = null)
            {
                // initial value
                List<ProjectReferencesView> projectReferencesViews = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    projectReferencesViews = this.AppController.ControllerManager.ProjectReferencesViewController.FetchAll(tempProjectReferencesView);
                }

                // return value
                return projectReferencesViews;
            }
            #endregion

            #region LoadProjects(Project tempProject = null)
            /// <summary>
            /// This method loads a collection of 'Project' objects.
            /// </summary>
            public List<Project> LoadProjects(Project tempProject = null)
            {
                // initial value
                List<Project> projects = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    projects = this.AppController.ControllerManager.ProjectController.FetchAll(tempProject);
                }

                // return value
                return projects;
            }
            #endregion

            #region LoadReferencesSets(ReferencesSet tempReferencesSet = null)
            /// <summary>
            /// This method loads a collection of 'ReferencesSet' objects.
            /// </summary>
            public List<ReferencesSet> LoadReferencesSets(ReferencesSet tempReferencesSet = null)
            {
                // initial value
                List<ReferencesSet> referencesSets = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    referencesSets = this.AppController.ControllerManager.ReferencesSetController.FetchAll(tempReferencesSet);
                }

                // return value
                return referencesSets;
            }
            #endregion

            #region LoadUIControlDetails(UIControlDetail tempUIControlDetail = null)
            /// <summary>
            /// This method loads a collection of 'UIControlDetail' objects.
            /// </summary>
            public List<UIControlDetail> LoadUIControlDetails(UIControlDetail tempUIControlDetail = null)
            {
                // initial value
                List<UIControlDetail> uIControlDetails = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    uIControlDetails = this.AppController.ControllerManager.UIControlDetailController.FetchAll(tempUIControlDetail);
                }

                // return value
                return uIControlDetails;
            }
            #endregion

            #region LoadUIControlTemplates(UIControlTemplate tempUIControlTemplate = null)
            /// <summary>
            /// This method loads a collection of 'UIControlTemplate' objects.
            /// </summary>
            public List<UIControlTemplate> LoadUIControlTemplates(UIControlTemplate tempUIControlTemplate = null)
            {
                // initial value
                List<UIControlTemplate> uIControlTemplates = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    uIControlTemplates = this.AppController.ControllerManager.UIControlTemplateController.FetchAll(tempUIControlTemplate);
                }

                // return value
                return uIControlTemplates;
            }
            #endregion

            #region LoadUIFields(UIField tempUIField = null)
            /// <summary>
            /// This method loads a collection of 'UIField' objects.
            /// </summary>
            public List<UIField> LoadUIFields(UIField tempUIField = null)
            {
                // initial value
                List<UIField> uIFields = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    uIFields = this.AppController.ControllerManager.UIFieldController.FetchAll(tempUIField);
                }

                // return value
                return uIFields;
            }
            #endregion

            #region LoadUIObjects(UIObject tempUIObject = null)
            /// <summary>
            /// This method loads a collection of 'UIObject' objects.
            /// </summary>
            public List<UIObject> LoadUIObjects(UIObject tempUIObject = null)
            {
                // initial value
                List<UIObject> uIObjects = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    uIObjects = this.AppController.ControllerManager.UIObjectController.FetchAll(tempUIObject);
                }

                // return value
                return uIObjects;
            }
            #endregion

            #region LoadUIProjects(UIProject tempUIProject = null)
            /// <summary>
            /// This method loads a collection of 'UIProject' objects.
            /// </summary>
            public List<UIProject> LoadUIProjects(UIProject tempUIProject = null)
            {
                // initial value
                List<UIProject> uIProjects = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    uIProjects = this.AppController.ControllerManager.UIProjectController.FetchAll(tempUIProject);
                }

                // return value
                return uIProjects;
            }
            #endregion

            #region LoadUserInterfaces(UserInterface tempUserInterface = null)
            /// <summary>
            /// This method loads a collection of 'UserInterface' objects.
            /// </summary>
            public List<UserInterface> LoadUserInterfaces(UserInterface tempUserInterface = null)
            {
                // initial value
                List<UserInterface> userInterfaces = null;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the load
                    userInterfaces = this.AppController.ControllerManager.UserInterfaceController.FetchAll(tempUserInterface);
                }

                // return value
                return userInterfaces;
            }
            #endregion

            #region SaveAdmin(ref Admin admin)
            /// <summary>
            /// This method is used to save 'Admin' objects.
            /// </summary>
            /// <param name="admin">The Admin to save.</param>
            public bool SaveAdmin(ref Admin admin)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.AdminController.Save(ref admin);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveControlInfo(ref ControlInfo controlInfo)
            /// <summary>
            /// This method is used to save 'ControlInfo' objects.
            /// </summary>
            /// <param name="controlInfo">The ControlInfo to save.</param>
            public bool SaveControlInfo(ref ControlInfo controlInfo)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.ControlInfoController.Save(ref controlInfo);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveControlInfoDetail(ref ControlInfoDetail controlInfoDetail)
            /// <summary>
            /// This method is used to save 'ControlInfoDetail' objects.
            /// </summary>
            /// <param name="controlInfoDetail">The ControlInfoDetail to save.</param>
            public bool SaveControlInfoDetail(ref ControlInfoDetail controlInfoDetail)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.ControlInfoDetailController.Save(ref controlInfoDetail);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveCustomReader(ref CustomReader customReader)
            /// <summary>
            /// This method is used to save 'CustomReader' objects.
            /// </summary>
            /// <param name="customReader">The CustomReader to save.</param>
            public bool SaveCustomReader(ref CustomReader customReader)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.CustomReaderController.Save(ref customReader);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveDTNDatabase(ref DTNDatabase dTNDatabase)
            /// <summary>
            /// This method is used to save 'DTNDatabase' objects.
            /// </summary>
            /// <param name="dTNDatabase">The DTNDatabase to save.</param>
            public bool SaveDTNDatabase(ref DTNDatabase dTNDatabase)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.DTNDatabaseController.Save(ref dTNDatabase);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveDTNField(ref DTNField dTNField)
            /// <summary>
            /// This method is used to save 'DTNField' objects.
            /// </summary>
            /// <param name="dTNField">The DTNField to save.</param>
            public bool SaveDTNField(ref DTNField dTNField)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.DTNFieldController.Save(ref dTNField);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveDTNProcedure(ref DTNProcedure dTNProcedure)
            /// <summary>
            /// This method is used to save 'DTNProcedure' objects.
            /// </summary>
            /// <param name="dTNProcedure">The DTNProcedure to save.</param>
            public bool SaveDTNProcedure(ref DTNProcedure dTNProcedure)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.DTNProcedureController.Save(ref dTNProcedure);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveDTNTable(ref DTNTable dTNTable)
            /// <summary>
            /// This method is used to save 'DTNTable' objects.
            /// </summary>
            /// <param name="dTNTable">The DTNTable to save.</param>
            public bool SaveDTNTable(ref DTNTable dTNTable)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.DTNTableController.Save(ref dTNTable);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveEnumeration(ref Enumeration enumeration)
            /// <summary>
            /// This method is used to save 'Enumeration' objects.
            /// </summary>
            /// <param name="enumeration">The Enumeration to save.</param>
            public bool SaveEnumeration(ref Enumeration enumeration)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.EnumerationController.Save(ref enumeration);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveFieldSet(ref FieldSet fieldSet)
            /// <summary>
            /// This method is used to save 'FieldSet' objects.
            /// </summary>
            /// <param name="fieldSet">The FieldSet to save.</param>
            public bool SaveFieldSet(ref FieldSet fieldSet)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.FieldSetController.Save(ref fieldSet);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveFieldSetField(ref FieldSetField fieldSetField)
            /// <summary>
            /// This method is used to save 'FieldSetField' objects.
            /// </summary>
            /// <param name="fieldSetField">The FieldSetField to save.</param>
            public bool SaveFieldSetField(ref FieldSetField fieldSetField)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.FieldSetFieldController.Save(ref fieldSetField);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveMethod(ref Method method)
            /// <summary>
            /// This method is used to save 'Method' objects.
            /// </summary>
            /// <param name="method">The Method to save.</param>
            public bool SaveMethod(ref Method method)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.MethodController.Save(ref method);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveProject(ref Project project)
            /// <summary>
            /// This method is used to save 'Project' objects.
            /// </summary>
            /// <param name="project">The Project to save.</param>
            public bool SaveProject(ref Project project)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.ProjectController.Save(ref project);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveProjectReference(ref ProjectReference projectReference)
            /// <summary>
            /// This method is used to save 'ProjectReference' objects.
            /// </summary>
            /// <param name="projectReference">The ProjectReference to save.</param>
            public bool SaveProjectReference(ref ProjectReference projectReference)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.ProjectReferenceController.Save(ref projectReference);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveReferencesSet(ref ReferencesSet referencesSet)
            /// <summary>
            /// This method is used to save 'ReferencesSet' objects.
            /// </summary>
            /// <param name="referencesSet">The ReferencesSet to save.</param>
            public bool SaveReferencesSet(ref ReferencesSet referencesSet)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.ReferencesSetController.Save(ref referencesSet);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveUIControlDetail(ref UIControlDetail uIControlDetail)
            /// <summary>
            /// This method is used to save 'UIControlDetail' objects.
            /// </summary>
            /// <param name="uIControlDetail">The UIControlDetail to save.</param>
            public bool SaveUIControlDetail(ref UIControlDetail uIControlDetail)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.UIControlDetailController.Save(ref uIControlDetail);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveUIControlTemplate(ref UIControlTemplate uIControlTemplate)
            /// <summary>
            /// This method is used to save 'UIControlTemplate' objects.
            /// </summary>
            /// <param name="uIControlTemplate">The UIControlTemplate to save.</param>
            public bool SaveUIControlTemplate(ref UIControlTemplate uIControlTemplate)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.UIControlTemplateController.Save(ref uIControlTemplate);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveUIField(ref UIField uIField)
            /// <summary>
            /// This method is used to save 'UIField' objects.
            /// </summary>
            /// <param name="uIField">The UIField to save.</param>
            public bool SaveUIField(ref UIField uIField)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.UIFieldController.Save(ref uIField);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveUIObject(ref UIObject uIObject)
            /// <summary>
            /// This method is used to save 'UIObject' objects.
            /// </summary>
            /// <param name="uIObject">The UIObject to save.</param>
            public bool SaveUIObject(ref UIObject uIObject)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.UIObjectController.Save(ref uIObject);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveUIProject(ref UIProject uIProject)
            /// <summary>
            /// This method is used to save 'UIProject' objects.
            /// </summary>
            /// <param name="uIProject">The UIProject to save.</param>
            public bool SaveUIProject(ref UIProject uIProject)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.UIProjectController.Save(ref uIProject);
                }

                // return value
                return saved;
            }
            #endregion

            #region SaveUserInterface(ref UserInterface userInterface)
            /// <summary>
            /// This method is used to save 'UserInterface' objects.
            /// </summary>
            /// <param name="userInterface">The UserInterface to save.</param>
            public bool SaveUserInterface(ref UserInterface userInterface)
            {
                // initial value
                bool saved = false;

                // if the AppController exists
                if (this.HasAppController)
                {
                    // perform the save
                    saved = this.AppController.ControllerManager.UserInterfaceController.Save(ref userInterface);
                }

                // return value
                return saved;
            }
            #endregion

        #endregion

        #region Properties

            #region AppController
            /// <summary>
            /// This property gets or sets the value for 'AppController'.
            /// </summary>
            public ApplicationController AppController
            {
                get { return appController; }
                set { appController = value; }
            }
            #endregion

            #region ConnectionName
            /// <summary>
            /// This property gets or sets the value for 'ConnectionName'.
            /// </summary>
            public string ConnectionName
            {
                get { return connectionName; }
                set { connectionName = value; }
            }
            #endregion
            
            #region HasAppController
            /// <summary>
            /// This property returns true if this object has an 'AppController'.
            /// </summary>
            public bool HasAppController
            {
                get
                {
                    // initial value
                    bool hasAppController = (this.AppController != null);

                    // return value
                    return hasAppController;
                }
            }
            #endregion

            #region HasConnectionName
            /// <summary>
            /// This property returns true if the 'ConnectionName' exists.
            /// </summary>
            public bool HasConnectionName
            {
                get
                {
                    // initial value
                    bool hasConnectionName = (!String.IsNullOrEmpty(this.ConnectionName));
                    
                    // return value
                    return hasConnectionName;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}

