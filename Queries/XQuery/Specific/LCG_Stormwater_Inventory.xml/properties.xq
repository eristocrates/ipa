declare namespace functx = "http://www.functx.com"; 
declare function functx:leaf-elements ($root as node()?) as element()* {
   $root/child::*[not(*)]
};
let $newline := codepoints-to-string(10)

let $propertyElements :=
  for $entityElement in //WorkspaceDefinition/DatasetDefinitions/DataElement/Children/DataElement/Metadata/XmlDoc/metadata/idinfo/descript
  return functx:leaf-elements($entityElement)
let $properties :=
  for $propertyElement in $propertyElements 
  return local-name($propertyElement)
return `
{string-join(distinct-values($properties),$newline)}

{string-join($propertyElements,$newline)}
`