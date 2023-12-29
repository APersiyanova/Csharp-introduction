// See https://aka.ms/new-console-template for more information
// По координатам точки (x и y), x и y не равны 0, программа выдаёт координаты четверти плоскости, в которой находится эта точка
Console.WriteLine("Введите координату x");
int xh = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y");
int yv = Convert.ToInt32(Console.ReadLine());
if (xh>0 && yv>0){
    Console.WriteLine($"Точка ({xh}, {yv}) находится в 1 четверти координатной плоскости");
}
if (xh<0 && yv>0){
    Console.WriteLine($"Точка ({xh}, {yv}) находится во 2 четверти координатной плоскости");
}
if (xh<0 && yv<0){
    Console.WriteLine($"Точка ({xh}, {yv}) находится в 3 четверти координатной плоскости");
}
if (xh>0 && yv<0){
    Console.WriteLine($"Точка ({xh}, {yv}) находится в 4 четверти координатной плоскости");
}

