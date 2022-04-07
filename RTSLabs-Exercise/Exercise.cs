namespace RTSLabs_Exercise
{
    public static class Exercise
    {
        public static Dictionary<string, int> AboveBelow(int[] unsorted, int comparison)
        {
            return new Dictionary<string, int>()
            {
                { "above", unsorted.Where(x => x > comparison).Count() },
                { "below", unsorted.Where(x => x < comparison).Count() },
            };
        }

        public static string StringRotation(string original, uint rotation)
        {
            if (rotation > original.Length)
                throw new ArgumentException("The provided rotation is greater than the length of the string.");

            var casted = (int)rotation; // substring doesn't accept unit
            return original.Substring(original.Length - casted, casted) + original.Substring(0, original.Length - casted);
        }
    }
}