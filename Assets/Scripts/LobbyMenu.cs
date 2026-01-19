using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LobbyMenu : MonoBehaviour
{
    
    private GameManager _manager;

    public Button b_Close;
    
    public List<GalereyaPanel> _galereyaPanels = new List<GalereyaPanel>();
    
    
    public void Init(GameManager manager)
    {
        _manager = manager;
        foreach (var panel in _galereyaPanels)
        {
            panel.Init(_manager);
        }
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
