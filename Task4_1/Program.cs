// See https://aka.ms/new-console-template for more information
// Бесконечно запрашивать ввод символа с консоли до тех пор, пока
// не введено число с четной суммой цифр или символ 'q'
int i = 0;
while (true){
    Console.WriteLine("Введите любое число или символ: ");
    string anyString = Console.ReadLine(); 
   
    if (anyString == "q"){
        break;
    }
    int anyNumber = 0;
    int digitsSum = 0;
    if (int.TryParse(anyString, out anyNumber)){
        while (anyNumber > 0){
            digitsSum += anyNumber%10;
            anyNumber /= 10;
        }
    }
    if (digitsSum %2 == 0){
        break;
    }
    i++;
}
