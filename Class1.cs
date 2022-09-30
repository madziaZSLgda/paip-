using System;
using System.Collections;

public class Class1
{

    public static void Main()
    {
        // tworzy nowy stos, wpycha wartości
        Stack myStack = new Stack();
        myStack.Push("lacznosci");
        myStack.Push("szkol");
        myStack.Push("zespol");
        myStack.Push("bozy");

        // pokazuje wartości stosu, '\t' = tabulator
        Console.Write("Stack values:");
        PrintValues(myStack, '\t');

        //wspaniała metoda stack.Pop usuwa 1 wartość stosu, ładnie pokazuje w konsoli co usunieto
        Console.WriteLine("(Pop)\t\t{0}", myStack.Pop());

        // printuje cały obecny stos po usunieciu objektu
        Console.Write("Stack values:");
        PrintValues(myStack, '\t');

        //wspaniała metoda stack.Peek zwraca górny obiekt stosu bez usuwania
        Console.WriteLine("(Peek)\t\t{0}", myStack.Peek());

        //znowu wkładamy sobie objekt na góre stosu
        myStack.Push("w gdansku");

        // printuje cały obecny stos po wlozeniu objektu
        Console.Write("Stack values:");
        PrintValues(myStack, '\t');
    }
}

}
