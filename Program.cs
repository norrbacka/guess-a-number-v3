﻿Console.WriteLine("Vilken vill du köra?");
Console.WriteLine("1. go to-loop");
Console.WriteLine("2. recursion-loop");
Console.WriteLine("3. while-loop");
Console.WriteLine("4. do while-loop");
Console.WriteLine("5. for-loop");
int Program = Convert.ToInt32(Console.ReadLine());
if(Program == 1) GoTo.Program();
if(Program == 2) Recursion.Program();
if(Program == 3) WhileLoop.Program();
if(Program == 4) DoWhile.Program();
if(Program == 5) ForLoop.Program();