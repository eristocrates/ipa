declare namespace ucd = "http://www.unicode.org/ns/2003/ucd/1.0";

for $char in //ucd:char
  where $char/@cp = "3184F"
  return $char