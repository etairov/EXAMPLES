//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
//--------------------------------------------
//Решениие группы:
//Console.WriteLine("Напишите день недели: ");
//string numberStr = Console.ReadLine();
//int number = Convert.ToInt32(numberStr);

//if(number == 1){
//Console.WriteLine("Понедельник");
//}
//else if(number == 2){
//Console.WriteLine("Вторник");
//}
//else if(number == 3){
//Console.WriteLine("Среда");
//}
//else if(number == 4){
//Console.WriteLine("Четверг");
//}
//else if(number == 5){
//Console.WriteLine("Пятница");
//}
//else if(number == 6){
//Console.WriteLine("Суббота");
//}
//else if(number == 7){
//Console.WriteLine("Воскресенье");
//}
//else
//{
//Console.WriteLine("Такого дня нет");
//}
//------------------------------------------

//Мое решение:

string day1 = "Monday";
string day2 = "Tuesday";
string day3 = "Wednesday";
string day4 = "Thursday";
string day5 = "Friday";
string day6 = "Saturday";
string day7 = "Sunday";

int daynumber = new Random().Next(1, 7);

if (daynumber == 1)
Console.WriteLine($"Номер дня {daynumber} = {day1}");
if(daynumber == 2)
Console.WriteLine($"Номер дня {daynumber} = {day2}");
if(daynumber == 3)
Console.WriteLine($"Номер дня {daynumber} = {day3}");
if(daynumber == 4)
Console.WriteLine($"Номер дня {daynumber} = {day4}");
if(daynumber == 5)
Console.WriteLine($"Номер дня {daynumber} = {day5}");
if(daynumber == 6)
Console.WriteLine($"Номер дня {daynumber} = {day6}");
if(daynumber == 7)
Console.WriteLine($"Номер дня {daynumber} = {day7}");