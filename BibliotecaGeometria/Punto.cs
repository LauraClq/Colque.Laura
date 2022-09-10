using System;

namespace BibliotecaGeometria
{
    public class Punto
    {
        #region Atributos
        private int x;
        private int y;
        #endregion

        #region Getter X
        public int GetX()
        {
            return this.x;
        }
        #endregion

        #region Getter Y
        public int GetY()
        {
            return this.y;
        }
        #endregion

        #region Constructor
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion
    }
}
