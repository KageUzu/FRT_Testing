using UnityEngine;

public class VisGO : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    public bool PMenu = true;

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup.alpha = 0f; //this makes everything transparent
        canvasGroup.blocksRaycasts = false; //this prevents the UI element to receive input events
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Switch();
        }
    }

    public void Hide()
    {
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        PMenu = !PMenu;
    }

    public void Show()
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0;
        PMenu = !PMenu;
    }

    void Switch()
    {


        if (PMenu == true)
        {
            Show();
        }
        else if (PMenu == false)
        {
            Hide();
        }
    }
}
