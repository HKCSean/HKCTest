namespace HKC.Exercises
{
    public class Exercise1
    {
        /// <summary>
        /// Refactoring challenge
        /// Can you please refactor this code
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        public static bool AreAllNamesValid(string[] names)
        {
            foreach (var name in names)
            {
                if (char.IsLower(name[0]))
                {
                    return false;
                }
                if (name.Length < 2)
                {
                    return false;
                }
                if (name.Length > 25)
                {
                    return false;
                }
            }
            return true;
        }

        ////Coding Exercise 1
        //Refactoring challenge
        //TODO implement this method
        public static bool AreAllNamesValid_Refactored(string[] names)
        {
            //TODO your code goes here
            throw new NotImplementedException();
        }
    }
}