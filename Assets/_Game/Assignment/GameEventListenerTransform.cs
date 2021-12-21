using UnityEngine;
using UnityEngine.Events;

namespace Assignment
{
    public class GameEventListenerTransform : MonoBehaviour
    {
        public GameEventWrapper Event;

        public UnityEventTransform Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(Transform trans)
        {
            Response.Invoke(trans);
        }
    }
}