let $childTags :=
  for $parent in //WorkspaceDefinition/DatasetDefinitions/DataElement
  
    let $child := $parent/child::element()
    let $childTag := $child/fn:local-name()  
  return $childTag
return sort(distinct-values($childTags))
  