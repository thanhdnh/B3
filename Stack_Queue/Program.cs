using System.Collections;
using System.Data.SqlTypes;
public class Node
{
    public Node next;
    public object data;
}
public class MyStack
{
    Node top;
    public bool IsEmpty()
    {
        return top == null;
    }
    public void Push(object ele)
    {
        Node n = new Node();
        n.data = ele;
        n.next = top;
        top = n;
    }
    public Node Pop()
    {
        if (top == null)
            return null;
        Node d = top;
        top = top.next;
        return d;
    }
    public void RemoveOdd(){
        MyStack temp = new MyStack();
        while(!this.IsEmpty()){
            int x = (int)this.Pop().data;
            if(x%2 == 0)
                temp.Push(x);
        }
        while(!temp.IsEmpty())
            this.Push(temp.Pop().data);
    }
    public MyStack Sort(){
        MyStack temp = new MyStack();
        List<int> list = new List<int>();
        while(!this.IsEmpty())
            list.Add((int)this.Pop().data);
        foreach(int x in list)
            this.Push(x);
        list.Sort();
        foreach(int x in list)
            temp.Push(x);
        return temp;
    }
}
public class Node2
{
    public Node2 prev, next;
    public object data;
}
public class MyQueue
{
    Node2 rear, front; 
    public bool IsEmpty()
    {
        return rear == null || front == null;
    }
    public void Enqueue2(object ele){
        List<int> list = new List<int>();
        while(!this.IsEmpty())
            list.Add((int)this.Dequeue().data);
        list.Add((int)ele);
        list.Sort();
        foreach(int value in list)
            this.Enqueue(value);
    }
    public void Enqueue(object ele){
        Node2 n = new Node2();
        n.data = ele;
        if (rear == null){
            rear = n; front = n;
        }else{
            rear.prev = n;
            n.next = rear; rear = n;
        }
    }
    public Node2 Dequeue()
    {
        if (front == null) return null;
        Node2 d = front;
        front = front.prev;
        if (front == null)
            rear = null;
        else
            front.next = null;
        return d;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        MyQueue q = new MyQueue();
        q.Enqueue2(25);
        q.Enqueue2(46);
        q.Enqueue2(22);
        q.Enqueue2(33);
        q.Enqueue2(88);
        q.Enqueue2(10);
        ;

        Queue qc = new Queue();
        Stack sc = new Stack();

        Queue<int> qg = new Queue<int>();
        Stack<int> sq = new Stack<int>();

        qc.Enqueue(1);
        int x = (int)qc.Dequeue();
        sc.Push(1);
        int y = (int)sc.Pop();

        qg.Enqueue(1); int xx = qg.Dequeue();
        sq.Push(1); int yy = sq.Pop();
        int oo = sq.Peek();
    }
}