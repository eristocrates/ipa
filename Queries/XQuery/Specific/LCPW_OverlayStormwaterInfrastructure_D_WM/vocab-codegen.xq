declare variable $feature_layer := "Outfall";
distinct-values(
  
 for $field in //pair[@name = "layers"]/item/pair[@name = "name" and text() = $feature_layer]/../pair[@name = "fields"]/item/pair[@name = "name"]
 order by $field
 return `let {replace($feature_layer, " ", "_")}'{$field/text()} = _vocab "{$feature_layer}.{$field/text()}"`

)