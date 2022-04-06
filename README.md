# WPFBareAnimations

# Usage
Add reference to library and paste this inside top-level window/app

`xmlns:bareanimations="clr-namespace:WPFBareAnimations;assembly=WPFBareAnimations"`

# Examples

`<Button Content="Hello!" bareanimations:OpacityTransition.ShouldBeShown="{Binding YourProperty, UpdateSourceTrigger=PropertyChanged}" bareanimations:OpacityTransition.AnimationDuration="00:00:0.5"/>
`
