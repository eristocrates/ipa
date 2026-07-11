type UserId = UserId of string

type User = { Id: UserId; Name: string }

type UserPersistence =
    { LoadUser: UserId -> Async<User option>
      SaveUser: User -> Async<unit> }
