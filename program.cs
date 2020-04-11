namespace baru.Latihanoop2
{
    public class Program
    {

        static void Main( string[] args )
        {
            Person person = new Person("Indah",19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Jesika",30,"3123","Math");
            teacher.GetNameAndAge();

            Student student = new Student("Melani",20,"2314","Melani@gmail.com");
            student.GetNameAndAge();
        }
    }
}