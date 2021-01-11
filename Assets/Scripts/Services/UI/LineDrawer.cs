using UnityEngine;

namespace Services
{
    public class LineDrawer: iLineDrawer
    {
        public void Draw(LineRenderer renderer, Vector3 start, Vector3 finish)
        {
            renderer.SetPosition(0, start);
            renderer.SetPosition(1, finish);
        }
    }
}