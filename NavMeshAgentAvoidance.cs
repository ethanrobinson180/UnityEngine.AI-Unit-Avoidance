using UnityEngine.AI;
using UnityEngine;

public class Avoidance : MonoBehaviour
{
    [Header("NavMesh Configurations")]
    public int PathfindingIterationsPerFrame = 100;
    public float AvoidancePredictionTime = 2;

    private void Start()
    {
        NavMesh.pathfindingIterationsPerFrame = PathfindingIterationsPerFrame;
        NavMesh.avoidancePredictionTime = AvoidancePredictionTime;
    }
}
