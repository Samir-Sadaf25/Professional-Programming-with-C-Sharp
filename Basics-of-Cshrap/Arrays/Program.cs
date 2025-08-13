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
Console.WriteLine(grid[1, 1]);