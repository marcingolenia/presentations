type Suit = | Spades | Clubs | Diamonds | Hearts
  
type Rank = | Two  | Three | Four  | Five  | Six  | Seven | Eight
            | Nine | Ten | Jack | Queen | King
  
type Card = Rank * Suit
type Deck = Card list
type Hand = Card list
type Player = { Name: string; Hand: Hand }
type Game = { Deck: Deck; Players: Player list }

type Deal = Deck -> (Deck * Card)
type PickupCard = (Hand * Card) -> Hand

