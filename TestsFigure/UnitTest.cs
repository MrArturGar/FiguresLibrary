namespace TestsFigure
{
    public class UnitTest
    {
        IFigure figure = null;
        [Fact]
        public void IsStraightTriangle()
        {
            figure = getFigure();

            if (figure is Triangle)
                Assert.True(Triangle.IsStraightTriangle(figure), $"{figure.GetType().ToString()}");
        }

        [Fact]
        public void Square()
        {
            figure = getFigure();

            double area = figure.GetArea();
            Assert.True(area > 0, $"{figure.GetType().ToString()} Area= {area.ToString()}");

        }

        [Fact]
        public void Perimetr()
        {
            figure = getFigure();

            double perimetr = figure.GetPerimetr();
            Assert.True(perimetr > 0, $"{figure.GetType().ToString()} Perimetr= {perimetr}");

        }

        private IFigure getFigure(int maxVariant = 4)
        {
            if (figure != null)
                return figure;

            Random rnd = new Random();

            switch (rnd.Next(0, maxVariant))
            {
                case 0:
                    return new Rectangle(rnd.Next(0, 1000), rnd.Next(0, 1000));
                case 1:
                    return new Square(rnd.Next(0, 1000));
                case 2:
                    return new Triangle(25, 24, 7);
                case 3:
                    return new Circle(rnd.Next(0, 1000));
                case 4:
                    return new Trapezoid(5, 10, 7,7);
                default:
                    return null;
            }
        }
    }
}