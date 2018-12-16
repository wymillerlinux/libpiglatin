module Tests

open System
open Xunit
open LibPigLatin

[<Fact>]
let ``Defacto test`` () =
    Assert.True(true)

[<Fact>]
let ``Apple turns into Appleyay`` () =
    
    let expected = "Appleyay"
    let actual = PigLatin.toPigLatin "Apple"

    Assert.Equal(expected, actual)

[<Fact>]
let ``Wyatt turns into yattWay`` () =
    
    let expected = "yattWay"
    let actual = PigLatin.toPigLatin "Wyatt"

    Assert.Equal(expected, actual)
