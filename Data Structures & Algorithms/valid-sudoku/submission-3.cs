public class Solution {

    List<char> box1 = new List<char>();
    List<char> box2 = new List<char>();
    List<char> box3 = new List<char>();
    List<char> box4 = new List<char>();
    List<char> box5 = new List<char>();
    List<char> box6 = new List<char>();
    List<char> box7 = new List<char>();
    List<char> box8 = new List<char>();
    List<char> box9 = new List<char>();

    bool ContainsDuplicate(List<char> list)
    {
        List<char> newList = new List<char>();

        foreach(var c in list)
        {
            if(c == '.')
                continue;
            else
                newList.Add(c);
        }

        bool hasDuplicates = (newList.Count != newList.Distinct().Count());
        Console.WriteLine($"hasDuplicates: {hasDuplicates}");



        return hasDuplicates;
    }

    void orderBoxes(int row, int col, char c)
    {

        if(row <=2 && col <=2)
            box1.Add(c);
        else if(row <=2 && col >=3 && col <=5 )
            box2.Add(c);
        else if(row <=2 && col >=6)
            box3.Add(c);

        else if(row >=3 && row <=5 && col <=2 )
            box4.Add(c);
        else if(row >= 3 && row <= 5 && col >=3 && col <=5)
            box5.Add(c);
        else if(row >=3 && row <=5 && col >=6)
            box6.Add(c);

        else if(row >5 && col <=2 )
            box7.Add(c);
        else if(row >5 && col >=3 && col <=5)
            box8.Add(c);
        else if(row >5 && col > 5)
            box9.Add(c);
        

    }

    public bool IsValidSudoku(char[][] board) 
    {

        /* #1
            Each row must contain the digits 1-9 without duplicates.
        
           #2
            Each column must contain the digits 1-9 without duplicates.
        */

        int rowLength = board[0].Length;

        List<char> tempCol = new List<char>();
        List<char> tempRow = new List<char>();

        List<List<char>> squares = new List<List<char>>();

        Console.WriteLine("\t-- Columns --");
        for(int r = 0; r < rowLength ; r++)
        {
            tempCol.Clear();
            for(int c = 0; c < rowLength ; c++)
            {
                tempCol.Add(board[r][c]);
                orderBoxes(r, c, board[r][c]);
                //Console.WriteLine($"\t Matrix[{r}][{c}] -- Adding: {board[r][c]}");
            }
            
            if(ContainsDuplicate(tempCol))
                return false;
        }

        Console.WriteLine("\t-- Rows --");
        for(int c = 0; c < rowLength ; c++)
        {
            tempRow.Clear();
            for(int r = 0; r < rowLength ; r++)
            {
                tempRow.Add(board[r][c]);

                //Console.WriteLine($"\t Matrix[{r}][{c}] -- Adding: {board[r][c]}");
            }

            if(ContainsDuplicate(tempRow))
                return false;
        }

  


        /* #3
            Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without duplicates.
        */

        squares.Add(box1);
        squares.Add(box2);
        squares.Add(box3);
        squares.Add(box4);
        squares.Add(box5);
        squares.Add(box6);
        squares.Add(box7);
        squares.Add(box8);
        squares.Add(box9);

        foreach(var b in squares)
        {
            if(ContainsDuplicate(b))
                return false;
        }



        return true;
    }



}
