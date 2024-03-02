﻿/*
MIT License

Copyright (c) Léo Corporation

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE. 
*/

using Gavilya.Commands;
using System.Windows;
using System.Windows.Input;

namespace Gavilya.ViewModels;

public class ExecutableViewModel : ViewModelBase
{
	private readonly GameEditionViewModel _gameEditionViewModel;

	public string Name { get; }
	public string FilePath { get; }

	public ICommand ClickCommand { get; }
	public ICommand CollapseCommand { get; }

	private Visibility _collapseGridVis = Visibility.Collapsed;
	public Visibility CollapseGridVid { get => _collapseGridVis; set { _collapseGridVis = value; OnPropertyChanged(nameof(CollapseGridVid)); } }

	private string _collapseIcon = "\uF2A4";
	public string CollapseIcon { get => _collapseIcon; set { _collapseIcon = value; OnPropertyChanged(nameof(CollapseIcon)); } }
	public ExecutableViewModel(string name, string filePath, GameEditionViewModel gameEditionViewModel)
	{
		Name = name;
		FilePath = filePath;
		_gameEditionViewModel = gameEditionViewModel;

		ClickCommand = new RelayCommand(Click);
		CollapseCommand = new RelayCommand(Collapse);
	}

	private void Click(object? obj)
	{
		_gameEditionViewModel.Name = Name;
		_gameEditionViewModel.Command = FilePath;
		_gameEditionViewModel.IsExeSelectorOpen = false;
	}

	private void Collapse(object? obj)
	{
		CollapseGridVid = CollapseGridVid == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
		CollapseIcon = CollapseGridVid == Visibility.Visible ? "\uF2B7" : "\uF2A4";
	}
}
