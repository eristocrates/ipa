let $newline := codepoints-to-string(10)


let $FeatureClassBlock :=
 for $FeatureClass in //WorkspaceDefinition/DatasetDefinitions/DataElement/Children/DataElement
 where $FeatureClass/Name/text() != "StormwaterPond_MediaPoints"
  let $FieldBinding :=
      string-join(
        for $Field in $FeatureClass/Fields/FieldArray/Field
          let $name := $Field/Name/text()
          
          
        
        
  return ``[
        `{$name}` : EsriField]``,$newline)



return ``[

type `{$FeatureClass/Name/text()}`FeatureClass =
    {
        `{$FieldBinding}` 
    }]``

let $FeatureDatasetBinding:= 
  string-join(
    for $FeatureDataset in //WorkspaceDefinition/DatasetDefinitions/DataElement
    
    let $FeatureClassBinding:=
    string-join(
      for $FeatureClass in $FeatureDataset/Children/DataElement
      
      
let $FieldBinding :=
      string-join(
        for $Field in $FeatureClass/Fields/FieldArray/Field
          let $name := $Field/Name/text()
          let $alias := if($Field/AliasName and ($Field/AliasName/text() != $Field/Name/text()) ) then `Some("{$Field/AliasName/text()}")` else "None"
          let $isNullable := $Field/IsNullable/text()
          let $length := $Field/Length/text()
          let $required := if($Field/Required = "true") then "true" else "false"
          let $defaultValue := if($Field/DefaultValue) then `Some("{$Field/DefaultValue/text()}")` else "None"
          
          
          group by $name, $alias, $isNullable, $length, $required, $defaultValue

        
        
return ``[
"`{$name}`" = {
          name = "`{$name}`"
          alias = `{$alias}`
          isNullable = `{$isNullable}`
          length = `{$length}`
          required = `{$required}`
          defaultValue = `{$defaultValue}`
        }]``,$newline)




return ``[
      `{$FeatureClass/Name/text()}`: `{$FeatureClass/Name/text()}`FeatureClass]``,$newline)



    return ``[
type `{$FeatureDataset/Name/text()}`FeatureDataset =
    {
      `{$FeatureClassBinding}`
    }
]``,$newline)

return `
type EsriField =
    {{ name: string
      alias: string option
      isNullable: bool
      length: int
      required: bool
      defaultValue: string option }}
{$FeatureClassBlock}
type FeatureClass =
    | EndPointFeatureClass of EndPointFeatureClass
    | BridgePointFeatureClass of BridgePointFeatureClass
    | InletFeatureClass of InletFeatureClass
    | ConduitFeatureClass of ConduitFeatureClass
    | DitchFeatureClass of DitchFeatureClass
    | ConnectivityFeatureClass of ConnectivityFeatureClass
    | Junction_fixedFeatureClass of Junction_fixedFeatureClass
    | StormwaterPondFeatureClass of StormwaterPondFeatureClass
    | BridgeFeatureClass of BridgeFeatureClass
    | DitchPointFeatureClass of DitchPointFeatureClass
    | GenericStormAssetFeatureClass of GenericStormAssetFeatureClass
    | StormwaterPondDischargeFeatureClass of StormwaterPondDischargeFeatureClass
    | CulvertCrossDrainFeatureClass of CulvertCrossDrainFeatureClass
    | PrivatePointFeatureClass of PrivatePointFeatureClass
    | MediaPointsFeatureClass of MediaPointsFeatureClass
    | DamageFeatureClass of DamageFeatureClass
    | DebrisTrapFeatureClass of DebrisTrapFeatureClass
    | InterferenceFeatureClass of InterferenceFeatureClass
    | MediaPointsWithoutPhotosFeatureClass of MediaPointsWithoutPhotosFeatureClass
    | OutfallFeatureClass of OutfallFeatureClass
    | Outfall_DrainageAreaFeatureClass of Outfall_DrainageAreaFeatureClass
    | Outfall_DrainageArea_MOFFeatureClass of Outfall_DrainageArea_MOFFeatureClass
    | Outfall_DrainageArea_MS4FeatureClass of Outfall_DrainageArea_MS4FeatureClass
    | PollutionControlBoxFeatureClass of PollutionControlBoxFeatureClass
    | StormwaterPondTopOfBankFeatureClass of StormwaterPondTopOfBankFeatureClass
{$FeatureDatasetBinding}
`
