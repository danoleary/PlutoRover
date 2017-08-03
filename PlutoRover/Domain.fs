namespace PlutoRover

module Domain =
    
    type Direction = North | South | East | West

    type Point = {
        x : int
        y : int
    }

    type Grid = {
        height : int
        width : int
        obstacles : Point list
    }

    type Command = F | B | L | R

    type Rover = {
        x : int
        y : int
        direction : Direction
        grid : Grid
        availableCommands : Command list
    }

    let execute command rover = 
        let moveIfNoObstacle rover newPos =
            if List.exists (fun o -> o = newPos) rover.grid.obstacles then
                {rover with availableCommands = []}
            else
                { rover with x = newPos.x; y = newPos.y}
        let moveNorth rover =
            let newY = if rover.y = rover.grid.height then 0 else rover.y + 1
            moveIfNoObstacle rover {x = rover.x; y = newY}
        let moveSouth rover =
            let newY = if rover.y = 0 then rover.grid.height else rover.y - 1
            moveIfNoObstacle rover {x = rover.x; y = newY}
        let moveEast rover = 
            let newX = if rover.x = rover.grid.width then 0 else rover.x + 1
            moveIfNoObstacle rover {x = newX; y = rover.y}
        let moveWest rover = 
            let newX = if rover.x = 0 then rover.grid.width else rover.x - 1
            moveIfNoObstacle rover {x = newX; y = rover.y}
        let turn direction rover = { rover with direction = direction }
        let actionToTake command direction =
            match command, rover.direction with
            | F, North | B, South -> moveNorth
            | F, South | B, North -> moveSouth
            | F, East | B, West -> moveEast
            | F, West | B, East -> moveWest
            | L, North | R, South -> turn West
            | L, South | R, North -> turn East
            | L, East | R, West -> turn North
            | L, West | R, East -> turn South
        let f = actionToTake command rover.direction
        f rover 

    let rec executeCommands commands rover =
        match rover.availableCommands with
        | [] -> rover
        | _ -> 
            match commands with
            | [] -> rover
            | [hd] -> executeCommands [] (execute hd rover)
            | hd::tl -> executeCommands tl (execute hd rover)


