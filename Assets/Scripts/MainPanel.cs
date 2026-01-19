using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{

    private GameManager _manager;
    
    public List<Button> b_Korpuses = new List<Button>();
    public List<Sprite> Korpuses = new List<Sprite>();

    public GameObject KorpusPanel;
    public Button b_CloseKorpus;
    public Button b_Close;

    private Image _imageKorpus;
    
    public void Init(GameManager manager)
    {
        _manager = manager;
        _imageKorpus = KorpusPanel.GetComponent<Image>();
        b_Close.onClick.AddListener(OnMenu);
        b_CloseKorpus.onClick.AddListener(OnCloseKorpus);
        for (int i = 0; i < b_Korpuses.Count; i++)
        {
            int k = i;
            b_Korpuses[i].onClick.AddListener(()=>OnClickKorpus(k));
        }
        
        Show();
    }

    private void Show()
    {
        OnCloseKorpus();
    }

    private void OnClickKorpus(int index)
    {
        //Debug.Log(index);
        KorpusPanel.SetActive(true);
        _imageKorpus.sprite = Korpuses[index];
        _manager.MessageOnHouse(index+1,1);
    }

    private void OnMenu()
    {
        KorpusPanel.SetActive(false);
        _manager.menuPanel.Show();
    }

    private void OnCloseKorpus()
    {
        KorpusPanel.SetActive(false);
        _manager.MessageOnDemo();
    }

}
