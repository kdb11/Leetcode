namespace Solution
{
    class solution16
    {
        public static int LargestAltitude(int[] gain) {
        
        int largestAltitudeYet = 0;
        int altitude = 0;

        for (int i = 0; i < gain.Length; i++)
        {

            altitude += gain[i];

            /* Console.WriteLine(altitude); */

            if (largestAltitudeYet < altitude)
            {
                largestAltitudeYet = altitude;
            }
        }
        
        Console.WriteLine(largestAltitudeYet);
        return largestAltitudeYet;
        }
    }
}