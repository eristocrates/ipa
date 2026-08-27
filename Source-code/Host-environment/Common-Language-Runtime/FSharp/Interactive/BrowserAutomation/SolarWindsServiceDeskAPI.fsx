#r "nuget: Dubzer.WhatwgUrl"
#r "nuget: FSharp.Data"
#r "nuget: PosInformatique.Foundations.EmailAddresses"
#r "nuget: libphonenumber-csharp"
#r "nuget: CaseConverter"
#r "nuget: Humanizer.Core"
open System
open FSharp.Data
open Dubzer.WhatwgUrl
open PosInformatique.Foundations.EmailAddresses
open PhoneNumbers
open Humanizer
open CaseConverter

[<RequireQualifiedAccess>]
type ObjectType =
    | asset_links
    | catalog_items
    | categories
    | change_catalogs
    | changes
    | configuration_items
    | contracts
    | departments
    | groups
    | hardwares
    | incidents
    | memberships
    | mobiles
    | other_assets
    | printers
    | problems
    | purchase_orders
    | releases
    | roles
    | sites
    | softwares
    | solutions
    | users
    | vendors

    member this.asPluralString = this.ToString()
    member this.asSingularString = this.ToString().Singularize()

module Incident =
    let getIncidentById = ()
    let getIncidents = ()

module Problem =
    let getProblemById = ()
    let getProblems = ()

module Change =
    let getChangeById = ()
    let getChanges = ()

module ChangeCatalog =
    let getChangeCatalogById = ()
    let getChangeCatalogs = ()

module Release =
    let getReleaseById = ()
    let getRelease = ()

module Solution =
    let getSolutionById = ()
    let getSolutions = ()

module CatalogItem =
    let getCatalogItemById = ()
    let getCatalogItems = ()

module ConfigurationItem =
    let getConfigurationItemById = ()
    let getConfigurationItems = ()

module User =
    let getUserById = ()
    let getUsers = ()

module Site =
    let getSiteById = ()
    let getSites = ()

module Department =
    let getDepartmentById = ()
    let getDepartments = ()

module Role =
    let getRoleById = ()
    let getRoles = ()

module Group =
    let getGroupById = ()
    let getGroups = ()

module Category =
    let getCategoryById = ()
    let getCategories = ()

module Hardware =
    let getHardwareById = ()
    let getHardwares = ()
    let getWarranties = ()

module MobileDevice =
    let getMobileById = ()
    let getMobiles = ()

module OtherAsset =
    let getAssetById = ()
    let getAssets = ()

module Software =
    let getSoftwareById = ()
    let getSoftwares = ()

module Printer =
    let getPrinterById = ()
    let getPrinters = ()

module Contract =
    let getContractById = ()
    let getContracts = ()

module PurchaseOrder =
    let getPurchaseOrderById = ()
    let getCPurchaseOrders = ()

module Vendor =
    let getVendorById = ()
    let getVendors = ()

module TimeTrack =
    let getTimeTracks = ()

module Audit =
    let getAudits = ()
    let getAuditById = ()

module Risk =
    let getRisks = ()

type IncidentsRequest =
    { layout: string option
      updated: string option
      updatedCustomGte: string option
      updatedCustomLte: string option
      updatedFrom: string option
      updatedTo: string option
      createdFrom: string option
      createdTo: string option
      page: int option
      perPage: int option
      reportId: int option
      searchInContext: string option
      requestId: string option
      connectionId: string option
      applied: bool option
      description: HtmlNode list
      descriptionIsNot: string array option
      department: int array option
      title: string array option
      state: State option
      sortBy: string option
      sortOrder: string option
      columns: string option }

and [<RequireQualifiedAccess>] State =
    | Assigned
    | ``Awaiting Approval``
    | ``Awaiting Delivery``
    | ``Awaiting Effective Date``
    | ``Awaiting Input - Tech``
    | ``Awaiting Input - User``
    | ``Awaiting Input - Vendor``
    | ``Awaiting Quote``
    | ``Canceled by Requester``
    | Closed
    | ``In Process``
    | New
    | ``On Hold``
    | ``Pending Assignment``
    | ``Project - Proactive``
    | ``Purchase in Process``
    | ``Research Required``
    | Resolved
    | ``Scheduled-Check Due Date``
    | ``Under Review``
