using UnityEngine;

public class HelpPopups : MonoBehaviour
{
    public GameObject helpPanel;

    public void ShowHelp()
    {
        helpPanel.SetActive(true);
    }

    public void HideHelp()
    {
        helpPanel.SetActive(false);
    }
}