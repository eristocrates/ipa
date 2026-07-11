declare namespace random = "http://basex.org/modules/random";


for $a in//@*
let $val := normalize-space(string($a))
let $ename := name($a/..)
(: element name, may include a prefix :) let $aname := name($a)
(: attribute name, may include a prefix :) where string-length($val) > 0
group by $ename, $aname
let $pick :=
    head(for $v in distinct-values($val)
         order by random:double()
         return $v)
return $ename || '@' || $aname || ' | ' || $pick