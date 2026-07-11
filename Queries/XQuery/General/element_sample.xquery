declare namespace random = "http://basex.org/modules/random";


for $t in//text()[normalize-space()]
let $val := normalize-space(string($t))
let $ename := name($t/..)
where string-length($val) gt 0
group by $ename
let $pick :=
    head(for $v in distinct-values($val)
         order by random:double()
         return $v)
return $ename || ' | ' || $pick