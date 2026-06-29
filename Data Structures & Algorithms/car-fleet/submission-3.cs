public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) 
    {

        var cars = new(int pos, int speed)[position.Length];
        
        int answer = 0;
        double leaderTTT = 0;

        for(int i = 0; i < position.Length; i++)           
            cars[i] = (position[i], speed[i]);
        
        var carsByPosition = cars.OrderByDescending(c => c.pos);
        foreach (var c in carsByPosition)
        {
            double timeToTarget = (double)(target - c.pos) / c.speed;
            if (timeToTarget > leaderTTT) 
            {
                leaderTTT = timeToTarget;
                answer++;
            }
        }

        return answer;
    }
}
