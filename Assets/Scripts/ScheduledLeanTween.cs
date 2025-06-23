using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DentedPixel.LTEditor;

/// <summary>
/// Provides a runtime controlled schedule of LeanTweenVisual animations.
/// Each entry contains a delay and the visual tween to run so that the
/// sequence can be configured directly in the inspector.
/// </summary>
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
    }

    private IEnumerator PlaySequence()
    {
        foreach (TweenEntry _Entry in m_TweenSchedule)
        {
            if (_Entry.m_Delay > 0f)
            {
                yield return new WaitForSeconds(_Entry.m_Delay);
            }

            if (_Entry.m_Tween != null)
            {
                LeanTween.cancel(_Entry.m_Tween.gameObject);
                _Entry.m_Tween.buildAllTweens(false);
            }
        }
        m_PlayRoutine = null;
    }
}
