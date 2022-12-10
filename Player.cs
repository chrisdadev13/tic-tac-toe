using System;

public class Player
{
        private bool Human {get; set;}
        public bool Turn {get; set;}
        public char Mark {get; set;}

        public Player(bool human, bool turn, char mark)
        {
                Human = human;
                Turn = turn;
                Mark = mark;
        }

        private bool validatePlay(char[] board, int direction)
        {
                if(board[direction] != ' ')
                {
                        return false;
                }
                return true;
        }
        public void play(char[] board, int direction)
        {
                if(Turn && validatePlay(board, direction))
                {
                       board[direction] = Mark; 
                       Turn = !Turn;
                }
        }
}