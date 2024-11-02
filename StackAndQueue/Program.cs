﻿using StackAndQueue;
Console.WriteLine("---------- Stack ------------------");
var stackLinkedList = new StackLinkedList();
stackLinkedList.Push(1);
stackLinkedList.Push(2);
stackLinkedList.Push(3);
stackLinkedList.PrintStack();
stackLinkedList.Pop();
stackLinkedList.PrintStack();

Console.WriteLine("---------- Queue ------------------");
var queueLinkedList = new QueueLinkedList();
queueLinkedList.Enqueue(1);
queueLinkedList.Enqueue(2);
queueLinkedList.Enqueue(3);
queueLinkedList.PrintQueue();
queueLinkedList.Dequeue();
queueLinkedList.PrintQueue();