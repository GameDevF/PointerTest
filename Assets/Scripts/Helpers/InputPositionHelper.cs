using UnityEngine;

namespace Helpers
{
    public class InputPositionHelper: iInputPositionHelper
    {
        public Vector3 getClickPositionInWorldPoint()
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickPosition.z = 0f;
            return clickPosition;
        }
    }
}