using UnityEngine;
using TMPro;

public class FontChanger : MonoBehaviour
{
    public TextMeshProUGUI spriteText;
    public TMP_FontAsset font1;
    public TMP_FontAsset font2;
    public TMP_FontAsset font3;

    private int currentFontIndex = 0;

    public void ChangeFont()
    {
        currentFontIndex = (currentFontIndex + 1) % 3;
        switch (currentFontIndex)
        {
            case 0:
                spriteText.font = font1;
                break;
            case 1:
                spriteText.font = font2;
                break;
            case 2:
                spriteText.font = font3;
                break;
        }
    }
}