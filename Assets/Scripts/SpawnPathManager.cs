using System;
using System.Collections.Generic;
using Services;
using UnityEngine;
using Zenject;

public class SpawnPathManager: MonoBehaviour
{
    [Header("Waypoint Settings")]
    [SerializeField] public List<GameObject> waypoints;
    [SerializeField] private GameObject waypointPrefab;
    
    
    public int waypointIndex = 0;
    
    
    private iWaypointSpawner _waypointSpawner;

    [Inject]
    public void Construct(iWaypointSpawner waypointSpawner)
    {
        _waypointSpawner = waypointSpawner;
    }

    public void SpawnAt(Vector3 position)
    {
        GameObject newWaypoint = _waypointSpawner.spawnWaypoint(waypointPrefab, position);
        addWaypoint(newWaypoint);
    }
    
    public void DestroyAndRemove(GameObject waypoint)
    {
        _waypointSpawner.destroyWaypoint(waypoint);
        removeWaypoint(waypoint);
    }
    
    public void addWaypoint(GameObject waypoint)
    {
        waypoints.Add(waypoint);
    }
    
    public void removeWaypoint(GameObject waypoint)
    {
        waypoints.Remove(waypoint);
    }
    
}
