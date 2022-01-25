using System;
using System.Collections.Generic;


namespace Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        public Deck gameDeck;
        
        public int score;

        public int totalScore;

        public bool isPlaying;

        public int currentCard;

        public int prevCard;

        public bool isCorrect;

        public string guess;

        public string userPlaying;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            totalScore = 300;
            isPlaying = true;
            gameDeck = new Deck();
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to HiLo, we will display a card and you guess if the next one will be higher or lower. \n If your right you will get 100 points, if you are wrong you will lose 75 points. \nIf you run out of points you lose. good Luck!!");
            Console.WriteLine();

            DrawCard();
            Console.WriteLine($"The card is {currentCard}");
            Console.WriteLine();

            

            while (isPlaying)
            {
                
                GetInputs();
                DoUpdates();
                DoOutputs();
                AskPlayAgain();
            }
            
        }

        public void AskPlayAgain()
        {
            if (isPlaying)
            {
                Console.WriteLine("Do you want to play again? [y/n]");
                userPlaying = Console.ReadLine();
                while (userPlaying != "y" && userPlaying != "n")
                {
                    Console.WriteLine("That is not a valid answer, enter  a valid one.");
                    userPlaying = Console.ReadLine();
                }
                if (userPlaying == "y")
                {
                    isPlaying = true;
                }

                if (userPlaying == "n")
                {
                    isPlaying = false;
                } 
            }
        }

        public void GetInputs()
        {
            Console.WriteLine("Will the next card be higher or Lower? [h/l]");
            guess = Console.ReadLine();
            while (guess != "h" && guess != "l")
            {
                Console.WriteLine("That is not a valid guess, guess again.");
                guess = Console.ReadLine();
            }
        }

        public void DoUpdates()
        {        
            DrawCard();

            score = 0;
            isCorrect = false;
            
            if (guess == "h")
            {
                if (currentCard > prevCard)
                {
                    isCorrect = true;
                }    
            }

            else if (guess == "l")
            {
                if (currentCard < prevCard)
                {
                    isCorrect = true;
                }
            } 

            if (isCorrect)
            {
                score = 100;
            }

            else if (!isCorrect)
            {
                score = -75;
            }

            totalScore += score;

            if (totalScore <= 0)
            {
                isPlaying = false;
            }


        }

        public void DoOutputs()
        {
            if (!isPlaying)
            {
                Console.WriteLine($"You lost by running out of points, the card was {currentCard}.");
            }

            else
            {
                Console.WriteLine($"The Card is {currentCard}");
                if (isCorrect)
                {
                    Console.WriteLine("You guessed right!");
                }
                if (!isCorrect)
                {
                    Console.WriteLine("You guessed wrong.");
                }
                Console.WriteLine($"Your points are {totalScore}.");
            }
            
        }

        public void DrawCard()
        {
            prevCard = currentCard;
            currentCard = gameDeck.cards[0];
            gameDeck.RemoveCard(0);
        }

        
        
    }
}

