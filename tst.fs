let prefix prefixStr baseStr =prefixStr + ", " + baseStr

let names = ["Ahmad";"Ali";"Jack"]

let prefixWithHello = prefix "Hello"

let exclaim s = s + "!"

let bigHello = prefixWithHello>>exclaim

names |> Seq.map bigHello |> Seq.sort

let hellos = names |> Seq.map (fun x -> printfn "Mapped over %s" x; bigHello x) |> Seq.sort |>Seq.iter (printfn "%s")

hellos