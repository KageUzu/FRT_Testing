using UnityEngine;

public class SpawnRat : MonoBehaviour
{
    public GameObject Rat;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Rat, transform.position, Quaternion.identity);
        //  PrefabUtility.InstantiatePrefab(Rat as GameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
