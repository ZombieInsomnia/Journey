using UnityEngine;

public class Outfitselect : MonoBehaviour
{
    public Outfits Outfits; //setting what outfit the button coresponds too 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void outfitSelect()
    {
        Debug.Log("you've picked " + Outfits.outfitName);
    }
}
