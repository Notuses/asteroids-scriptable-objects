using System.Collections.Generic;
using UnityEngine;

namespace Assignment
{
    [CreateAssetMenu]
    public class GameEventWrapper : ScriptableObject
    {
        private readonly List<GameEventListenerTransform> eventListeners = new List<GameEventListenerTransform>();

        public void Raise(Transform trans)
        {
            for (int i = eventListeners.Count -1; i >= 0; i--)
            {
                eventListeners[i].OnEventRaised(trans);
            }
        }

        public void RegisterListener(GameEventListenerTransform listener)
        {
            if (!eventListeners.Contains(listener))
            {
                eventListeners.Add(listener);
            }
        }

        public void UnregisterListener(GameEventListenerTransform listener)
        {
            if (eventListeners.Contains(listener))
            {
                eventListeners.Remove(listener);
            }
        }
    }
}