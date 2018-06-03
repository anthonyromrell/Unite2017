// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;

namespace RoboRyanTron.Unite2017.Sets
{
    public class ThingMonitor : MonoBehaviour
    {
        private int previousCount = -1;
        public ThingRuntimeSet Set;

        public Text Text;

        private void OnEnable()
        {
            UpdateText();
        }

        private void Update()
        {
            if (previousCount != Set.Items.Count)
            {
                UpdateText();
                previousCount = Set.Items.Count;
            }
        }

        public void UpdateText()
        {
            Text.text = "There are " + Set.Items.Count + " things.";
        }
    }
}