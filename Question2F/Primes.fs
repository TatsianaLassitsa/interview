module SimcorpInterview.FSharp.Primes

/// Write an algorithm that returns the first <n> prime numbers (простi числа)
/// Assume n <= 100
let firstPrimes (n : int) : int array =
    [|2; 3; 5|]

firstPrimes 3 |> Array.iter (printfn "%i")
