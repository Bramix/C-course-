namespace Lab1.Interface
{
    public interface IDemo
    {
        void Show(); 
        double Length();
        int X { get; } 
        int Y { get; }
        int this[int i] { get; set; } 
    }
}