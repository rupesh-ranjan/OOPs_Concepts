namespace OOPs_Concepts
{
    public class Test
    {
        protected int x;
    }

    public class Test2 : Test 
    {
        public Test2(int x)
        {
            this.x = x;
        }
        public int CW()
        {
            return x;
        }
    }
    
}