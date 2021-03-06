using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [Header("Menus")]
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject quitMenu;

    public void quitGame()
    {
        Application.Quit();
    }
}
