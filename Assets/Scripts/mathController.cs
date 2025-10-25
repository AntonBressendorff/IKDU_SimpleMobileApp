using UnityEngine;
using TMPro;

public class mathController : MonoBehaviour
{

    public TextMeshProUGUI ourText;
    public int startingNumber = 10;
    private int currentNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentNumber = startingNumber;
        updateNumber();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updateNumber()
    {
        ourText.text = currentNumber.ToString();
    }

    public void minusOperation(int numberToMinus)
    {
        currentNumber -= numberToMinus;
        updateNumber();
    }

    public void plusOperation(int numberToPlus)
    {
        currentNumber += numberToPlus;
        updateNumber();
    }
}
