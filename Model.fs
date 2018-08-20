// type Details = 
//     { Name: string
//       Description :string }


// type Item = 
//     { Details: Details }

// type Exit = 
//     | PassableExt of Details * destination: Room
//     | LockedExit of Details * Key: Item * next: Exit
//     | NoExit of Details option
  


// and Exits = 
//     { North: Exit
//       South: Exit
//       East: Exit
//       West: Exit
//     }

// and Room =
//     { Details: Details
//       Items: Item list
//       Exits: Exits}


     
// let firstRoom =
//     { Details = { Name = "First Room"; Description="You're standing here"};
//       Items =[];
//       Exits = 
//             { North = NoExit(None);
//               South = NoExit(None);
//               East = NoExit(None);
//               West = NoExit(None)
//             }
//     }



type Details = 
open System.Collections.Generic
    {
        Name: string
        Description: string
    }

type Item =
    { Details: Details}

type RoomId =
    | RoomId of string
type Exit = 
    | PassableExit of string * destination: RoomId
    | LockedExit of string * key: Item * next: Exit
    | NoExit of string option

type Exits = 
    {
        North: Exit
        South: Exit
    }


type Room = 
    {
        Id: RoomId
        Details: Details
        Items: Item List
        Exits: Exits
    }

type Player = 
    {
        Details: Details
        Location: RoomId
        Inventory: Item list
    }


type World = {
    Rooms: Map<RoomId,Room>
    Player: Player
}