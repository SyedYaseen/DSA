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

var Q = new PriorityQueueClass();
Q.EnQueue(5);
Q.EnQueue(10);
Q.EnQueue(30);

Q.EnQueue(25);
Q.EnQueue(20);



Console.WriteLine(Q.DeQueue());
Console.WriteLine(Q.DeQueue());
Console.WriteLine(Q.DeQueue());
Console.WriteLine(Q.DeQueue());
Console.WriteLine(Q.DeQueue());
Q.EnQueue(35);
Q.EnQueue(40);
Console.WriteLine(Q.DeQueue());
Console.WriteLine(Q.DeQueue());


