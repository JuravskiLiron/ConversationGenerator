using System;

namespace ConversationGenerator
{


    class ConversationGenerator
    {
        private static string[] topics = {
        "Travel",
        "Art",
        "Technology",
        "Food and Drinks",
        "Personal Hobbies",
        "Cultural Events",
        "Sports",
        "Movies and Books",
        "Scientific Discoveries",
        "Music"
    };

        private static string[] levels = {
        "Beginner",
        "Intermediate",
        "Expert"
    };

        private static string[] depths = {
        "General Knowledge",
        "In-depth Understanding",
        "Personal Experience"
    };

        private static Random random = new Random();

        public static string GenerateTopic()
        {
            string topic = topics[random.Next(topics.Length)];
            string level = levels[random.Next(levels.Length)];
            string depth = depths[random.Next(depths.Length)];

            return $"Topic: {topic}\nLevel: {level}\nDepth: {depth}";
        }

        public static string GenerateCustomTopic(string[] customTopics, string[] customLevels, string[] customDepths)
        {
            string topic = customTopics[random.Next(customTopics.Length)];
            string level = customLevels[random.Next(customLevels.Length)];
            string depth = customDepths[random.Next(customDepths.Length)];

            return $"Topic: {topic}\nLevel: {level}\nDepth: {depth}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Conversation Starter!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Generate a random topic.");
            Console.WriteLine("2. Generate a custom topic.");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    GenerateRandomTopic();
                    break;
                case 2:
                    GenerateCustomTopic();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        static void GenerateRandomTopic()
        {
            Console.WriteLine("Random Topic:");
            Console.WriteLine(ConversationGenerator.GenerateTopic());
        }

        static void GenerateCustomTopic()
        {
            Console.WriteLine("Enter custom topics (comma-separated):");
            string customTopicsInput = Console.ReadLine();
            string[] customTopics = customTopicsInput.Split(',');

            Console.WriteLine("Enter custom levels (comma-separated):");
            string customLevelsInput = Console.ReadLine();
            string[] customLevels = customLevelsInput.Split(',');

            Console.WriteLine("Enter custom depths (comma-separated):");
            string customDepthsInput = Console.ReadLine();
            string[] customDepths = customDepthsInput.Split(',');

            Console.WriteLine("Custom Topic:");
            Console.WriteLine(ConversationGenerator.GenerateCustomTopic(customTopics, customLevels, customDepths));
        }
    }
}