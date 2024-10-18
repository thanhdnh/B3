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
    public void Enqueue(object ele)
    {
        Node2 n = new Node2();
        n.data = ele;
        if (rear == null)
        {
            rear = n; front = n;
        }
        else
        {
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
        MyStack st = new MyStack();
        st.Push(25);
        st.Push(46);
        st.Push(22);
        st.Push(33);
        st.Push(88);
        st.Push(10);
        st.RemoveOdd();
        ;
    }
}