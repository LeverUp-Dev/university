internal class Program
{
    class Pet
    {
        public string name;
        public int age;
    }

    class Person
    {
        public string name;
        public string adress;
        public List<Pet> pets;
    }
    private static void Main(string[] args)
    {
        Pet pet1 = new Pet();
        pet1.name = "구름";
        pet1.age = 7;

        Pet pet2 = new Pet();
        pet2.name = "별";
        pet2.age = 1;

        Person person = new Person();
        person.name = "윤인성";
        person.adress = "서울시 강서구";
        person.pets = new List<Pet>() { pet1, pet2 };
    }
}