namespace OOPs_Concepts
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void copy()
        {
            Console.WriteLine("Object Copied to clipboard");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object duplicated");
        }
    }
}
