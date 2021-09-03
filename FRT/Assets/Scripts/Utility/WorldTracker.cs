using UnityEngine;

public class WorldTracker : MonoBehaviour
{
    public bool Physical = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Physical = !Physical;
        }

    }
}
