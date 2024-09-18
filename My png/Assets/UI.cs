using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private float b;
    [SerializeField] private TextMeshProUGUI textCount;
    public float StartTimer;
    [SerializeField] private float timer;
    private bool a;
    [SerializeField] private Image Clock;
    [SerializeField] private TextMeshProUGUI TextMeshPro;
    

    // Update is called once per frame
    void Update()
    {
        UITimer();
        
    }
    public void Decrypt()
    {
        TextMeshPro.text = TextMeshPro.text.Replace('*', 'u');
        TextMeshPro.text = TextMeshPro.text.Replace('$', ' ');
    }
    public void Correct()
    {
        TextMeshPro.text = TextMeshPro.text.Replace('>', '\n');
    }
    public void Peel()
    {
        
        int i = TextMeshPro.text.Length - 1;
        while (TextMeshPro.text[i] != '.')
        {

            TextMeshPro.text = TextMeshPro.text.Remove(i);
            i--;
        }
    }
    
    public void Encrypt()
    {
        TextMeshPro.text = string.Concat(TextMeshPro.text.Select(c => $@"\u{(int)c:x4}"));
        TextMeshPro.text = TextMeshPro.text.Replace('0', '#');
    }

    public void UITimer()
    {

        Clock.fillAmount =   timer / StartTimer;
        if (a && timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if( timer <= 0)
        {
            a = false;
            Clock.fillAmount = 1;
        }
    }

  
    
    public void CluckButton()
    {
        timer = StartTimer;
        a = true;
        b++;
        textCount.text = b.ToString();
    }
}
