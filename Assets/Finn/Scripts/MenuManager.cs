using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject pantsMenu;
    public GameObject shirtMenu;
    public GameObject shoesMenu;
    public GameObject accMenu;
    public GameObject previousMenu;
    public GameObject nextMenu;
    public GameObject pantOutfitbox;
    public GameObject shirtOutfitbox;
    public GameObject shoesOutfitbox;
    public GameObject accOutfitbox;
    public int menuNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pantOutfitbox.SetActive(false);
        shirtOutfitbox.SetActive(false);
        shoesOutfitbox.SetActive(false);
        accOutfitbox.SetActive(false);
        UpdateVisuals();
        
    }
    public void NextMenu()
    {
        if (menuNumber < 3)
        {
            menuNumber += 1;
            UpdateVisuals();
        }
    }
    public void PreviousMenu()
    {
        if (menuNumber >= 0) 
        {
            menuNumber -= 1;
            UpdateVisuals();
        }
    }

    void UpdateVisuals()
    {
        if (menuNumber == 0)
        {
            shirtMenu.SetActive(true);
            pantsMenu.SetActive(false);
            shoesMenu.SetActive(false);
            accMenu.SetActive(false);
            previousMenu.SetActive(false);

        }

        if (menuNumber == 1)
        {
            shirtMenu.SetActive(false);
            pantsMenu.SetActive(true);
            shoesMenu.SetActive(false);
            previousMenu.SetActive(true);
            accMenu.SetActive(false);
        }

        if (menuNumber == 2)
        {
            shirtMenu.SetActive(false);
            pantsMenu.SetActive(false);
            shoesMenu.SetActive(true);
            accMenu.SetActive(false);
            nextMenu.SetActive(true);


        }

        if (menuNumber == 3)
        {
            shirtMenu.SetActive(false);
            pantsMenu.SetActive(false);
            shoesMenu.SetActive(false);
            accMenu.SetActive(true);
            nextMenu.SetActive(false);
        }
    }
}
