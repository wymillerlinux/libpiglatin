namespace LibPigLatin

open System

module PigLatin =
    let toPigLatin (str: string) =
        
        // if a word starts with a vowel, word + "yay"
        // if not, word turns into (Banana -> ananaBay)

        let vowels = set ['a';'e';'i';'o';'u']

        let firstChar = str.[0]

        if vowels.Contains(Char.ToLower firstChar) then
            str + "yay"
        else
            str.[1..] + Char.ToString(firstChar) + "ay"