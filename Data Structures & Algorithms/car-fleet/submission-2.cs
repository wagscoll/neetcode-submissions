public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        Dictionary<int,int> cars = new Dictionary<int,int>();

        int answer = 0;
        double leaderTTT = 0;

        for(int i = 0; i < position.Length; i++)           
            cars.Add(position[i], speed[i]);
        
        var carsByPosition = cars.OrderByDescending(kvp => kvp.Key);
        foreach (var kvp in carsByPosition)
        {
            double timeToTarget = (double)(target - kvp.Key) / kvp.Value;
            if (timeToTarget > leaderTTT) 
            {
                leaderTTT = timeToTarget;
                answer++;
            }
        }

        return answer;
    }
}
