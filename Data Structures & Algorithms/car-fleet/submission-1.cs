public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        Dictionary<int,int> cars = new Dictionary<int,int>();

        int answer = position.Length > 0 ? 1 : 0;

        double timeToTarget;
        double leaderTTT = 0;

        for(int i = 0; i < position.Length; i++)
        {           
            cars.Add(position[i], speed[i]);
        }

        var carsByPosition = cars.OrderByDescending(kvp => kvp.Key);
        foreach (var kvp in carsByPosition)
        {
            timeToTarget = ((double)(target-kvp.Key)/(double)kvp.Value);

            if(leaderTTT == 0)
            {
                leaderTTT = timeToTarget;
                continue;
            }
            else if(leaderTTT != 0 && timeToTarget <= leaderTTT)
            {
                continue;
            }
            else
            {
               leaderTTT = timeToTarget;
                answer++;
            }
        }
        
        return answer;
    }
}
