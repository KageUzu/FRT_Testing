using UnityEngine;

public class SpawnMana : MonoBehaviour
{
    public GameObject Mana;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Mana, transform.position, Quaternion.identity);
        //  PrefabUtility.InstantiatePrefab(Play1 as GameObject);
    }

}
