using UnityEngine;
using TMPro;

public class HelpPopups : MonoBehaviour
{
    public GameObject HelpPanel;
    public GameObject CreditsPanel;

    public void ShowHelp()
    {
        bool isActive = HelpPanel.activeSelf;  
        HelpPanel.SetActive(!isActive);  
    }
    public void ShowCredits()
    {
        bool isActive = CreditsPanel.activeSelf;  
        CreditsPanel.SetActive(!isActive);  
    }

    
    
}