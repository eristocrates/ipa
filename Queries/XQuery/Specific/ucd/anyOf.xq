declare namespace ucd = "http://www.unicode.org/ns/2003/ucd/1.0";
declare variable $anyOf := "0123456789abcdefgABCDEFG";

for $character in characters($anyOf)
  
  let $cp:= string:format("%04X",string-to-codepoints($character))
  let $cp-block := 
    for $character in //ucd:char
      where $character/@cp = $cp
      return $character
  return $cp-block
