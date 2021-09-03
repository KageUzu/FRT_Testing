using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxSpawn : MonoBehaviour
{
    public GameObject Rat;

    // Start is called before the first frame update
    void Start()
    {
        Rat.SetActive(true);     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
