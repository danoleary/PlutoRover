namespace PlutoRover

module Domain =
    
    type Direction = North | South | East | West

    type Rover = {
        x : int
        y : int
        direction : Direction
    }

    type Command = F | B

    let execute command rover = 
        let moveNorth rover = { rover with y = rover.y + 1}
        let moveSouth rover = { rover with y = rover.y - 1}
        let moveEast rover = { rover with x = rover.x + 1}
        let moveWest rover = { rover with x = rover.x - 1}
        match command with
        | F -> 
            match rover.direction with
            | North -> moveNorth rover
            | South -> moveSouth rover 
            | East -> moveEast rover
            | West -> moveWest rover 
        | B -> 
            match rover.direction with
            | North -> moveSouth rover 
            | South -> moveNorth rover
            | East -> moveWest rover 
            | West -> moveEast rover

