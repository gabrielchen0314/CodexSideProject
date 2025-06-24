using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DentedPixel.LTEditor;

/// <summary>
/// Provides a runtime controlled schedule of LeanTweenVisual animations.
/// Each entry contains a delay and the visual tween to run so that the
/// sequence can be configured directly in the inspector.
/// </summary>
[ExecuteAlways]
public class ScheduledLeanTween : MonoBehaviour
{
	/// <summary>
	/// Single scheduled tween entry.
	/// </summary>
	[System.Serializable]
	public class TweenEntry
	{
		/// <summary>
		/// Tween to play after the specified delay.
		/// </summary>
		public LeanTweenVisual m_Tween;

		/// <summary>
		/// Delay before triggering the tween.
		/// </summary>
		public float m_Delay;
	}

	/// <summary>
	/// Ordered list of tweens to play.
	/// </summary>
	public List<TweenEntry> m_TweenSchedule = new List<TweenEntry>();

	/// <summary>
	/// Toggle playback of the schedule.
	/// </summary>
	public bool m_IsPlaying;

	private bool m_WasPlaying;
	private float m_LastUpdateTime;
	private Coroutine m_PlayRoutine;

	/// <summary>
	/// Play the configured schedule.
	/// </summary>
	[ContextMenu("Play Schedule")]
	public void PlaySchedule()
	{
		if (m_PlayRoutine != null)
		{
			StopCoroutine(m_PlayRoutine);
		}
		m_PlayRoutine = StartCoroutine(PlaySequence());
		m_IsPlaying = true;
	}

	/// <summary>
	/// Initializes state when the component becomes enabled.
	/// </summary>
	void OnEnable()
	{
		m_LastUpdateTime = Time.realtimeSinceStartup;
		m_WasPlaying = m_IsPlaying;
	}

/// <summary>
/// Updates playback state each frame.
/// </summary>
	void Update()
	{
		if (m_IsPlaying && !m_WasPlaying)
		{
			if (m_PlayRoutine == null)
			{
			PlaySchedule();
			}
		}
		else if (!m_IsPlaying && m_WasPlaying)
		{
			m_LastUpdateTime = Time.realtimeSinceStartup;
		}
		m_WasPlaying = m_IsPlaying;
	}

/// <summary>
/// Plays each entry in the schedule sequentially.
/// </summary>
	private IEnumerator PlaySequence()
	{
		foreach (TweenEntry _Entry in m_TweenSchedule)
		{
			float _Timer = 0f;
			while (_Timer < _Entry.m_Delay)
			{
				if (m_IsPlaying)
				{
				float _Delta = Time.realtimeSinceStartup - m_LastUpdateTime;
				m_LastUpdateTime = Time.realtimeSinceStartup;
				_Timer += Application.isPlaying ? Time.deltaTime : _Delta;
			}
			yield return null;
			}
		
		if (_Entry.m_Tween != null)
		{
		LeanTween.cancel(_Entry.m_Tween.gameObject);
		_Entry.m_Tween.buildAllTweens(false);
		}
		}
	m_PlayRoutine = null;
	m_IsPlaying = false;
	}
}
