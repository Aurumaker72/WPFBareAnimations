# WPFBareAnimations

# Usage
Add a reference to library and import the library to anywhere you will use it like so:
```xml
xmlns:bareanimations="clr-namespace:WPFBareAnimations;assembly=WPFBareAnimations"
```

# Examples

```xml
<Button Content="Hello!" bareanimations:OpacityTransition.ShouldBeShown="{Binding YourProperty, UpdateSourceTrigger=PropertyChanged}" bareanimations:OpacityTransition.AnimationDuration="00:00:0.5"/>
```
