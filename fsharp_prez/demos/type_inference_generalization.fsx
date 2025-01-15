let addToListIfNotThere list item =
    match (list |> Seq.contains item) with
        | true -> list
        | _ -> item :: list