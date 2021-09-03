using UnityEngine;

public class object_physical : MonoBehaviour
{
    MeshRenderer p_Mesh;

    public WorldTracker WorldTracker;

    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        p_Mesh = GetComponentInChildren<MeshRenderer>();
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
        p_Mesh.enabled = true;

    }

    void NotVis()
    {
        Debug.Log(name + "Not Visible");
        p_Mesh.enabled = false;
    }

}
