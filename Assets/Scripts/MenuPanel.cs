using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanel : MonoBehaviour
{

    private GameManager _manager;

    public Button b_Location;
    public Button b_Blagoustroystvo;
    public Button b_Lobby;
    public Button b_Arhitectura;
    public Button b_Infrastruktura;
    public Button b_Kvartiry;
    public Button b_ChoseFlatOnParameters;

    public Button b_Close;
    
    public void Init(GameManager manager)
    {
        _manager = manager;
        
        b_Location.onClick.AddListener(OnLocation);
        b_Blagoustroystvo.onClick.AddListener(OnBlagoustroystvo);
        b_Lobby.onClick.AddListener(OnLobby);
        b_Arhitectura.onClick.AddListener(OnArhitectura);
        b_Infrastruktura.onClick.AddListener(OnInfrastruktura);
        b_Kvartiry.onClick.AddListener(OnKvartiry);
        b_ChoseFlatOnParameters.onClick.AddListener(OnChoseFlatOnParameters);
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

    private void OnLocation()
    {
        _manager.raspolozheniePanel.Show();
    }

    private void OnBlagoustroystvo()
    {
        _manager.blagoustroystvoPanel.Show();
    }

    private void OnLobby()
    {
        _manager.lobbyPanel.Show();
    }

    private void OnArhitectura()
    {
        _manager.arhitecturaPanel.Show();
    }

    private void OnInfrastruktura()
    {
        _manager.infrastrukturaPanel.Show();
    }
    
    private void OnKvartiry()
    {
        _manager.kvartiryPanel.Show();
    }
    
    private void OnChoseFlatOnParameters()
    {
        //_manager.ch.Show();
        Debug.Log("ChoseFlat");
    }

}
