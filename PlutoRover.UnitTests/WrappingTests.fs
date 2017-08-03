module WrappingTests

open System
open Xunit
open PlutoRover.Domain

[<Fact>]
let ``when the rover moves forwards over the northern edge of the grid then it appears on the southern edge`` () =
    let rover = {
        x = 0
        y = 100
        direction = North
        grid = {
            height = 100
            width = 100
            obstacles = []
        }
    }

    let rover' = execute F rover

    Assert.Equal (rover', { rover with y = 0 })

[<Fact>]
let ``when the rover moves backwards over the northern edge of the grid then it appears on the southern edge`` () =
    let rover = {
        x = 0
        y = 100
        direction = South
        grid = {
            height = 100
            width = 100
            obstacles = []
        }
    }

    let rover' = execute B rover

    Assert.Equal (rover', { rover with y = 0 })

[<Fact>]
let ``when the rover moves forwards over the southern edge of the grid then it appears on the northern edge`` () =
    let rover = {
        x = 0
        y = 0
        direction = South
        grid = {
            height = 100
            width = 100
            obstacles = []
        }
    }

    let rover' = execute F rover

    Assert.Equal (rover', { rover with y = 100 })

[<Fact>]
let ``when the rover moves backwards over the southern edge of the grid then it appears on the northern edge`` () =
    let rover = {
        x = 0
        y = 0
        direction = North
        grid = {
            height = 100
            width = 100
            obstacles = []
        }
    }

    let rover' = execute B rover

    Assert.Equal (rover', { rover with y = 100 })

[<Fact>]
let ``when the rover moves forward over the eastern edge of the grid then it appears on the western edge`` () =
    let rover = {
        x = 100
        y = 0
        direction = East
        grid = {
            height = 100
            width = 100
            obstacles = []
        }
    }

    let rover' = execute F rover

    Assert.Equal (rover', { rover with x = 0 })

[<Fact>]
let ``when the rover moves backwards over the eastern edge of the grid then it appears on the western edge`` () =
    let rover = {
        x = 100
        y = 0
        direction = West
        grid = {
            height = 100
            width = 100
            obstacles = []
        }
    }

    let rover' = execute B rover

    Assert.Equal (rover', { rover with x = 0 })

[<Fact>]
let ``when the rover moves forward over the western edge of the grid then it appears on the eastern edge`` () =
    let rover = {
        x = 0
        y = 0
        direction = West
        grid = {
            height = 100
            width = 100
            obstacles = []
        }
    }

    let rover' = execute F rover

    Assert.Equal (rover', { rover with x = 100 })

[<Fact>]
let ``when the rover moves backwards over the western edge of the grid then it appears on the eastern edge`` () =
    let rover = {
        x = 0
        y = 0
        direction = East
        grid = {
            height = 100
            width = 100
            obstacles = []
        }
    }

    let rover' = execute B rover

    Assert.Equal (rover', { rover with x = 100 })
