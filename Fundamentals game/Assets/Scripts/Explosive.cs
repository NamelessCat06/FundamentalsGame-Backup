using UnityEngine;

namespace UnityFundamentals
{

    // This script applies explosive force to nearby objects within a specified radius.
    // Generated by ChatGPT :).

    public class Explosive : MonoBehaviour
    {
        public float explosionForce = 1000f;
        public float explosionRadius = 5f;

        public void GoBoom()
        {
            if (!enabled) return;

            // Find all colliders within the explosion radius.
            Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

            // Iterate through each collider.
            foreach (Collider hit in colliders)
            {
                // Get the rigidbody component of the collider.
                Rigidbody rb = hit.GetComponent<Rigidbody>();

                // If a rigidbody is found, apply explosion force to it.
                if (rb != null)
                {
                    rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, 0f, ForceMode.Impulse);
                }
            }
        }

        //demo to show that if you don't make something explicitly public, it won't show up in unity events
        void DontGoBoom()
        {

        }

        private void OnDrawGizmos()
        {
            if (!enabled) return;

            Gizmos.color = new Color(1,0,0,0.2f);
            Gizmos.DrawSphere(transform.position, explosionRadius);
        }
    }
}