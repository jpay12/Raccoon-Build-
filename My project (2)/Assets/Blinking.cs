
using UnityEngine;
using UnityEngine.UI;

public class Blinking : MonoBehaviour
{
    public Color Color1; 
    public Color Color2;
    public Text myText; 

    public void Update()
    {
       FlashingText(); 
    }
    
    public void FlashingText()
    {
        myText.color = Color.Lerp(Color1, Color2, Mathf.PingPong(Time.time,1)); 
    }
}
