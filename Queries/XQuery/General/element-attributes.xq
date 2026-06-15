distinct-values(for $element in //enumerationCheckConstraint
  
  return $element/@*/name()
  )