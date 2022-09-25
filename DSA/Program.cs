// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Xml;
using DSA.ArrayDSA;
using DSA.LinkedListDSA;
using DSA.QueueDSA;
using DSA.StackClassDSA;


// var Q = new Queue<int>();
// Q.Enqueue(5);
// Q.Enqueue(10);
// Q.Enqueue(15);
//
// var ReversedQ = QueueClass.ReverseQ(Q);
// Console.WriteLine(ReversedQ);

var Q = new ArrQCircularArray(5);
Q.EnQueue(5);
Q.EnQueue(10);
Q.EnQueue(20);
Q.EnQueue(25);
Q.EnQueue(30);


Console.WriteLine(Q.DeQueue());
Console.WriteLine(Q.DeQueue());
Console.WriteLine(Q.DeQueue());
Console.WriteLine(Q.DeQueue());
Console.WriteLine(Q.DeQueue());
Console.WriteLine(Q.DeQueue());


