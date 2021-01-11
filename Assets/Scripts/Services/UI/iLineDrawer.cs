using UnityEngine;

namespace Services
{
    public interface iLineDrawer
    {
        void Draw(LineRenderer renderer, Vector3 start, Vector3 finish);
    }
}