using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrezentetionPanel : MonoBehaviour
{

    public Transform ContentParent;
    public GameObject ImagePrefab;
    public Scrollbar Scrollbar;
    
    public List<Sprite> sprites = new List<Sprite>();
    
    public void Init()
    {
        foreach (var sprite in sprites)
        {
            GameObject go = Instantiate(ImagePrefab, ContentParent);
            go.GetComponent<Image>().sprite = sprite;
        }

        Scrollbar.value = 1f;
        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);
        Scrollbar.value = 1f;
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }


}
