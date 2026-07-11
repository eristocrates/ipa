for $feature in //pair[@name = "features" and @type = "array"]/item
  let $key := $feature/pair/pair[@name = "UNITID"]
  where string-length($key) > 1
  (:and $key/text() = "Round":)

  
  return $key
  