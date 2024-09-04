//using System;
//using LinkList;

//class Program
//{
//	static void Main(string[] args)
//	{
//		int totalTests = 0;
//		int passedTests = 0;

//		// Test 1: Creating an empty linked list
//		totalTests++;
//		try
//		{
//			LinkedList list1 = new LinkedList();
//			if (list1.Length() == 0)
//			{
//				Console.WriteLine("Test 1 Passed: Creating an empty linked list.");
//				passedTests++;
//			}
//			else
//			{
//				Console.WriteLine("Test 1 Failed: Length is not zero for an empty list.");
//			}
//		}
//		catch
//		{
//			Console.WriteLine("Test 1 Failed: Unexpected exception.");
//		}

//		// Test 2: Adding elements to the end of the list
//		totalTests++;
//		try
//		{
//			LinkedList list2 = new LinkedList();
//			list2.Add(1);
//			list2.Add(2);
//			list2.Add(3);

//			if (list2.Length() == 3 && list2.Display() == "1 -> 2 -> 3")
//			{
//				Console.WriteLine("Test 2 Passed: Adding elements to the end of the list.");
//				passedTests++;
//			}
//			else
//			{
//				Console.WriteLine("Test 2 Failed: Elements not added correctly.");
//			}
//		}
//		catch
//		{
//			Console.WriteLine("Test 2 Failed: Unexpected exception.");
//		}

//		// Test 3: Removing a value (RemoveValue) from the list
//		totalTests++;
//		try
//		{
//			LinkedList list3 = new LinkedList();
//			list3.Add(1);
//			list3.Add(2);
//			list3.Add(3);
//			list3.RemoveValue(2);

//			if (list3.Length() == 2 && list3.Display() == "1 -> 3")
//			{
//				Console.WriteLine("Test 3 Passed: Removing a value from the list.");
//				passedTests++;
//			}
//			else
//			{
//				Console.WriteLine("Test 3 Failed: Value not removed correctly.");
//			}
//		}
//		catch
//		{
//			Console.WriteLine("Test 3 Failed: Unexpected exception.");
//		}

//		// Test 4: Removing all instances of a value (RemoveAllValues)
//		totalTests++;
//		try
//		{
//			LinkedList list4 = new LinkedList();
//			list4.Add(5);
//			list4.Add(5);
//			list4.Add(5);
//			list4.RemoveAllValues(5);

//			if (list4.Length() == 0 && list4.Display() == "")
//			{
//				Console.WriteLine("Test 4 Passed: Removing all instances of a value from the list.");
//				passedTests++;
//			}
//			else
//			{
//				Console.WriteLine("Test 4 Failed: Not all instances of value removed.");
//			}
//		}
//		catch
//		{
//			Console.WriteLine("Test 4 Failed: Unexpected exception.");
//		}

//		// Test 5: Removing by index (RemoveIndex)
//		totalTests++;
//		try
//		{
//			LinkedList list5 = new LinkedList();
//			list5.Add(10);
//			list5.Add(20);
//			list5.Add(30);
//			list5.RemoveIndex(1); // Should remove the second element

//			if (list5.Length() == 2 && list5.Display() == "10 -> 30")
//			{
//				Console.WriteLine("Test 5 Passed: Removing by index.");
//				passedTests++;
//			}
//			else
//			{
//				Console.WriteLine("Test 5 Failed: Value not removed at the correct index.");
//			}
//		}
//		catch
//		{
//			Console.WriteLine("Test 5 Failed: Unexpected exception.");
//		}
//	}
using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // יצירת מחלקת Stack
            Stack stack = new Stack();

            // בדיקת Push ו-Peek
            Console.WriteLine("Testing Push and Peek:");
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // צפוי להחזיר 30, כי זהו הנתון שנמצא בראש הערימה
            Console.WriteLine("Peek: " + stack.Peek()); // Output: 30

            // בדיקת Count
            Console.WriteLine("Count: " + stack.Count()); // Output: 3

            // בדיקת Pop
            Console.WriteLine("Testing Pop:");
            Console.WriteLine("Pop: " + stack.Pop()); // Output: 30
            Console.WriteLine("Peek after Pop: " + stack.Peek()); // Output: 20
            Console.WriteLine("Count after Pop: " + stack.Count()); // Output: 2

            // בדיקת Pop על ערימה ריקה
            stack.Pop();
            stack.Pop(); // עכשיו הערימה אמורה להיות ריקה
            Console.WriteLine("Peek on empty stack: " + stack.Peek()); // Output: -1
            Console.WriteLine("Count on empty stack: " + stack.Count()); // Output: 0

            Queue q = new Queue();

            // שמירה על המתודה הריקה לפני סיום התוכנית
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}




