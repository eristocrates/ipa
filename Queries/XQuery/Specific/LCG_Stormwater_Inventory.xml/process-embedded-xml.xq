let $XmlDocStep :=
  copy $doc := .
  modify (
    for $XmlDoc in $doc//XmlDoc
    return
      try {
        replace node $XmlDoc/node()
        with parse-xml(string($XmlDoc))/node()
      } catch * {
        ()
      }
  )
  return $doc
let $peXmlStep :=
  copy $doc := $XmlDocStep
  modify (
    for $peXml in $doc//peXml
    return
      try {
        replace node $peXml/node()
        with parse-xml(string($peXml))/node()
      } catch * {
        ()
      }
  )
  return $doc

return
  copy $doc := $peXmlStep
  modify (
    for $Process in $doc//Process
    return
      try {
        replace node $Process/node()
        with parse-xml-fragment(string($Process))/node()
      } catch * {
        ()
      }
  )
  return $doc