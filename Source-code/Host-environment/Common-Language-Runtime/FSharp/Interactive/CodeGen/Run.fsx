#load "GenerateUserPersistenceInterface.fsx"
#load "UserPersistence.fsx"
#load "UserPersistence.Generated.fsx"

let inMemoryUser =
    {
        Id = UserId "user-1"
        Name = "Ada"
    }

let recordPort : UserPersistence =
    {
        LoadUser =
            fun userId ->
                async {
                    if userId = inMemoryUser.Id then
                        return Some inMemoryUser
                    else
                        return None
                }

        SaveUser =
            fun user ->
                async {
                    printfn "Saved user: %A" user
                }
    }

let interfacePort : IUserPersistence =
    UserPersistenceInterface.toInterface recordPort

let roundTrippedRecordPort : UserPersistence =
    UserPersistenceInterface.ofInterface interfacePort

async {
    let! loadedUser = roundTrippedRecordPort.LoadUser (UserId "user-1")
    printfn "Loaded user: %A" loadedUser

    do! roundTrippedRecordPort.SaveUser inMemoryUser
}
|> Async.RunSynchronously