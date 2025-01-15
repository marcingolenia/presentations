type Suit = | Spades | Clubs | Diamonds | Hearts // Union type is choice - pick one 
  
type Rank = | Two  | Three | Four  | Five  | Six  | Seven | Eight
            | Nine | Ten | Jack | Queen | King | Ace
  
type Card = Rank * Suit // Tuple means pair, so card has a face and suit.

type Deck = Card list  // built in list type
type Hand = Card list
type Player = { Name: string; Hand: Hand }
type Game = { Deck: Deck; Players: Player list }

type Deal = Deck -> (Deck * Card)
type PickupCard = (Hand * Card) -> Hand

