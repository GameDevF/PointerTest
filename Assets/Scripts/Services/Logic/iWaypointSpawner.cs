using UnityEngine;

namespace Services
{
    public interface iWaypointSpawner
    {
        GameObject spawnWaypoint(GameObject waypoint, Vector3 coordinates);
        void destroyWaypoint(GameObject waypoint);
    }
}