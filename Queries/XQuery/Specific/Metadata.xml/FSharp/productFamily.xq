declare function local:attributeValue($attribute as attribute()) {
  switch (fn:local-name($attribute))
    case "effectiveDateTime" return if ($attribute != "") then `Some(DateTime.Parse("{$attribute}"))` else "None"
    case "length" return `{$attribute}`
    case "dataScale" return `{$attribute}`
    case "dataPrecision" return `{$attribute}`
    case "showSearchOrder" return `{$attribute}`
    case "useSearchOrder" return `{$attribute}`
    case "identitySeed" return `{$attribute}`
    case "identityStep" return `{$attribute}`
    case "order" return `{$attribute}`
    case "cardinalityChild" return `{$attribute}`
    case "cardinalityParent" return `{$attribute}`
    case "value" return `{$attribute}`
    case "isRequired" return `{$attribute}`
    case "isNullable" return `{$attribute}`
    case "isAgencyEnhancable" return `{$attribute}`
    case "isHansen" return `{$attribute}`
    case "hasNullRecord" return `{$attribute}`
    case "isLicensed" return `{$attribute}`
    case "isUnique" return `{$attribute}`
    case "description" return `"""{$attribute}"""`
    default return `"{fn:normalize-space($attribute)}"`
};

declare function local:Capitalize($input as xs:string) {
  concat(
    fn:upper-case(fn:substring($input, 1, 1)),
    fn:substring($input, 2)
  )
};
declare variable $reservedKeyword := (
"type"  
);
declare variable $assetTable:= (
"StormBackflowPreventer",
"StormChannel",
"StormChannelDrainageConnection",
"StormInlet",
"StormLevee",
"StormLiftStation",
"StormMain",
"StormManhole",
"StormMeter",
"StormMeterComponent",
"StormMeterRegister",
"StormMiscellaneous",
"StormNode",
"StormPump",
"StormServiceLine",
"StormStorageBasin",
"StormValve"
);
declare variable $targetColumn:= (
"AssetKey",
"AssetType",
"FloorDetailKey",
"RoomDetailKey",
"AddressKey",
"ParcelKey",
"BudgetNumberKey",
"EmployeeID",
"ManufacturerKey",
"Code"
);
declare variable $targetProductFamily:= (
"AssetManagement",
"Property",
"Resources"
);
declare variable $targetTable:= (
"StormArea",
"StormBackflowPreventerType",
"StormChannelShape",
"StormChannelType",
"StormColor",
"StormCondition",
"StormConnectionType",
"StormConstructMaterial",
"StormCriticalRating",
"StormDirection",
"StormDistrict",
"StormDrainType",
"StormFenceType",
"StormGrateType",
"StormInletType",
"StormJointType",
"StormLandUse",
"StormLeveeFoundationType",
"StormLeveeType",
"StormLiftStationType",
"StormLocation",
"StormMainLineType",
"StormManholeConeType",
"StormManholeCoverType",
"StormManholeFrameType",
"StormManholeMaterial",
"StormManholeType",
"StormMeterComponentType",
"StormMeterRegisterType",
"StormMeterType",
"StormMiscellaneousType",
"StormNodeType",
"StormObstruction",
"StormOwnership",
"StormPipeShape",
"StormPipeType",
"StormPumpType",
"StormResponsibility",
"StormServiceLineType",
"StormServiceStatus",
"StormServiceType",
"StormSIC",
"StormStorageBasinType",
"StormSubArea",
"StormSurfaceCover",
"StormUnitOfMeasure",
"StormValveStatus",
"StormValveType",
"StormVegetationType",
"Asset",
"AssetType",
"Building",
"Address",
"Parcel",
"BudgetNumber",
"Employee",
"Manufacturer",
"Organization"
);
let $newline := codepoints-to-string(10)
let $productFamilyBlock :=
  string-join(
    for $productFamily in //productFamily
    let $productFamilyName := string($productFamily/@name)
    let $productFamilyVariable := replace($productFamilyName, "[\s\.]", "_")
    let $isTargetProductFamily :=
      $productFamilyName = ("AssetManagement.Storm", $targetProductFamily)

    where $isTargetProductFamily

    let $requiredSystemLicense :=
      if ($productFamily/requiredSystemLicense)
      then `Some(systemLicense.{replace($productFamily/requiredSystemLicense/@name, "[\s]", "_")})`
      else "None"

    let $productFamilyProperties :=
      string-join(
        for $productFamilyAttribute in $productFamily/@*
        let $productFamilyAttributeName := fn:local-name($productFamilyAttribute)
        let $productFamilyAttributeVariable :=
          if ($productFamilyAttributeName = $reservedKeyword)
          then concat("``", $productFamilyAttributeName, "``")
          else $productFamilyAttributeName
        return ``[
      `{$productFamilyAttributeVariable}` = `{local:attributeValue($productFamilyAttribute)}`]``,
        $newline
      )

    let $tableBlock :=
      string-join(
        for $tableElement in $productFamily/table
        let $tableName := string($tableElement/@name)
        let $tableVariable := replace($tableName, "[\s\.]", "_")
        let $isAssetTable := $tableName = $assetTable
        let $isTargetTable := $tableName = $targetTable

        where $isAssetTable or $isTargetTable

        let $tableProperties :=
          string-join(
            for $tableAttribute in $tableElement/@*
            let $tableAttributeName := fn:local-name($tableAttribute)
            let $tableAttributeVariable :=
              if ($tableAttributeName = $reservedKeyword)
              then concat("``", $tableAttributeName, "``")
              else $tableAttributeName
            return ``[
            `{$tableAttributeVariable}` = `{local:attributeValue($tableAttribute)}`]``,
            $newline
          )

        let $tableTextProperties :=
          string-join(
            for $tableTextAttribute in $tableElement/text/@*
            return ``[
            `{fn:local-name($tableTextAttribute)}` = `{local:attributeValue($tableTextAttribute)}`]``,
            $newline
          )

        let $domainColumnReferenceBlock :=
          string-join(
            for $domainColumnReferenceElement in $tableElement/domainColumnReference
            let $domainColumnReferenceName := string($domainColumnReferenceElement/@name)
            let $domainColumnReferenceVariable := replace($domainColumnReferenceName, "[\s\.]", "_")
            let $domainColumnReferenceProperties :=
              string-join(
                for $domainColumnReferenceAttribute in $domainColumnReferenceElement/@*
                return ``[
                `{fn:local-name($domainColumnReferenceAttribute)}` = `{local:attributeValue($domainColumnReferenceAttribute)}`]``,
                $newline
              )
            return ``[
        [<AutoOpen>]
        module `{$domainColumnReferenceVariable}` =
            let domainColumnReference = {
                `{$domainColumnReferenceProperties}`
            }]``,
            $newline || $newline
          )

        let $columnBlock :=
          string-join(
            for $columnElement in $tableElement/column
            let $columnName := string($columnElement/@name)
            let $columnVariable := replace($columnName, "[\s\.]", "_")
            let $keepColumn :=
              $isAssetTable
              or ($isTargetTable and $columnName = $targetColumn)

            where $keepColumn

            let $columnProperties :=
              string-join(
                for $columnAttribute in $columnElement/@*
                let $columnAttributeName := fn:local-name($columnAttribute)
                let $columnAttributeVariable :=
                  if ($columnAttributeName = $reservedKeyword)
                  then concat("``", $columnAttributeName, "``")
                  else $columnAttributeName
                return ``[
                `{$columnAttributeVariable}` = `{local:attributeValue($columnAttribute)}`]``,
                $newline
              )

            let $columnTextProperties :=
              string-join(
                for $columnTextAttribute in $columnElement/text/@*
                let $columnTextAttributeName := fn:local-name($columnTextAttribute)
                where $columnTextAttributeName != "locale"
                return ``[
                `{$columnTextAttributeName}` = `{local:attributeValue($columnTextAttribute)}`]``,
                $newline
              )

            return ``[
        [<AutoOpen>]
        module `{$columnVariable}` =
            let column = {
            `{$columnProperties}`
            `{$columnTextProperties}`
            }
            ]``,
            $newline || $newline
          )

        return ``[
    [<AutoOpen>]
    module `{$tableVariable}` =
        let table = {
          `{$tableProperties}`
          `{$tableTextProperties}`
        }
    `{$columnBlock}`
    `{$domainColumnReferenceBlock}`
    ]``,
        $newline || $newline
      )

    return ``[
[<AutoOpen>]
module `{$productFamilyVariable}` =
    let productFamily = {
      requiredSystemLicense = `{$requiredSystemLicense}`
`{$productFamilyProperties}`

    }
`{$tableBlock}`

    ]``,
    $newline
  )    
return `{$productFamilyBlock}`
