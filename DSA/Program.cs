// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Xml;
using DSA.ArrayDSA;
using DSA.DictionaryDSA;
using DSA.LinkedListDSA;
using DSA.QueueDSA;
using DSA.StackClassDSA;

// var charFinder = new FirstNonRepeatedCharacter();
//
// Console.WriteLine(charFinder.FindNonRepeatedChar("hello help"));

//Reverse first K elements of Q
var Q = new QLinkedList();
Q.Enqueue(1);
Q.Enqueue(2);
Q.Enqueue(3);
Q.Enqueue(4);
Q.Enqueue(5);

Console.WriteLine(Q.Dequeue());
Console.WriteLine(Q.Dequeue());
Console.WriteLine(Q.Dequeue());
Console.WriteLine(Q.Dequeue());


// var ReversedQ = ReverseUntilKthElement.ReverseUntilK(3, Q);
// Console.WriteLine("This is over");