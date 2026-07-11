let $all :=//foreignColumnReference/parent::*/parent::*
let $n := random:integer(count($all)) + 1
return $all[$n]