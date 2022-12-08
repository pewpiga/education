using practice_8_1;

//Num count in List<int>
int num = 100;

List<int> rndNums = new List<int>();

ListOperations op = new ListOperations(num, rndNums);

op.FillList();
op.PrintToConsole();

op.DeleteNums();
op.PrintToConsole();