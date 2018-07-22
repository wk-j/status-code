namespace StatusCode.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.AspNetCore.Mvc
open Microsoft.AspNetCore.Mvc

type Message = {
    Data: string
}

[<Route("api/[controller]/[action]")>]
[<ApiController>]
type HelloController() =
    inherit ControllerBase()

    [<HttpGet()>]
    member this.Hello() =
        this.StatusCode(700, { Data = "Hello"} )

    [<HttpPost>]
    member this.FromParamsString(data: string) =
        this.StatusCode(700, { Data = "-- " + data })

    [<HttpPost>]
    member this.FromBodyObject(data: Message) =
        this.StatusCode(700, { Data = "-- " + data.Data })
