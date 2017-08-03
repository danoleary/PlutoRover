namespace PlutoRover

module Domain =
    
    type Direction = North | South | East | West

    type Rover = {
        x : int
        y : int
        direction : Direction
    }

    type Command = F | B | L | R

    let execute command rover = 
        let moveNorth rover = { rover with y = rover.y + 1}
        let moveSouth rover = { rover with y = rover.y - 1}
        let moveEast rover = { rover with x = rover.x + 1}
        let moveWest rover = { rover with x = rover.x - 1}
        let turnNorth rover = { rover with direction = North}
        let turnSouth rover = { rover with direction = South}
        let turnEast rover = { rover with direction = East}
        let turnWest rover = { rover with direction = West}
        match command, rover.direction with
        | F, North | B, South -> moveNorth rover
        | F, South | B, North -> moveSouth rover
        | F, East | B, West -> moveEast rover
        | F, West | B, East -> moveWest rover
        | L, North | R, South -> turnWest rover
        | L, South | R, North -> turnEast rover
        | L, East | R, West -> turnNorth rover
        | L, West | R, East -> turnSouth rover 

