using System;
using System.Linq;
using System.Windows;
using System.Windows.Media.Animation;

namespace WPFBareAnimations
{
    public static class OpacityTransition
    {

        public static readonly DependencyProperty ShouldBeShownProperty = DependencyProperty.RegisterAttached(
            "ShouldBeShown",
            typeof(bool),
            typeof(OpacityTransition),
            new PropertyMetadata(default(bool), OnShouldBeShownChanged));

        public static readonly DependencyProperty AnimationDurationProperty = DependencyProperty.Register("AnimationDuration", typeof(TimeSpan), typeof(OpacityTransition));

        public static void SetAnimationDuration(DependencyObject element, TimeSpan value) => element.SetValue(AnimationDurationProperty, value);
        [AttachedPropertyBrowsableForType(typeof(DependencyObject))]
        public static TimeSpan GetAnimationDuration(DependencyObject element) => (TimeSpan)element.GetValue(AnimationDurationProperty);

        public static void SetShouldBeShown(DependencyObject element, bool value) => element.SetValue(ShouldBeShownProperty, value);
        [AttachedPropertyBrowsableForType(typeof(DependencyObject))]
        public static bool GetShouldBeShown(DependencyObject element) => (bool)element.GetValue(ShouldBeShownProperty);

        private static void OnShouldBeShownChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue as bool? == null) throw new ArgumentNullException("Can\'t be null");
            var target = d as FrameworkElement;
            var duration = GetAnimationDuration(d) == null ? TimeSpan.FromMilliseconds(500) : GetAnimationDuration(d);
            var opacityAnimation = new DoubleAnimation
            {
                To = (bool)e.NewValue ? 1 : 0,
                Duration = duration,
            };
            var visibilityAnimation = new ObjectAnimationUsingKeyFrames();
            visibilityAnimation.KeyFrames.Add(new DiscreteObjectKeyFrame()
            {
                KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(0)),
                Value = Visibility.Visible
            });
            visibilityAnimation.KeyFrames.Add(new DiscreteObjectKeyFrame()
            {
                KeyTime = KeyTime.FromTimeSpan(duration),
                Value = (bool)(e.NewValue) ? Visibility.Visible : Visibility.Collapsed
            });
            ((FrameworkElement)d).BeginAnimation(UIElement.OpacityProperty, opacityAnimation, HandoffBehavior.SnapshotAndReplace);
            ((FrameworkElement)d).BeginAnimation(UIElement.VisibilityProperty, visibilityAnimation, HandoffBehavior.SnapshotAndReplace);
        }

    }
}
