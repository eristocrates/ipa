for $Domain in //Domain
  where string-length($Domain/Description) > 0
  return $Domain