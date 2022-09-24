// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Xml;
using DSA.ArrayDSA;
using DSA.LinkedListDSA;
using DSA.StackClassDSA;

// var stack = new StackClass(5);
// stack.Push(1);
// stack.Push(2);
// stack.Push(3);
// stack.Push(3);
// stack.Push(3);
// stack.Push(3);
// stack.Push(3);
// stack.Push(25);
//
// Console.WriteLine(stack.Peek());
// Console.WriteLine(stack.IsEmpty());

var stack = new TwoStacksOneArray(5);
stack.Push1(5);
stack.Push1(3);
stack.Push2(12);
stack.Push1(200);

// stack.Pop2();
Console.WriteLine(stack.Peek1());
Console.WriteLine(stack.Peek2());
// Console.WriteLine(stack.MatchBrackets("{j}()"));
    


































////////////////LinkedList
// var Ll = new LinkedListClass();
// // Ll.AddLast(5);
// Ll.AddLast(1);
// Ll.AddLast(2);
// Ll.AddLast(3);
// Ll.AddLast(4);
// Ll.AddLast(5);
// Ll.AddLast(6);
// Ll.PrintMiddle();

// Console.WriteLine(Ll.HasLoop());


////////////////Array
// var newArr = new ArrayClass<int>(2); 
// newArr.Insert(2);
// newArr.Insert(3);
// newArr.Insert(4);
// // newArr.PrintItems();
// Console.WriteLine("-------");
// newArr.Delete(2);
// newArr.Delete(3);
// // newArr.PrintItems();
// Console.WriteLine("-------");
// newArr.InsertAt(25, 10);
// // newArr.PrintItems();
//
// var intersectionArr = ArrayClass<int>.Intersect(new int[] {1,2,3}, new int[] {1,2,2 ,6});
// intersectionArr.PrintItems();

