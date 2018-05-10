using RoboRyanTron.Unite2017.Events;
using UnityEngine;


namespace AR.Events
{
    public class ClickRunEventBehaviour : MonoBehaviour
    {
        public GameEvent Event;

        private void OnMouseDown()
        {
            Event.Raise();
        }
    }

}

