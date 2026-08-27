import json
import sys
from pathlib import Path

import ijson
from genson import SchemaBuilder


source_directory = Path(sys.argv[1])
schema_path = Path(sys.argv[2])

item_schema_builder = SchemaBuilder(schema_uri=None)

for source_path in source_directory.glob("*.json"):
    with source_path.open("rb") as source:
        for item in ijson.items(source, "item", use_float=True):
            item_schema_builder.add_object(item)

schema = {
    "$schema": "http://json-schema.org/draft-07/schema#",
    "type": "array",
    "items": item_schema_builder.to_schema(),
}

with schema_path.open("w", encoding="utf-8") as destination:
    json.dump(schema, destination, indent=2)