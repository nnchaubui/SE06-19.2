using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class loadingtext : MonoBehaviour
{

    private RectTransform rect;
    private Image img;

    [SerializeField] float speed = 200f;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI textNormal;


    // Use this for initialization
    void Start()
    {
        rect = GetComponent<RectTransform>();
        img = rect.GetComponent<Image>();
        img.fillAmount = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        int a = 0;
        if (img.fillAmount != 1f)
        {
            img.fillAmount = img.fillAmount + Time.deltaTime * speed;
            a = (int)(img.fillAmount * 100);
            if (a > 0 && a <= 33)
            {
                textNormal.text = "Loading...";
            }
            else if (a > 33 && a <= 67)
            {
                textNormal.text = "Downloading...";
            }
            else if (a > 67 && a <= 100)
            {
                textNormal.text = "Please wait...";
            }
            else
            {

            }
            text.text = a + "%";
        }
        else
        {
            img.fillAmount = 0.0f;
            text.text = "0%";
        }
    }
}
