using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sach
{
    public class Move : Pawn
    {
        private int targetX;
        private int targetY;
        private int destinationX;
        private int destinationY;

        public Move()
        {
            targetX = 0;
            targetY = 0;
            destinationX = 0;
            destinationY = 0;
            Exit = false;
        }



        public bool Exit { get; set; }

        public void MakeMove()
        {
            GetInput();

            if (!Exit)
                RearangePawns();
        }

        private void GetInput()
        {
            //get input and validate it
            //the program runs until enter invalid input.

            Console.WriteLine("Suradnica X ");
            Exit = ValidateInput(int.TryParse(Console.ReadLine(), out targetX));

            if (!Exit) //if we passed the previous validation, move to the next coordinates
            {
                Console.WriteLine("Suradnica Y");
                Exit = ValidateInput(int.TryParse(Console.ReadLine(), out targetY));
            }

            if (!Exit) //if we passed the previous validation, move to the next coordinates
            {
                Console.WriteLine("Cielova suradnica X");
                Exit = ValidateInput(int.TryParse(Console.ReadLine(), out destinationX));
            }

            if (!Exit) //if we passed the previous validation, move to the next coordinates
            {
                Console.WriteLine("Cielova suradnica Y");
                Exit = ValidateInput(int.TryParse(Console.ReadLine(), out destinationY));
            }
        }

        private bool ValidateInput(bool parsed)
        {
            bool error = false;

            if (!parsed)
                error = true;
            else if (targetX < 0 || targetX < 0 || destinationX < 0 || destinationY < 0)
                error = true;
            else if (targetX > ChessBoard.DIMENSION - 1 || targetY > ChessBoard.DIMENSION - 1 || destinationX > ChessBoard.DIMENSION - 1 || destinationY > ChessBoard.DIMENSION - 1)
                error = true;

            if (error)
                Console.WriteLine("Chyba vstupu, ukončujem program!");

            return error;
        }

        private void RearangePawns()
        {
            pawns[destinationX, destinationY] = pawns[targetX, targetY];
            pawns[targetX, targetY] = SPACE;
        }

    }
}
