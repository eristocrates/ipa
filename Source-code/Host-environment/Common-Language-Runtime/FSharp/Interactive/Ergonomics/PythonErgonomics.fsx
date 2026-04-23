#r "nuget: pythonnet, 3.1.0-rc.0"

open Python.Runtime

Runtime.PythonDLL <-
    @"C:\Repositories\eristocrates\ipa\Language\Python\python-full-3.13.4-windows-x86_64\bin\python313.dll"

PythonEngine.PythonHome <- @"C:\Repositories\eristocrates\ipa\Language\Python\python-full-3.13.4-windows-x86_64"

PythonEngine.Initialize()

let gil = Py.GIL()

let pyRoot =
    @"C:\Repositories\eristocrates\ipa\Language\Python\python-full-3.13.4-windows-x86_64"

let pyBin = pyRoot + @"\bin"
let sitePackages = pyRoot + @"\Lib\site-packages"
let grafeoPkg = sitePackages + @"\grafeo"

let osModule = Py.Import("os")
let sysModule = Py.Import("sys")

let addDllDirectory (path: string) =
    let fn = osModule.GetAttr("add_dll_directory")
    fn.Invoke([| new PyString(path) :> PyObject |])

// Keep these alive
let dllDir1 = addDllDirectory pyBin
let dllDir2 = addDllDirectory sitePackages
let dllDir3 = addDllDirectory grafeoPkg

let sysPath = sysModule.GetAttr("path")
printfn "sys.path = %O" sysPath

let grafeo = Py.Import("grafeo")
let grafeoFile = grafeo.GetAttr("__file__")
printfn "grafeo loaded from: %O" grafeoFile

grafeo.GetAttr("__version__")

let db_path =
    new PyString(@"C:\Repositories\eristocrates\ipa\Persistence\Database\Embedded\Graph\Grafeo\grafeo.db")

let grafeo'GrafeoDB = grafeo.GetAttr("GrafeoDB")

let db = grafeo'GrafeoDB.Invoke([| db_path :> PyObject |])


printfn "db = %O" db

let db'execute (command_string: string) =
    use command_python_string = new PyString(command_string)

    db.InvokeMethod("execute", [| command_python_string.ToPython() |])

db'execute "INSERT (:Person {name: 'Alix', age: 30})"

db'execute "INSERT (:Person {name: 'Gus', age: 25})"

db'execute "INSERT (:Person {name: 'Alix'})-[:KNOWS]->(:Person {name: 'Gus'})"

let query_result = db'execute "MATCH (p:Person) RETURN p.name, p.age"

printfn "columns = %O" (query_result.GetAttr("columns"))
printfn "first row = %O" (query_result.GetItem(0))
let builtins = Py.Import("builtins")
let dirFn = builtins.GetAttr("dir")
let names = dirFn.Invoke([| db |])

printfn "%O" names

let full_graph =
    db'execute
        """
  MATCH (n)
  RETURN n
  """

db'execute
    """
MATCH (n)
DETACH DELETE n

INSERT (:Person {name: 'Alix', age: 30})
INSERT (:Person {name: 'Gus', age: 25})

MATCH (a:Person {name: 'Alix'}), (b:Person {name: 'Gus'})
INSERT (a)-[:KNOWS]->(b)

MATCH (p:Person)
RETURN p.name, p.age"""


db'execute
    """
MATCH (n)
DELETE n
"""








// When completely done, optionally close the handles:
// dllDir3.InvokeMethod("close") |> ignore
// dllDir2.InvokeMethod("close") |> ignore
// dllDir1.InvokeMethod("close") |> ignore

PythonEngine.Shutdown()
