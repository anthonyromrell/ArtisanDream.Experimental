using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
	public IntData Data;
	private Text label;
	public string Format = "C0";
	
	void Start ()
	{
		label = GetComponent<Text>();
		OnUpdate();
	}

	public void OnUpdate()
	{
		label.text = Data.Value.ToString(Format);
	}
}