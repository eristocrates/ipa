for $element-name in //*/name()
  order by $element-name
  group by $element-name
  return distinct-values($element-name)