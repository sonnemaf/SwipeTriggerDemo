# SwipeTriggerDemo
UWP demo app for a SwipeTriggerBehavior 


# Video
![image](https://github.com/sonnemaf/SwipeTriggerDemo/blob/master/SwipeTriggerDemo.gif)

# MainPage.xaml

```xml
<Page x:Class="SwipeTriggerDemo.MainPage"
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:Custom="using:Microsoft.Xaml.Interactivity"
      xmlns:Custom1="using:Microsoft.Xaml.Interactions.Core"
      xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
      xmlns:local="using:SwipeTriggerDemo"
      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
      x:Name="PageRoot"
      Background="{ThemeResource ApplicationPageBackgroundThemeBrush}"
      mc:Ignorable="d">

    <Grid>
        <Grid.ChildrenTransitions>
            <TransitionCollection>
                <RepositionThemeTransition />
            </TransitionCollection>
        </Grid.ChildrenTransitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="1*" />
            <RowDefinition Height="1*" />
        </Grid.RowDefinitions>
        <Border x:Name="border"
                Margin="40"
                Background="{StaticResource SystemAccentColor}">
            <TextBlock Text="Slide Up or Down"
                       Style="{StaticResource HeaderTextBlockStyle}"
                       HorizontalAlignment="Center"
                       VerticalAlignment="Center" />
            <Custom:Interaction.Behaviors>
                <local:SwipeTriggerBehavior Direction="Down">
                    <Custom1:CallMethodAction MethodName="MoveDown"
                                              TargetObject="{Binding ElementName=PageRoot}" />
                </local:SwipeTriggerBehavior>
                <local:SwipeTriggerBehavior Direction="Up">
                    <Custom1:CallMethodAction MethodName="MoveUp"
                                              TargetObject="{Binding ElementName=PageRoot}" />
                </local:SwipeTriggerBehavior>
            </Custom:Interaction.Behaviors>
        </Border>
    </Grid>
</Page>
```

# MainPage.xaml.cs
```cs
using System;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SwipeTriggerDemo {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public void MoveDown() {
            Grid.SetRow(border, 1);
        }

        public void MoveUp(object sender, SwipeEventArgs e) {
            Grid.SetRow(border, 0);
        }
    }
}
```

