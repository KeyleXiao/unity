using UnityEngine;
using MarkLight;
using MarkLight.Views.UI;
using UFZ.Interaction;

[HideInPresenter]
public class ViewpointsView : UIView
{
	public string MenuHeader = "Viewpoints";
	public ObservableList<Viewpoint> Viewpoints;

	public override void Initialize()
	{
		base.Initialize();

		
		var viewpointGroup = GameObject.Find("Viewpoints");
		if (viewpointGroup == null || viewpointGroup.transform.childCount == 0 ||
		    viewpointGroup.GetComponentsInChildren<Viewpoint>() == null)
			MenuHeader = "No viewpoints defined";
		else
		{
			Viewpoints = new ObservableList<Viewpoint>();
			// Iterate over childs to preserve order from editor
			for (var i = 0; i < viewpointGroup.transform.childCount; ++i)
			{
				var child = viewpointGroup.transform.GetChild(i);
				var viewpoint = child.gameObject.GetComponent<Viewpoint>();
				if (viewpoint == null) continue;
				Viewpoints.Add(viewpoint);
			}
		}
	}

	public void ViewpointChanged(ItemSelectionActionData eventData)
	{
		Viewpoints.SelectedItem.Move();
	}
}
