using UnityEngine;

public class Chaser_P : MonoBehaviour
{
    public Transform Player;


    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = Player.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
