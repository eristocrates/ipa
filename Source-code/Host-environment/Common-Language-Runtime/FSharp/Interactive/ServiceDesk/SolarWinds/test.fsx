#r "nuget: PosInformatique.Foundations.EmailAddresses"
#r "nuget: FSharp.Data"
#r "nuget: Dubzer.WhatwgUrl"
#r "nuget: libphonenumber-csharp"
open System
open PosInformatique.Foundations.EmailAddresses
open Dubzer.WhatwgUrl
open FSharp.Data
open PhoneNumbers

type Priority =
    | None = -1
    | Low = 4
    | Medium = 3
    | High = 2
    | Critical = 1

type Department =
    | Administration = 353811
    | Appraiser = 353830
    | Archives = 1080875
    | Audit = 1080876
    | Audits = 285788
    | ``Avenu Insights`` = 1142976
    | ``Bailiff Unit`` = 238710
    | BOCC = 285791
    | ``Brooks Building Solutions`` = 1142974
    | ``Brooks Bulding Solutions`` = 662388
    | ``Building Logix`` = 1142990
    | CDA = 302701
    | ``Central Cashiering`` = 376634
    | ``Central Filing`` = 1080877
    | ``Certified Controls`` = 1142985
    | ``Child Services Council`` = 285817
    | CIS = 285344
    | ``City of Tallahassee (CoT)`` = 259792
    | ``Civil Administration`` = 1080878
    | ``Civil Customer Assistance`` = 353813
    | ``Civil Customer Service`` = 1080815
    | ``Civil Filing`` = 376636
    | ``Civil Intake`` = 353827
    | ``Clerk Administration`` = 285737
    | ``Clerk of Courts`` = 236161
    | Commercial = 353836
    | ``County Administration`` = 236121
    | ``County Commission`` = 236120
    | ``County Probation`` = 285802
    | ``Court - Court Administration`` = 236163
    | ``Court - Other Court-Related Programs`` = 236164
    | ``Court Administration`` = 236165
    | ``Court Attendance`` = 353843
    | Courts = 238704
    | ``Criminal Customer Assistance`` = 376629
    | ``Criminal Customer Service`` = 376633
    | ``Criminal Intake`` = 1080879
    | ``Criminal Support`` = 353840
    | ``CSC - Children's Services Council of Leon County`` = 322520
    | ``CSO-SRO`` = 1080814
    | ``Delta Technologies`` = 1142970
    | ``Detention Operations Division`` = 1142981
    | ``Developmental Support and Environmental Management`` = 285783
    | ``Emergency Management Services`` = 285813
    | ``Emergency Management-Floor`` = 285720
    | ``Engineering Services`` = 285765
    | Exemption = 376630
    | Exemptions = 353834
    | ``Facilities Management`` = 236125
    | FBI = 1143012
    | Fellowship = 1080880
    | Finance = 285354
    | ``Finance: Treasury`` = 1080881
    | ``GAL - Guardian Ad Litem`` = 236325
    | ``Geographic Information Systems`` = 285787
    | GIS = 353832
    | ``GIS - Office of Economic Vitality`` = 236147
    | ``Guardian Ad-Litem`` = 353850
    | ``Help Center`` = 376616
    | ``Housing and Human Services`` = 285764
    | HR = 1080882
    | ``Human Resources`` = 1080883
    | IT = 353824
    | ``Johnson Controls`` = 1142988
    | ``Judicial Bureau`` = 1142969
    | ``K-9 Unit`` = 1143002
    | ``LCG - Animal Control`` = 236118
    | ``LCG - Building Plans Review & Inspection`` = 236131
    | ``LCG - County Administration`` = 236116
    | ``LCG - County Attorney`` = 236162
    | ``LCG - County Commission`` = 236119
    | ``LCG - County Probation`` = 236151
    | ``LCG - Customer Engagement Services`` = 236132
    | ``LCG - Development Services`` = 236134
    | ``LCG - Drug & Alcohol Testing`` = 236152
    | ``LCG - DS Support Services`` = 236140
    | ``LCG - Emergency Management Services`` = 285763
    | ``LCG - Emergency Medical Services`` = 236124
    | ``LCG - Engineering Services`` = 236154
    | ``LCG - Environmental Services`` = 236141
    | ``LCG - Facilities Management`` = 236127
    | ``LCG - Fleet Management`` = 236155
    | ``LCG - Geographic Information Systems`` = 233803
    | ``LCG - Grants - Emergency Management`` = 236437
    | ``LCG - Grants Sheriff`` = 353874
    | ``LCG - Housing Services`` = 236143
    | ``LCG - Human Resources`` = 236145
    | ``LCG - Human Services`` = 236144
    | ``LCG - Library Services`` = 236146
    | ``LCG - Management Information Services`` = 233802
    | ``LCG - Office of Management and Budget`` = 236122
    | ``LCG - Office of Sustainability`` = 236158
    | ``LCG - Operations`` = 236148
    | ``LCG - Parks and Recreation`` = 236128
    | ``LCG - Permit and Code Services`` = 236142
    | ``LCG - Public Works`` = 285355
    | ``LCG - Purchasing`` = 236157
    | ``LCG - PW Support Services`` = 236156
    | ``LCG - Real Estate Management`` = 236149
    | ``LCG - Risk Management`` = 236150
    | ``LCG - Solid Waste`` = 236129
    | ``LCG - Strategic Initiatives`` = 236117
    | ``LCG - Supervised Pretrial Release`` = 236153
    | ``LCG - Tourism Development`` = 236159
    | ``LCG - Veteran Services`` = 236160
    | ``LCG- Management Information Services`` = 1080884
    | ``LCSO Detention `` = 1080886
    | ``LCSO-`` = 285743
    | ``LCSO- Bailiff`` = 1080885
    | ``LCSO- Information Technology`` = 376619
    | ``LCSO-Accreditation`` = 285818
    | ``LCSO-Administration`` = 285749
    | ``LCSO-Administration - CIB (230)`` = 285768
    | ``LCSO-Administration and External Affairs Department`` = 1142961
    | ``LCSO-Administrative Services`` = 285738
    | ``LCSO-Aviation`` = 285739
    | ``LCSO-Bailiff`` = 285733
    | ``LCSO-Bailiff Unit`` = 285361
    | ``LCSO-Booking and Releasing`` = 285731
    | ``LCSO-Bureau of Uniform Patrol`` = 285752
    | ``LCSO-Chaplain`` = 285766
    | ``LCSO-CIB`` = 285821
    | ``LCSO-CIB - Propery Crimes`` = 285777
    | ``LCSO-CIB ICAC`` = 285359
    | ``LCSO-CIB Organized Crime`` = 1143010
    | ``LCSO-CIB Persons Investigations`` = 353842
    | ``LCSO-CIB Property`` = 285357
    | ``LCSO-Citizen Advisory Council`` = 376625
    | ``LCSO-Civil`` = 285761
    | ``LCSO-Communications`` = 285797
    | ``LCSO-Community & Media Relations`` = 285775
    | ``LCSO-Corizon`` = 285714
    | ``LCSO-Corizon Medical`` = 285353
    | ``LCSO-CorrecTek Vendor`` = 1142971
    | ``LCSO-Correctional Officer`` = 376618
    | ``LCSO-Crime Prevention`` = 285774
    | ``LCSO-Crime Scene`` = 285722
    | ``LCSO-Crimescene`` = 439580
    | ``LCSO-Criminal Intelligence Bureau`` = 1143000
    | ``LCSO-Crossing Guard`` = 285754
    | ``LCSO-CSMB`` = 353871
    | ``LCSO-DCF`` = 1143011
    | ``LCSO-Department of Finance`` = 1143008
    | ``LCSO-Department of Law Enforcement`` = 1142993
    | ``LCSO-Detention`` = 285343
    | ``LCSO-Detention Administration`` = 285740
    | ``LCSO-Detention Administratiron`` = 376626
    | ``LCSO-Detention Housing`` = 285773
    | ``LCSO-Detention Medical`` = 285721
    | ``LCSO-Detention Operations`` = 285345
    | ``LCSO-Detention Records Administration`` = 285741
    | ``LCSO-Detetntion Operations`` = 376623
    | ``LCSO-Disabled`` = 285347
    | ``LCSO-Extra Duty Office`` = 285808
    | ``LCSO-Facilities Maintenance`` = 285769
    | ``LCSO-Financial Crimes`` = 285751
    | ``LCSO-Fiscal`` = 353825
    | ``LCSO-Fiscal Operations`` = 285745
    | ``LCSO-Fleet`` = 285727
    | ``LCSO-Fugitive Task Force`` = 285781
    | ``LCSO-Human Relations`` = 353828
    | ``LCSO-Human Resources`` = 285758
    | ``LCSO-ICAC`` = 285771
    | ``LCSO-Information Technology`` = 285715
    | ``LCSO-Inmate Services`` = 285820
    | ``LCSO-Inmate Welfare`` = 353812
    | ``LCSO-Inmate Welfare - Support Services`` = 285799
    | ``LCSO-Inmate Work Details`` = 285804
    | ``LCSO-Intel`` = 285770
    | ``LCSO-Internal Affairs`` = 285801
    | ``LCSO-Investigations`` = 285356
    | ``LCSO-Jail Operations`` = 285807
    | ``LCSO-Jail Operations (450)`` = 285723
    | ``LCSO-Judicial Services`` = 285798
    | ``LCSO-Juvenile Investigations`` = 285746
    | ``LCSO-K-9`` = 285772
    | ``LCSO-Law Enforcement`` = 285806
    | ``LCSO-LCSO-Uniform Patrol`` = 285795
    | ``LCSO-Legal`` = 285819
    | ``LCSO-Leon County Sheriff's Office Advisory Council`` = 285789
    | ``LCSO-Media Relations`` = 285814
    | ``LCSO-No_Department`` = 285782
    | ``LCSO-Patrol`` = 285342
    | ``LCSO-Patrol Support`` = 285756
    | ``LCSO-PREA Coordinaton`` = 1143007
    | ``LCSO-Procurement`` = 285805
    | ``LCSO-Professional Standards`` = 285779
    | ``LCSO-Property and Evidence`` = 1142997
    | ``LCSO-Property Crimes`` = 285360
    | ``LCSO-Public Relations`` = 353872
    | ``LCSO-Purchasing`` = 285726
    | ``LCSO-RAPID`` = 662387
    | ``LCSO-Re-Entry and Inmate Programs`` = 1142983
    | ``LCSO-Real Time Crime Center`` = 353849
    | ``LCSO-Records`` = 285735
    | ``LCSO-Records Management`` = 285362
    | ``LCSO-Recruiting`` = 353873
    | ``LCSO-Reserves`` = 285346
    | ``LCSO-Resources`` = 376635
    | ``LCSO-RTCC`` = 285810
    | ``LCSO-School Crossing Guards`` = 285809
    | ``LCSO-School Resource`` = 285728
    | ``LCSO-School Resource Unit`` = 285811
    | ``LCSO-School Resource Unit (510)`` = 285760
    | ``LCSO-Sheriff`` = 285790
    | ``LCSO-Sheriff Staff`` = 285796
    | ``LCSO-Sheriff's Office`` = 285792
    | ``LCSO-Special Investigations`` = 353826
    | ``LCSO-Special Operations Division`` = 1142980
    | ``LCSO-Special Victims Unit`` = 285753
    | ``LCSO-Supply and Facilities`` = 439578
    | ``LCSO-SVU`` = 285794
    | ``LCSO-TPD Taskforce`` = 1142977
    | ``LCSO-Traffic`` = 285730
    | ``LCSO-Training`` = 285742
    | ``LCSO-Training Unit`` = 285812
    | ``LCSO-UIniform Patrol`` = 1142987
    | ``LCSO-Uniform Parol TEA`` = 381316
    | ``LCSO-Uniform Patrol`` = 285358
    | ``LCSO-US Marshalls`` = 1143005
    | ``LCSO-VCU`` = 285778
    | ``LCSO-Vendor`` = 353829
    | ``LCSO-Victim Advocate`` = 285750
    | ``LCSO-Violent Crimes`` = 285759
    | ``LCSO-Volunteer`` = 376639
    | ``LCSO-Warrants`` = 285748
    | ``LCSO-Wellness`` = 1143004
    | ``LCSO-Wellness and Resiliency`` = 1142998
    | ``LCSO-YesCare`` = 353810
    | ``LCSO-Youth Services`` = 285780
    | ``Leon County Medical Examiner`` = 376613
    | Library = 285755
    | ``Library Services`` = 285822
    | ``LSCO-ICAC`` = 1142979
    | ``LSO-Human Resources`` = 439577
    | ``Management Information Services`` = 285785
    | ``Management Services`` = 353838
    | ME = 332626
    | ``Mentis Technology`` = 1142978
    | ``Metro Traffic`` = 376637
    | ``Not Set`` = 285505
    | ``OEV - PLANNING DEPARTMENT`` = 376615
    | ``Office of Information and Technology`` = 1142975
    | ``Office of Information Technology`` = 1080816
    | ``Office of Sustainability`` = 285803
    | ``Official Records`` = 285762
    | Operations = 285776
    | ``ORS - Facilities Management for LCSO`` = 285784
    | ``ORS/Facilities Management`` = 236130
    | ``Other Court-Related Programs`` = 285793
    | ``Ownership Records`` = 353831
    | ``Paradigm Software`` = 1142973
    | ``PRO Phoenix`` = 924983
    | ``Property Appraiser`` = 238720
    | ``PSC Security`` = 330202
    | ``Public Defender's Office`` = 235997
    | ``Public Relations`` = 353839
    | ``Public Works`` = 285747
    | Records = 1142995
    | ``Records Management`` = 376632
    | RedundantExport = 924984
    | Residential = 353833
    | ``School Resource Unit`` = 1142992
    | ``SGS Technologies LLC`` = 439579
    | ``SOE - Supervisor of Elections`` = 236166
    | ``Solid Waste`` = 285767
    | ``Special Processing`` = 1142972
    | ``State Attorney`` = 236168
    | ``Strategic Initiatives`` = 285757
    | ``Supervised Pretrial Release`` = 238703
    | Tangible = 353835
    | ``Tax Collector`` = 238740
    | TPP = 353837
    | Traffic = 353875
    | ``Traffic Remote`` = 376614

type Incident =
    { id: int
      number: int
      name: string
      description: HtmlNode
      description_no_html: string
      state: State
      priority: Priority
      category: Category
      subcategory: Category option
      assignee: Assignee
      requester: User
      created_at: DateTime
      updated_at: DateTime
      due_at: DateTime option
      sla_violations: string array
      number_of_comments: int
      user_saw_all_comments: bool
      is_service_request: bool
      created_by: User
      resolved_by: Employee
      resolution_description: string
      resolution_code: ResolutionCode
      group_assignee: Assignee option
      customer_satisfaction_survey_sent_at: DateTime
      customer_satisfaction_survey_completed_at: DateTime option
      custom: string option
      href: DomUrl
      href_account_domain: DomUrl
      site: Site option
      department: Department
      cc: EmailAddress
      custom_fields_values: unit array
      origin: string
      releases: unit array
      problems: unit array
      problem: unit array
      incidents: IncidentReference array
      changes: unit array
      tasks: unit array
      time_tracks: unit array
      solutions: unit array
      assets: unit array
      mobiles: unit array
      other_assets: unit array
      configuration_items: unit array
      discovery_hardwares: unit array
      purchase_orders: unit array }

and [<RequireQualifiedAccess>] State =
    | New
    | ``Pending Assignment``
    | ``In Process``
    | ``On Hold``
    | ``Awaiting Approval``
    | ``Awaiting Asset Tag``
    | ``Awaiting Delivery``
    | ``Awaiting Effective Date``
    | ``Awaiting Input - User``
    | ``Awaiting Input - Tech``
    | ``Awaiting Input - Vendor``
    | ``Awaiting Quote``
    | ``Canceled by Requester``
    | ``Pending HR Actions``
    | ``Project - Proactive``
    | ``Purchase in Process``
    | ``Research Required``
    | ``Scheduled-Check Due Date``
    | ``Under Review``
    | Assigned
    | Resolved

and [<RequireQualifiedAccess>] ResolutionCode =
    | Aborted
    | ``Canceled by User Request``
    | Duplicate
    | ``No longer Funded``
    | ``Not Solved (Black Flag Blocking - See Notes)``
    | ``Not Solved (Escalated to External Support)``
    | ``Not Solved (Escalated to Vendor)``
    | ``Not Solved (Resolution Set for Future Upgrade)``
    | ``Not Solved (Not Reproducible)``
    | ``Not Solved (Too Costly)``
    | Postponed
    | ``Solved (Permanently)``
    | ``Solved (Work Around)``
    | ``Unknown (No Response From User)``

and User =
    { id: int
      account_id: int
      user_id: int
      email: EmailAddress
      name: string
      disabled: bool
      site_id: int option
      site: Site option
      department_id: int
      department: Department
      has_gravatar: bool
      customer_satisfaction_survey_time: DateTime option
      avatar: Avatar }

and Site =
    { id: int
      name: string
      location: string
      description: string option
      time_zone: string }

and Avatar =
    | AvatarInitials of AvatarInitials
    | AvatarImage of AvatarImage

and AvatarInitials = { initials: string; color: string }

and AvatarImage =
    { image_class: string option
      sso_image_class: string option
      avatar_url: DomUrl }

and IncidentRow =
    { Assignee: string
      Category: string
      Comments: string
      ``Created At``: string
      ``Created By``: string
      Department: string
      Description: string
      ``Group Assignment``: string
      Priority: string
      Requester: string
      Site: string
      State: string
      Subcategory: string
      Tags: string
      Title: string
      ``Updated At``: string }

and IncidentReference = { id: int; href: DomUrl }

and Category =
    { id: int
      name: string
      default_tags: string option
      parent_id: int option
      deleted: bool
      default_assignee_id: int }

and Assignee =
    { group_id: int
      is_user: bool
      id: int
      name: string
      email: EmailAddress
      avatar: Avatar
      reports_to: Assignee option }

and Employee =
    { id: int
      name: string
      disabled: bool
      title: string
      email: EmailAddress
      created_at: DateTime
      updated_at: DateTime
      last_login: DateTime
      phone: PhoneNumber
      mobile_phone: PhoneNumber option
      role: Role
      group_ids: int array
      available_for_assignment: bool
      can_be_available_for_assignment: bool
      provider: string
      custom_fields_values: unit array
      site: Site option
      department: Department
      avatar: Avatar
      reports_to: Assignee option }

and Role =
    { id: int
      name: string
      description: string
      portal: bool
      show_my_tasks: bool }
