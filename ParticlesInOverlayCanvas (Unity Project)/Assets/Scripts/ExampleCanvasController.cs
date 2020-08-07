using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExampleCanvasController : MonoBehaviour 
{
	public Button Emit10Button;
	public Button Emit100Button;
	public Button PlayStopToggleButton;
	public Button b4;
	public Button b5;
	public Button b6;
	public Button b7;

	private bool particlesPlaying;

	public void Start()
	{
		particlesPlaying = false;

		Emit10Button.onClick.AddListener(()  => OverlayParticles.ShowParticles(10, Emit10Button.transform.position));
		Emit100Button.onClick.AddListener(()  => OverlayParticles.ShowParticles(100, Emit100Button.transform.position));

		PlayStopToggleButton.onClick.AddListener(ToggleParticles);

		if (b4 != null) b4.onClick.AddListener(() => OverlayParticles.ShowParticles(100, b4.transform.position));
	}

	public void DoParticles(int number, Transform t)
	{
		OverlayParticles.ShowParticles(20, t.position);
	}

	private void ToggleParticles()
	{
		if(particlesPlaying)
		{
			OverlayParticles.StopContinuousParticles();

			particlesPlaying = false;

			Emit10Button.enabled = true;
			Emit100Button.enabled = true;
		}
		else
		{
			OverlayParticles.ShowContinuousParticles();

			particlesPlaying = true;

			Emit10Button.enabled = false;
			Emit100Button.enabled = false;
		}
	}
}
