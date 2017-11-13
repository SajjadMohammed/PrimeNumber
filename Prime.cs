namespace PrimeNumber
{
    public class Prime
    {
        public bool IsPrime(int numberToCheck)
        {
            #region Factors local function
            int FactorsOfNumber()
            {
                var counter = 0;
                for (int i = 1; i <= numberToCheck; i++)
                {
                    if (numberToCheck % i == 0)
                    {
                        counter++;
                        if (counter > 2)
                        {
                            break;
                        }
                    }
                }
                return counter;
            }
            #endregion

            return FactorsOfNumber() == 2;
        }
    }
}