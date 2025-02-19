namespace Solution
{
    class solution9
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            bool isTrue = true;
            char letterInRansomNote = 'a';
            bool boolResult = false;

            string result = "";

            for (int i = 0; i < ransomNote.Length; i++) // Loop through the ransomNote, not the magazine
            {
                isTrue = true; // Reset isTrue for each new letter in the ransom note

                while (isTrue) // This loop ensures we are always checking from the start of the magazine
                {
                    for (int j = 0; j < magazine.Length; j++) // Start over with the magazine on each letter of ransomNote
                    {
                        letterInRansomNote = ransomNote[i];

                        if (letterInRansomNote == magazine[j])
                        {
                            result += letterInRansomNote;
                            magazine = magazine.Remove(j, 1); // Remove the character from the magazine to ensure it's used only once
                            isTrue = false; // Break out of the loop after a match
                            break;
                        }
                    }

                    if (isTrue == true)
                    {
                        // If we couldn't find the letter in the magazine, break and return false
                        break;
                    }
                }

                if (result.Length == ransomNote.Length)
                {
                    boolResult = true; // Successfully matched all letters
                    break;
                }
            }

            return boolResult;

        }
    }
}