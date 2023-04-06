using OrderedList;
OrList<int> list = new OrList<int>();
OrList<int> list2 = new OrList<int>();
list.Add(14);
list.Add(62);
list.Add(3);
list.Add(94);
list.Add(57);
list.Add(6);
list.Add(70);
list.Add(68);
list.Add(91);
list.Add(10);
Console.WriteLine(list);


list.Delete(68);
list.Delete(10);
list.Delete(91);
list.Delete(3);
Console.WriteLine(list);


list2.Add(1);
list2.Add(2);
list2.Add(3);
list2.Add(4);
list2.Add(82);
list2.Add(5);
list2.Add(1000);

list.Merge(list2);
Console.WriteLine(list);
