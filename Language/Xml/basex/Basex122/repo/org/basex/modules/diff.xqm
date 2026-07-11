(:~
 : Basic functions for comparing XML elements.
 : @author Christian Grün, BaseX GmbH
 :)
module namespace diff = "http://modules.basex.org/diff";

(:~ Suffix for different element structures. :)
declare %private variable $diff:ELEM-SUFFIX := '-';
(:~ Separator for different text contents. :)
declare %private variable $diff:TEXT-SEPARATOR := ' ► ';

(:~
 : Compares the specified XML elements and creates a combined view.
 : @param  $elem1 first element
 : @param  $elem2 second element
 : @return combined view
 :)
declare function diff:diff(
  $elem1  as element(),
  $elem2  as element()
) as element()* {
  diff:diff($elem1, $elem2, true())
};

(:~
 : Compares the specified XML elements and creates a combined view.
 : @param  $elem1 first element
 : @param  $elem2 second element
 : @param  $merge merge XML elements, only return differences
 : @return combined view
 :)
declare function diff:diff(
  $elem1  as element()*,
  $elem2  as element()*,
  $merge  as xs:boolean
) as element()* {
  let $names1 := $elem1/node-name()
  let $names2 := $elem2/node-name()
  let $names := distinct-values(($names1, $names2))
  for $name in $names
  let $c1 := count($names1[. = $name])
  let $c2 := count($names2[. = $name])
  let $cm := min(($c1, $c2))
  return (
    for $pos in 1 to $cm
    let $se1 := $elem1[node-name() = $name][$pos]
    let $se2 := $elem2[node-name() = $name][$pos]
    let $values := distinct-values(($se1/text(), $se2/text()))
    let $children := diff:diff($se1/*, $se2/*, $merge)
    where not($merge) or $children or count($values) > 1
    return element { $name } {
      $children,
      string-join($values, $diff:TEXT-SEPARATOR)
    },
    for $pos in $cm + 1 to $c1
    return element { $name || $diff:ELEM-SUFFIX || 'OLD' }
      { $elem1[node-name() = $name][$pos]/node() },
    for $pos in $cm + 1 to $c2
    return element { $name || $diff:ELEM-SUFFIX || 'NEW' }
      { $elem2[node-name() = $name][$pos]/node() }
  )
};
