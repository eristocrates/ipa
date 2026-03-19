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
    default return `"{$attribute}"`
};
declare function local:Capitalize($input as xs:string) {
    concat(
        fn:upper-case(fn:substring($input, 1, 1)),
        fn:substring($input, 2)
    )
};
let $newline := codepoints-to-string(10)


for $element in //productFamily
  let $elementName := $element/@name
  let $elementVariable:= replace($elementName,"[\s\.]","_")
  let $elementProperties:=
      string-join(
        for $attribute in $element/@*
        

          
        
        
  return ``[
            `{fn:local-name($attribute)}` = `{local:attributeValue($attribute)}`]``,$newline)



return ``[
    let `{$elementVariable}` =
        {
            `{$elementProperties}` 
        }]``

