

type IUserPersistence =
    abstract LoadUser : UserId -> Async<User option>
    abstract SaveUser : User -> Async<unit>

module UserPersistenceInterface =

    let toInterface (rcord : UserPersistence) : IUserPersistence =
        { new IUserPersistence with
            member _.LoadUser parameter_0 = rcord.LoadUser parameter_0
            member _.SaveUser parameter_0 = rcord.SaveUser parameter_0
        }

    let ofInterface (iface : IUserPersistence) : UserPersistence =
        {
            LoadUser = fun parameter_0 -> iface.LoadUser parameter_0
            SaveUser = fun parameter_0 -> iface.SaveUser parameter_0
        }
