for $attribute-name in //@*/name()
  order by $attribute-name
  group by $attribute-name
  return distinct-values($attribute-name)