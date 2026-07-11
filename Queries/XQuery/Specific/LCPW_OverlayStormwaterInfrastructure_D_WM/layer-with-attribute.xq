for $layer in //pair[@name = "layers"]/item
 where $layer/pair[@name = "features"]/item/pair/pair[@name = "DESCRIPTION"] 
  return $layer
  