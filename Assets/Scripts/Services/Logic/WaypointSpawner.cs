using UnityEngine;

namespace Services
{
    public class WaypointSpawner: iWaypointSpawner
    {
        public GameObject spawnWaypoint(GameObject waypoint, Vector3 coordinates)
        {
            GameObject newWaypoint = Object.Instantiate(waypoint, coordinates, Quaternion.identity);
            return newWaypoint;
        }
        
        public void destroyWaypoint(GameObject waypoint)
        {
           Object.Destroy(waypoint);
        }

    }
}