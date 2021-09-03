using UnityEngine;
public class Chase_Player : MonoBehaviour
{

    public Transform[] points;
    public Transform target;

    Vector3 destination;
    private int TargetDist = 100;
    private int KillDist = 3;
    private UnityEngine.AI.NavMeshAgent agent;

    public VisGO VisGO;


    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        destination = agent.destination;

        // Disabling auto-braking allows for continuous movement between points (ie, the agent doesn't slow down as it approaches a destination point).
        agent.autoBraking = false;
    }
    void Update()
    {

        if (Vector3.Distance(transform.position, target.position) <= TargetDist)
        {
            agent.destination = target.position;
            destination = target.position;

        }

        if (Vector3.Distance(transform.position, target.position) < KillDist)
        {
            Debug.Log("Show");
            VisGO.GetComponent<VisGO>().Show();
        }
        // Choose the next destination point when the agent gets
        // close to the current one.

    }
}