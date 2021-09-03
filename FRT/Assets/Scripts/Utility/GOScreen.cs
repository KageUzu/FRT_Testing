using UnityEngine;

public class GOScreen : MonoBehaviour
{
    public bool PMenu = true;

    public VisGO other;

    private void Start()
    {

    }

    void Update()
    {
        if (PMenu == true && Input.GetKeyDown(KeyCode.P))
        {
            other.GetComponent<VisGO>().Show();
            PMenu = !PMenu;
        }

        if (PMenu == false && Input.GetKeyDown(KeyCode.O))
        {
            other.GetComponent<VisGO>().Hide();
            PMenu = !PMenu;
        }
    }
}
