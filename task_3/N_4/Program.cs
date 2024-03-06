namespace N_4
{
    class Matrix
    {
        private double[,] matrix;
        private int rows;
        private int columns;

        public int Rows
        {
            get { return this.rows; }
        }

        public int Columns
        {
            get { return this.columns; }
        }

        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
        }

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

    class Program
    {
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