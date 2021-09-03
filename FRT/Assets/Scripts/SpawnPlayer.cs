using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject Play1;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Play1, transform.position, Quaternion.identity);
        //  PrefabUtility.InstantiatePrefab(Play1 as GameObject);
    }

}
