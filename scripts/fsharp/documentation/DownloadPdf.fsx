open System
open System.IO
open System.Net.Http
open System.Threading
open System.Threading.Tasks

/// Ensure a directory path ends with a directory separator for safe prefix checks.
let private ensureTrailingSeparator (p: string) =
    if String.IsNullOrWhiteSpace p then
        p
    else
        let sep = Path.DirectorySeparatorChar.ToString()

        if p.EndsWith(sep, StringComparison.Ordinal) then
            p
        else
            p + sep

/// Compute the output file path by taking everything after the path segment "DOC".
/// Example:
///   URL path:  /hansen/DOC/some/folder/file.pdf
///   Output:    <parentDir>/some/folder/file.pdf
let outputPathFromUrlAfterDoc (parentDirectory: string) (urlString: string) : string =
    let uri = Uri(urlString)

    // AbsolutePath excludes query and fragment; it's a canonical starting point.
    // It remains URL-escaped (e.g., %20) in some cases, hence we decode later.
    let absPath = uri.AbsolutePath

    // We want to match DOC as a *segment*, not as arbitrary substring.
    // A reliable way: search for "/DOC/" first, otherwise allow "/DOC" at end.
    // This is case-sensitive by default; if your server might use doc/Doc, adjust.
    let marker1 = "/DOC/"
    let marker2 = "/DOC"

    let idx =
        let i = absPath.IndexOf(marker1, StringComparison.Ordinal)

        if i >= 0 then
            // Start after "/DOC/"
            i + marker1.Length
        else
            let j = absPath.IndexOf(marker2, StringComparison.Ordinal)

            if j >= 0 && j + marker2.Length = absPath.Length then
                // Path ends with "/DOC" => remainder is empty (invalid as a file path)
                j + marker2.Length
            else
                -1

    if idx < 0 then
        raise (ArgumentException($"URL path does not contain the segment '/DOC/': {absPath}"))

    // The remainder is the part we want to treat as a relative path.
    // Trim any leading slashes to prevent Path.Combine from discarding parentDirectory.
    let remainderRaw = if idx >= absPath.Length then "" else absPath.Substring(idx)
    let remainderTrimmed = remainderRaw.TrimStart('/')

    if String.IsNullOrWhiteSpace remainderTrimmed then
        raise (ArgumentException($"URL contains '/DOC/' but nothing after it: {absPath}"))

    // URL decode (%20 etc.) and convert URL separators to OS separators.
    let remainderDecoded = Uri.UnescapeDataString(remainderTrimmed)
    let remainderOsPath = remainderDecoded.Replace('/', Path.DirectorySeparatorChar)

    // Combine under the parent directory
    let combined = Path.Combine(parentDirectory, remainderOsPath)

    // Security / correctness: prevent traversal escaping the parent directory.
    // GetFullPath normalizes .. and .
    let parentFull = parentDirectory |> Path.GetFullPath |> ensureTrailingSeparator
    let combinedFull = combined |> Path.GetFullPath

    if not (combinedFull.StartsWith(parentFull, StringComparison.OrdinalIgnoreCase)) then
        raise (ArgumentException($"Refusing to write outside parent directory. Computed: {combinedFull}"))

    combinedFull

let downloadPdfToDocPathAsync
    (http: HttpClient)
    (parentDirectory: string)
    (urlString: string)
    (ct: CancellationToken)
    : Task<string> =
    task {
        let outPath = outputPathFromUrlAfterDoc parentDirectory urlString

        // Ensure intermediate directories exist
        let outDir = Path.GetDirectoryName(outPath)

        if not (String.IsNullOrWhiteSpace outDir) then
            Directory.CreateDirectory(outDir) |> ignore

        use! resp = http.GetAsync(Uri(urlString), HttpCompletionOption.ResponseHeadersRead, ct)
        resp.EnsureSuccessStatusCode() |> ignore

        use! inStream = resp.Content.ReadAsStreamAsync(ct)
        use outStream = File.Create(outPath)
        do! inStream.CopyToAsync(outStream, 81920, ct)

        return outPath
    }

let downloadAllToDocPathsAsync (parentDirectory: string) (urls: string list) : Task<string list> =
    task {
        use http = new HttpClient()
        use cts = new CancellationTokenSource()

        let tasks: Task<string>[] =
            urls
            |> List.map (fun u -> downloadPdfToDocPathAsync http parentDirectory u cts.Token)
            |> List.toArray

        let! paths = Task.WhenAll(tasks)
        return paths |> Array.toList
    }

let pdfList =
    [ "https://intra.leoncountyfl.gov/hansen/DOC/Change_Password_in_IPS.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/Fac_ActivityCodes.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Asset_Lookup.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Assigning_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Closing_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Create_a_Unit_Maintenance_Schedule.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Create_an_Asset_Group.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Creating_a_Building_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Creating_a_Complex_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Creating_a_Facility_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Creating_a_Service_Request.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Creating_a_Usage_Area_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Creating_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Creating_an_Equipment_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Generate_WOs_from_a_Group_Maintenance_Schedule.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Generate_WOs_from_a_Unit_Maintenance_Schedule.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Lookup_a_Group_Maintenance_Schedule.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Lookup_a_Group_Project.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Lookup_a_Unit_Maintenance_Schedule.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Lookup_an_Asset_Group.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Lookup_Service_Request.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Lookup_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Printing_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Resolving_a_Service_Request.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/FAC_IPS/FAC_Resolving_an_Inspected_Request.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS-Hansen8_CrystalReports_Development-Standards.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS/Creating%20a%20Mapping%20SR.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS/Creating%20a%20WO.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Adding_an_Attachment.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Adding_an_Attachment.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Closing_a_Service_Request.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Closing_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Creating_a_Plant_Misc_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Creating_a_Service_Request.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Creating_a_Work_Order_from_Service_Request.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Editing_a_Contact.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_EMP_Work_Order_Details.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Lookup_a_Service_Request.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Lookup_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_PO_Work_Order_Details.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Printing_a_Service_Request.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Printing_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Searching_for_a_Plant_Misc_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/MIS_IPS/MIS_Training_Work_Order_Details.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/351-sign-image-instuctions.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/354-sign-image-instuctions.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/Completing-Worksheets.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/create-worksheet-Sign-Inventory.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/Creating-Asset-Sign-Inventory.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/Creating-Service-Request-for-Private-Dirt-Road-Repair.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/Creating-Service-Requests.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/Daily%20Image%20Download%20Log.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/Equipment_Types_Changes.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/GIS/Collecting%20State%20Plane%20Coordinates.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/GIS/Starting%20the%20GPS%20Unit.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/GIS/Using%20the%20Find%20Tool.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/GIS/Using%20the%20Identify%20Tool.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/Hansen_HowToSteps_AddingNew_SignTypeCodes.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/New-Small-Equipment.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/Procedure-for-adding-a-new-road.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/Procedure-for-New-Segment.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/Updating-Asset-Sign-Inventory.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW-7/Updating-Service-Request-Inspections.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW/ActivityWorksheet.pdf"
      "https://intra.leoncountyfl.gov/Hansen/DOC/PW/ActivityWorksheet.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW/FEMA%20Equipment%20List.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW/Oper-ActivityCodes-Alph.pdf"
      "https://intra.leoncountyfl.gov/Hansen/DOC/PW/Prk-ActivityCodes.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW/SignImageInstuctions.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/Creating%20Group%20Maintenance%20Schedule.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/OPS_Printing_a_Field_Order_Form.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PRK_Printing_a_Field_Order_Form.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PRK_Quick_Reference_for_Closing_the_last_weeks_Work_Orders.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PRK_Quick_Reference_for_Preparing_the_Next_weeks_Work_Orders.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Assigning_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Closing_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Create_a_Unit_Maintenance_Schedule.pdf"
      "https://intra.leoncountyfl.gov/Hansen/DOC/PW_IPS/PW_Create_an_Asset_Group.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Creating_a_Building_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Creating_a_Facility_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Creating_a_Park_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Creating_a_Sign_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Creating_a_Storm_Basin_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Creating_a_Storm_Miscellaneous_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Creating_a_Street_Segment_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Creating_a_Usage_Area_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Creating_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Creating_an_Appurtenance_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Creating_an_Equipment_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Expiring_an_Equipment_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Exporting_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Generate_WOs_from_a_Group_Maintenance_Schedule.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Generate_WOs_from_a_Unit_Maintenance_Schedule.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Lookup_a_Group_Maintenance_Schedule.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Lookup_a_Group_Project.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Lookup_a_Unit_Maintenance_Schedule.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Lookup_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Lookup_Asset.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Lookup_Asset_Group.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Lookup_Service_Request.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Operations_Quick_Reference_Guide_for_Creating_a_Service_Request.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Operations_Quick_Reference_Guide_for_Creating_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Printing_a_Work_Order.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Record_an_Inspection_Result.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Resolve_a_SR_with_WO.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Resolve_an_Inspected_Result_with_No_WO.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Submit_a_Service_Request.pdf"
      "https://intra.leoncountyfl.gov/hansen/DOC/PW_IPS/PW_Submit_a_Service_Request_for_a_Private_Road.pdf" ]

downloadAllToDocPathsAsync "surfaces/Leon_County/OIT/MIS/Infor_Documentation" pdfList
