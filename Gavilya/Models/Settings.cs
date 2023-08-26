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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gavilya.Models
{
	public class Settings
	{
		/// <summary>
		/// Indicates if it is the first run of Gavilya.
		/// </summary>
		public bool IsFirstRun { get; set; }

		/// <summary>
		/// Indicates if the <see cref="MainWindow"/> is maximized or not.
		/// </summary>
		public bool IsMaximized { get; set; }

		public Language Language { get; set; }

		/// <summary>
		/// True if Gavilya should make an autosave.
		/// </summary>
		public bool? MakeAutoSave { get; set; }

		/// <summary>
		/// The day when Gavilya should make an auto save.
		/// </summary>
		public int? AutoSaveDay { get; set; }

		/// <summary>
		/// The save file path.
		/// </summary>
		public string SavePath { get; set; }

		/// <summary>
		/// The maximum amount of recent games shown in the home page.
		/// </summary>
		public int? MaxNumberRecentGamesShown { get; set; }

		/// <summary>
		/// The number of search results to display in the search box. (default = 3)
		/// </summary>
		public int? NumberOfSearchResultsToDisplay { get; set; }

		/// <summary>
		/// The opacity of the FPS Counter (a value between 0 et 1)
		/// </summary>
		public double? FpsCounterOpacity { get; set; }

		/// <summary>
		/// True if Gavilya should show a notification if updates are available.
		/// </summary>
		public bool? UpdatesAvNotification { get; set; }

		/// <summary>
		/// The position of the sidebar.
		/// </summary>
		public Position? SidebarPosition { get; set; }

		/// <summary>
		/// The path of the theme to load.
		/// </summary>
		public string? ThemePath { get; set; }
	}

	public enum Position
	{
		Left,
		Right
	}

	public enum Language
	{
		Default,
		en_US,
		fr_FR,
		zh_CN
	}
}
