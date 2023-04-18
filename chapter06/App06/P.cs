public class P 
{
    public void PublicMethod() {
    }
    protected void ProtectedMethod() {
    }
    internal void InternalMethod() {
    }
}

class C : P 
{
    public void TestMethods() 
    {
        PublicMethod();
        ProtectedMethod();
        InternalMethod();
    }
}