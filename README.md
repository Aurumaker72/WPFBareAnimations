<p align="center">
  <img width="128" align="center" src="https://user-images.githubusercontent.com/48759429/198681794-d492ca14-b28c-4bb5-a855-4fd4fa2e598d.png">
</p>


<h1 align="center">
  WPF Bare Animations
</h1>
<p align="center">
  A barebones animation library for WPF
</p>
<p align="center">
    <img src="https://img.shields.io/badge/Simplicity-All%20the%20way%20up-green?style=for-the-badge"/>
</p>

# Usage
Add a reference to library and import the library to anywhere you will use it like so:
```xml
xmlns:bareanimations="clr-namespace:WPFBareAnimations;assembly=WPFBareAnimations"
```

# Examples

```xml
<Button Content="Hello!" bareanimations:OpacityTransition.ShouldBeShown="{Binding YourProperty, UpdateSourceTrigger=PropertyChanged}" bareanimations:OpacityTransition.AnimationDuration="00:00:0.5"/>
```
