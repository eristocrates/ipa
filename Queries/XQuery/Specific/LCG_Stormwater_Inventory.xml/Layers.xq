let $newline := codepoints-to-string(10)
let $FeatureDatasetBlock := 
  string-join(
    for $FeatureDataset in //WorkspaceDefinition/DatasetDefinitions/DataElement
    let $FeatureClassBlock :=
    string-join(
      for $FeatureClass in $FeatureDataset/Children/DataElement
      
      
let $FieldDeclaration :=
      string-join(
        for $Field in $FeatureClass/Fields/FieldArray/Field
          let $name := $Field/Name/text()
          let $alias := if($Field/AliasName and ($Field/AliasName/text() != $Field/Name/text()) ) then `Some("{$Field/AliasName/text()}")` else "None"
          let $isNullable := $Field/IsNullable/text()
          let $length := $Field/Length/text()
          let $required := if($Field/Required = "true") then "true" else "false"
          let $defaultValue := if($Field/DefaultValue) then `Some("{$Field/DefaultValue/text()}")` else "None"
          
          
          group by $name, $alias, $isNullable, $length, $required, $defaultValue

        
        
return ``[
     module `{$name}` =
      let field = {
        name = "`{$name}`"
        alias = `{$alias}`
        isNullable = `{$isNullable}`
        length = `{$length}`
        required = `{$required}`
        defaultValue = `{$defaultValue}`
        }
]``,$newline)




return ``[
    module "`{$FeatureClass/Name/text()}`" = `{$FieldDeclaration}`
  
]``,$newline)



    return ``[
module `{$FeatureDataset/Name/text()}` =`{$FeatureClassBlock}`
]``,$newline)
return $FeatureDatasetBlock

