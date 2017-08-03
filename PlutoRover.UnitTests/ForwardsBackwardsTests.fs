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
    }
    let rover' = execute F rover
    Assert.Equal (rover', {rover with y = 1})

[<Fact>]
let ``when the rover is facing north and it moves backwards then its y co-ordinate is decremented by 1`` () =
    let rover = {
        x = 0
        y = 0
        direction = North
    }
    let rover' = execute B rover
    Assert.Equal (rover', {rover with y = -1})

[<Fact>]
let ``when the rover is facing south and it moves forwards then its y co-ordinate is decremented by 1`` () =
    let rover = {
        x = 0
        y = 0
        direction = South
    }
    let rover' = execute F rover
    Assert.Equal (rover', {rover with y = -1})

[<Fact>]
let ``when the rover is facing south and it moves backwards then its y co-ordinate is incremented by 1`` () =
    let rover = {
        x = 0
        y = 0
        direction = South
    }
    let rover' = execute B rover
    Assert.Equal (rover', {rover with y = 1})

[<Fact>]
let ``when the rover is facing east and it moves forwards then its x co-ordinate is incremented by 1`` () =
    let rover = {
        x = 0
        y = 0
        direction = East
    }
    let rover' = execute F rover
    Assert.Equal (rover', {rover with x = 1})

[<Fact>]
let ``when the rover is facing east and it moves backwards then its x co-ordinate is decremented by 1`` () =
    let rover = {
        x = 0
        y = 0
        direction = East
    }
    let rover' = execute B rover
    Assert.Equal (rover', {rover with x = -1})

[<Fact>]
let ``when the rover is facing west and it moves forwards then its x co-ordinate is decremented by 1`` () =
    let rover = {
        x = 0
        y = 0
        direction = West
    }
    let rover' = execute F rover
    Assert.Equal (rover', {rover with x = -1})

[<Fact>]
let ``when the rover is facing west and it moves backwards then its x co-ordinate is incremented by 1`` () =
    let rover = {
        x = 0
        y = 0
        direction = West
    }
    let rover' = execute B rover
    Assert.Equal (rover', {rover with x = 1})
