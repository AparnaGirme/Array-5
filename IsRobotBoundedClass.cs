public class Solution {
    // TC => O(n)
    // SC => O(1)
    public bool IsRobotBounded(string instructions) {
        if(string.IsNullOrEmpty(instructions)){
            return true;
        }

        int[][] dirs = [[0,1], [-1, 0], [0,-1], [1,0]];

        int x = 0, y = 0, i = 0;
        for(int j = 0; j < instructions.Length; j++){
            char c = instructions[j];

            if(c == 'G'){
                x += dirs[i][0];
                y += dirs[i][1];
            }
            else if(c == 'L'){
                i = (i + 1) % 4;
            }
            else if(c == 'R'){
                i = (i + 3) % 4;
            }
        }
        return ((x == 0 && y == 0) || i != 0);
    }
}