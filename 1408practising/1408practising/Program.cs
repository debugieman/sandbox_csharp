//declare jagged array (3 arrays inside this array)
int[][] jaggedarray = new int[3][];
//def rows
jaggedarray[0] = new int[5];
jaggedarray[1] = new int[3];
jaggedarray[2] = new int[2];
//adding value 
jaggedarray[0] = new int[]  { 2, 3, 4, 5, 6 };
jaggedarray[0] = new int[] { 5 };
jaggedarray[0] = new int[] { 6, 11 };


// 2nd option of adding
int[][] jaggedArray2 = new int[][]

{
new int[] {2,4,6,7,8 },
new int[] {2,4,8}


};

Console.WriteLine($"The value is {jaggedArray2[0][2]}");

for (int i = 0; i < jaggedArray2.Length; i++)
{
    Console.WriteLine($"Element {i}");
    for ( int j = 0; j < jaggedArray2[i].Length; j++ )
    Console.WriteLine(jaggedArray2[i][j]);

}



Console.ReadKey();