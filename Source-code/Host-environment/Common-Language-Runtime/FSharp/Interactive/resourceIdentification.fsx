module dotnetfsi =
    module exe =
        [<Literal>]
        let filePath =
            @"C:\Program Files\Microsoft Visual Studio\18\Professional\Common7\IDE\CommonExtensions\Microsoft\FSharp\Tools\fsi.exe"

module dotnet =
    module exe =
        [<Literal>]
        let filePath = @"C:\Program Files\dotnet\dotnet.exe"

module java =
    module cmd =
        [<Literal>]
        let filePath =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Shell\Powershell\java.cmd"
