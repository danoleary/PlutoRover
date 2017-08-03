namespace PlutoRover

module Domain =
    
    type Direction = North | South | East | West

    type Obstacle = {
        x : int
        y : int
    }

    type Grid = {
        height : int
        width : int
        obstacles : Obstacle list
    }

    type Rover = {
        x : int
        y : int
        direction : Direction
        grid : Grid
    }

    type Command = F | B | L | R

    let execute command rover = 
        let moveNorth rover =
            let newY = if rover.y = rover.grid.height then 0 else rover.y + 1
            if List.exists (fun o -> o = {x = rover.x; y = newY} ) rover.grid.obstacles then
                rover
            else
                { rover with y = newY}
        let moveSouth rover =
            let newY = if rover.y = 0 then rover.grid.height else rover.y - 1
            if List.exists (fun o -> o = {x = rover.x; y = newY} ) rover.grid.obstacles then
                rover
            else
                { rover with y = newY}
        let moveEast rover = 
            let newX = if rover.x = rover.grid.width then 0 else rover.x + 1
            if List.exists (fun o -> o = {x = newX; y = rover.y} ) rover.grid.obstacles then
                rover
            else
                { rover with x = newX }
        let moveWest rover = 
            let newX = if rover.x = 0 then rover.grid.width else rover.x - 1
            if List.exists (fun o -> o = {x = newX; y = rover.y} ) rover.grid.obstacles then
                rover
            else
                { rover with x = newX }
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

