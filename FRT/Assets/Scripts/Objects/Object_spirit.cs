using UnityEngine;

public class Object_spirit : MonoBehaviour
{
    //  Collider s_collider;

    MeshRenderer s_Mesh;

    public WorldTracker WorldTracker;

    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        s_Mesh = GetComponentInChildren<MeshRenderer>();
        WorldTracker.GetComponentInChildren<WorldTracker>();
        Debug.Log("Check0");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.E))
        {
            if (WorldTracker.Physical == true)
            {
                IsVis();
            }
            else if (WorldTracker.Physical == false)
            {
                NotVis();
            }
        }
    }

    public void IsVis()
    {
        Debug.Log(name + "Visible");
        s_Mesh.enabled = true;

    }

    void NotVis()
    {
        Debug.Log(name + "Not Visible");
        s_Mesh.enabled = false;
    }

}
