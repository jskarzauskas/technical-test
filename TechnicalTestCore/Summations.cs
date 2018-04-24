namespace TechnicalTestCore
{
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            return (int)GetSumFrom1TillNr(maxNrAsInt);
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int maxNr = int.Parse(maxNrAsString);
            return GetSumFrom1TillNr(maxNr).ToString();
        }

        private static double GetSumFrom1TillNr(int maxNr)
        {
            double sumOfNumbers = 0;

            for (int i = 1; i <= maxNr; i++)
            {
                sumOfNumbers = sumOfNumbers + i;
            }

            return sumOfNumbers;
        }
    }
}
