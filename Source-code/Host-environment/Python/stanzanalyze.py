import argparse
import json
import sys
import stanza

ALL_PROCESSORS = "tokenize,mwt,pos,lemma,depparse,ner,sentiment,constituency"
# stanza.download("en", processors=ALL_PROCESSORS)

SENTIMENT_LABELS = {
    0: "negative",
    1: "neutral",
    2: "positive",
}
CLAUSE_LABELS = {"S", "SBAR", "SBARQ", "SINV", "SQ"}
PHRASE_LABELS = {
    "NP", "VP", "PP", "ADJP", "ADVP", "QP", "WHNP", "WHPP", "WHADJP", "WHADVP",
    "CONJP", "FRAG", "INTJ", "LST", "NAC", "NX", "PRN", "PRT", "RRC", "UCP"
}

def get_tree_label(node):
    label = getattr(node, "label", None)
    return label() if callable(label) else label

def get_tree_children(node):
    children = getattr(node, "children", None)
    return children() if callable(children) else children or []

def constituency_level(label):
    if label in CLAUSE_LABELS:
        return "clause"
    if label in PHRASE_LABELS:
        return "phrase"
    return "word"

def stanza_constituency_to_object(node):
    label = get_tree_label(node)
    children = get_tree_children(node)

    # Leaf/token node: Stanza represents terminal words as nodes with no children.
    if not children:
        return label

    # Preterminal node: POS tag with exactly one terminal child.
    # Example: (DT The) -> { label: "DT", level: "word", constituency: "The" }
    if len(children) == 1 and not get_tree_children(children[0]):
        return {
            "label": label,
            "level": "word",
            "constituency": get_tree_label(children[0]),
        }

    return {
        "label": label,
        "level": constituency_level(label),
        "constituency": [
            stanza_constituency_to_object(child)
            for child in children
        ],
    }

def stanza_constituency_to_json_shape(tree):
    label = get_tree_label(tree)
    children = get_tree_children(tree)

    if label == "ROOT" and len(children) == 1:
        return {
            "ROOT": stanza_constituency_to_object(children[0])
        }

    return {
        label: {
            "level": constituency_level(label),
            "constituency": [
                stanza_constituency_to_object(child)
                for child in children
            ],
        }
    }
def build_pipeline():
    return stanza.Pipeline(
        "en",
        processors=ALL_PROCESSORS,
        use_gpu=False,
        download_method=None,
    )


def analyze_text(nlp, text: str) -> dict:
    doc = nlp(text)
    return {
        "text": doc.text,
        "sentences": [
            {
                "text": sentence.text,
                "dependencies": [
                    {
                        "dependency": dependency,
                        "dependent": dependent.text,
                        "head": head.text,
                    }
                    for head, dependency, dependent in sentence.dependencies
                ],
                "sentiment": {
                    "value": getattr(sentence, "sentiment", None),
                    "label": SENTIMENT_LABELS.get(getattr(sentence, "sentiment", None))
                },
                "constituency": (
                    stanza_constituency_to_json_shape(sentence.constituency)
                    if getattr(sentence, "constituency", None) is not None
                    else None
                ),
                "words": [
                    {
                        "id": w.id,
                        "text": w.text,
                        "lemma": w.lemma,
                        "upos": w.upos,
                        "xpos": w.xpos,
                        "head": w.head,
                        "deprel": w.deprel,
                    }
                    for w in sentence.words
                ],
            }
            for sentence in doc.sentences
        ],
        "entities": [
            {
                "text": ent.text,
                "type": ent.type,
                "start_char": ent.start_char,
                "end_char": ent.end_char,
            }
            for ent in doc.entities
        ],
        "num_tokens": doc.num_tokens,
        "num_words": doc.num_words,
        "tokens": doc.to_dict()
    }
def main():
    parser = argparse.ArgumentParser(description="Run Stanza on an input string.")
    parser.add_argument("text", nargs="?", help="Input text to analyze")
    parser.add_argument("--file", dest="file_path", help="Read input text from a file")
    parser.add_argument("--pretty", action="store_true", help="Pretty-print JSON output")
    args = parser.parse_args()

    if args.file_path is not None:
        with open(args.file_path, "r", encoding="utf-8") as f:
            text = f.read()
    elif args.text is not None:
        text = args.text
    else:
        print("Provide input text as an argument or use --file.", file=sys.stderr)
        sys.exit(2)

    nlp = build_pipeline()
    result = analyze_text(nlp,text)
    # print(result)
    if args.pretty:
         print(json.dumps(result, ensure_ascii=False, indent=2))
    else:
         print(json.dumps(result, ensure_ascii=False))

if __name__ == "__main__":
    main()