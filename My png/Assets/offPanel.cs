using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offPanel : MonoBehaviour
{
    [SerializeField] private GameObject _PanelPlay;
    [SerializeField] private GameObject _PanelExitMainMenu;
    [SerializeField] private GameObject _ButtonExit;
    public void Play()
    {
        _PanelPlay.SetActive(false);
        _PanelExitMainMenu.SetActive(true);
        _ButtonExit.SetActive(true);

    }
    public void ExitMainMenu()
    {
        _PanelPlay.SetActive(true);
        _PanelExitMainMenu.SetActive(false);
        _ButtonExit.SetActive(false);
    }
}
