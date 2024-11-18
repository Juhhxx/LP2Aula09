using UnityEngine;

namespace LP2Aula09
{
    public class ScaleBehaviour : MonoBehaviour, IAnimateBehaviour
    {
        [SerializeField] private float scaleSpeed = 10f;
        public void Animate()
        {
            transform.localScale = Mathf.Abs(Mathf.Cos(scaleSpeed * Time.time)) * Vector3.one;
        }
    }
}