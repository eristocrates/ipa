#r "nuget: Dubzer.WhatwgUrl"
#r "nuget: FSharp.Data"
#r "nuget: PosInformatique.Foundations.EmailAddresses"
#r "nuget: libphonenumber-csharp"
open System
open FSharp.Data
open Dubzer.WhatwgUrl
open PosInformatique.Foundations.EmailAddresses
open PhoneNumbers

type Incident =
    { id: int
      number: int
      name: string
      description: HtmlNode list
      description_no_html: string
      state: State
      priority: Priority
      category: Category option
      subcategory: Subcategory option
      assignee: Assignee option
      requester: Requester option
      created_at: DateTime
      updated_at: DateTime
      due_at: DateTime option
      sla_violations: SlaViolation array
      number_of_comments: int
      user_saw_all_comments: bool
      is_service_request: bool
      created_by: User option
      resolved_by: Assignee option
      resolution_description: string option
      resolution_code: ResolutionCode option
      group_assignee: GroupAssignee option
      customer_satisfaction_survey_sent_at: DateTime option
      customer_satisfaction_survey_completed_at: DateTime option
      custom: string option
      href: DomUrl
      href_account_domain: DomUrl
      site: Site option
      department: Department option
      cc: string array
      custom_fields_values: string
      origin: Origin
      problems: Problem array
      problem: Problem array
      tasks: Task array
      time_tracks: TimeTrack array
      solutions: Solution array
      assets: Asset array }

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

and [<RequireQualifiedAccess>] Priority =
    | Critical
    | High
    | Low
    | Medium
    | None

and [<RequireQualifiedAccess>] Origin =
    | email
    | external
    | mobile
    | web

and [<RequireQualifiedAccess>] ResolutionCode =
    | Aborted
    | ``Canceled by User Request``
    | Done
    | Duplicate
    | ``No longer Funded``
    | ``Not Solved (Black Flag Blocking - See Notes)``
    | ``Not Solved (Escalated to External Support)``
    | ``Not Solved (Escalated to Vendor)``
    | ``Not Solved (Not Reproducible)``
    | ``Not Solved (Resolution Set for Future Upgrade)``
    | ``Not Solved (Too Costly)``
    | Not_solved_not_reproducible
    | Not_solved_too_costly
    | Postponed
    | ``Resolved (Permanently)``
    | ``Resolved by Requester``
    | Solved
    | ``Solved (Permanently)``
    | ``Solved (Work Around)``
    | Solved_permanently
    | Solved_work_around
    | ``Unknown (No Response From User)``

and Problem = { id: int; href: DomUrl }

and Category =
    { id: int
      name: string
      default_tags: string
      deleted: bool
      default_assignee_id: int option }

and Subcategory =
    { id: int
      name: string
      default_tags: string
      parent_id: int
      deleted: bool
      default_assignee_id: int option }

and Assignee =
    { id: int
      name: string
      description: HtmlNode list
      disabled: bool option
      is_user: bool
      reports_to: Account option
      avatar: Avatar
      ``type``: string option
      send_notifications: bool option
      memberships: Membership array option
      group_id: int option
      email: string option }

and Account =
    { id: int
      avatar: Avatar option
      name: string option
      href: DomUrl option
      group_id: int option
      is_user: bool option
      email: string option }

and Avatar =
    { ``type``: string
      image_class: string option
      sso_image_class: string option
      avatar_url: string option
      initials: string option
      color: string option
      klass: string option }

and Membership =
    { id: int
      ``type``: string
      user: string }

and Requester =
    { id: int
      account_id: int
      user_id: int option
      email: string
      name: string
      disabled: bool
      site_id: int option
      site: string option
      department_id: int option
      department: string option
      has_gravatar: bool
      customer_satisfaction_survey_time: string option
      avatar: Avatar }

and SlaViolation =
    { id: int
      name: string
      sla_id: int
      sla_type: string
      resolved: bool
      time_delay: int
      time_units: string
      assignee: Assignee option
      group_assignee: GroupAssignee option }

and GroupAssignee = { id: int; name: string }

and User =
    { id: int
      account_id: int
      user_id: int option
      email: string
      name: string
      disabled: bool
      site_id: int option
      site: string option
      department_id: int option
      department: string option
      has_gravatar: bool
      customer_satisfaction_survey_time: string option
      avatar: Avatar }

and Site =
    { id: int
      name: string
      location: string
      description: HtmlNode list
      time_zone: string
      language: string }

and Department =
    { id: int
      name: string
      description: HtmlNode list
      default_assignee_id: int option }

and CustomFieldsValue =
    { id: int
      custom_field_id: int
      name: string
      value: string
      attachment: Attachment option
      options: string option
      ``type``: int
      type_name: string
      user: User option
      raw_value: obj option }

and Attachment =
    { id: int
      content_type: string
      size: int
      filename: string
      url: string
      shared_attachment: bool
      attachable_id: int
      attachable_type: string
      attachment_type: string
      thumb_url: string
      secure_url: string
      link_uuid_url: string
      uuid: string }

and Task = { id: int; href: DomUrl }
and TimeTrack = { id: int; href: DomUrl }
and Solution = { id: int; href: DomUrl }
and Asset = { id: int; href: DomUrl }

module Category =
    let ``Account Management`` =
        { id = 1397170
          name = "Account Management"
          default_tags = "account management"
          deleted = true
          default_assignee_id = None }

    let ``Administrative Actions`` =
        { id = 1535510
          name = "Administrative Actions"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let Applications =
        { id = 1397167
          name = "Applications"
          default_tags = "applications"
          deleted = true
          default_assignee_id = None }

    let ``Audio Visual & Sound Systems`` =
        { id = 1449404
          name = "Audio Visual & Sound Systems"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706935 }

    let ``Chamber Technology Support`` =
        { id = 1466687
          name = "Chamber Technology Support"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``CoVid Special Projects`` =
        { id = 1482278
          name = "CoVid Special Projects"
          default_tags = ""
          deleted = true
          default_assignee_id = Some 6706997 }

    let ``County Applications`` =
        { id = 1448839
          name = "County Applications"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Court Judicial Specific Support`` =
        { id = 1503653
          name = "Court Judicial Specific Support"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Database Support`` =
        { id = 1524346
          name = "Database Support"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6568482 }

    let ``Desktop Group Policy`` =
        { id = 2081739
          name = "Desktop Group Policy"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Document Accessibility`` =
        { id = 4703453
          name = "Document Accessibility"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``EMS Specific Software Applications`` =
        { id = 1449511
          name = "EMS Specific Software Applications"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706995 }

    let ``EMS Specific Technology`` =
        { id = 1449415
          name = "EMS Specific Technology"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``EOC Specific Technology`` =
        { id = 1449433
          name = "EOC Specific Technology"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``GIS Support`` =
        { id = 1559742
          name = "GIS Support"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6764326 }

    let ``Horizon & Virtual Desktops`` =
        { id = 1456446
          name = "Horizon & Virtual Desktops"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Image and MDT Maintenance`` =
        { id = 1682335
          name = "Image and MDT Maintenance"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Inventory & Surplus Assistance`` =
        { id = 1478583
          name = "Inventory & Surplus Assistance"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Library Specific Technology`` =
        { id = 1451772
          name = "Library Specific Technology"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Loaner Devices`` =
        { id = 1456459
          name = "Loaner Devices"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Mobile Devices`` =
        { id = 1448804
          name = "Mobile Devices"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Moves & Relocations`` =
        { id = 1449403
          name = "Moves & Relocations"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Network Administration & Support`` =
        { id = 1463512
          name = "Network Administration & Support"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``PC Related Requests`` =
        { id = 1448916
          name = "PC Related Requests"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PSC Specific Technology - Common Areas`` =
        { id = 1449476
          name = "PSC Specific Technology - Common Areas"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Password Reset`` =
        { id = 1449378
          name = "Password Reset"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Phones - Office, Desk & Softphone`` =
        { id = 1449405
          name = "Phones - Office, Desk & Softphone"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Policy Pak`` =
        { id = 2465648
          name = "Policy Pak"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Printers & Copiers`` =
        { id = 1449343
          name = "Printers & Copiers"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Profile Picture in Office 365`` =
        { id = 1461466
          name = "Profile Picture in Office 365"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6568086 }

    let ``Project Related Support`` =
        { id = 1969421
          name = "Project Related Support"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Purchasing & Procurement`` =
        { id = 1456442
          name = "Purchasing & Procurement"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``SAO - State Attorney's Office`` =
        { id = 1598426
          name = "SAO - State Attorney\'s Office"
          default_tags = "SAO Helpdesk"
          deleted = false
          default_assignee_id = Some 7191004 }

    let ``SPAM filtering & Emails`` =
        { id = 1463910
          name = "SPAM filtering & Emails"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706945 }

    let Security =
        { id = 1562844
          name = "Security"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Servers Administration & Support`` =
        { id = 1449664
          name = "Servers Administration & Support"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706945 }

    let Software =
        { id = 1448818
          name = "Software"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Test Category`` =
        { id = 1448800
          name = "Test Category"
          default_tags = ""
          deleted = true
          default_assignee_id = Some 6568086 }

    let Training =
        { id = 1449410
          name = "Training"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Websites & Web Stewards`` =
        { id = 1449565
          name = "Websites & Web Stewards"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``WiFi & Cellular Relay in County Buildings`` =
        { id = 1449421
          name = "WiFi & Cellular Relay in County Buildings"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Z-Email To Categorize`` =
        { id = 1459752
          name = "Z-Email To Categorize"
          default_tags = ""
          deleted = false
          default_assignee_id = Some 6706997 }

module Subcategory =
    let ``.NET'1499406`` =
        { id = 1499406
          name = ".NET"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``ACD - Add'1535535`` =
        { id = 1535535
          name = "ACD - Add"
          default_tags = ""
          parent_id = 1535510
          deleted = false
          default_assignee_id = Some 7816438 }

    let ``ACD - Change'1731701`` =
        { id = 1731701
          name = "ACD - Change"
          default_tags = ""
          parent_id = 1535510
          deleted = false
          default_assignee_id = Some 7816438 }

    let ``ACD - Check'4301068`` =
        { id = 4301068
          name = "ACD - Check"
          default_tags = ""
          parent_id = 1535510
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``ACD - Clerk'1736974`` =
        { id = 1736974
          name = "ACD - Clerk"
          default_tags = ""
          parent_id = 1535510
          deleted = false
          default_assignee_id = Some 6706978 }

    let ``ACD - Delete'1731702`` =
        { id = 1731702
          name = "ACD - Delete"
          default_tags = ""
          parent_id = 1535510
          deleted = false
          default_assignee_id = Some 7816438 }

    let ``ACD - Vendor'1736726`` =
        { id = 1736726
          name = "ACD - Vendor"
          default_tags = ""
          parent_id = 1535510
          deleted = false
          default_assignee_id = Some 7816438 }

    let ``ACL Reported - Recategorize'1462733`` =
        { id = 1462733
          name = "ACL Reported - Recategorize"
          default_tags = ""
          parent_id = 1459752
          deleted = false
          default_assignee_id = Some 6706959 }

    let Accela'1448866 =
        { id = 1448866
          name = "Accela"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706959 }

    let ``Access Point Needed'1463515`` =
        { id = 1463515
          name = "Access Point Needed"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Add User Access to Pool'1456451`` =
        { id = 1456451
          name = "Add User Access to Pool"
          default_tags = ""
          parent_id = 1456446
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Add photo to Office Photo'1463511`` =
        { id = 1463511
          name = "Add photo to Office Photo"
          default_tags = ""
          parent_id = 1461466
          deleted = false
          default_assignee_id = Some 6568086 }

    let ``Add printer to PC'1503655`` =
        { id = 1503655
          name = "Add printer to PC"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Address Book Updates & Changes'1451479`` =
        { id = 1451479
          name = "Address Book Updates & Changes"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Adobe Creative Cloud'1451587`` =
        { id = 1451587
          name = "Adobe Creative Cloud"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Adobe Pro or Reader'1448825`` =
        { id = 1448825
          name = "Adobe Pro or Reader"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Adobe Products '4595642`` =
        { id = 4595642
          name = "Adobe Products "
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Agenda Process Support'1451597`` =
        { id = 1451597
          name = "Agenda Process Support"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Akamai CMS Updates'1451595`` =
        { id = 1451595
          name = "Akamai CMS Updates"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Animal Abuse Registry (Clerk IT)'4751918`` =
        { id = 4751918
          name = "Animal Abuse Registry (Clerk IT)"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6712585 }

    let ``App Control Pop-ups - Secure Run'1461314`` =
        { id = 1461314
          name = "App Control Pop-ups - Secure Run"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let Appxtender'1448898 =
        { id = 1448898
          name = "Appxtender"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6714348 }

    let ArcMap'1478064 =
        { id = 1478064
          name = "ArcMap"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ArcView'1491519 =
        { id = 1491519
          name = "ArcView"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Arctic Wolf/Cylance'4376022`` =
        { id = 4376022
          name = "Arctic Wolf/Cylance"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Asset Tiger'1889425`` =
        { id = 1889425
          name = "Asset Tiger"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6713108 }

    let ``Aurora/Cylance Security'4595662`` =
        { id = 4595662
          name = "Aurora/Cylance Security"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706945 }

    let AutoCAD'1448830 =
        { id = 1448830
          name = "AutoCAD"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Automox Agent'4428711`` =
        { id = 4428711
          name = "Automox Agent"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Automox Patching'4595644`` =
        { id = 4595644
          name = "Automox Patching"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Azure Support'1450817`` =
        { id = 1450817
          name = "Azure Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Banner 9'1448840`` =
        { id = 1448840
          name = "Banner 9"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706978 }

    let ``Banner Password Reset'1449380`` =
        { id = 1449380
          name = "Banner Password Reset"
          default_tags = "AD Password Reset"
          parent_id = 1449378
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Banner Reports'1449676`` =
        { id = 1449676
          name = "Banner Reports"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706978 }

    let ``Banner Self-Service'1449675`` =
        { id = 1449675
          name = "Banner Self-Service"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706978 }

    let ``Banner Self-Service Password Reset'1449607`` =
        { id = 1449607
          name = "Banner Self-Service Password Reset"
          default_tags = "Banner GOAT"
          parent_id = 1449378
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Barcode Scanners'1451829`` =
        { id = 1451829
          name = "Barcode Scanners"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Battery - CMOS'1451473`` =
        { id = 1451473
          name = "Battery - CMOS"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Battery - Laptop & Tablet'1451472`` =
        { id = 1451472
          name = "Battery - Laptop & Tablet"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let Benchmark'1503654 =
        { id = 1503654
          name = "Benchmark"
          default_tags = ""
          parent_id = 1503653
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``BeyondTrust Remote Device Support'4595587`` =
        { id = 4595587
          name = "BeyondTrust Remote Device Support"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Blue Screen'1451474`` =
        { id = 1451474
          name = "Blue Screen"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Bomgar/BeyondTrust'3110819`` =
        { id = 3110819
          name = "Bomgar/BeyondTrust"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Boot Problem - Reboots Randomly'1479425`` =
        { id = 1479425
          name = "Boot Problem - Reboots Randomly"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Booting Problem - Won't Boot'1451476`` =
        { id = 1451476
          name = "Booting Problem - Won\'t Boot"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let CAD'1449669 =
        { id = 1449669
          name = "CAD"
          default_tags = ""
          parent_id = 1449511
          deleted = false
          default_assignee_id = Some 6706995 }

    let ``CAD Laptops or Tablets'1449424`` =
        { id = 1449424
          name = "CAD Laptops or Tablets"
          default_tags = ""
          parent_id = 1449415
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Cable Management Needed'1451387`` =
        { id = 1451387
          name = "Cable Management Needed"
          default_tags = ""
          parent_id = 1449403
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Cable Replacements'1449432`` =
        { id = 1449432
          name = "Cable Replacements"
          default_tags = ""
          parent_id = 1449415
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Cables & Adapters'1451242`` =
        { id = 1451242
          name = "Cables & Adapters"
          default_tags = ""
          parent_id = 1449404
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Calendar Support - Android'1543805`` =
        { id = 1543805
          name = "Calendar Support - Android"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Calendar Support - Apple'1543804`` =
        { id = 1543804
          name = "Calendar Support - Apple"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Calendar Update Request'1470423`` =
        { id = 1470423
          name = "Calendar Update Request"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Call Queue Changes & Creation'1449538`` =
        { id = 1449538
          name = "Call Queue Changes & Creation"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Cellular Relay in County Buildings'1463502`` =
        { id = 1463502
          name = "Cellular Relay in County Buildings"
          default_tags = ""
          parent_id = 1449421
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Chamber Broadcast Support'1466692`` =
        { id = 1466692
          name = "Chamber Broadcast Support"
          default_tags = ""
          parent_id = 1466687
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Chamber Lighting Support'1466691`` =
        { id = 1466691
          name = "Chamber Lighting Support"
          default_tags = ""
          parent_id = 1466687
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Chamber PC Support'1466689`` =
        { id = 1466689
          name = "Chamber PC Support"
          default_tags = ""
          parent_id = 1466687
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Chamber Sound Support'1466690`` =
        { id = 1466690
          name = "Chamber Sound Support"
          default_tags = ""
          parent_id = 1466687
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Chamber Support'1451244`` =
        { id = 1451244
          name = "Chamber Support"
          default_tags = ""
          parent_id = 1449404
          deleted = false
          default_assignee_id = Some -1 }

    let ``Character Generator Support'1466688`` =
        { id = 1466688
          name = "Character Generator Support"
          default_tags = ""
          parent_id = 1466687
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Charging Cable or Charger'1448809`` =
        { id = 1448809
          name = "Charging Cable or Charger"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Chrome Browser'1575504`` =
        { id = 1575504
          name = "Chrome Browser"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Citizens Connect'1847935`` =
        { id = 1847935
          name = "Citizens Connect"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706982 }

    let Codestat'1465113 =
        { id = 1465113
          name = "Codestat"
          default_tags = ""
          parent_id = 1449511
          deleted = false
          default_assignee_id = Some 6706995 }

    let ``Coin & Bill Acceptor'4001800`` =
        { id = 4001800
          name = "Coin & Bill Acceptor"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Comcast & XFinity Support'1513428`` =
        { id = 1513428
          name = "Comcast & XFinity Support"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Comcast Cable Support'1500621`` =
        { id = 1500621
          name = "Comcast Cable Support"
          default_tags = ""
          parent_id = 1449404
          deleted = false
          default_assignee_id = Some 6706935 }

    let ``Committee Tracking System'1468938`` =
        { id = 1468938
          name = "Committee Tracking System"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Committee Tracking System'1468937`` =
        { id = 1468937
          name = "Committee Tracking System"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Comprise System'1459909`` =
        { id = 1459909
          name = "Comprise System"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Computer Reservations - Sign-Up Stations'1451825`` =
        { id = 1451825
          name = "Computer Reservations - Sign-Up Stations"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Conference Room Projectors'1449419`` =
        { id = 1449419
          name = "Conference Room Projectors"
          default_tags = ""
          parent_id = 1449404
          deleted = false
          default_assignee_id = Some 6706935 }

    let ``Conference Room Sound Systems'1449420`` =
        { id = 1449420
          name = "Conference Room Sound Systems"
          default_tags = ""
          parent_id = 1449404
          deleted = false
          default_assignee_id = Some 6706935 }

    let ``Connectivity - Latency or Dropping'1476859`` =
        { id = 1476859
          name = "Connectivity - Latency or Dropping"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Constitutional Out-Of-Scope Request'1511900`` =
        { id = 1511900
          name = "Constitutional Out-Of-Scope Request"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Constitutional WiFi'1451653`` =
        { id = 1451653
          name = "Constitutional WiFi"
          default_tags = ""
          parent_id = 1449421
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Content Update Request'1470732`` =
        { id = 1470732
          name = "Content Update Request"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Contract Related'1496884`` =
        { id = 1496884
          name = "Contract Related"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6568086 }

    let Converge'1847934 =
        { id = 1847934
          name = "Converge"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706959 }

    let ``Copier & Printer Billing'1456458`` =
        { id = 1456458
          name = "Copier & Printer Billing"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6750453 }

    let ``Copier & Printer Password Reset'1451478`` =
        { id = 1451478
          name = "Copier & Printer Password Reset"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Copier - Faxing'1449350`` =
        { id = 1449350
          name = "Copier - Faxing"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Copier - Printing'1449348`` =
        { id = 1449348
          name = "Copier - Printing"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Copier - Scan to Email'1449354`` =
        { id = 1449354
          name = "Copier - Scan to Email"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Copier - Scan to Folder (Workflow)'1449356`` =
        { id = 1449356
          name = "Copier - Scan to Folder (Workflow)"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Copilot - Microsoft'4595661`` =
        { id = 4595661
          name = "Copilot - Microsoft"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``County Law Client '1470426`` =
        { id = 1470426
          name = "County Law Client "
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Court Services'4501259`` =
        { id = 4501259
          name = "Court Services"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Courtroom AV'1451243`` =
        { id = 1451243
          name = "Courtroom AV"
          default_tags = ""
          parent_id = 1449404
          deleted = false
          default_assignee_id = Some 6715542 }

    let ``Create Base VM'1466753`` =
        { id = 1466753
          name = "Create Base VM"
          default_tags = ""
          parent_id = 1456446
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Create Documentation or Instructions'2131271`` =
        { id = 2131271
          name = "Create Documentation or Instructions"
          default_tags = ""
          parent_id = 1449410
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Create GPO'2081740`` =
        { id = 2081740
          name = "Create GPO"
          default_tags = ""
          parent_id = 2081739
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Create Image'1682336`` =
        { id = 1682336
          name = "Create Image"
          default_tags = ""
          parent_id = 1682335
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Create MDT Deployment'2106671`` =
        { id = 2106671
          name = "Create MDT Deployment"
          default_tags = ""
          parent_id = 1682335
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Create New Desktop Pool'1456455`` =
        { id = 1456455
          name = "Create New Desktop Pool"
          default_tags = ""
          parent_id = 1456446
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Create New Policy'2465651`` =
        { id = 2465651
          name = "Create New Policy"
          default_tags = ""
          parent_id = 2465648
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Create a New Phone Number'1449534`` =
        { id = 1449534
          name = "Create a New Phone Number"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Create and Analyze Business Case'1969429`` =
        { id = 1969429
          name = "Create and Analyze Business Case"
          default_tags = ""
          parent_id = 1969421
          deleted = false
          default_assignee_id = Some 6706997 }

    let CrowdStrike'2636265 =
        { id = 2636265
          name = "CrowdStrike"
          default_tags = ""
          parent_id = 1448818
          deleted = true
          default_assignee_id = Some 6706997 }

    let ``Daily SPAM digest review how-to'1463913`` =
        { id = 1463913
          name = "Daily SPAM digest review how-to"
          default_tags = ""
          parent_id = 1463910
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Damaged - Screen'1479590`` =
        { id = 1479590
          name = "Damaged - Screen"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Damaged Cables or Cable Replacement'1513429`` =
        { id = 1513429
          name = "Damaged Cables or Cable Replacement"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Database Restoration'1500657`` =
        { id = 1500657
          name = "Database Restoration"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Deep Freeze'1483947`` =
        { id = 1483947
          name = "Deep Freeze"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Deploy Policy'2465652`` =
        { id = 2465652
          name = "Deploy Policy"
          default_tags = ""
          parent_id = 2465648
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Desk Phone Not Working'1449544`` =
        { id = 1449544
          name = "Desk Phone Not Working"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Digital Signage Updates'1451593`` =
        { id = 1451593
          name = "Digital Signage Updates"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Disk Space Increase Request'1450889`` =
        { id = 1450889
          name = "Disk Space Increase Request"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Disk Space Issues'1468876`` =
        { id = 1468876
          name = "Disk Space Issues"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Docking Station Issues'2208125`` =
        { id = 2208125
          name = "Docking Station Issues"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Docking Stations - In Truck'1449431`` =
        { id = 1449431
          name = "Docking Stations - In Truck"
          default_tags = ""
          parent_id = 1449415
          deleted = false
          default_assignee_id = Some 6706997 }

    let DocuSign'1524345 =
        { id = 1524345
          name = "DocuSign"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 7526010 }

    let ``Documents for  Internet'4703455`` =
        { id = 4703455
          name = "Documents for  Internet"
          default_tags = ""
          parent_id = 4703453
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Domain Registrations'1549335`` =
        { id = 1549335
          name = "Domain Registrations"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Drive Mappings'1450836`` =
        { id = 1450836
          name = "Drive Mappings"
          default_tags = "CMD gpupdate /force"
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Driver Support'3993869`` =
        { id = 3993869
          name = "Driver Support"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``EC500 Call Forward Needed'1449546`` =
        { id = 1449546
          name = "EC500 Call Forward Needed"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``EDBWIN Access Support'1559743`` =
        { id = 1559743
          name = "EDBWIN Access Support"
          default_tags = ""
          parent_id = 1559742
          deleted = false
          default_assignee_id = Some 6764326 }

    let ``EMS Desktops'1449426`` =
        { id = 1449426
          name = "EMS Desktops"
          default_tags = ""
          parent_id = 1449415
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``EMS Specific Training - Vendor Supplied'1496543`` =
        { id = 1496543
          name = "EMS Specific Training - Vendor Supplied"
          default_tags = ""
          parent_id = 1449511
          deleted = false
          default_assignee_id = Some 6706995 }

    let ``EOC - Audio & Video Devices'1449449`` =
        { id = 1449449
          name = "EOC - Audio & Video Devices"
          default_tags = ""
          parent_id = 1449433
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``EOC - Breakout Room PC's'1449448`` =
        { id = 1449448
          name = "EOC - Breakout Room PC\'s"
          default_tags = ""
          parent_id = 1449433
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``EOC - Call Taker PC's'1449445`` =
        { id = 1449445
          name = "EOC - Call Taker PC\'s"
          default_tags = ""
          parent_id = 1449433
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``EOC - Command PC's'1449447`` =
        { id = 1449447
          name = "EOC - Command PC\'s"
          default_tags = ""
          parent_id = 1449433
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``EOC - Copier & Printers'1449450`` =
        { id = 1449450
          name = "EOC - Copier & Printers"
          default_tags = ""
          parent_id = 1449433
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``EOC - Room Setup for Activation/Training'1598362`` =
        { id = 1598362
          name = "EOC - Room Setup for Activation/Training"
          default_tags = ""
          parent_id = 1449433
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``EOC - Staff PC's'1449439`` =
        { id = 1449439
          name = "EOC - Staff PC\'s"
          default_tags = ""
          parent_id = 1449433
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``EOC - Training PC's'1449446`` =
        { id = 1449446
          name = "EOC - Training PC\'s"
          default_tags = ""
          parent_id = 1449433
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``EPCR Laptops'1449425`` =
        { id = 1449425
          name = "EPCR Laptops"
          default_tags = ""
          parent_id = 1449415
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``ESO Solutions'1465117`` =
        { id = 1465117
          name = "ESO Solutions"
          default_tags = ""
          parent_id = 1449511
          deleted = false
          default_assignee_id = Some 6706995 }

    let ``Edge Browser'1575503`` =
        { id = 1575503
          name = "Edge Browser"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Edit GPO'2081741`` =
        { id = 2081741
          name = "Edit GPO"
          default_tags = ""
          parent_id = 2081739
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Email Account Removal'1516507`` =
        { id = 1516507
          name = "Email Account Removal"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Email Archive Support'1450822`` =
        { id = 1450822
          name = "Email Archive Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Email Auto-Reply Support'1450829`` =
        { id = 1450829
          name = "Email Auto-Reply Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Email Delegation, Proxy & Access Support'1450827`` =
        { id = 1450827
          name = "Email Delegation, Proxy & Access Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Email Gateway Support'1450816`` =
        { id = 1450816
          name = "Email Gateway Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Email Groups & Distribution Lists'1450825`` =
        { id = 1450825
          name = "Email Groups & Distribution Lists"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Email Resource Account'1466861`` =
        { id = 1466861
          name = "Email Resource Account"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Email Review for Phishing or SPAM'1504356`` =
        { id = 1504356
          name = "Email Review for Phishing or SPAM"
          default_tags = ""
          parent_id = 1463910
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Email Rules Support'1450830`` =
        { id = 1450830
          name = "Email Rules Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Equipment Move to Different Building'1720320`` =
        { id = 1720320
          name = "Equipment Move to Different Building"
          default_tags = ""
          parent_id = 1449403
          deleted = false
          default_assignee_id = Some 6706997 }

    let Excel'1448824 =
        { id = 1448824
          name = "Excel"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Existing Server Support'1450815`` =
        { id = 1450815
          name = "Existing Server Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let FASTER'1451297 =
        { id = 1451297
          name = "FASTER"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706982 }

    let ``File Recovery Support'1450820`` =
        { id = 1450820
          name = "File Recovery Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``File transfer or access between accounts'1463750`` =
        { id = 1463750
          name = "File transfer or access between accounts"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let Finweb'1448895 =
        { id = 1448895
          name = "Finweb"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6712585 }

    let ``Firefox Browser'1575505`` =
        { id = 1575505
          name = "Firefox Browser"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Firewall Support'1500629`` =
        { id = 1500629
          name = "Firewall Support"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let FirstNet'1969410 =
        { id = 1969410
          name = "FirstNet"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let FirstWatch'1465116 =
        { id = 1465116
          name = "FirstWatch"
          default_tags = ""
          parent_id = 1449511
          deleted = false
          default_assignee_id = Some 6706995 }

    let ``Forescout Admin Access'1654522`` =
        { id = 1654522
          name = "Forescout Admin Access"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Forescout Block Support'1654523`` =
        { id = 1654523
          name = "Forescout Block Support"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Forms by Microsoft'1743381`` =
        { id = 1743381
          name = "Forms by Microsoft"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``FortiClient VPN'2410564`` =
        { id = 2410564
          name = "FortiClient VPN"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let FortiNAC'2410565 =
        { id = 2410565
          name = "FortiNAC"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let Fortra'4680106 =
        { id = 4680106
          name = "Fortra"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Fuel Master'1451298`` =
        { id = 1451298
          name = "Fuel Master"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706982 }

    let ``GIS Web Applications'1451299`` =
        { id = 1451299
          name = "GIS Web Applications"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6764326 }

    let ``GPO Updates'1967221`` =
        { id = 1967221
          name = "GPO Updates"
          default_tags = ""
          parent_id = 1562844
          deleted = false
          default_assignee_id = Some 6706997 }

    let GoToMeeting'1474454 =
        { id = 1474454
          name = "GoToMeeting"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Google Earth Pro'2388840`` =
        { id = 2388840
          name = "Google Earth Pro"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6764326 }

    let ``GovMax - OMB is Primary Support'1451300`` =
        { id = 1451300
          name = "GovMax - OMB is Primary Support"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6568482 }

    let ``Hardware Purchase Needed'1456457`` =
        { id = 1456457
          name = "Hardware Purchase Needed"
          default_tags = ""
          parent_id = 1456442
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Hardware Related Problems'1474346`` =
        { id = 1474346
          name = "Hardware Related Problems"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let Headset'1476933 =
        { id = 1476933
          name = "Headset"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Headset Related Support'1514052`` =
        { id = 1514052
          name = "Headset Related Support"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Holiday Call Schedule Change'1449539`` =
        { id = 1449539
          name = "Holiday Call Schedule Change"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Horizon Client Setup'1534534`` =
        { id = 1534534
          name = "Horizon Client Setup"
          default_tags = ""
          parent_id = 1456446
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Horizons by VMWare'1481087`` =
        { id = 1481087
          name = "Horizons by VMWare"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6568086 }

    let ``INTERnet Support'1449604`` =
        { id = 1449604
          name = "INTERnet Support"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``INTRAnet Support'1449603`` =
        { id = 1449603
          name = "INTRAnet Support"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Image Creation - ISO'1488777`` =
        { id = 1488777
          name = "Image Creation - ISO"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Implementation Needs'1969424`` =
        { id = 1969424
          name = "Implementation Needs"
          default_tags = ""
          parent_id = 1969421
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Infor Hansen'1448912`` =
        { id = 1448912
          name = "Infor Hansen"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706982 }

    let ``Infor Hansen Password Reset'1449386`` =
        { id = 1449386
          name = "Infor Hansen Password Reset"
          default_tags = "Server Side Reset"
          parent_id = 1449378
          deleted = false
          default_assignee_id = Some 6706982 }

    let ``Install - Copier & Printers'1451480`` =
        { id = 1451480
          name = "Install - Copier & Printers"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Install Client Side Extensions'2465650`` =
        { id = 2465650
          name = "Install Client Side Extensions"
          default_tags = ""
          parent_id = 2465648
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Install Cloud Agent'2465649`` =
        { id = 2465649
          name = "Install Cloud Agent"
          default_tags = ""
          parent_id = 2465648
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Inventory Update Needed'1478586`` =
        { id = 1478586
          name = "Inventory Update Needed"
          default_tags = ""
          parent_id = 1478583
          deleted = false
          default_assignee_id = Some 6706997 }

    let Ivanti'1461468 =
        { id = 1461468
          name = "Ivanti"
          default_tags = ""
          parent_id = 1448839
          deleted = true
          default_assignee_id = Some 6568086 }

    let ``Ivanti Agent - AV, App Ctrl, Patch'1463430`` =
        { id = 1463430
          name = "Ivanti Agent - AV, App Ctrl, Patch"
          default_tags = ""
          parent_id = 1448818
          deleted = true
          default_assignee_id = Some 6706997 }

    let ``JIS - CMS'1449677`` =
        { id = 1449677
          name = "JIS - CMS"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706973 }

    let ``JIS - County Lab'1534998`` =
        { id = 1534998
          name = "JIS - County Lab"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706973 }

    let ``JIS - JMS'1448841`` =
        { id = 1448841
          name = "JIS - JMS"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706973 }

    let ``JIS - JUV'2192629`` =
        { id = 2192629
          name = "JIS - JUV"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706973 }

    let ``JIS - NF Pawn'1449679`` =
        { id = 1449679
          name = "JIS - NF Pawn"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706973 }

    let ``JIS - PD'1588284`` =
        { id = 1588284
          name = "JIS - PD"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706973 }

    let ``JIS - Pre-Trial'1449678`` =
        { id = 1449678
          name = "JIS - Pre-Trial"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706973 }

    let ``JIS - Probation'1534994`` =
        { id = 1534994
          name = "JIS - Probation"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706973 }

    let ``JIS - SAO'1588283`` =
        { id = 1588283
          name = "JIS - SAO"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706973 }

    let ``JIS - Warrants'2192628`` =
        { id = 2192628
          name = "JIS - Warrants"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706973 }

    let ``JIS Password Reset'1449395`` =
        { id = 1449395
          name = "JIS Password Reset"
          default_tags = "Server Side Reset"
          parent_id = 1449378
          deleted = false
          default_assignee_id = Some 6706973 }

    let Java'1474347 =
        { id = 1474347
          name = "Java"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let Keyboard'1448919 =
        { id = 1448919
          name = "Keyboard"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Kiosk Login'1499354`` =
        { id = 1499354
          name = "Kiosk Login"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let Knowbe4'1461465 =
        { id = 1461465
          name = "Knowbe4"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``LANSweeper Enterprise'1598365`` =
        { id = 1598365
          name = "LANSweeper Enterprise"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6568086 }

    let ``LastPass Enterprise Password Manager'1871743`` =
        { id = 1871743
          name = "LastPass Enterprise Password Manager"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Lectern - Portable '1449416`` =
        { id = 1449416
          name = "Lectern - Portable "
          default_tags = ""
          parent_id = 1449404
          deleted = false
          default_assignee_id = Some 6706935 }

    let ``Legal Files'4295292`` =
        { id = 4295292
          name = "Legal Files"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Library Training Database'1499633`` =
        { id = 1499633
          name = "Library Training Database"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Library Training Database'1499634`` =
        { id = 1499634
          name = "Library Training Database"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Library WiFi'1451651`` =
        { id = 1451651
          name = "Library WiFi"
          default_tags = ""
          parent_id = 1449421
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Life Packs'1449429`` =
        { id = 1449429
          name = "Life Packs"
          default_tags = ""
          parent_id = 1449415
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``LinkedIn Learning'4595656`` =
        { id = 4595656
          name = "LinkedIn Learning"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Linkedin Learning Access'1449412`` =
        { id = 1449412
          name = "Linkedin Learning Access"
          default_tags = ""
          parent_id = 1449410
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Loaner Laptop Needed'1456460`` =
        { id = 1456460
          name = "Loaner Laptop Needed"
          default_tags = ""
          parent_id = 1456459
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Loaner MiFi Hotspot Needed'1456462`` =
        { id = 1456462
          name = "Loaner MiFi Hotspot Needed"
          default_tags = ""
          parent_id = 1456459
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Loaner Mobile Phone'1456567`` =
        { id = 1456567
          name = "Loaner Mobile Phone"
          default_tags = ""
          parent_id = 1456459
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``MACD Update'1574185`` =
        { id = 1574185
          name = "MACD Update"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6568086 }

    let ``MFA - Multi Factor Authentication'1475018`` =
        { id = 1475018
          name = "MFA - Multi Factor Authentication"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let Marvlis'1449671 =
        { id = 1449671
          name = "Marvlis"
          default_tags = ""
          parent_id = 1449511
          deleted = false
          default_assignee_id = Some 6706995 }

    let ``Med Unit Mobile Phones'1449430`` =
        { id = 1449430
          name = "Med Unit Mobile Phones"
          default_tags = ""
          parent_id = 1449415
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Medical Examiner'2245723`` =
        { id = 2245723
          name = "Medical Examiner"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706995 }

    let Medvaults'1449427 =
        { id = 1449427
          name = "Medvaults"
          default_tags = ""
          parent_id = 1449415
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``MiFi Portable Hotspot'1449667`` =
        { id = 1449667
          name = "MiFi Portable Hotspot"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Mobile Aircard - Laptop & Tablet'1449666`` =
        { id = 1449666
          name = "Mobile Aircard - Laptop & Tablet"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Mobile Apps'1448810`` =
        { id = 1448810
          name = "Mobile Apps"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Mobile Archive Setup'1477004`` =
        { id = 1477004
          name = "Mobile Archive Setup"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Mobile Contacts Support - Android'1543807`` =
        { id = 1543807
          name = "Mobile Contacts Support - Android"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Mobile Outreach Laptops/Scanner/Receipt Printer'1451837`` =
        { id = 1451837
          name = "Mobile Outreach Laptops/Scanner/Receipt Printer"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Mobile Phone'1448806`` =
        { id = 1448806
          name = "Mobile Phone"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Mobile Phone Purchase Request'1448812`` =
        { id = 1448812
          name = "Mobile Phone Purchase Request"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Modify MDT Deployment'2106672`` =
        { id = 2106672
          name = "Modify MDT Deployment"
          default_tags = ""
          parent_id = 1682335
          deleted = false
          default_assignee_id = Some 6706997 }

    let Monitor'1448918 =
        { id = 1448918
          name = "Monitor"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let Mouse'1448917 =
        { id = 1448917
          name = "Mouse"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``My Rewards'1451594`` =
        { id = 1451594
          name = "My Rewards"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``NWK Reported - Recategorize'1461320`` =
        { id = 1461320
          name = "NWK Reported - Recategorize"
          default_tags = ""
          parent_id = 1459752
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Name Change Needed on Desk Phone'1456570`` =
        { id = 1456570
          name = "Name Change Needed on Desk Phone"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``NeoGov - Call HR Directly'1448896`` =
        { id = 1448896
          name = "NeoGov - Call HR Directly"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Network (PC Login) Password Reset'1449390`` =
        { id = 1449390
          name = "Network (PC Login) Password Reset"
          default_tags = "AD Password Reset"
          parent_id = 1449378
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Network Access Control Lists'1465022`` =
        { id = 1465022
          name = "Network Access Control Lists"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Network Account Support'1450818`` =
        { id = 1450818
          name = "Network Account Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Network Card & Connectivity'1463506`` =
        { id = 1463506
          name = "Network Card & Connectivity"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Network Drive Support'1524969`` =
        { id = 1524969
          name = "Network Drive Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``New Network Port Needed'1727670`` =
        { id = 1727670
          name = "New Network Port Needed"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``New Server Needed'1450814`` =
        { id = 1450814
          name = "New Server Needed"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``New Virtual PC Needed'1456449`` =
        { id = 1456449
          name = "New Virtual PC Needed"
          default_tags = ""
          parent_id = 1456446
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``No Connectivity Between Endpoints'1463516`` =
        { id = 1463516
          name = "No Connectivity Between Endpoints"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``No connectivity at wall port'1463513`` =
        { id = 1463513
          name = "No connectivity at wall port"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``No connectivity on switch port'1463514`` =
        { id = 1463514
          name = "No connectivity on switch port"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``No-Touch Temperature System Setup'1482279`` =
        { id = 1482279
          name = "No-Touch Temperature System Setup"
          default_tags = ""
          parent_id = 1482278
          deleted = true
          default_assignee_id = Some 6706997 }

    let ``Office 365'4595650`` =
        { id = 4595650
          name = "Office 365"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Office 365'1448819`` =
        { id = 1448819
          name = "Office 365"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Office 365 Password Reset'1449381`` =
        { id = 1449381
          name = "Office 365 Password Reset"
          default_tags = "AD Password Reset"
          parent_id = 1449378
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Office 365 Profile Picture'1648021`` =
        { id = 1648021
          name = "Office 365 Profile Picture"
          default_tags = ""
          parent_id = 1535510
          deleted = false
          default_assignee_id = Some 6568086 }

    let ``Office 365 Quick Help Request'1449413`` =
        { id = 1449413
          name = "Office 365 Quick Help Request"
          default_tags = ""
          parent_id = 1449410
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Office 365 Support - SAO'1598431`` =
        { id = 1598431
          name = "Office 365 Support - SAO"
          default_tags = ""
          parent_id = 1598426
          deleted = false
          default_assignee_id = Some 7191004 }

    let ``Office Licensing Change Assignment - G1, G3, etc'2200534`` =
        { id = 2200534
          name = "Office Licensing Change Assignment - G1, G3, etc"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let OneDrive'4595651 =
        { id = 4595651
          name = "OneDrive"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let OneDrive'1448829 =
        { id = 1448829
          name = "OneDrive"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Operative IQ'1465114`` =
        { id = 1465114
          name = "Operative IQ"
          default_tags = ""
          parent_id = 1449511
          deleted = false
          default_assignee_id = Some 6706995 }

    let ``Oracle Support'1524347`` =
        { id = 1524347
          name = "Oracle Support"
          default_tags = ""
          parent_id = 1524346
          deleted = false
          default_assignee_id = Some 14692648 }

    let ``Orion by SolarWinds'1681823`` =
        { id = 1681823
          name = "Orion by SolarWinds"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Other - Not Listed'1449372`` =
        { id = 1449372
          name = "Other - Not Listed"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let Outlook'1448820 =
        { id = 1448820
          name = "Outlook"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Outlook - Microsoft'4595660`` =
        { id = 4595660
          name = "Outlook - Microsoft"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Outreach Tablets'1451842`` =
        { id = 1451842
          name = "Outreach Tablets"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PC Deployments - NEW'1466833`` =
        { id = 1466833
          name = "PC Deployments - NEW"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PC Deployments - OLD'1466834`` =
        { id = 1466834
          name = "PC Deployments - OLD"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PC Health Check/Cleanup'2303921`` =
        { id = 2303921
          name = "PC Health Check/Cleanup"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PC Move - Different Room'1449407`` =
        { id = 1449407
          name = "PC Move - Different Room"
          default_tags = ""
          parent_id = 1449403
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PC Move - Same Room'1449406`` =
        { id = 1449406
          name = "PC Move - Same Room"
          default_tags = ""
          parent_id = 1449403
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PC Related Support - SAO'1598432`` =
        { id = 1598432
          name = "PC Related Support - SAO"
          default_tags = ""
          parent_id = 1598426
          deleted = false
          default_assignee_id = Some 7191004 }

    let ``PC Removal - Permanent'1449408`` =
        { id = 1449408
          name = "PC Removal - Permanent"
          default_tags = ""
          parent_id = 1449403
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PC Removal - Temporary'1449409`` =
        { id = 1449409
          name = "PC Removal - Temporary"
          default_tags = ""
          parent_id = 1449403
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PSC - Audio Visual Devices'1449512`` =
        { id = 1449512
          name = "PSC - Audio Visual Devices"
          default_tags = ""
          parent_id = 1449476
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PSC - Conference Room Devices'1449505`` =
        { id = 1449505
          name = "PSC - Conference Room Devices"
          default_tags = ""
          parent_id = 1449476
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PSC - Digital Signage Devices'1449509`` =
        { id = 1449509
          name = "PSC - Digital Signage Devices"
          default_tags = ""
          parent_id = 1449476
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PSC - Facilities Management PC Support'1449510`` =
        { id = 1449510
          name = "PSC - Facilities Management PC Support"
          default_tags = ""
          parent_id = 1449476
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PSC - Room Rearrangement'1500631`` =
        { id = 1500631
          name = "PSC - Room Rearrangement"
          default_tags = ""
          parent_id = 1449476
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``PSC - Security Desk Devices'1449508`` =
        { id = 1449508
          name = "PSC - Security Desk Devices"
          default_tags = ""
          parent_id = 1449476
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Paradigm (Compuweigh)'1448915`` =
        { id = 1448915
          name = "Paradigm (Compuweigh)"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706982 }

    let ``Password Reset'1397171`` =
        { id = 1397171
          name = "Password Reset"
          default_tags = "password reset"
          parent_id = 1397170
          deleted = true
          default_assignee_id = None }

    let ``Password or Security Support'1642932`` =
        { id = 1642932
          name = "Password or Security Support"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Patching & Prep'1461317`` =
        { id = 1461317
          name = "Patching & Prep"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Patching & Prep'1461316`` =
        { id = 1461316
          name = "Patching & Prep"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Patching Request'1511908`` =
        { id = 1511908
          name = "Patching Request"
          default_tags = ""
          parent_id = 1449433
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Pay-For-Print - Mobile Printing'1451827`` =
        { id = 1451827
          name = "Pay-For-Print - Mobile Printing"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Pay-For-Print - Print Release Stations'1451789`` =
        { id = 1451789
          name = "Pay-For-Print - Print Release Stations"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Phone Cords & Cables'1451477`` =
        { id = 1451477
          name = "Phone Cords & Cables"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Phone Features Not Working'1514046`` =
        { id = 1514046
          name = "Phone Features Not Working"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Phone Move Needed'1449543`` =
        { id = 1449543
          name = "Phone Move Needed"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Phone Port Activation'1464873`` =
        { id = 1464873
          name = "Phone Port Activation"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Point of Sale System(s)'4654247`` =
        { id = 4654247
          name = "Point of Sale System(s)"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let PolicyPak'4751095 =
        { id = 4751095
          name = "PolicyPak"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let PolicyPak'2460015 =
        { id = 2460015
          name = "PolicyPak"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Portable Scanners'1870782`` =
        { id = 1870782
          name = "Portable Scanners"
          default_tags = ""
          parent_id = 1449415
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Possible Infection Detected'1816862`` =
        { id = 1816862
          name = "Possible Infection Detected"
          default_tags = ""
          parent_id = 1562844
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Power - Won't Come On'1451475`` =
        { id = 1451475
          name = "Power - Won\'t Come On"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Power BI'1658455`` =
        { id = 1658455
          name = "Power BI"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Power Bi & Gateway Portal'1513425`` =
        { id = 1513425
          name = "Power Bi & Gateway Portal"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Power Strip Needed'1451413`` =
        { id = 1451413
          name = "Power Strip Needed"
          default_tags = ""
          parent_id = 1449403
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Power Supply Support'1551358`` =
        { id = 1551358
          name = "Power Supply Support"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Printer - Add Printer to PC'1503656`` =
        { id = 1503656
          name = "Printer - Add Printer to PC"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Printers - Non-Sharp'1449360`` =
        { id = 1449360
          name = "Printers - Non-Sharp"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Printing Problems - Driver Issues'1466346`` =
        { id = 1466346
          name = "Printing Problems - Driver Issues"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ProjectDox'1448913 =
        { id = 1448913
          name = "ProjectDox"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706982 }

    let ``ProofPoint SPAM Support'1465023`` =
        { id = 1465023
          name = "ProofPoint SPAM Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Public Catalog PC's'1451833`` =
        { id = 1451833
          name = "Public Catalog PC\'s"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Public Document Scanners'1451839`` =
        { id = 1451839
          name = "Public Document Scanners"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Public Internet PC's'1451832`` =
        { id = 1451832
          name = "Public Internet PC\'s"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Public Laptops'1451834`` =
        { id = 1451834
          name = "Public Laptops"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Public Notices'4460554`` =
        { id = 4460554
          name = "Public Notices"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Public Printers'1451838`` =
        { id = 1451838
          name = "Public Printers"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Public Records Request Support'1450835`` =
        { id = 1450835
          name = "Public Records Request Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Public WiFi - Non-Library'1449422`` =
        { id = 1449422
          name = "Public WiFi - Non-Library"
          default_tags = ""
          parent_id = 1449421
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Purchase Software'1451589`` =
        { id = 1451589
          name = "Purchase Software"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Quote Needed - PC or Other Hardware'1456515`` =
        { id = 1456515
          name = "Quote Needed - PC or Other Hardware"
          default_tags = ""
          parent_id = 1456442
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Quote Needed - Software'1524342`` =
        { id = 1524342
          name = "Quote Needed - Software"
          default_tags = ""
          parent_id = 1456442
          deleted = false
          default_assignee_id = Some 6706997 }

    let RFID'1486233 =
        { id = 1486233
          name = "RFID"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Raven Scanners'1499407`` =
        { id = 1499407
          name = "Raven Scanners"
          default_tags = ""
          parent_id = 1451772
          deleted = true
          default_assignee_id = Some 6715952 }

    let ``Re-Image PC/Laptop/Tablet'1476509`` =
        { id = 1476509
          name = "Re-Image PC/Laptop/Tablet"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``RecTrac / WebTrac'1524344`` =
        { id = 1524344
          name = "RecTrac / WebTrac"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Relocate - Copiers & Printers'1451505`` =
        { id = 1451505
          name = "Relocate - Copiers & Printers"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Remote Access - RDP'1466760`` =
        { id = 1466760
          name = "Remote Access - RDP"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Removal - Copiers & Printers'1451534`` =
        { id = 1451534
          name = "Removal - Copiers & Printers"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Remove Photo in Profile'1463510`` =
        { id = 1463510
          name = "Remove Photo in Profile"
          default_tags = ""
          parent_id = 1461466
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Replace Photo in Profile'1463509`` =
        { id = 1463509
          name = "Replace Photo in Profile"
          default_tags = ""
          parent_id = 1461466
          deleted = false
          default_assignee_id = Some 6568086 }

    let ``Request Email Add to Filter'1463911`` =
        { id = 1463911
          name = "Request Email Add to Filter"
          default_tags = ""
          parent_id = 1463910
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Research - EMS Specific'1462957`` =
        { id = 1462957
          name = "Research - EMS Specific"
          default_tags = ""
          parent_id = 1449415
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Research - EOC Specific'1462956`` =
        { id = 1462956
          name = "Research - EOC Specific"
          default_tags = ""
          parent_id = 1449433
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Research - Library Specific'1462955`` =
        { id = 1462955
          name = "Research - Library Specific"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Research - PSC Specific'2145415`` =
        { id = 2145415
          name = "Research - PSC Specific"
          default_tags = ""
          parent_id = 1449476
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Reservation Tracking System '1481061`` =
        { id = 1481061
          name = "Reservation Tracking System "
          default_tags = ""
          parent_id = 1448839
          deleted = true
          default_assignee_id = Some 6706982 }

    let ``Reset Virtual PC'1456452`` =
        { id = 1456452
          name = "Reset Virtual PC"
          default_tags = ""
          parent_id = 1456446
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Reset Voicemail Password'1449535`` =
        { id = 1449535
          name = "Reset Voicemail Password"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Routers - In Truck'1449428`` =
        { id = 1449428
          name = "Routers - In Truck"
          default_tags = ""
          parent_id = 1449415
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``SIM Cards'1449668`` =
        { id = 1449668
          name = "SIM Cards"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``SIRSI Workflows'1451828`` =
        { id = 1451828
          name = "SIRSI Workflows"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``SPAM user digest not working'1463912`` =
        { id = 1463912
          name = "SPAM user digest not working"
          default_tags = ""
          parent_id = 1463910
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``SQL Support'1524348`` =
        { id = 1524348
          name = "SQL Support"
          default_tags = ""
          parent_id = 1524346
          deleted = false
          default_assignee_id = Some 15065194 }

    let ``SSL Certificate Support'1450828`` =
        { id = 1450828
          name = "SSL Certificate Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``STAC Support - SAO'1598429`` =
        { id = 1598429
          name = "STAC Support - SAO"
          default_tags = ""
          parent_id = 1598426
          deleted = false
          default_assignee_id = Some 7191004 }

    let ``Scan to Email Account Management'1464874`` =
        { id = 1464874
          name = "Scan to Email Account Management"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Scanner - Local'1910263`` =
        { id = 1910263
          name = "Scanner - Local"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Schedule Move'1503658`` =
        { id = 1503658
          name = "Schedule Move"
          default_tags = ""
          parent_id = 1478583
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Schedule Surplus'1503657`` =
        { id = 1503657
          name = "Schedule Surplus"
          default_tags = ""
          parent_id = 1478583
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Security System/Vendor Support'1803886`` =
        { id = 1803886
          name = "Security System/Vendor Support"
          default_tags = ""
          parent_id = 1562844
          deleted = false
          default_assignee_id = Some 6706928 }

    let Selectron'1449673 =
        { id = 1449673
          name = "Selectron"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706959 }

    let ``Self Checkout Machines'1451831`` =
        { id = 1451831
          name = "Self Checkout Machines"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Server Antivirus Support'1639942`` =
        { id = 1639942
          name = "Server Antivirus Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Service Desk - OIT Solar Winds'1461463`` =
        { id = 1461463
          name = "Service Desk - OIT Solar Winds"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6568482 }

    let ``Service Desk - SolarWinds'1499409`` =
        { id = 1499409
          name = "Service Desk - SolarWinds"
          default_tags = ""
          parent_id = 1449378
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``SharePoint 365'1513365`` =
        { id = 1513365
          name = "SharePoint 365"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Shortcuts or Icons'1479424`` =
        { id = 1479424
          name = "Shortcuts or Icons"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let Smartsheet'1448897 =
        { id = 1448897
          name = "Smartsheet"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6568482 }

    let ``Softphone Avaya'1463424`` =
        { id = 1463424
          name = "Softphone Avaya"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Software Related Support - SAO'1598433`` =
        { id = 1598433
          name = "Software Related Support - SAO"
          default_tags = ""
          parent_id = 1598426
          deleted = false
          default_assignee_id = Some 7191004 }

    let ``Software Removal Needed'1478589`` =
        { id = 1478589
          name = "Software Removal Needed"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Software Won't Run'1478063`` =
        { id = 1478063
          name = "Software Won\'t Run"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Software Won't Run or Runs Slow'1524970`` =
        { id = 1524970
          name = "Software Won\'t Run or Runs Slow"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Sound System - Portable'1449417`` =
        { id = 1449417
          name = "Sound System - Portable"
          default_tags = ""
          parent_id = 1449404
          deleted = false
          default_assignee_id = Some 6706935 }

    let ``Speaker Bar or Speakers'1499461`` =
        { id = 1499461
          name = "Speaker Bar or Speakers"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Speaker Timer - CAO'1647965`` =
        { id = 1647965
          name = "Speaker Timer - CAO"
          default_tags = ""
          parent_id = 1466687
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Speaker Timer - Clerk'1647964`` =
        { id = 1647964
          name = "Speaker Timer - Clerk"
          default_tags = ""
          parent_id = 1466687
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Special Event Equipment Needed'2120313`` =
        { id = 2120313
          name = "Special Event Equipment Needed"
          default_tags = ""
          parent_id = 1449415
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Staff Activity Manager'1451826`` =
        { id = 1451826
          name = "Staff Activity Manager"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Staff Laptops'1451840`` =
        { id = 1451840
          name = "Staff Laptops"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Staff Printers & Copiers'1451845`` =
        { id = 1451845
          name = "Staff Printers & Copiers"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Staff Receipt Printers'1451830`` =
        { id = 1451830
          name = "Staff Receipt Printers"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Staff WiFi'1449423`` =
        { id = 1449423
          name = "Staff WiFi"
          default_tags = ""
          parent_id = 1449421
          deleted = false
          default_assignee_id = Some 6706935 }

    let Steam'1500628 =
        { id = 1500628
          name = "Steam"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Sticky Notes'1648393`` =
        { id = 1648393
          name = "Sticky Notes"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Stock Spare Request'1488786`` =
        { id = 1488786
          name = "Stock Spare Request"
          default_tags = ""
          parent_id = 1478583
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``SuperSAAS Room Reservations'1451591`` =
        { id = 1451591
          name = "SuperSAAS Room Reservations"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Surplus - Old Equipment'1478584`` =
        { id = 1478584
          name = "Surplus - Old Equipment"
          default_tags = ""
          parent_id = 1478583
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Surplus Storage Needed'1478585`` =
        { id = 1478585
          name = "Surplus Storage Needed"
          default_tags = ""
          parent_id = 1478583
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``TLC Permits'1507787`` =
        { id = 1507787
          name = "TLC Permits"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``TOTP Hardware Token'4490397`` =
        { id = 4490397
          name = "TOTP Hardware Token"
          default_tags = ""
          parent_id = 1562844
          deleted = false
          default_assignee_id = Some 6706945 }

    let TabFusion'1568152 =
        { id = 1568152
          name = "TabFusion"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6568482 }

    let ``Team Viewer'2120908`` =
        { id = 2120908
          name = "Team Viewer"
          default_tags = ""
          parent_id = 1448818
          deleted = true
          default_assignee_id = Some 6706997 }

    let ``TeamViewer Enterprise'1478463`` =
        { id = 1478463
          name = "TeamViewer Enterprise"
          default_tags = ""
          parent_id = 1448839
          deleted = true
          default_assignee_id = Some 6706997 }

    let ``Teams CLOUD Configurations ONLY'4164328`` =
        { id = 4164328
          name = "Teams CLOUD Configurations ONLY"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 9909293 }

    let ``Teams Cloud Configuration'1884678`` =
        { id = 1884678
          name = "Teams Cloud Configuration"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 9909293 }

    let ``Teams Desktop Software'4164329`` =
        { id = 4164329
          name = "Teams Desktop Software"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Teams Desktop Software'1451588`` =
        { id = 1451588
          name = "Teams Desktop Software"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Technology Supplies Needed'1456456`` =
        { id = 1456456
          name = "Technology Supplies Needed"
          default_tags = ""
          parent_id = 1456442
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Telestaff (AD) Password Reset'1819679`` =
        { id = 1819679
          name = "Telestaff (AD) Password Reset"
          default_tags = ""
          parent_id = 1449378
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Television Support'1500620`` =
        { id = 1500620
          name = "Television Support"
          default_tags = ""
          parent_id = 1449404
          deleted = false
          default_assignee_id = Some 6706935 }

    let ``Toner Orders'1449366`` =
        { id = 1449366
          name = "Toner Orders"
          default_tags = ""
          parent_id = 1449343
          deleted = false
          default_assignee_id = Some 6706997 }

    let Triptix'1449670 =
        { id = 1449670
          name = "Triptix"
          default_tags = ""
          parent_id = 1449511
          deleted = false
          default_assignee_id = Some 6706995 }

    let ``Troubleshoot Policy'2480878`` =
        { id = 2480878
          name = "Troubleshoot Policy"
          default_tags = ""
          parent_id = 2465648
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Turbo Containers & Server'1512190`` =
        { id = 1512190
          name = "Turbo Containers & Server"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Two Factor Authentication'1524836`` =
        { id = 1524836
          name = "Two Factor Authentication"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Two Factor Authentication'1524835`` =
        { id = 1524835
          name = "Two Factor Authentication"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``UDCID Account Needed (Leonad)'1468415`` =
        { id = 1468415
          name = "UDCID Account Needed (Leonad)"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``USB Drive Support'1450837`` =
        { id = 1450837
          name = "USB Drive Support"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Unlock AD Account'1570132`` =
        { id = 1570132
          name = "Unlock AD Account"
          default_tags = ""
          parent_id = 1449378
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Update Base VM'1466752`` =
        { id = 1466752
          name = "Update Base VM"
          default_tags = ""
          parent_id = 1456446
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Update Desktop Pool'3076741`` =
        { id = 3076741
          name = "Update Desktop Pool"
          default_tags = ""
          parent_id = 1456446
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Update Existing Image'1682337`` =
        { id = 1682337
          name = "Update Existing Image"
          default_tags = ""
          parent_id = 1682335
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``User How-To'1688678`` =
        { id = 1688678
          name = "User How-To"
          default_tags = ""
          parent_id = 1449410
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``VOD & Invintus Agenda Support'1451596`` =
        { id = 1451596
          name = "VOD & Invintus Agenda Support"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``VPN Password Reset'1449389`` =
        { id = 1449389
          name = "VPN Password Reset"
          default_tags = "AD Password Reset"
          parent_id = 1449378
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``VPN Password Reset - Contractors ONLY'1451420`` =
        { id = 1451420
          name = "VPN Password Reset - Contractors ONLY"
          default_tags = "Server Side Reset"
          parent_id = 1449378
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``VPN Related Support'1525191`` =
        { id = 1525191
          name = "VPN Related Support"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Vcenter Related Support'1450832`` =
        { id = 1450832
          name = "Vcenter Related Support"
          default_tags = ""
          parent_id = 1449664
          deleted = false
          default_assignee_id = Some 6706945 }

    let ``Vendor Supplied Training Request - Offsite'1449414`` =
        { id = 1449414
          name = "Vendor Supplied Training Request - Offsite"
          default_tags = ""
          parent_id = 1449410
          deleted = false
          default_assignee_id = Some 6693027 }

    let ``Verify phone needs'2223043`` =
        { id = 2223043
          name = "Verify phone needs"
          default_tags = ""
          parent_id = 1449405
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Video Content Support'1487101`` =
        { id = 1487101
          name = "Video Content Support"
          default_tags = ""
          parent_id = 1466687
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Video Evidence Player Support - SAO'1598430`` =
        { id = 1598430
          name = "Video Evidence Player Support - SAO"
          default_tags = ""
          parent_id = 1598426
          deleted = false
          default_assignee_id = Some 7191004 }

    let ``Virtual Machine Troubleshooting'2248354`` =
        { id = 2248354
          name = "Virtual Machine Troubleshooting"
          default_tags = ""
          parent_id = 1456446
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Virus or Malware'1466820`` =
        { id = 1466820
          name = "Virus or Malware"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let Visio'1662100 =
        { id = 1662100
          name = "Visio"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Voicemail Password Reset'1449537`` =
        { id = 1449537
          name = "Voicemail Password Reset"
          default_tags = "Server Side Reset"
          parent_id = 1449378
          deleted = false
          default_assignee_id = Some 6706896 }

    let ``Voicify Support'1559690`` =
        { id = 1559690
          name = "Voicify Support"
          default_tags = ""
          parent_id = 1466687
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``WEB Reported - Recategorize'1462652`` =
        { id = 1462652
          name = "WEB Reported - Recategorize"
          default_tags = ""
          parent_id = 1459752
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Web Application Won't Run'1475017`` =
        { id = 1475017
          name = "Web Application Won\'t Run"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Web Forms Support'1449605`` =
        { id = 1449605
          name = "Web Forms Support"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let WebEx'1462895 =
        { id = 1462895
          name = "WebEx"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let Webcam'1466836 =
        { id = 1466836
          name = "Webcam"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Website Content Update Request'1465168`` =
        { id = 1465168
          name = "Website Content Update Request"
          default_tags = ""
          parent_id = 1449565
          deleted = false
          default_assignee_id = Some 6706989 }

    let ``Website URL Blocked'1489368`` =
        { id = 1489368
          name = "Website URL Blocked"
          default_tags = ""
          parent_id = 1463512
          deleted = false
          default_assignee_id = Some 6706928 }

    let Webxtender'1448899 =
        { id = 1448899
          name = "Webxtender"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6714348 }

    let ``WiFi - Laptop & Tablet'1449665`` =
        { id = 1449665
          name = "WiFi - Laptop & Tablet"
          default_tags = ""
          parent_id = 1448916
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``WiFi - Public'1451835`` =
        { id = 1451835
          name = "WiFi - Public"
          default_tags = ""
          parent_id = 1451772
          deleted = false
          default_assignee_id = Some 6706928 }

    let Windows'1479537 =
        { id = 1479537
          name = "Windows"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let Word'1448822 =
        { id = 1448822
          name = "Word"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Word - Microsoft'4595652`` =
        { id = 4595652
          name = "Word - Microsoft"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Workforce Telestaff'1449672`` =
        { id = 1449672
          name = "Workforce Telestaff"
          default_tags = ""
          parent_id = 1449511
          deleted = false
          default_assignee_id = Some 6706995 }

    let Zoom'1462896 =
        { id = 1462896
          name = "Zoom"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Zoom REV Closed Captioning AI'1468303`` =
        { id = 1468303
          name = "Zoom REV Closed Captioning AI"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Zoom for Leon County ONLY'1727679`` =
        { id = 1727679
          name = "Zoom for Leon County ONLY"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``Zscaler VPN'4247104`` =
        { id = 4247104
          name = "Zscaler VPN"
          default_tags = ""
          parent_id = 1448839
          deleted = false
          default_assignee_id = Some 6706928 }

    let ``Zscaler VPN'4247044`` =
        { id = 4247044
          name = "Zscaler VPN"
          default_tags = ""
          parent_id = 1448818
          deleted = false
          default_assignee_id = Some 6706997 }

    let iDrive'1465115 =
        { id = 1465115
          name = "iDrive"
          default_tags = ""
          parent_id = 1449511
          deleted = false
          default_assignee_id = Some 6706995 }

    let iPad'1448805 =
        { id = 1448805
          name = "iPad"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }

    let ``iPad Purchase Request'1451380`` =
        { id = 1451380
          name = "iPad Purchase Request"
          default_tags = ""
          parent_id = 1448804
          deleted = false
          default_assignee_id = Some 6706997 }
