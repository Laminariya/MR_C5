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
        
        b_Korpuses[0].onClick.AddListener(()=>OnClickKorpus(1,1,0));
        b_Korpuses[1].onClick.AddListener(()=>OnClickKorpus(1,2,1));
        b_Korpuses[2].onClick.AddListener(()=>OnClickKorpus(2,1,2));
        b_Korpuses[3].onClick.AddListener(()=>OnClickKorpus(2,2,3));
        b_Korpuses[4].onClick.AddListener(()=>OnClickKorpus(3,1,4));
        b_Korpuses[5].onClick.AddListener(()=>OnClickKorpus(3,2,5));
        b_Korpuses[6].onClick.AddListener(()=>OnClickKorpus(4,2,6));
        b_Korpuses[7].onClick.AddListener(()=>OnClickKorpus(4,1,7));
        
        Show();
    }

    private void Show()
    {
        OnCloseKorpus();
    }

    private void OnClickKorpus(int korpus, int porch, int index)
    {
        Debug.Log("K:" + korpus + " P: " + porch + "Index: "+index);
        KorpusPanel.SetActive(true);
        _imageKorpus.sprite = Korpuses[index];
        _manager.MessageOffAllLight();
        _manager.MessageOnHouse(korpus,porch);
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
