Console.Clear();
Console.WriteLine("Введите количество кустов: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
int max1 = arr[0];
int max2 = 0, max3 = 0;

for(int i = 0; i<=N-1; i++){
    Console.WriteLine($"Введите количесво ягод на кусте {i+1}:");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i<=N-1; i++){
    Console.Write(arr[i] + " ");
    if(arr[i]>max1){
    max3 = max2;
    max2 = max1;
    max1 = arr[i];
} 
else if(arr[i]>max2){
    max3 = max2;
    max2 = arr[i];
 }
 else if(arr[i]>max3){
    max3 = arr[i];
 }
}
Console.WriteLine("");
Console.WriteLine($"Максимальное число ягод: {max1+max2+max3}");

