using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaspolozheniePanel : MonoBehaviour
{

    private GameManager _manager;
    private Button b_Close;
    
    public void Init(GameManager manager)
    {
        _manager = manager;
        b_Close = GetComponentInChildren<Button>(true);
        b_Close.onClick.AddListener(Hide);
        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

}
