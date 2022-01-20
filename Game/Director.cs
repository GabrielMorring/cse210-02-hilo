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
        Deck gameDeck = new Deck();
        
        int score;

        int totalScore = 300;

        bool isPlaying = true;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();

            }
            
        }

        public void GetInputs()
        {
            Console.Write("Draw card? [y/n] ");
            string answer = Console.ReadLine();
            isPlaying = (answer == "y");
            

        }

        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }
        
        score = 0;
    


        }

        
        
    }
}

