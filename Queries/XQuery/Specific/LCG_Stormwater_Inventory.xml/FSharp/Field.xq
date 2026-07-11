for $Field in //Field
  
  let $FieldName := $Field/Name/text()
  let $FieldType := $Field/Type/text()
  let $FieldRequired := if ($Field/Required/text() = "true") then "true" else "false"
  group by $FieldName, $FieldType, $FieldRequired
  return `
  {$FieldName} : {$FieldType}
  {$FieldRequired}
  `