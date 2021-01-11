using System.Collections;
using System.Collections.Generic;
using Services;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Infrastructure")]
    [SerializeField] private InputManager _inputManager;

    private SpawnPathManager _spawnPathManager;
    void Start()
    {
        _spawnPathManager = FindObjectOfType<SpawnPathManager>();
        _inputManager.AddListenerOnPointerDownHandler(HandleInput);
    }

    private void HandleInput(Vector3 position)
    {
        _spawnPathManager.SpawnAt(position);
    }
}
