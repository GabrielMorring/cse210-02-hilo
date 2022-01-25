# Hilo
Hilo is a card game where you guess if the next card drawn is higher or lower than the last one.
The player starts out with 300 point and gets 100 for correct guesses and loses 75 for wrong guesses.
If your reach 0 points you lose.

## Required Software
.NET 6.0

### Project Structure
---
The project files and folders are organized as follows:
```
root                            (project root folder)
+-- Game                        (source code folder)
+-- Program.cs                  (program entry point)    
+-- README.md                   (general info)
+-- cse210-02-hilo.csproj       (dotnet project file)
```

#### Program design
The program will have a director class and a deck class. 

The Director class will run the game. It will store the points of the player, 
give prompts to the player, and decide if the game is over or not.

The Director class will have the properties of:
1 gameDeck: the deck of cards to draw from
2 score: the points the player will earn or lose
3 totalScore: the total points of the player
4 isPlaying: whether the  game is playing or not
5 currentCard: the card that is drawn
6 prevCard: the last card that was drawn

The Director class will have the methods of:
1 StartGame: starts and runs the game
2 DrawCard: draws a card from the deck and makes currentCard it, and prevcard the last card.

The Deck class will be the deck of cards.

The Deck class will have the properties of:
1 cards: all the cards in the deck organized in a list

The Deck class will have the methods of:
1 GenearateDeck: generates a standard 52 card deck
2 AddCard: adds a card to the end of the deck
3 RemoveCard: removes a card from the deck with a parameter of index for what card to remove
4 Shuffle: shuffles the deck
5 Reset: Resets the deck to default 52 card deck

