using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGeometria
{
    public class Rectangulo
    {
        #region Atributos
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float perimetro;
        private float area;
        #endregion

        #region Getter Area
        public float Area()
        {
            float baseRectangulo;
            float alturaRectangulo;

            baseRectangulo = vertice1.GetX() - vertice3.GetX();
            alturaRectangulo = vertice1.GetY() - vertice3.GetY();

            Math.Abs(baseRectangulo);
            Math.Abs(alturaRectangulo);

            this.area = (baseRectangulo * alturaRectangulo);

            return this.area;
        }
        #endregion

        #region Getter Perimetro
        public float Perimetro()
        {
            float baseRectangulo;
            float alturaRectangulo;

            baseRectangulo = vertice1.GetX() - vertice3.GetX();
            alturaRectangulo = vertice1.GetY() - vertice3.GetY();

            Math.Abs(baseRectangulo);
            Math.Abs(alturaRectangulo);

            this.perimetro = ((baseRectangulo + alturaRectangulo) / 2);

            return this.perimetro;
        }
        #endregion

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
        }
    }
}
