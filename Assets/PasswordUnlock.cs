using UnityEngine;
using UnityEngine.UI;

public class PasswordUnlock : MonoBehaviour
{
    public GameInstance gameInstance;
    public Button[] numberButtons;  // 数字按钮数组
    public Image phoneImage;  // 原始手机图片
    public Image unlockedImage;  // 解锁后的图片
    public string correctPassword = "000229";  // 正确的密码
    private string inputPassword = "";  // 用户输入的密码

    void Start()
    {
        // 添加数字按钮的点击事件
        for (int i = 0; i < numberButtons.Length; i++)
        {
            int index = i;  // 避免闭包问题
            numberButtons[i].onClick.AddListener(() => OnNumberButtonClick(index));
        }
    }

    void OnNumberButtonClick(int number)
    {
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
                gameInstance.gameState.phoneUnlocked = true;
            }
            else
            {
                ShowIncorrectPasswordMessage();
                inputPassword = "";  // 重置输入的密码
            }
        }
    }

    void UnlockResource()
    {
        // 显示解锁后的图片
        phoneImage.gameObject.SetActive(false);
        unlockedImage.gameObject.SetActive(true);
        gameInstance.gameState.phoneUnlocked = true;
        // Debug.Log("资源已解锁！");
    }

    void ShowIncorrectPasswordMessage()
    {
        // 显示密码错误的提示
        Debug.Log("密码错误，请重新输入。");
    }
}