module ForwardBackwardTests

open System
open Xunit
open PlutoRover.Domain

[<Fact>]
let ``when the rover is facing north and it moves forwards then its y co-ordinate is incremented by 1`` () =
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
    let rover' = execute F rover
    Assert.Equal (rover', {rover with y = 1})

[<Fact>]
let ``when the rover is facing north and it moves backwards then its y co-ordinate is decremented by 1`` () =
    let rover = {
        x = 0
        y = 1
        direction = North
        grid = {
            height = 10
            width = 10
            obstacles = []
        }
    }
    let rover' = execute B rover
    Assert.Equal (rover', {rover with y = 0})

[<Fact>]
let ``when the rover is facing south and it moves forwards then its y co-ordinate is decremented by 1`` () =
    let rover = {
        x = 0
        y = 1
        direction = South
        grid = {
            height = 10
            width = 10
            obstacles = []
        }
    }
    let rover' = execute F rover
    Assert.Equal (rover', {rover with y = 0})

[<Fact>]
let ``when the rover is facing south and it moves backwards then its y co-ordinate is incremented by 1`` () =
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
    let rover' = execute B rover
    Assert.Equal (rover', {rover with y = 1})

[<Fact>]
let ``when the rover is facing east and it moves forwards then its x co-ordinate is incremented by 1`` () =
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
    let rover' = execute F rover
    Assert.Equal (rover', {rover with x = 1})

[<Fact>]
let ``when the rover is facing east and it moves backwards then its x co-ordinate is decremented by 1`` () =
    let rover = {
        x = 1
        y = 0
        direction = East
        grid = {
            height = 10
            width = 10
            obstacles = []
        }
    }
    let rover' = execute B rover
    Assert.Equal (rover', {rover with x = 0})

[<Fact>]
let ``when the rover is facing west and it moves forwards then its x co-ordinate is decremented by 1`` () =
    let rover = {
        x = 1
        y = 0
        direction = West
        grid = {
            height = 10
            width = 10
            obstacles = []
        }
    }
    let rover' = execute F rover
    Assert.Equal (rover', {rover with x = 0})

[<Fact>]
let ``when the rover is facing west and it moves backwards then its x co-ordinate is incremented by 1`` () =
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
    let rover' = execute B rover
    Assert.Equal (rover', {rover with x = 1})
