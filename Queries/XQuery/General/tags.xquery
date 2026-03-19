xquery version "3.1";


declare option output:method "text";

(: ---------- helpers & config (prolog) ---------- :)


declare function local:clark-name($n as node())
as xs:string { let $qn := node-name($n)
let $uri := namespace-uri-from-QName($qn)
let $loc := local-name-from-QName($qn)
return if ($uri = "") then $loc else concat("{", $uri, "}", $loc) };

(: CSV escape (double inner quotes, wrap in quotes if comma/quote/newline
 : present) :)
declare function local:csv($s as xs:string)
as xs:string { let $t := replace($s, '"', '""')
return if (matches($t, '[,"\r\n]')) then concat('"', $t, '"') else $t };

(: weights :)
declare variable $W_PARENT as xs:integer := 3;

declare variable $W_CHILD_TYPES as xs:integer := 2;

declare variable $W_TOTAL as xs:integer := 1;

declare variable $W_TEXT_PEN as xs:integer := 2;

(: scope: use collection('surfaces')//* for multi-doc :)
declare variable $NODES := .//*;


(: ---------- output ---------- :)

(: header :)
string-join(('score', 'name', 'asParent', 'distinctChildTypes', 'total',
            'textOnly'),
            ',') || "&#10;",
(: rows :)
for $name in
    distinct-values(for $e in $NODES
                    return local:clark-name($e))
let $elems := $NODES[local:clark-name(.) = $name]
let $total := count($elems)
let $asParent := count($elems[*])
let $textOnly := count($elems[not(*) and normalize-space(.) != ""])
let $distinctChildTypes :=
    count(distinct-values(for $c in $elems/*
                          return local:clark-name($c)))
let $score :=
    $W_PARENT * $asParent + $W_CHILD_TYPES * $distinctChildTypes + $W_TOTAL *
        ($total - $textOnly) - $W_TEXT_PEN * $textOnly
(: uncomment to drop pure text-only tags :) (: where $asParent > 0 :) order by
    $score descending, $asParent descending, $distinctChildTypes descending,
    $name
return
    (string-join((local:csv(string($score)), local:csv($name),
                 local:csv(string($asParent)),
                 local:csv(string($distinctChildTypes)),
                 local:csv(string($total)), local:csv(string($textOnly))),
                 ',') || "&#10;")