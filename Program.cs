using System; 
class GFG {
    static void Main()
    {
        Stack<String>.push("Avv");
        Stack<String>.push("Bcc");
        Stack<String>.push("Cxx");
        Stack<String>.push("Dzz");
        Stack<String>.push("Fqq");
        Stack<String>.pop();
        //Stack<String>.print();
        //System.Console.WriteLine(Stack<String>.peak());
        Stack<String>.clear();
        Stack<String>.print();

    }
    class CustomException : Exception
{
    public CustomException(string message)
    {
    }
}
private static void TestThrow()
{
    throw new CustomException("No elements to pop");
}
 public static class Stack<T> {
    private static T []arr=new T[10];
    public static int counter=0;
    
  public static void push(T item){
    arr[counter]=item;
    counter++;
    if(counter>10){
    counter=counter%10;    
    }
  }
  public static T pop(){
    if(counter==0)TestThrow();
    counter=counter-1;
    return arr[counter+1];
  }
  public static void print(){
    for(int i=0;i<counter;i++){
        if(arr[i]==null)continue;
        System.Console.WriteLine(arr[i]);
    }
  }
  public static T peak(){
    return arr[counter-1];
  }
  public static void clear(){
    arr=new T[10];
    counter=0;
  }
}
}