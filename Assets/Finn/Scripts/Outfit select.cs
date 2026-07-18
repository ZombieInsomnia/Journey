using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;


public class Outfitselect : MonoBehaviour
{
    public Outfits Outfits; //setting what outfit the button coresponds too 
    public GameObject outfitbox; //the image box the outfit is set too
    public Image outfitsprite;
    void Start()
    {
        outfitbox.SetActive(false); //turns off the image box so character isn't in any starting outfit
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void outfitSelect()
    {
        
        Debug.Log("you've picked " + Outfits.outfitName);
        
        outfitsprite.sprite = Outfits.outfit;
        outfitbox.SetActive(true);
    }
}
