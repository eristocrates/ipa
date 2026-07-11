declare option output:method "text";


let $nl := codepoints-to-string(10)
let $header := '"element","spaced"'
let $rows :=
    for $e in//element[content-model[@spec = 'element']]
    let $name := normalize-space($e/@name)
    let $spaced := normalize-space($e/content-model[@spec = 'element']/@spaced)
    return
        concat('"', replace($name, '"', '""'), '",', '"',
               replace($spaced, '"', '""'), '"')
return string-join(($header, $rows), $nl)