# WPF Bare Animations
Simple class library for trivially animating WPF controls

# Getting Started
![grafik](https://user-images.githubusercontent.com/48759429/162015300-dde5f1a6-0752-46b3-ba10-50e32dd5f334.png)
- Add a reference to the class library by opening the context menu under "Dependencies" and clicking "Add reference..." 
- Edit highest-order container control's properties to include reference to the library (e.g.: paste this inside MainWindow.xaml inside Window tag)

```
  <Window 
    ...
    xmlns:bareanimations="clr-namespace:WPFBareAnimations;assembly=WPFBareAnimations"/>
 ```
  
### You're done!
 
# Usage
```            <Button Content="Hello!" bareanimations:OpacityTransition.ShouldBeShown="{Binding YourBooleanProperty, UpdateSourceTrigger=PropertyChanged}" bareanimations:OpacityTransition.AnimationDuration="00:00:0.5"/>
```
