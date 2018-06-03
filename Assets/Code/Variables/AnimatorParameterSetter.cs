// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using UnityEngine;

namespace RoboRyanTron.Unite2017.Variables
{
    /// <summary>
    ///     Takes a FloatVariable and sends its value to an Animator parameter
    ///     every frame on Update.
    /// </summary>
    public class AnimatorParameterSetter : MonoBehaviour
    {
        [Tooltip("Animator to set parameters on.")]
        public Animator Animator;

        /// <summary>
        ///     Animator Hash of ParameterName, automatically generated.
        /// </summary>
        [SerializeField] private int parameterHash;

        [Tooltip("Name of the parameter to set with the value of Variable.")]
        public string ParameterName;

        [Tooltip("Variable to read from and send to the Animator as the specified parameter.")]
        public FloatVariable Variable;

        private void OnValidate()
        {
            parameterHash = Animator.StringToHash(ParameterName);
        }

        private void Update()
        {
            Animator.SetFloat(parameterHash, Variable.Value);
        }
    }
}