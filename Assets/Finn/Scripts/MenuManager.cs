using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject pantsMenu;
    public GameObject shirtMenu;
    public GameObject previousMenu;
    public int menuNumber = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (menuNumber == 0)
        {
            shirtMenu.SetActive(true);
            pantsMenu.SetActive(false);
            previousMenu.SetActive(false);
            
        }

        else if (menuNumber == 1)
        {
            shirtMenu.SetActive(false);
            pantsMenu.SetActive(true);
            previousMenu.SetActive(true);
        }
    }
    public void NextMenu()
    {
        menuNumber += 1;
    }
    public void PreviousMenu()
    {
        menuNumber -= 1;
    }

    
}
