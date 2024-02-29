namespace Numbergame
{


    class program
    {
        static void Main(string[] args)
        {
            bool IsCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 101);

            Console.WriteLine("Welcome to the best Number guessing game in the world!!");
            Console.WriteLine("Guess the correct Number from 1-100 and you Win........**||Ready!!**");



            while (!IsCorrectGuess)
            {
                Console.WriteLine("Please enter your guess");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > randomNum)
                {
                    Console.WriteLine("Your guess is High");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Your guess is low");
                }
                else
                {
                    Console.WriteLine("You guessed right");
                    IsCorrectGuess = true;
                }

            }
            Console.WriteLine("Congratulation....You just won the game");

            Console.ReadKey();

        }
    }
}