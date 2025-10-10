using UnityEngine;
using System.Collections.Generic;

namespace KP.QuickKit.Physics
{
    public class GravityField : MonoBehaviour
    {
        [SerializeField] private float _gravityForce;

        private List<Rigidbody> _rigidbodies = new();

        void FixedUpdate()
        {
            foreach (Rigidbody rigidbody in _rigidbodies)
            {
                Vector3 direction = (transform.position - rigidbody.position).normalized;

                float distance = Vector3.Distance(transform.position, rigidbody.position);
                if (distance < 1.0f) distance = 1.0f;

                float force = _gravityForce / Mathf.Pow(distance, 2);

                rigidbody.AddForce(direction * force);
            }
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Rigidbody rigidbody)
                && !_rigidbodies.Contains(rigidbody))
            {
                _rigidbodies.Add(rigidbody);
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out Rigidbody rigidbody)
                && _rigidbodies.Contains(rigidbody))
            {
                _rigidbodies.Remove(rigidbody);
            }
        }
    }
}