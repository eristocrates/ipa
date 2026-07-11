for $attribute in //@*
  where contains  (string($attribute),"&lt;")
  return $attribute