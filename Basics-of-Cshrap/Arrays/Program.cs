int size = 5;
int[] marks = new int[size];

marks[0] = 40;
marks[1] = 50;
marks[2] = 60;
marks[3] = 70;
marks[4] = 80;
//Console.WriteLine(marks[2]);

int[,] grid = new int[3, 2];
grid[0, 0] = 1;
grid[0, 1] = 2;
grid[1, 0] = 3;
grid[1, 1] = 4;
grid[2, 0] = 5;
grid[2, 1] = 6;
//Console.WriteLine(grid[1, 1]);

// [][][]
// [][][][]
// [][]

int[][] arr = new int[3][];

arr[0] = new int[2];
arr[1] = new int[3];
arr[2] = new int[4];

arr[0][0] = 1;
arr[0][1] = 2;

arr[1][0] = 3;
arr[1][1] = 4;
arr[1][2] = 5;

arr[2][0] = 6;
arr[2][1] = 7;
arr[2][2] = 8;
