using System;
using System.Data.SqlClient;
using System.Diagnostics;


namespace Object_Pool_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Cars;Integrated Security=True;Pooling=False"))
            {
                // Создан пул подключений к БД Cars
                connection.Open();
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);


            watch = Stopwatch.StartNew();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Players;Integrated Security=True;Pooling=False"))
            {
                connection.Open();
                //  Создан пул подключений к БД Players
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);


            watch = Stopwatch.StartNew();
            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Cars;Integrated Security=True;Pooling=False"))
            {
                connection.Open();
                // Извлечено подключение из пула подключений к БД Cars
            }
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);

            Console.ReadLine();
        }
    }
}