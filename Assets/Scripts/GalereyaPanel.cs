using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GalereyaPanel : MonoBehaviour
{
    private GameManager _manager;

    public Button b_Left;
    public Button b_Right;
    public Button b_Back;
    
    public List<Sprite> ImageList = new List<Sprite>();
    
    public Image _image;
    private int _currentImage;
    
    public void Init(GameManager manager)
    {
        _manager = manager;
        
        b_Back.onClick.AddListener(OnBack);
        b_Left.onClick.AddListener(OnLeft);
        b_Right.onClick.AddListener(OnRight);
        
        if(_image==null)
            _image = GetComponent<Image>();
        
        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);
        _currentImage = 0;
        OnLeft();
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    private void OnBack()
    {
        Hide();
    }

    private void OnLeft()
    {
        _currentImage--;
        if (_currentImage <= 0)
            _currentImage = 0;
        _image.sprite = ImageList[_currentImage];
    }

    private void OnRight()
    {
        _currentImage++;
        if (_currentImage >= ImageList.Count)
            _currentImage = ImageList.Count - 1;
        _image.sprite = ImageList[_currentImage];
    }
    
}
