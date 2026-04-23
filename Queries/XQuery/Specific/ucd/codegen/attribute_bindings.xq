declare namespace ucd = "http://www.unicode.org/ns/2003/ucd/1.0";
declare variable $xpath_navigator_identifier := "document_root";
declare variable $namespace_manager_identifier := "namespace_manager";

for $attribute_local_name in distinct-values(//ucd:char/@*/local-name())
  return `let {$attribute_local_name}_attributes = {$xpath_navigator_identifier }.Select( "//ucd:char/@{$attribute_local_name}", {$namespace_manager_identifier})`