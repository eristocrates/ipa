declare variable $table := "StormValve";

for $table_column in //productFamily[@name = "AssetManagement.Storm"]/table[@name = $table]/column
  let $column := $table_column/@name/string()
  order by $column
  return `let {$column} = _vocab "Hansen.AssetManagement.Storm.{$table}.{$column}"`