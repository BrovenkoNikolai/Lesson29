using System;

namespace Object_Urok29
{
    class Point
    {
        public int X { get; set; }

        public Point Y { get; set; }

        public override bool Equals(object obj)
        {
            // Данная конструкция ровна нижней от "// Начало" до "// Конец"
            //if (obj == null) return false;

            //var point = obj as Point; // is Возвращает boll значение. as 

            //if (point != null)
            //{
            //    return X == point.X;
            //}
            //else
            //{
            //    return false;
            //}

            // Начало
            if (obj is Point point)
            {
                return point.X == X;
            }
            else
            {
                return false;
            }
            // Конец
        }

        public override int GetHashCode() // Урезанный Equals
        {
            return X;
        }

        public override string ToString()
        {
            return X.ToString();
        }
        // Клон объекта, можно создавать только в одном и том же классе
        #region Не глубокое клонирование, будет создан второй аналогичный тип, но со своей отличающейся переменной Х, но ссылочные переменные У будут равны.
        public Point Clone()    // Клан объекта, можно создавать только в одном и том же классе
        {
            return MemberwiseClone() as Point;
        }
        #endregion
        
        #region Глубокое клонирование, будет создан второй аналогичный тип, но со своей отличающейся переменной Х, и ссылочные отличающейся У будут не равны.
        //public Point Clone()    
        //{
        //    var resut = (Point)MemberwiseClone();
        //    resut.Y = Y.Clone();
        //}
        #endregion
        public new Type GetType()
        {
            return typeof(UInt16);
        }
    }
}
