/*
    Задача. Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.
*/

int [,] CreateTriangle (int size){
    int [,] triangle = new int [size, size];

    for(int i = 0; i < size; i++){
        triangle[i,0] = 1;
        triangle[i,i] = 1;
    }

    for(int i = 2; i < size; i++){
        for(int j = 1; j < i; j++){
            triangle [i,j] = triangle [i-1, j-1] + triangle [i-1,j];  
        }
    }

    PrintMatrix (triangle);

    return triangle;
}

void PrintMatrix(int[,] array){
    string[,] arrayToString = new string[array.GetLength(0), array.GetLength(1)];

    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = array.GetLength(1) - 1; j >= 0; j--){

            string temp = array[i, j].ToString();

            if(temp == "0"){
                temp = String.Empty;
                arrayToString[i, j] = temp;
                Console.Write($"{arrayToString[i, j]} ");
            }  
            else{
                arrayToString[i, j] = temp;
                Console.Write($"{arrayToString[i, j]} ");
            }     
        }
        Console.WriteLine();
    }
}

Console.Write("Введите не четное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0){
    Console.WriteLine("Запрошенное число четное.");
}
else CreateTriangle (number);