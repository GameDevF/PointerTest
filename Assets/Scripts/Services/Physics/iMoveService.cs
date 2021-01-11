using UnityEngine;

namespace Services
{
    public interface iMoveService
    {
        void moveTo(GameObject gameObject, Vector3 to, float maxDistanceDelta);
        void changeSpeed(MoveManager mover, float newSpeed);
    }
}