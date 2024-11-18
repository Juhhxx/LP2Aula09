using UnityEngine;
using UnityEngine.Tilemaps;

namespace LP2Aula09
{
    public class RotateBehaviour : MonoBehaviour, IAnimateBehaviour
    {
        [SerializeField] private float rotationSpeed = 10f;
        public void Animate()
        {
            transform.Rotate(0f,0f,Time.deltaTime * rotationSpeed);
        }
    }
}