using System;

public class Program
{
   static void Main(string[] args)
   {
      var l = new LinkedList();
      AddCoordinates(l,3,5);
      AddCoordinates(l,0,5);
      AddCoordinates(l,0,0);
      AddCoordinates(l,5,0);
   }
   static void AddCoordinates
   (LinkedList l, int x, int y)
   {
      Console.WriteLine("\nList before adding new points");
      
      l.PrintList();
      
      Node n = l.head;
      Node prev = null;

      Node new_n = new Node(x,y);

      // first find the closest 
      // x coordinate position
      while(n != null 
      && x > n.x)
      {
         prev = n;
         n = n.next;
      }
      // Next check for the y coordinate
      while(n != null 
            && y > n.y 
            && x == n.x)
     {
            prev = n;
            n = n.next;
     }
     
      // insert if position of coordinates 
      // is at the beginning
      if(prev == null)
      {
         new_n.next = l.head;
         l.head = new_n;
      }
      // insert last
      else if (n == null)
      {
         prev.next = new_n;
      }
      else
      {
         prev.next = new_n;
         new_n.next = n;
      }
      
      Console.WriteLine("\nList after adding new points");
      l.PrintList();
      Console.WriteLine("\n\n");
   }
}
public class Node
{
    public int x;
    public int y;
    public Node next;
    public Node(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
   
 class LinkedList
 {
    public Node head;
    
    public void PrintList()
    {
        Node n = head;
        while(n!= null)
        {
           Console.Write($"({n.x}, {n.y})->");
           n = n.next;
        }
    }
 }
