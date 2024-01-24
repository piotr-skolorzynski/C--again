namespace FirstProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           Shape[] shapes = { new Circle(), new Rectangle(), new Triangle() };

           foreach (Shape shape in shapes)
           {
            shape.Draw();
           }
        }

        //efektem pętli będzie Drawing circle, Drawing rectangle, Drawing Triangle mimo tego że shape
        //jest zadeklarowany jako typ Shape a nie poszczególne typy pochodne
        //takie zachowanie nazywa się polimorficznym
    }
}
