using UnityEngine;
using UnityEngine.AI;

public class Patrol_P : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;
    //  public Transform home;

    public LayerMask whatIsGround, whatIsPlayer;

    //Patroling
    public Vector3 dest;
    bool destPointset;
    public float destPointRange;

    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    //States
    public float PlayerDist = 10, KillDist = 2;
    public bool playerInSightRange, playerInAttackRange;

    public VisGO VisGO;


    void Awake()
    {
        player = GameObject.Find("Play1").transform;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        dest = agent.destination;

        // Disabling auto-braking allows for continuous movement between points (ie, the agent doesn't slow down as it approaches a destination point).
        //   agent.autoBraking = false;
    }
    void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, PlayerDist, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, KillDist, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange) Patrolling();
        if (playerInSightRange && !playerInAttackRange) Chase();
        if (playerInSightRange && playerInAttackRange) Attack();

    }





    void Patrolling()
    {
        if (!destPointset) SearchDestPoint();

        if (destPointset)
            agent.SetDestination(dest);

        Vector3 distanceToWalkPoint = transform.position - dest;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
            destPointset = false;
    }

    private void SearchDestPoint()
    {
        //Calculate random point in range
        float randomZ = Random.Range(-destPointRange, destPointRange);
        float randomX = Random.Range(-destPointRange, destPointRange);

        dest = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(dest, -transform.up, 2f, whatIsGround))
            destPointset = true;
    }

    void Chase()
    {
        agent.SetDestination(player.position);
    }

    void Attack()
    {
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            Debug.Log("Show");
            //   VisGO.GetComponent<VisGO>().Show();

            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }

    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, PlayerDist);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, KillDist);
    }
}