let $attributesWithElements := for $attribute in //@type
  let $attributeElement := name($attribute/parent::element())
  order by $attributeElement
  
  return `{$attribute}: {$attributeElement}`
return distinct-values($attributesWithElements)