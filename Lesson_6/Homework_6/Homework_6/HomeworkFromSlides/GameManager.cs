using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    public class GameManager
    {
        private const string nameOfTheGame = "Big Brother Is Watching You";
        private string nameOfTheMap;
        private StringBuilder nameOfThePlayer;

        private readonly object[]  enemies;
        private int emptyEnemiesIndex;

        private readonly int[,]  gameField;
        private int fieldDimensionX;
        private int fieldDimensionY;
        char[] splitRules = {',', '!', '?', ' '};
       
        public GameManager(int expectedNumberOfEnemies, int fieldDimensionX, int fieldDimensionY)
        {
            nameOfThePlayer = new StringBuilder();
            nameOfTheMap = String.Empty;
            enemies = new object[expectedNumberOfEnemies];
            emptyEnemiesIndex = 0;

            this.fieldDimensionX = fieldDimensionX;
            this.fieldDimensionY = fieldDimensionY;
            gameField = new int[fieldDimensionX, fieldDimensionY];
        }

        public void AddNameToTheMap(string name)
        {
            name = name.Trim();
            nameOfTheMap = name;
            Console.WriteLine($"The game is {nameOfTheGame}. You are playing on the {nameOfTheMap}");
        }

        public string[] SeparateUserTextInTokens(string text)
        {
            return text.Split(' ');
        }

        public string CreateATextFromWords(string[] words)
        {
            return String.Join(' ', words);
        }

        public void AddNameOfThePlayer(string nameOfThePlayer)
        {
            this.nameOfThePlayer.Append(nameOfThePlayer);
        }

        public void AddNameOfThePlayer(StringBuilder nameOfThePlayer)
        {
            this.nameOfThePlayer = nameOfThePlayer;
        }

        public void AddNewEnemies(object enemy)
        {
            if(emptyEnemiesIndex < enemies.Length)
            {
                enemies[emptyEnemiesIndex] = enemy;
                emptyEnemiesIndex++;
                PlaceEnemyAtRandomPosition();
            }
            else
            {
                Console.WriteLine("Maximum Number Of Enemies");
            }
        }
        /*Value 0 in the gameField array represents empty position, value 1 the enemy position, value 2 represents the player position,*/
        public void PlaceEnemyAtRandomPosition()
        {
            Random random = new Random();
            int xAxesPosition = random.Next(fieldDimensionX);
            int yAxesPosition = random.Next(fieldDimensionY);
            gameField[xAxesPosition, yAxesPosition] = 1;
        }
    }
}
