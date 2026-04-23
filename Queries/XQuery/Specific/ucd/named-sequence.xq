declare namespace ucd = "http://www.unicode.org/ns/2003/ucd/1.0";

for $sequence in //ucd:named-sequence
  where contains($sequence/@cps, "09CD 09B7")
  return $sequence