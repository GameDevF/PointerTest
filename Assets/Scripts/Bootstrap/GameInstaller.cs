using Helpers;
using Services;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<iInputPositionHelper>()
            .To<InputPositionHelper>()
            .AsSingle();
        Container.Bind<iWaypointSpawner>()
            .To<WaypointSpawner>()
            .AsSingle();
        Container.Bind<iMoveService>()
            .To<MoveService>()
            .AsSingle();
        Container.Bind<iLineDrawer>()
            .To<LineDrawer>()
            .AsSingle();
    }
}