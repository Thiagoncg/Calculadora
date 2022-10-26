using UnityEngine;
using UnityEngine.UI;

public class Themes : MonoBehaviour
{
    //Color Black
    [SerializeField] private Color blackBackground = Color.black;
    [SerializeField] private Color numberBlue = Color.blue;
    [SerializeField] private Color buttomBlak = Color.black;
    
    
    //Color Write
    [SerializeField] private Color whiteBackground = Color.white;
    
    //UI Components.
    [SerializeField] private Text[] font ;
    [SerializeField] private Sprite spriteButtons;
    [SerializeField] private Camera myCamera;



    public void ChoiceBackColor()
    {
        myCamera.backgroundColor = blackBackground;
    }

    public void ChoicecWhiteColor()
    {
        
    }
}
