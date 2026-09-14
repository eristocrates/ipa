#r "nuget: Microsoft.SqlServer.DacFx, 162.5.57"

open System
open Microsoft.SqlServer.TransactSql.ScriptDom
open Microsoft.Data.Tools.Schema.Sql.SchemaModel
open Microsoft.SqlServer.Dac.Model
open System

type ModelType =
    | AssemblyModel of Assembly
    | BuiltInServerRoleModel of BuiltInServerRole
    | CheckConstraintModel of CheckConstraint
    | ContractModel of Contract
    | DataTypeModel of DataType
    | DatabaseOptionModel of DatabaseOption
    | DefaultConstraintModel of DefaultConstraint
    | DmlTriggerModel of DmlTrigger
    | EndpointModel of Endpoint
    | ExtendedPropertyModel of ExtendedProperty
    | FilegroupModel of Filegroup
    | ForeignKeyConstraintModel of ForeignKeyConstraint
    | IndexModel of Index
    | LoginModel of Login
    | MessageTypeModel of MessageType
    | PrimaryKeyConstraintModel of PrimaryKeyConstraint
    | ProcedureModel of Procedure
    | QueueModel of Queue
    | RoleModel of Role
    | RoleMembershipModel of RoleMembership
    | ScalarFunctionModel of ScalarFunction
    | SchemaModel of Schema
    | ServiceModel of Service
    | StatisticsModel of Statistics
    | SynonymModel of Synonym
    | TableModel of Table
    | TableTypeModel of TableType
    | TableValuedFunctionModel of TableValuedFunction
    | UniqueConstraintModel of UniqueConstraint
    | UserModel of User
    | UserDefinedTypeModel of UserDefinedType
    | ViewModel of View
