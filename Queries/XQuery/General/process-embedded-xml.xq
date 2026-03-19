copy $doc := .
modify (
  for $p in $doc//XmlDoc
  return replace node $p/node() with parse-xml(string($p))/*
)
return $doc