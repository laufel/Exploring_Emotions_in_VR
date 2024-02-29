using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace PathCreation.Examples
{
    // Moves along a path at constant speed.
    // Depending on the end of path instruction, will either loop, reverse, or stop at the end of the path.
    public class PathFollowerTerrain : MonoBehaviour
    {
        public PathCreator pathCreator;
        public float groundOffset = 0.1f;
        public float rotationSpeed = 0.1f;
        public EndOfPathInstruction endOfPathInstruction;
        public float speed = 5;

        private float distanceTravelled;
        private RaycastHit hit;

        private void Start()
        {
            if (pathCreator != null)
            {
                pathCreator.pathUpdated += OnPathChanged;
            }
        }

        private void Update()
        {
            if (pathCreator != null)
            {
                distanceTravelled += speed * Time.deltaTime;

                Vector3 pathPosition = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
                Quaternion pathRotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);

                if (Physics.Raycast(pathPosition, Vector3.down, out hit))
                {
                    Vector3 newPosition = hit.point + Vector3.up * groundOffset;
                    Quaternion newRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);

                    transform.position = newPosition;
                    transform.rotation = Quaternion.Slerp(pathRotation, newRotation, Time.deltaTime * rotationSpeed);
                }
            }
        }

        private void OnPathChanged()
        {
            distanceTravelled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);
        }
    }
}


        