using System;
using System.Collections.Generic;
using Helpers;
using Services;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;


public class MoveManager : MonoBehaviour
{
    
    [Header("Move Settings")]
    [SerializeField] public float moveSpeed = 2f;

    [Header("Infrastructure")] 
    [SerializeField] private GameObject _player;
    
    private LineRenderer _lineRenderer;
    private SpawnPathManager _spawnPathManager;
    
    private iLineDrawer _lineDrawer;
    private iMoveService _moveService;

    [Inject]
    public void Construct(iLineDrawer lineDrawer, iMoveService moveService)
    {
        _lineDrawer = lineDrawer;
        _moveService = moveService;
    }
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _spawnPathManager = FindObjectOfType<SpawnPathManager>();
    }

    private void Update()
    {
        Move();
    }

    private bool isNonEmptyWaypoints()
    {
        return _spawnPathManager.waypointIndex <= _spawnPathManager.waypoints.Count - 1;
    }

    private void KillWaypointIfReached(Vector3 targetPosition, GameObject currentGameObject)
    {
        if (_player.transform.position == targetPosition)
        {
            _spawnPathManager.DestroyAndRemove(currentGameObject);
        }
    }
    
    private void Move()
    {
        if (isNonEmptyWaypoints())
        {
            var waypoint = _spawnPathManager.waypoints[_spawnPathManager.waypointIndex];
            var waypointPosition = waypoint.transform.position;
            var maxDistanceDelta = moveSpeed * Time.deltaTime;
            
            _lineDrawer.Draw(_lineRenderer, _player.transform.position, waypointPosition);
            _moveService.moveTo(_player, waypointPosition, maxDistanceDelta);
            
            KillWaypointIfReached(waypointPosition, waypoint);
        }
    }

    public void changeSpeed(float newSpeed)
    {
        _moveService.changeSpeed(this, newSpeed);
    }
    
    
}
