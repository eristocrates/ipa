declare function local:propertyValue($property) {
  switch (fn:local-name($property))
    case "effectiveDateTime" return if ($property != "") then `Some(DateTime.Parse("{$property}"))` else "None"
    case "id" return `{$property}`
    case "dataScale" return `{$property}`
    case "dataPrecision" return `{$property}`
    case "showSearchOrder" return `{$property}`
    case "useSearchOrder" return `{$property}`
    case "identitySeed" return `{$property}`
    case "identityStep" return `{$property}`
    case "order" return `{$property}`
    case "cardinalityChild" return `{$property}`
    case "cardinalityParent" return `{$property}`
    case "value" return `{$property}`
    case "isRequired" return `{$property}`
    case "isNullable" return `{$property}`
    case "isAgencyEnhancable" return `{$property}`
    case "isHansen" return `{$property}`
    case "hasNullRecord" return `{$property}`
    case "isLicensed" return `{$property}`
    case "isUnique" return `{$property}`
    case "description" return `"""{$property}"""`
    case "sublayers" return ""
    default return `"{fn:normalize-space($property)}"`
};
declare variable $groupLayerPropertyKeyExclusions := (
"subLayers",
"extent"
);
let $newline := codepoints-to-string(10)
let $groupLayerBlock :=
  string-join(
    for $groupLayerElement in //layers/*
    let $groupLayerName := string($groupLayerElement/name)
    let $groupLayerVariable := replace($groupLayerName, "[\s\.]", "_")
    let $groupLayerType:= string($groupLayerElement/type)
    where $groupLayerType = "Group Layer"
    let $groupLayerProperties :=
      string-join(
        for $groupLayerProperty in $groupLayerElement/*
        
        let $groupLayerPropertyKey := fn:local-name($groupLayerProperty)

        where not($groupLayerPropertyKey = $groupLayerPropertyKeyExclusions)
          
        return ``[
        `{$groupLayerPropertyKey}` = `{local:propertyValue($groupLayerProperty)}`]``,
        $newline
      )

    return ``[
[<AutoOpen>]
module `{$groupLayerVariable}` =
    let layer= {
        `{$groupLayerProperties}`
    }]``,
    $newline || $newline
  )
return $groupLayerBlock