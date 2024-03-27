namespace N_4
{
    /// <summary>
    /// Класс реализующий матрицу
    /// </summary>
    class Matrix
    {
        private double[,] matrix;
        private int rows;
        private int columns;

        /// <value>
        /// Свойство возвращающее кол-во строк в матрице
        /// </value>
        public int Rows
        {
            get { return this.rows; }
        }

        /// <value>
        /// Свойство возвращающее кол-во столбцов в матрице
        /// </value>
        public int Columns
        {
            get { return this.columns; }
        }

        /// <summary>
        /// Конструктор класса Matrix, создающий из двумерного массива, матрицу
        /// </summary>
        /// <param name="matrix">Двумерный массив</param>
        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
        }

        /// <summary>
        /// Конструктор класса Matrix, создающий пустую матрицу
        /// </summary>
        /// <param name="rows">Кол-во строк</param>
        /// <param name="columns">Кол-во столбцов</param>
        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new double[rows, columns];
        }

        public double this[int row, int col]
        {
            get => matrix[row, col];
            set => matrix[row, col] = value;
        }

        /* 
        Перегрузка оператора +
        Позволяет к значениям первого столбца прибавить значения указанного столбца
        */
        public static Matrix operator + (Matrix curMatrix, int columnIndex)
        {
            Matrix newMatrix = new Matrix(curMatrix.Rows, curMatrix.Columns);

            for (int i = 0; i < curMatrix.Rows; i++)
            {
                for (int j = 0; j < curMatrix.Columns; j++)
                {
                    if (j == columnIndex)
                    {
                        newMatrix[i, 0] = curMatrix[i, 0] + curMatrix[i, j];
                    }
                    
                    newMatrix[i, j] = curMatrix[i, j];
                }
            }

            return newMatrix;
        }

        /// <summary>
        /// Метод выводящий матрицу в консоль
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    Console.Write($"{this.matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }

    /// <summary>
    /// Класс содержащий основную программу
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод выполняющий программу
        /// </summary>
        /// <param name="args">Аргументы консоли</param>
        static void Main(string[] args)
        {
            Matrix m = new Matrix(3, 3);

            Random rnd = new Random();
            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Columns; j++)
                {
                    m[i, j] = rnd.Next(5);
                }
            }
            m.Print();

            Console.WriteLine();
            Matrix newM = m + 2;

            newM.Print();
        }
    }
}