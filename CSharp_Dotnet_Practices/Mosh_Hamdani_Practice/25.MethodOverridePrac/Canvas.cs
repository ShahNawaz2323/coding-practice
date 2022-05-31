using System.Collections.Generic;

namespace MethodOverridePrac
{
    public class Canvas : Shape
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

    }
}
