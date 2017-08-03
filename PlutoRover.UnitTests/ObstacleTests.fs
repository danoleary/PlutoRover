module ObstacleTests

open System
open Xunit
open PlutoRover.Domain

[<Fact>]
let ``when there is an obstacle in the rovers path to the north then the rovers position does not change and the available commands list is empty`` () =
    let rover = {
        x = 0
        y = 0
        direction = North
        grid = {
            height = 10
            width = 10
            obstacles = [
                { x = 0; y =1 }
            ]
        }
        availableCommands = [F; B; L; R]
    }
    let rover' = execute F rover
    Assert.Equal ({rover with availableCommands = []}, rover')

[<Fact>]
let ``when there is an obstacle in the rovers path to the south then the rovers position does not change and the available commands list is empty`` () =
    let rover = {
        x = 0
        y = 0
        direction = South
        grid = {
            height = 10
            width = 10
            obstacles = [
                { x = 0; y =10 }
            ]
        }
        availableCommands = [F; B; L; R]
    }
    let rover' = execute F rover
    Assert.Equal ({rover with availableCommands = []}, rover')

[<Fact>]
let ``when there is an obstacle in the rovers path to the east then the rovers position does not change and the available commands list is empty`` () =
    let rover = {
        x = 0
        y = 0
        direction = East
        grid = {
            height = 10
            width = 10
            obstacles = [
                { x = 1; y = 0}
            ]
        }
        availableCommands = [F; B; L; R]
    }
    let rover' = execute F rover
    Assert.Equal ({rover with availableCommands = []}, rover')

[<Fact>]
let ``when there is an obstacle in the rovers path to the west then the rovers position does not change and the available commands list is empty`` () =
    let rover = {
        x = 0
        y = 0
        direction = West
        grid = {
            height = 10
            width = 10
            obstacles = [
                { x = 10; y = 0}
            ]
        }
        availableCommands = [F; B; L; R]
    }
    let rover' = execute F rover
    Assert.Equal ({rover with availableCommands = []}, rover')