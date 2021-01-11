using UnityEngine;

namespace Services
{
    public class MoveService: iMoveService
    {
        public void moveTo(GameObject gameObject, Vector3 to, float maxDistanceDelta)
        {
            gameObject.transform.position = Vector2.MoveTowards(
                gameObject.transform.position,
                to,
                maxDistanceDelta
            );
        }
        
        public void changeSpeed(MoveManager mover, float newSpeed)
        {
            mover.moveSpeed = newSpeed;
        }
    }
}