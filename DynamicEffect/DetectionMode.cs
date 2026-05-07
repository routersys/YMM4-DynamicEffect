using System.ComponentModel.DataAnnotations;

namespace DynamicEffect
{
    internal enum DetectionMode
    {
        [Display(Name = nameof(Texts.DetectionModeRms), Description = nameof(Texts.DetectionModeRmsDesc), ResourceType = typeof(Texts))]
        Rms,
        [Display(Name = nameof(Texts.DetectionModePeak), Description = nameof(Texts.DetectionModePeakDesc), ResourceType = typeof(Texts))]
        Peak,
    }
}
