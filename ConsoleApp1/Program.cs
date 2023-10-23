MyPet cat = new MyPet(); //создаем объект cat в классе MyPet

string PetName = cat.name; //значение полей в переменные
int PetAge = cat.age;
int PetHunger = cat.hunger;

Console.WriteLine($"Имя питомца: {PetName}, Возраст питомца: {PetAge}, Голод: {PetHunger}");//получаем значения из класса

cat.name = "Фиса";//задаем значения полей объекта класса
cat.age = 14;
cat.hunger = 2;

Console.WriteLine($"Имя питомца: {cat.name}, Возраст питомца: {cat.age}, Голод: {cat.hunger}");//выводит новые значения

class MyPet //сам класс
{
    public string name = "Undefinded"; //публичная переменная, так как приватную можем использовать только в самом классе
    public int age;
    public int hunger;
}