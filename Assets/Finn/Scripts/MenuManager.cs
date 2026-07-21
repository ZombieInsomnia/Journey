using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject pantsMenu;
    public GameObject shirtMenu;
    public GameObject shoesMenu;
    public GameObject accMenu;


    public GameObject previousMenu;
    public GameObject nextMenu;
    public GameObject doneButton;



    public GameObject pantOutfitbox;
    public GameObject shirtOutfitbox;
    public GameObject shoesOutfitbox;
    public GameObject accOutfitbox;

    public Transform player;
    public GameObject playerSprite;

    bool isDone = false;
    public int menuNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pantOutfitbox.SetActive(false);
        shirtOutfitbox.SetActive(false);
        shoesOutfitbox.SetActive(false);
        accOutfitbox.SetActive(false);
        doneButton.SetActive(false);
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

    public void DoneButton()
    {
        Debug.Log("yippee");
        isDone = true;
        UpdateVisuals();
    }

    void UpdateVisuals()
    {
        if (isDone == false)
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
                doneButton.SetActive(false);


            }

            if (menuNumber == 3)
            {
                shirtMenu.SetActive(false);
                pantsMenu.SetActive(false);
                shoesMenu.SetActive(false);
                accMenu.SetActive(true);
                doneButton.SetActive(true);
                nextMenu.SetActive(false);
            }
        }

        if (isDone == true)
        {
            shirtMenu.SetActive(false);
            pantsMenu.SetActive(false);
            shoesMenu.SetActive(false);
            accMenu.SetActive(false);
            doneButton.SetActive(false);
            nextMenu.SetActive(false);
            previousMenu.SetActive(false);
            MovePlayer();
            
        }
      
    }
    public void MovePlayer()
    {
        playerSprite.transform.SetParent(player);
        playerSprite.transform.localPosition = Vector3.zero;
    }
}
