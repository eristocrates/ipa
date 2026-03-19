let $newline := codepoints-to-string(10)


for $FeatureClass in //WorkspaceDefinition/DatasetDefinitions/DataElement/Children/DataElement
  let $FieldBinding :=
      string-join(
        for $Field in $FeatureClass/Fields/FieldArray/Field
          let $name := $Field/Name/text()
          
        
        
  return ``[
        `{$name}` : EsriField]``,$newline)



return ``[
type `{$FeatureClass/Name/text()}`FeatureClass
    {
        `{$FieldBinding}` 
    }]``

