let $newline := codepoints-to-string(10)
let $incompatibleDomain := (
   "dDomainSourceYear",
  "dDomainPipeDia",
  "WhoCreatOrModified",
    "Crew",
  "CompanyDomain"
)

let $compatibleDomain := (
 "dDomainInventoryType",
 "InventoriedBy",
 "dDomainPondType",
 "dDomainEndPointMaterial",
 "dDomainPRResolution",
 "dDomainSource",
 "dDomainPipeShape",
 "dDomainAccuracyCode",
 "WhoCreatOrModified",
 "dDomainDitchSurfType",
 "DamageType",
 "dDomainJunctionMaterial",
 "MediaCode",
 "Outfall Type",
 "StructureType",
 "dDomainInletMaterial",
 "dDomainFilterLocation",
 "dDomainNonNetwork",
 "dDomainMaintBy",
 "dDomainMaterial",
 "dDomainOwner",
   "dDomainFieldComment",
  "dDomainLifeCycle",
  "AncillaryRoleDomain",
    "dDomainLifeCycle",
  "FilterType"
)
let $booleanCase := (
  "dDomainBoolean",
  "EnabledDomain"
  )

let $DomainBlock := 
  string-join(
    for $Domain in //Domain
    let $DomainName := string($Domain/DomainName)
    group by $DomainName
    let $CodedValueBlock :=
      string-join(
        for $CodedValue in $Domain/CodedValues/CodedValue
        let $rawName := string($CodedValue/Name)
        let $code := string($CodedValue/Code)
        let $name := replace(replace($rawName,"[\s-]","_"), "[\\/]","_")

        group by $rawName, $name, $code
        let $name := $name[1]
        order by $code
        return ``[    let `{$name}` = 
        {
          name = @"`{$rawName}`" 
          code = "`{$code}`"
        }
      ]``
        

        ,$newline
      )
      where $DomainName = $compatibleDomain
    return ``[
module `{replace($DomainName,"\s","")}` =
`{$CodedValueBlock}`
]``,
    $newline || $newline
  )
return $DomainBlock