module RightLeftTests

open System
open Xunit
open PlutoRover.Domain

[<Fact>]
let ``when the rover is facing north and it turns left then its new direction is west`` () =
    let rover = {
        x = 0
        y = 0
        direction = North
        grid = {
            height = 10
            width = 10
            obstacles = []
        }
    }
    let rover' = execute L rover
    Assert.Equal (rover', { rover with direction  = West })

[<Fact>]
let ``when the rover is facing north and it turns right then its new direction is east`` () =
    let rover = {
        x = 0
        y = 0
        direction = North
        grid = {
            height = 10
            width = 10
            obstacles = []
        }
    }
    let rover' = execute R rover
    Assert.Equal (rover', { rover with direction = East })

[<Fact>]
let ``when the rover is facing south and it turns left then its new direction is east`` () =
    let rover = {
        x = 0
        y = 0
        direction = South
        grid = {
            height = 10
            width = 10
            obstacles = []
        }
    }
    let rover' = execute L rover
    Assert.Equal (rover', { rover with direction = East })

[<Fact>]
let ``when the rover is facing south and it turns right then its new direction is west`` () =
    let rover = {
        x = 0
        y = 0
        direction = South
        grid = {
            height = 10
            width = 10
            obstacles = []
        }
    }
    let rover' = execute R rover
    Assert.Equal (rover', { rover with direction = West })

[<Fact>]
let ``when the rover is facing east and it turns left then its new direction is north`` () =
    let rover = {
        x = 0
        y = 0
        direction = East
        grid = {
            height = 10
            width = 10
            obstacles = []
        }
    }
    let rover' = execute L rover
    Assert.Equal (rover', { rover with direction = North })

[<Fact>]
let ``when the rover is facing east and it turns right then its new direction is south`` () =
    let rover = {
        x = 0
        y = 0
        direction = East
        grid = {
            height = 10
            width = 10
            obstacles = []
        }
    }
    let rover' = execute R rover
    Assert.Equal (rover', { rover with direction = South })

[<Fact>]
let ``when the rover is facing west and it turns left then its new direction is south`` () =
    let rover = {
        x = 0
        y = 0
        direction = West
        grid = {
            height = 10
            width = 10
            obstacles = []
        }
    }
    let rover' = execute L rover
    Assert.Equal (rover', { rover with direction = South })

[<Fact>]
let ``when the rover is facing west and it turns right then its new direction is north`` () =
    let rover = {
        x = 0
        y = 0
        direction = West
        grid = {
            height = 10
            width = 10
            obstacles = []
        }
    }
    let rover' = execute R rover
    Assert.Equal (rover', { rover with direction = North })