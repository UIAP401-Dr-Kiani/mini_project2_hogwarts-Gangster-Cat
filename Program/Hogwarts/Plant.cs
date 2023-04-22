namespace Hogwarts
{
    public class Plant
    {
        public Plant(PlantName name, int count)
        {
            Name = name;
            Count = count;
        }

        protected Plant()
        {
        }

        public PlantName Name { get; set; }
        public int Count { get; set; }
    }
}