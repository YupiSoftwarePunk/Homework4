namespace Howemork4
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car("12df34", "Toyata", "Mark II", 1999, "Orange"));
            cars.Add(new Car("22we344", "BMW", "M5", 2020, "White"));
            cars.Add(new Car("349clmd79", "Porche", "911", 2024, "Yellow"));
            cars.Add(new Car("678gjhg47", "Honda", "Civic", 1990, "Blue"));
            cars.Add(new Car("974gf6", "Lincoln", "Continental", 1970, "Black"));


            Console.WriteLine("Добавьте новую машину: ");

            Console.Write("Введите марку: ");
            string brand = Console.ReadLine();

            Console.Write("Введите модель: ");
            string model = Console.ReadLine();

            Console.Write("Введите год выпуска: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Введите цвет: ");
            string colour = Console.ReadLine();

            Console.Write("Введите вин-номер: ");
            string vinNum = Console.ReadLine();

            cars.Add(new Car(vinNum, brand, model, year, colour));

            Console.WriteLine("\n\nСписок автомобилей до удаления и сортировки:");
            foreach (var car in cars)
            {
                Console.WriteLine($"Марка: {car.Brand}, Модель: {car.Model}, Вин-номер: {car.VinNum}, Цвет: {car.Colour}, Год: {car.Year}");
            }

            cars.Sort((car1, car2) => car1.Year.CompareTo(car2.Year));

            Console.Write("\n\n\nВведите VIN-номер для удаления: ");
            string vinToRemove = Console.ReadLine();

            int removedCount = cars.RemoveAll(car => car.VinNum == vinToRemove);

            if (removedCount > 0)
            {
                Console.WriteLine("\nАвтомобиль удален.");
            }
            else
            {
                Console.WriteLine("\nАвтомобиль с таким VIN-номером не найден.");
            }


            Console.WriteLine("\n\nСписок автомобилей после удаления и сортировки:");
            foreach (var car in cars)
            {
                Console.WriteLine($"Марка: {car.Brand}, Модель: {car.Model}, Вин-номер мотора: {car.VinNum}, Цвет: {car.Colour}, Год: {car.Year}");
            }

            Console.WriteLine("\n\n\n");



            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee("Мышин", "Александр", "Сергеевич", "слесарь", 1999));
            employees.Add(new Employee("Сушкин", "Денис", "Максимович", "пекарь", 2020));
            employees.Add(new Employee("Плюшкин", "Евгений", "Алексеевич", "программист", 1980));
            employees.Add(new Employee("Лукин", "Владислав", "Денисович", "сантехник", 1973));
            employees.Add(new Employee("Шишкин", "Иван", "Артемович", "радиоведущий", 1996));


            Console.WriteLine("Добавьте нового сотрудника: ");

            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите отчество: ");
            string secondName = Console.ReadLine();

            Console.Write("Введите должность: ");
            string job = Console.ReadLine();

            Console.Write("Введите год устройства на работу: ");
            int hireYear = int.Parse(Console.ReadLine());

            employees.Add(new Employee(surname, name, secondName, job, hireYear));


            Console.WriteLine("\n\n");

            Console.WriteLine("Список без удаления и сортировки");
            foreach (var empl in employees)
            {
                Console.WriteLine($"Имя: {empl.Name}, Фамилия: {empl.Surname}, Отчество: {empl.Secondname}, Должность: {empl.Job}, Год принятия на работу: {empl.HireYear}");
            }

            Console.WriteLine("\n\n");


            employees.Sort((e1, e2) => e1.Surname.CompareTo(e2.Surname));

           

            Console.Write("\nВведите фамилию для удаления: ");
            string surnameRemove = Console.ReadLine();

            Console.Write("\nВведите имя для удаления: ");
            string nameRemove = Console.ReadLine();

            Console.Write("\nВведите отчество для удаления: ");
            string secondNameRemove = Console.ReadLine();


            int removeCount = employees.RemoveAll(empl => empl.Surname == surnameRemove && empl.Name == nameRemove && empl.Secondname == secondNameRemove);

            if (removedCount > 0)
            {
                Console.WriteLine("\nСотрудник удален.");
            }
            else
            {
                Console.WriteLine("\nСотрудник с таким ФИО не найден.");
            }


            Console.WriteLine("Список после удаления и сортировки");
            foreach (var empl in employees)
            {
                Console.WriteLine($"Имя: {empl.Name}, Фамилия: {empl.Surname}, Отчество: {empl.Secondname}, Должность: {empl.Job}, Год принятия на работу: {empl.HireYear}");
            }
        }
    }
} 
