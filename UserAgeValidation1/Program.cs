// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutaja vanust
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakase
//"you are too young to use Instagram"
//muul juhul kuvatakse
//"Welcome to Instagram"

Console.WriteLine("Enter your age: ");

int userAge= Int32.Parse (Console.ReadLine()); //"13" - heap, 13- salvestatakse stacki ja on kiirem, säästab ressurssi
//console tagastab vaid stringi siis tuleb parsida või konsolideerida
//int tüüpi muutuja salvestatakse ka stacki
//string muutuja puhul ei laseks seda teha, sõnu ja arve ei saa võrrelda. Otsime vastuseks numbrit seega peab olema arv
if (userAge >= 13) // kui kasutaja vanus on suurem või võrdne siis toimib sedasi
{
    Console.WriteLine("Welcome to Instagram!");
}

else //viimane võimalik valik arvuti jaoks kui on üle 13 vastus
{
    Console.WriteLine("You are too young to use Instagram.");
}