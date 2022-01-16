using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Loading : MonoBehaviour
{
    [SerializeField] float speed = 200f;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] TextMeshProUGUI textNormal;
    [SerializeField] RectTransform fxHolder;

    private RectTransform rect;
    private Image img;

    // Start is called before the first frame update
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

        img.fillAmount += Time.deltaTime * speed;
        a = (int)(img.fillAmount * 101);
        fxHolder.rotation = Quaternion.Euler(new Vector3(0f, 0f, -img.fillAmount * 360));

        if(img.fillAmount != 1f)
        {
            if(img.fillAmount > 0 && img.fillAmount <= 33)
            {
                textNormal.text = "Loading...";

            }
            else if(img.fillAmount >33 && img.fillAmount <= 67)
            {
                textNormal.text = "Dowloading...";

            }
            else if(img.fillAmount > 67 & img.fillAmount <= 100)
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

        }
        
    }
}
