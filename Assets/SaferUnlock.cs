using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaferUnlock : MonoBehaviour
{
    public GameInstance gameInstance;
    public Button[] numberButtons;  // 数字按钮数组
    public Image lockImage;  // 原始手机图片
    public Image unlockedImage;  // 解锁后的图片
    public GameObject tips;
    //public Text text;
    public string correctPassword = "22101";  // 正确的密码
    private string inputPassword = "";  // 用户输入的密码
    public float duration = 0.25f;

    public List<GameObject> shownInputs;

    public List<Sprite> icons;
    
    void Start()
    {
        //returnButton = GetComponent<BackButton>();
        //returnButton.GetComponent<Button>().onClick.AddListener(OnReturnButtonClick);
        // 添加数字按钮的点击事件
        for (int i = 0; i < numberButtons.Length; i++)
        {
            int index = i;  // 避免闭包问题
            numberButtons[i].onClick.AddListener(() => OnNumberButtonClick(index));
        }

        for (int i = 0; i < 5; ++i)
        {
            shownInputs[i].SetActive(false);
        }
    }

    void OnReturnButtonClick()
    {
        inputPassword = "";
    }
    void OnNumberButtonClick(int number)
    {
        shownInputs[inputPassword.Length].SetActive(true);
        shownInputs[inputPassword.Length].GetComponent<Image>().sprite = icons[number];
        // 在输入的密码中添加数字
        inputPassword += number.ToString();
        

        // 打印当前输入的密码（调试用）
        Debug.Log("当前输入的密码: " + inputPassword);

        // 检查输入的密码是否达到所需长度
        if (inputPassword.Length == correctPassword.Length)
        {
            // 判断密码是否正确
            if (inputPassword == correctPassword)
            {
                UnlockResource();
            }
            else
            {
                ShowIncorrectPasswordMessage();
                inputPassword = "";  // 重置输入的密码
                StartCoroutine(ShowToast());
            }
        }
    }

    IEnumerator ShowToast()
    {
        //text.text = message;
        tips.SetActive(true);

        yield return new WaitForSeconds(duration);
        tips.SetActive(false);
        
        foreach (GameObject input in shownInputs)
        {
            input.SetActive(false);
        }

    }
    void UnlockResource()
    {
        // 显示解锁后的图片
        lockImage.gameObject.SetActive(false);
        unlockedImage.gameObject.SetActive(true);
        //gameInstance.gameState.phoneUnlocked = true;
        // Debug.Log("资源已解锁！");
    }

    void ShowIncorrectPasswordMessage()
    {
        // 显示密码错误的提示
        Debug.Log("密码错误，请重新输入。");
    }
}