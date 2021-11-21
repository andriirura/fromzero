using System;

namespace GameOfLife
{
    class GameOfLife
    {
        private int hight;
        private int width;
        private int[,] board;

        public GameOfLife(int hight, int width)
        {
            this.hight = hight;
            this.width = width;
            board = new int[hight, width];
        }

        public void Seed()
        {
            Random rand = new Random();

            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    board[i, j] = rand.Next(2);
                }
                
            }


        }

        public void MoveToNextGeneration()
        {
            int[,] nextboard = new int[hight,width];
            
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int liveCells = GetLiveNeighborsCount(i, j);

                    if (board[i,j] == 1 && (liveCells == 2 || liveCells ==3))
                    {
                        nextboard[i, j] = 1;
                    }
                    else if (board[i, j] == 0 && liveCells == 3)
                    {
                        nextboard[i, j] = 1;
                    }
                    else
                    {
                        nextboard[i, j] = 0;
                    }
                }

            }

            board = nextboard;
        }

        public int GetLiveNeighborsCount(int row, int column)
        {
            int liveCells = 0;

            if(column+1 < width)
            {
                if (board[row, column + 1] == 1)
                    liveCells++;
            }

            if (column - 1 >= 0)
            {
                if (board[row, column - 1] == 1)
                    liveCells++;
            }
            if (row - 1 >= 0)
            {
                if (board[row - 1, column] == 1)
                    liveCells++;
            }
            if (row + 1 < hight)
            {
                if (board[row + 1, column] == 1)
                    liveCells++;
            }
            if (column + 1 < width & row + 1 < hight)
            {
                if (board[row + 1, column + 1] == 1)
                    liveCells++;
            }
            if (column + 1 < width & row - 1 >= 0)
            {
                if (board[row - 1, column + 1] == 1)
                    liveCells++;
            }
            if (column - 1 >= 0 & row - 1 >= 0)
            {
                if (board[row - 1, column - 1] == 1)
                    liveCells++;
            }
            if (column - 1 >= 0 & row + 1 < hight)
            {
                if (board[row + 1, column - 1] == 1)
                    liveCells++;
            }

            return liveCells;
        }

        public void Print()
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (board[i,j] == 0)
                    {
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write((char)219);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
