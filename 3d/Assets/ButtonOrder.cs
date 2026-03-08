using UnityEngine;
using UnityEngine.UI;

public class ButtonOrder : MonoBehaviour
{
    public Button firstButton;
    public Button secondButton;

    void Start()
    {
        // Disable the second button initially
        secondButton.interactable = false;

        // Add a listener to the first button
        firstButton.onClick.AddListener(FirstButtonClicked);
    }

    void FirstButtonClicked()
    {
        // Perform operations related to the first button here

        // Enable the second button after the first button is clicked
        secondButton.interactable = true;

        // Optionally, you can remove the listener from the first button if you don't want it to be clicked again
        // firstButton.onClick.RemoveListener(FirstButtonClicked);
    }
}
