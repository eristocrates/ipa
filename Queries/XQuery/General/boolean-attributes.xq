for $attribute in //@*
where $attribute = "true" or $attribute = "false"
group by $attributeName := name($attribute)
return $attributeName