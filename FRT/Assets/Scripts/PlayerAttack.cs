using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int hitRange = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }

    void Attack()
    {
        int layerMask = 1 << 3;
        layerMask = ~layerMask;

        RaycastHit hit;
        //  Vector3 forward = transform.TransformDirection(Vector3.forward);
        //    Vector3 origin = transform.position;

        //
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, hitRange, layerMask))
        {


            if (hit.transform.gameObject.tag == "foe")
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);

                hit.transform.gameObject.SendMessage("TakeDamage", 30);
                Debug.Log("Hit scored");
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 10, Color.green);
                Debug.Log("Hit missed");
            }
        }
    }
}
