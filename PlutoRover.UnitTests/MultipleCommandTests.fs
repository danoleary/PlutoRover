module MultipleCommandTests

open System
open Xunit
open PlutoRover.Domain

[<Fact>]
let ``when a list of commands is applied to a rover then it ends up in the correct state`` () =
    let rover = {
        x = 0
        y = 0
        direction = North
        grid = {
            height = 100
            width = 100
            obstacles = [
                { x = 10; y = 0}
            ]
        }
        availableCommands = [F; B; L; R]
    }
    let commands = [F; F; R; F; F]

    let rover' = executeCommands commands rover

    Assert.Equal({rover with x = 2; y = 2; direction = East;}, rover')