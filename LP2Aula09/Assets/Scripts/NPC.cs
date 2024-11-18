using UnityEngine;
using System;

namespace LP2Aula09
{
    public class NPC : MonoBehaviour
    {
        private IAnimateBehaviour animateBehaviour;

        private void Awake()
        {
            animateBehaviour = GetComponent<IAnimateBehaviour>();
        }
        private void Update()
        {
            animateBehaviour.Animate();
        }
    }
}
