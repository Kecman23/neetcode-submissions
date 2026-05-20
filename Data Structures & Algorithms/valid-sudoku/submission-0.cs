public class Solution {
    public bool IsValidSudoku(char[][] board) {
        

        for(int i=0;i<board.Length;i++){
            HashSet<char> set = new HashSet<char>();
            for(int j=0;j<board.Length;j++){
            if (board[i][j] == '.') continue;

            if(set.Contains(board[i][j])){
                return false;
            }
            else{
                set.Add(board[i][j]);
            }
            }
        }
        
        for(int i=0;i<board.Length;i++){
            HashSet<char> set = new HashSet<char>();
            for(int j=0;j<board.Length;j++){
            if (board[j][i] == '.') continue;

            if(set.Contains(board[j][i])){
                return false;
            }
            else{
                set.Add(board[j][i]);
            }
            }
        }
        
        for(int i=0;i<9;i+=3){
        for(int j=0;j<9;j+=3){
            
            HashSet<char> set = new HashSet<char>();

        for(int r=0;r<3;r++){
         
        for(int c=0;c<3;c++){

            char val = board[r+i][c+j];
            if(val == '.') continue;

            if(set.Contains(val)){
                return false;
            }
            else{
                set.Add(val);
            }


        }

        }

        }

        }

        return true;

    }
}
