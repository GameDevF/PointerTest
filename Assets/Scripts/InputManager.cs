using System;
using Helpers;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class InputManager: MonoBehaviour
{
    private iInputPositionHelper _positionHelper;
    private Action<Vector3> OnPointerDownHandler;

    [Inject]
    public void Construct(iInputPositionHelper positionHelper)
    {
        _positionHelper = positionHelper;
    }

    void Update()
    {
        GetInput();
    }
    
    public void GetInput()
    {
        if (Input.GetButtonDown("Fire1") && !EventSystem.current.IsPointerOverGameObject())
        {
            var position = _positionHelper.getClickPositionInWorldPoint();
            OnPointerDownHandler?.Invoke(position);
        }
    }

    public void AddListenerOnPointerDownHandler(Action<Vector3> listener)
    {
        OnPointerDownHandler += listener;
    }
    
    public void RemoveListenerOnPointerDownHandler(Action<Vector3> listener)
    {
        OnPointerDownHandler -= listener;
    }
}
