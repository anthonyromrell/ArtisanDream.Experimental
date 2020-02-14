using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

[RequireComponent(
    typeof(Button), 
    typeof(Image), 
    typeof(RectTransform))]
public class StoreButton : MonoBehaviour
{
    [HideInInspector] public Button btn;
    [HideInInspector] public Image img;
    [HideInInspector] public RectTransform rectTransform;
    [HideInInspector] public ItemPreview itemPreview;
    [HideInInspector] public Text textLabel;
    [HideInInspector] public StoreItem currentItem;
    
    public GameObject purchasedImg;
    [FormerlySerializedAs("AddAction")] public GameAction addAction;
    [FormerlySerializedAs("ItemAction")] public GameAction itemAction;
    private void Awake()
    {
        btn = GetComponent<Button>();
        img = GetComponent<Image>();
        rectTransform = GetComponent<RectTransform>();
        itemPreview = GetComponentInChildren<ItemPreview>();
        textLabel = GetComponentInChildren<Text>();
    }

    public void UseAddAction(StoreItem item)
    {
        //AddAction.Raise(item);
        item.inUse = true;
        DisableButton();
    }

    public void UpdateButton(StoreItem item)
    {
        currentItem = item;
        textLabel.text = item.name;
        itemPreview.img.sprite = item.storePreview;
        itemPreview.img.color = item.previewColor;
        rectTransform.localScale = Vector3.one;
        //ItemAction = item.ItemAction;                
        //ItemAction.Raise = Raise;
    }

    public void DisableButton()
    {
        btn.interactable = false;
        var color = currentItem.previewColor;
        color.a = .5f;
        itemPreview.img.color = color;
        //ItemAction.Raise = Raise;
    }

    public void EnableButton()
    {
        currentItem.inUse = false;
        itemPreview.img.color = currentItem.previewColor;
        btn.interactable = true;
    }
    private void Raise(object obj)
    {
        print(obj);
        var newItem = obj as StoreItem;
        itemPreview.img.color = currentItem.previewColor;
        EnableButton();   
        gameObject.SetActive(false);
        //UpdateButton(newItem);
    }
}