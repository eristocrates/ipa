declare namespace sch = "http://purl.oclc.org/dsdl/schematron";


declare option output:method "text";


let $nl := codepoints-to-string(10)
let $header := '"element","requiredAttribute"'
let $rows :=
    for $a in//sch:rule/sch:assert
    let $ctx := normalize-space($a/parent::sch:rule/@context)
    let $test := normalize-space($a/@test)
    where not(ends-with($ctx, '/@xmlns:xsi')) and not($test = ". = ''")
    return
        concat('"', replace($ctx, '"', '""'), '",', '"',
               replace($test, '"', '""'), '"')
return string-join(($header, $rows), $nl)