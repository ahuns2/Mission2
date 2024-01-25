using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int numRolls = 0;
        double[] rollType = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        numRolls = int.Parse(System.Console.ReadLine());

        Random random = new Random();

        for (int i = 0; i < numRolls; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);

            int roll = die1 + die2;

            if (roll == 2)
            {
                rollType[0] += 1;
            }
            else if (roll == 3)
            {
                rollType[1] += 1;
            }
            else if (roll == 4)
            {
                rollType[2] += 1;
            }
            else if (roll == 5)
            {
                rollType[3] += 1;
            }
            else if (roll == 6)
            {
                rollType[4] += 1;
            }
            else if (roll == 7)
            {
                rollType[5] += 1;
            }
            else if (roll == 8)
            {
                rollType[6] += 1;
            }
            else if (roll == 9)
            {
                rollType[7] += 1;
            }
            else if (roll == 10)
            {
                rollType[8] += 1;
            }
            else if (roll == 11)
            {
                rollType[9] += 1;
            }
            else
            {
                rollType[10] += 1;
            }
        }

        for (int i = 0; i < rollType.Length; i++)
        {
            double percentage = ((double)rollType[i] / numRolls) * 100;
            rollType[i] = (int)Math.Round(percentage);
        }

        string[] rollTypeAsterisks = { "", "", "", "", "", "", "", "", "", "", "" };

        for (int i = 0; i < rollType.Length; ++i)
        {
            int count = (int)rollType[i];
            rollTypeAsterisks[i] = new string('*', count);
        }

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n" +
                                "Each \"*\" represents 1% of the total number of rolls.\n" +
                                "Total number of rolls: " + numRolls + ".\n\n" +
                                "2: " + rollTypeAsterisks[0] + " " + rollType[0] + "%\n" +
                                "3: " + rollTypeAsterisks[1]  + " " + rollType[1] + "%\n" +
                                "4: " + rollTypeAsterisks[2] + " " + rollType[2] + "%\n" +
                                "5: " + rollTypeAsterisks[3] + " " + rollType[3] +  "%\n" +
                                "6: " + rollTypeAsterisks[4] + " " + rollType[4] + "%\n" +
                                "7: " + rollTypeAsterisks[5] + " " + rollType[5] + "%\n" +
                                "8: " + rollTypeAsterisks[6] + " " + rollType[6] + "%\n" +
                                "9: " + rollTypeAsterisks[7] + " " + rollType[7] + "%\n" +
                                "10: " + rollTypeAsterisks[8] + " " + rollType[8] + "%\n" +
                                "11: " + rollTypeAsterisks[9] + " " + rollType[9] + "%\n" +
                                "12: " + rollTypeAsterisks[10] + " " + rollType[10] + "%\n\n" +
                                "Thank you for using the dice throwing simulator. Goodbye!");

    }
}