
using UnityEngine;
using UnityEngine.InputSystem;

public class HelpScreenManager : MonoBehaviour
{
    [Tooltip("Assign your Help Panel GameObject here.")]
    public GameObject helpPanel;

    void Start()
    {
        if (helpPanel != null)
            helpPanel.SetActive(false); // Hide help screen at start
    }

    void Update()
    {
        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            if (helpPanel != null)
            {
                bool isActive = !helpPanel.activeSelf;
                helpPanel.SetActive(isActive);
                Time.timeScale = isActive ? 0f : 1f;
            }
        }
    }
}
