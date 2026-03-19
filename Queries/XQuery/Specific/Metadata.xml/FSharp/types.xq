declare function local:attributeType($attributeName as xs:string) {
  switch ($attributeName)
    case "effectiveDateTime" return "DateTime"
    case "length" return "int"
    case "dataScale" return "int"
    case "dataPrecision" return "int"
    case "showSearchOrder" return "int"
    case "useSearchOrder" return "int"
    case "identitySeed" return "int"
    case "identityStep" return "int"
    case "order" return "int"
    case "cardinalityChild" return "int"
    case "cardinalityParent" return "int"
    case "value" return "int"
    case "isRequired" return "bool"
    case "isNullable" return "bool"
    case "isAgencyEnhancable" return "bool"
    case "isHansen" return "bool"
    case "hasNullRecord" return "bool"
    case "isLicensed" return "bool"
    case "isUnique" return "bool"
    default return "string"
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
let $newline := codepoints-to-string(10)

for $elementTag in distinct-values(//*/local-name(.))
  let $attribute-colon-type :=
    string-join(
      for $attributeNameRaw in distinct-values(//*[local-name() = $elementTag]/@*/local-name(.))
          let $attributeName :=
            if ($attributeNameRaw = $reservedKeyword)
              then
                concat("``",$attributeNameRaw,"``") 
              else
                `{$attributeNameRaw}`
      order by $attributeName

      let $attributeType := local:attributeType($attributeName)
      return ``[
          `{$attributeName}` : `{$attributeType}`]``,
      $newline
    )
return ``[
type `{local:Capitalize($elementTag)}` =
    {
`{$attribute-colon-type}`
}]``