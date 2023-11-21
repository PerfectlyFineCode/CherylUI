﻿using Avalonia.Controls;
using CherylUI.Controls;
using ReactiveUI;

namespace CherylCrossTest.ViewModels;

public class MainViewModel : ReactiveObject
{
    private bool _description = false;
    public bool Description
    {
        get => _description;
        set => this.RaiseAndSetIfChanged(ref _description, value);
    }

    public void LaunchToast()
    {
        InteractiveContainer.ShowToast(new TextBlock(){Text = "Hit !"},3);
    }
}