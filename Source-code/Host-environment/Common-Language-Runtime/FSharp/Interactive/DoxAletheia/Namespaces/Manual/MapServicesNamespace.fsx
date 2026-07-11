#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics


module MapServices =
    let prefix = prefix_label "MapServices"

    let LCPW_OverlayStormwaterInfrastructure_D_WM =
        prefix "LCPW_OverlayStormwaterInfrastructure_D_WM"

    /// (0)
    let Drainage_Network = prefix "Drainage_Network"
    /// (1)
    let Outfall = prefix "Outfall"
    /// (2)
    let Stormwater_Pond = prefix "Stormwater_Pond"
    /// (3)
    let End_Point = prefix "End_Point"
    /// (4)
    let Inlet = prefix "Inlet"
    /// (5)
    let Debris_Trap = prefix "Debris_Trap"
    /// (6)
    let Junction_Fixed = prefix "Junction_Fixed"
    /// (7)
    let Connectivity = prefix "Connectivity"
    /// (8)
    let Generic_Storm_Asset = prefix "Generic_Storm_Asset"
    /// (9)
    let Stormwater_Pond_Discharge = prefix "Stormwater_Pond_Discharge"
    /// (10)
    let Private_Point = prefix "Private_Point"
    /// (11)
    let Conduit = prefix "Conduit"
    /// (12)
    let Culvert_Cross_Drain = prefix "Culvert_Cross_Drain"
    /// (13)
    let Ditch_Point = prefix "Ditch_Point"
    /// (14)
    let Ditch = prefix "Ditch"
    /// (15)
    let Bridge_Point = prefix "Bridge_Point"
    /// (16)
    let Bridge = prefix "Bridge"
    /// (17)
    let Stormwater_Pond___Top_of_Bank = prefix "Stormwater_Pond___Top_of_Bank"
    /// (18)
    let Outfall_Drainage_Area_MS4 = prefix "Outfall_Drainage_Area_MS4"
    /// (19)
    let Outfall_Drainage_Area = prefix "Outfall_Drainage_Area"
    /// (20)
    let Outfall_Drainage_Area_MOF = prefix "Outfall_Drainage_Area_MOF"
    /// (21)
    let Media_Points = prefix "Media_Points"
    /// (22)
    let Damage = prefix "Damage"
    /// (23)
    let Non_Drainage_Network = prefix "Non_Drainage_Network"
    /// (24)
    let Media_Points_Without_Photos = prefix "Media_Points_Without_Photos"
    /// (25)
    let Interference = prefix "Interference"
    /// (26)
    let Pollution_Control_Box = prefix "Pollution_Control_Box"
