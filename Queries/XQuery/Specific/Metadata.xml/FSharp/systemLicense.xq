declare function local:attributeValue($attribute as attribute()) {
  switch (fn:local-name($attribute))
    case "effectiveDateTime" return `DateTime.Parse("{$attribute}")`
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

    default return `"{$attribute}"`
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


for $element in //systemLicense
  let $elementName := $element/@name
  let $elementVariable:= replace($elementName,"[\s]","_")
  let $elementProperties:=
      string-join(
        for $attribute in $element/@*
        let $attributeName :=
            if (fn:local-name($attribute)= $reservedKeyword)
              then
                concat("``",fn:local-name($attribute),"``") 
              else
                `{fn:local-name($attribute)}`

          
        
        
  return ``[
            `{$attributeName}` = `{local:attributeValue($attribute)}`]``,$newline)



return ``[
    let `{$elementVariable}` =
        {
            `{$elementProperties}` 
        }]``

