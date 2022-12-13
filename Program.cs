using System.Text.Json;
using System.IO;

/*
// считываем с консоли
string ReadData(string line)
{
    Console.Write(line);
    string name = Console.ReadLine()?? "";
    return name;
}


int ReadDataNumber(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}



string jobTitle = ReadData("Введите наименование вакансии: ");
string skils = ReadData("Введите Ключевые навыки: ");
string discription = ReadData("Введите Описание: ");
int salary = ReadDataNumber("Введите Зарплату: ");
string typeWork = ReadData("Введите Вид работы (удаленный, смешанный, в офисе): ");

//Console.WriteLine(jobTitle);


//  пишем в файл
try
{
    StreamWriter sw = new StreamWriter("data.txt");
    //Write a line of text
    sw.WriteLine(jobTitle);
    //Write a second line of text
    sw.WriteLine(salary);
    //Close the file
    sw.Close();
}
catch(Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Запись прошла успешно.");
}




// читаем из файла
String line;
try
{
    StreamReader sr = new StreamReader("data.txt");
    //Read the first line of text
    line = sr.ReadLine() ?? "";
    //Continue to read until you reach end of file
    while (line != null)
    {
        //write the line to console window
        Console.WriteLine(line);
        //Read the next line
        line = sr.ReadLine() ?? "";
    }
    //close the file
    sr.Close();
}
catch(Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("прочитано успешно.");
}
*/



 
// сохранение данных
using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
{
    Person tom = new Person("Tom", 37);
    await JsonSerializer.SerializeAsync<Person>(fs, tom);
    Console.WriteLine("Data has been saved to file");
}
 
// чтение данных
using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
{
    Person? person = await JsonSerializer.DeserializeAsync<Person>(fs);
    Console.WriteLine($"Name: {person?.Name}  Age: {person?.Age}");
}
 
class Person
{
    public string Name { get;}
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
