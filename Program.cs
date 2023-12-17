using System.Reflection.Metadata.Ecma335;

string[] array = {"Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};

int count =0;

for(int rows = 0; rows < array.Length; rows++) {

    if(array[rows].Length<4) count++;
}


Function(count, array);

static void Function(int count, string[] array) {    

string[] newarray = new string[count];

int row=0;
for(int rows = 0; rows < array.Length; rows++) {

    if(array[rows].Length<4) {
        newarray[row]=array[rows];
        row++;
    };
}
Console.Write("[");
for(int rows = 0; rows < count-1; rows++) {
    Console.Write($"'{newarray[rows]}';");
   }
   Console.Write($"'{newarray[count-1]}']");
}