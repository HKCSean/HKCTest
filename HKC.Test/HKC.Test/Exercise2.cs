namespace HKC.Exercises
{
    public class Exercise2
    {
        /// <summary>
        /// Is there is a cat that weighs over 2 kilos?
        /// </summary>
        public class Pet
        {
            public int Id { get; }
            public string Name { get; }
            public PetType PetType { get; }
            public float Weight { get; }

            public Pet(int id, string name, PetType petType, float weight)
            {
                Id = id;
                Name = name;
                PetType = petType;
                Weight = weight;
            }

            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Type: {PetType}, Weight: {Weight}";
            }
        }

        public enum PetType
        {
            Cat,
            Dog,
            Fish
        }

        //Coding Exercise 2
        //Using LINQ, implement the AreThereAnyBigCats method, which will check
        //if in the collection of Pets there is a cat that weighs over 2 kilos.
        public static bool AreThereAnyBigCats(IEnumerable<Pet> pets)
        {
            //TODO you code goes here
            throw new NotImplementedException();
        }
    }
}

